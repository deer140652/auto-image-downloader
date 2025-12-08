using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 自動儲存圖片
{
    public partial class txtSaveFolder : Form
    {
        
        public txtSaveFolder()
        {
            InitializeComponent();
            textBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\DownloadedImages\\";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 判斷是否有任何圖片網址
            if (string.IsNullOrWhiteSpace(rtbImageUrls.Text))
            {
                MessageBox.Show("尚未擷取到任何圖片網址，請先擷取圖片圖片後再下載！","提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 確保用 TLS 1.2（有些 https 網站會要求）
            ServicePointManager.SecurityProtocol =
                SecurityProtocolType.Tls12 |
                SecurityProtocolType.Tls11 |
                SecurityProtocolType.Tls;

            string[] lines = rtbImageUrls.Lines;

            foreach (string line in lines)
            {
                string urlText = line.Trim();
                if (string.IsNullOrEmpty(urlText))
                    continue;

                // 檢查網址是否合法
                if (!Uri.TryCreate(urlText, UriKind.Absolute, out Uri uri) ||
                    (uri.Scheme != Uri.UriSchemeHttp && uri.Scheme != Uri.UriSchemeHttps))
                {
                    MessageBox.Show("略過無效網址：\r\n" + urlText);
                    continue;
                }

                // 取得檔名（用 Uri + Path，比自己切字串安全很多）
                string fileName = System.IO.Path.GetFileName(uri.LocalPath);
                if (string.IsNullOrEmpty(fileName))
                {
                    fileName = "image";
                }

                string folder = textBox1.Text;
                if (string.IsNullOrEmpty(folder))
                {
                    MessageBox.Show("請先選擇儲存資料夾");
                    return;
                }

                // 如果資料夾不存在 → 自動建立
                if (!System.IO.Directory.Exists(folder))
                {
                    System.IO.Directory.CreateDirectory(folder);
                }

                string filePath = System.IO.Path.Combine(folder, fileName);

                // 如果檔案已存在，就自動在後面加 (1)、(2)...
                int index = 1;
                string nameWithoutExt = System.IO.Path.GetFileNameWithoutExtension(fileName);
                string ext = System.IO.Path.GetExtension(fileName);

                while (System.IO.File.Exists(filePath))
                {
                    string newName = $"{nameWithoutExt}({index}){ext}";
                    filePath = System.IO.Path.Combine(folder, newName);
                    index++;
                }

                using (WebClient client = new WebClient())
                {
                    try
                    {
                        client.DownloadFile(uri, filePath);
                    }
                    catch (WebException ex)
                    {
                        MessageBox.Show($"下載失敗：\r\n{urlText}\r\n{ex.Message}");
                        // 不中斷整個程式，繼續下一個
                    }
                }
            }

            MessageBox.Show("下載完成","提示訊息", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            textBox1.Text = path.SelectedPath + "\\";
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void buttonGetImageUrls_Click(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol =
                SecurityProtocolType.Tls12 |
                SecurityProtocolType.Tls11 |
                SecurityProtocolType.Tls;

            string pageUrl = textBoxPageUrl.Text.Trim();

            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;

            string html = client.DownloadString(pageUrl);

            // 抓 img src
            MatchCollection matches = Regex.Matches(
                html,
                "<img[^>]+src=[\"']([^\"']+)[\"']",
                RegexOptions.IgnoreCase
            );

            Uri baseUri = new Uri(pageUrl);

            rtbImageUrls.Clear();

            foreach (Match m in matches)
            {
                string src = m.Groups[1].Value;

                // 忽略不是圖片的
                if (!src.EndsWith(".jpg") &&
                    !src.EndsWith(".jpeg") &&
                    !src.EndsWith(".png") &&
                    !src.EndsWith(".gif") &&
                    !src.EndsWith(".webp"))
                {
                    continue;
                }

                Uri imgUri = new Uri(baseUri, src);  // 轉成完整網址
                rtbImageUrls.AppendText(imgUri.AbsoluteUri + Environment.NewLine);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            using (HelpForm help = new HelpForm())
            {
                help.ShowDialog(this);   // 以對話框顯示，會在主視窗前面
            }
        }

        private void btnExtractImageUrls_Click(object sender, EventArgs e)
        {
            // 1. 讀取目前 rtbRawContent 的原始內容
            string rawText = rtbRawContent.Text;

            if (string.IsNullOrWhiteSpace(rawText))
            {
                MessageBox.Show("目前沒有任何內容可以整理，請先貼上原始碼或網址。","提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. 用 Regex 抓出所有圖片網址
            //    規則：以 http 或 https 開頭，後面不是空白/引號/<>，且以常見圖片副檔名結尾
            Regex regex = new Regex(
                @"https?://[^\s""'<>]+?\.(jpg|jpeg|png|gif|webp)",
                RegexOptions.IgnoreCase
            );

            MatchCollection matches = regex.Matches(rawText);

            if (matches.Count == 0)
            {
                MessageBox.Show("在這段文字中沒有找到任何圖片網址。","整理完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 3. 用 HashSet 去除重複網址
            HashSet<string> urlSet = new HashSet<string>();
            StringBuilder sb = new StringBuilder();

            foreach (Match m in matches)
            {
                string url = m.Value.Trim();

                // 如果是新的（不重複），就加入
                if (urlSet.Add(url))
                {
                    sb.AppendLine(url);
                }
            }

            // 4. 把整理好的結果寫回 rtbImageUrls
            rtbImageUrls.Text = sb.ToString();

            MessageBox.Show($"已整理完成，共找到 {urlSet.Count} 個圖片網址。","整理完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClearRawContent_Click(object sender, EventArgs e)
        {
            rtbRawContent.Clear();
        }

        private void btnClearImageUrls_Click(object sender, EventArgs e)
        {
            rtbImageUrls.Clear();
        }

    }
}
