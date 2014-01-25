using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Spanish_Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void wikiButton_Click(object sender, EventArgs e)
        {
            string key = wordBox.Text.Trim();
            key = key.Replace(" ", "_");//wikipedia does not use utf-8

            string wikiUrl = "";
            if (isEs2En)
                wikiUrl = "http://es.wikipedia.org/wiki/" + key;
            else
                wikiUrl = "http://en.wikipedia.org/wiki/" + key;

            wikiBrowser.Navigate(wikiUrl);
            wikiPanel.Location = new Point(0, 0);
            wikiPanel.Visible = true;

        }

        private void closeWiki_Click(object sender, EventArgs e)
        {
            timerHide.Enabled = true;
            closeWiki.ForeColor = Color.DimGray;
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            string key = wordBox.Text.Trim();
            key = System.Web.HttpUtility.UrlEncode(key);

            string transUrl = "";
            if (isEs2En)
                transUrl = "http://www.wordreference.com/es/en/translation.asp?spen=" + key;
            else
                transUrl = "http://www.wordreference.com/es/translation.asp?tranword=" + key;

            wikiBrowser.Navigate(transUrl);
            wikiPanel.Location = new Point(0, 0);
            wikiPanel.Visible = true;
        }

        private void pronounceButton_Click(object sender, EventArgs e)
        {
            try
            {
                string key = wordBox.Text.Trim();
                key = System.Web.HttpUtility.UrlEncode(key);

                string local_path = Path.Combine(System.Environment.CurrentDirectory, "speech");

                if (!Directory.Exists(local_path))
                    Directory.CreateDirectory(local_path);

                if (!Directory.Exists(local_path + "\\es"))
                    Directory.CreateDirectory(local_path + "\\es");

                if (!Directory.Exists(local_path + "\\en"))
                    Directory.CreateDirectory(local_path + "\\en");

                string local_path_mp3 = "";
                string url = "";

                if (isEs2En)
                {
                    local_path_mp3 = Path.Combine(local_path + "\\es", key + ".mp3");
                    url = "http://audio1.spanishdict.com/audio?lang=es&speed=25&text=" + key;
                }
                else
                {
                    local_path_mp3 = Path.Combine(local_path + "\\en", key + ".mp3");
                    url = "http://www.onelook.com/pronounce/macmillan/US/" + key + "-American-English-pronunciation.mp3";
                }

                if (!File.Exists(local_path_mp3))
                {
                    WebClient myWebClient = new WebClient();
                    myWebClient.DownloadFile(url, local_path_mp3);
                }

                wmp.URL = local_path_mp3;
                wmp.Ctlcontrols.play();
            }
            catch 
            {
                wmp.Ctlcontrols.stop();
                wmp.URL = "http://www.onelook.com/pronounce/macmillan/US/sorry-American-English-pronunciation.mp3";
                wmp.Ctlcontrols.play();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wikiPanel.BringToFront();//its visibility is set to false, this allows wikiPanel to fill the window when displayed
            wordBox.AutoCompleteCustomSource.Clear();
            wordBox.AutoCompleteCustomSource.AddRange(Properties.Resources.autocomplete_es.Split("%".ToCharArray()));
        }

        private void alpha_Click(object sender, EventArgs e)
        {
            int selStart = wordBox.SelectionStart;
            wordBox.Text = wordBox.Text.Remove(selStart, wordBox.SelectionLength);//replace selected text (if exists)
            wordBox.Text = wordBox.Text.Insert(selStart, ((Label)sender).Text);//insert alpha from dial pad
            wordBox.SelectionStart = selStart + 1;//adjust selection
        }

        bool isEs2En = true;
        private void reverseButton_Click(object sender, EventArgs e)
        {
            reverseButton.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            reverseButton.Refresh();

            if (this.Text == "Spanish to English")
            {
                this.Text = "English to Spanish";
                isEs2En = false;
            }
            else
            {
                this.Text = "Spanish to English";
                isEs2En = true;
            }
        }

        private void wikiBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string err1 = "No translation found for";//wordreference en-es
            string err2 = "No English translation found for";//wordreference es-en
            string err3 = "Wikipedia aún no tiene una página llamada";//wikipedia es
            string err4 = "Wikipedia does not have an article with";//wikipedia

            if (wikiBrowser.DocumentText.Contains(err1) ||
                wikiBrowser.DocumentText.Contains(err2) ||
                wikiBrowser.DocumentText.Contains(err3) ||
                wikiBrowser.DocumentText.Contains(err4) || wikiBrowser.DocumentText == "")
            {
                wikiBrowser.Navigate("http://css-tricks.com/thispagedoesntexist");
            }
        }

        private void closeWiki_MouseHover(object sender, EventArgs e)
        {
            closeWiki.ForeColor = Color.White;
        }

        private void closeWiki_MouseLeave(object sender, EventArgs e)
        {
            closeWiki.ForeColor = Color.DimGray;
        }

        private void wordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                translateButton_Click(translateButton, new EventArgs());
            }
        }

        private void timerHide_Tick(object sender, EventArgs e)
        {
            if (wikiPanel.Left < this.ClientSize.Width)
            {
                wikiPanel.Left += 100;//drag right
            }
            else
            {
                timerHide.Enabled = false;
                wikiPanel.Visible = false;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (timerHide.Enabled)
            {
                wikiPanel.Height = this.ClientSize.Height;
            }
            else
            {
                wikiPanel.Size = this.ClientSize;
            }
        }

        private void mainButton_MouseHover(object sender, EventArgs e)
        {
            Image image = ((PictureBox)sender).Image;
            Bitmap bitmap = new Bitmap(image.Width, image.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(image, new Rectangle(5, 5, 118, 118), new Rectangle(0, 0, 128, 128), GraphicsUnit.Pixel);
            g.Dispose();
            ((PictureBox)sender).Image = bitmap;
        }

        private void mainButton_MouseLeave(object sender, EventArgs e)
        {
            translateButton.Image = Properties.Resources.translate;
            pronounceButton.Image = Properties.Resources.speaker;
            wikiButton.Image = Properties.Resources.wikipedia;
            reverseButton.Image = Properties.Resources.refresh;
            browserButton.Image = Properties.Resources.browser;
            musicButton.Image = Properties.Resources.music;

            if (!isEs2En)
                reverseButton.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        private void alpha_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).Font = new Font(((Label)sender).Font.FontFamily, 14.25f, FontStyle.Regular);
        }

        private void alpha_MouseMove(object sender, MouseEventArgs e)
        {
            ((Label)sender).Font = new Font(((Label)sender).Font.FontFamily, 16f, FontStyle.Bold);
        }

        private void wordBox_TextChanged(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("key.wav");
            player.Play();
        }

        private void browserButton_Click(object sender, EventArgs e)
        {
            wikiBrowser.Navigate(wordBox.Text.Trim());
            wikiPanel.Location = new Point(0, 0);
            wikiPanel.Visible = true;
        }

        private void musicButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Music|*.mp3";
            dlg.FileName = "";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                wmp.URL = dlg.FileName;
                wmp.Ctlcontrols.play();
            }
        }

        private void wikiBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            wikiBrowserProgressBar.Visible = true;
            if ((e.CurrentProgress > 0) && (e.MaximumProgress > 0))
            {
                wikiBrowserProgressBar.Maximum = Convert.ToInt32(e.MaximumProgress);//total bytes
                wikiBrowserProgressBar.Step = Convert.ToInt32(e.CurrentProgress);//bytes already downloaded
                wikiBrowserProgressBar.PerformStep();
            }
            else if (wikiBrowser.ReadyState == WebBrowserReadyState.Complete)//hide after complete
            {
                wikiBrowserProgressBar.Value = 0;
                wikiBrowserProgressBar.Visible = false;
            }
        }
    }
}
