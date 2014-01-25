namespace Spanish_Dictionary
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wordBox = new System.Windows.Forms.TextBox();
            this.translateButton = new System.Windows.Forms.PictureBox();
            this.pronounceButton = new System.Windows.Forms.PictureBox();
            this.wikiButton = new System.Windows.Forms.PictureBox();
            this.reverseButton = new System.Windows.Forms.PictureBox();
            this.alpha1 = new System.Windows.Forms.Label();
            this.alpha2 = new System.Windows.Forms.Label();
            this.alpha3 = new System.Windows.Forms.Label();
            this.alpha4 = new System.Windows.Forms.Label();
            this.alpha5 = new System.Windows.Forms.Label();
            this.alpha7 = new System.Windows.Forms.Label();
            this.alpha6 = new System.Windows.Forms.Label();
            this.alpha8 = new System.Windows.Forms.Label();
            this.alpha9 = new System.Windows.Forms.Label();
            this.wikiBrowser = new System.Windows.Forms.WebBrowser();
            this.wikiPanel = new System.Windows.Forms.Panel();
            this.closeWiki = new System.Windows.Forms.Label();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.browserButton = new System.Windows.Forms.PictureBox();
            this.musicButton = new System.Windows.Forms.PictureBox();
            this.timerHide = new System.Windows.Forms.Timer(this.components);
            this.wikiBrowserProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.translateButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pronounceButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wikiButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reverseButton)).BeginInit();
            this.wikiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browserButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicButton)).BeginInit();
            this.SuspendLayout();
            // 
            // wordBox
            // 
            this.wordBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wordBox.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.wordBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.wordBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.wordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordBox.Location = new System.Drawing.Point(14, 22);
            this.wordBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.wordBox.Name = "wordBox";
            this.wordBox.Size = new System.Drawing.Size(756, 31);
            this.wordBox.TabIndex = 0;
            this.wordBox.TextChanged += new System.EventHandler(this.wordBox_TextChanged);
            this.wordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wordBox_KeyDown);
            // 
            // translateButton
            // 
            this.translateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.translateButton.BackColor = System.Drawing.Color.Transparent;
            this.translateButton.Image = global::Spanish_Dictionary.Properties.Resources.translate;
            this.translateButton.Location = new System.Drawing.Point(166, 116);
            this.translateButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(128, 128);
            this.translateButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.translateButton.TabIndex = 2;
            this.translateButton.TabStop = false;
            this.toolTip1.SetToolTip(this.translateButton, "Translate");
            this.translateButton.MouseLeave += new System.EventHandler(this.mainButton_MouseLeave);
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            this.translateButton.MouseHover += new System.EventHandler(this.mainButton_MouseHover);
            // 
            // pronounceButton
            // 
            this.pronounceButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pronounceButton.BackColor = System.Drawing.Color.Transparent;
            this.pronounceButton.Image = global::Spanish_Dictionary.Properties.Resources.speaker;
            this.pronounceButton.Location = new System.Drawing.Point(328, 116);
            this.pronounceButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pronounceButton.Name = "pronounceButton";
            this.pronounceButton.Size = new System.Drawing.Size(128, 128);
            this.pronounceButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pronounceButton.TabIndex = 4;
            this.pronounceButton.TabStop = false;
            this.toolTip1.SetToolTip(this.pronounceButton, "Pronounce");
            this.pronounceButton.MouseLeave += new System.EventHandler(this.mainButton_MouseLeave);
            this.pronounceButton.Click += new System.EventHandler(this.pronounceButton_Click);
            this.pronounceButton.MouseHover += new System.EventHandler(this.mainButton_MouseHover);
            // 
            // wikiButton
            // 
            this.wikiButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wikiButton.BackColor = System.Drawing.Color.Transparent;
            this.wikiButton.Image = global::Spanish_Dictionary.Properties.Resources.wikipedia;
            this.wikiButton.Location = new System.Drawing.Point(166, 274);
            this.wikiButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.wikiButton.Name = "wikiButton";
            this.wikiButton.Size = new System.Drawing.Size(128, 128);
            this.wikiButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wikiButton.TabIndex = 5;
            this.wikiButton.TabStop = false;
            this.toolTip1.SetToolTip(this.wikiButton, "Wikipedia");
            this.wikiButton.MouseLeave += new System.EventHandler(this.mainButton_MouseLeave);
            this.wikiButton.Click += new System.EventHandler(this.wikiButton_Click);
            this.wikiButton.MouseHover += new System.EventHandler(this.mainButton_MouseHover);
            // 
            // reverseButton
            // 
            this.reverseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reverseButton.BackColor = System.Drawing.Color.Transparent;
            this.reverseButton.Image = global::Spanish_Dictionary.Properties.Resources.refresh;
            this.reverseButton.Location = new System.Drawing.Point(328, 274);
            this.reverseButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(128, 128);
            this.reverseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reverseButton.TabIndex = 6;
            this.reverseButton.TabStop = false;
            this.toolTip1.SetToolTip(this.reverseButton, "Reverse");
            this.reverseButton.MouseLeave += new System.EventHandler(this.mainButton_MouseLeave);
            this.reverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            this.reverseButton.MouseHover += new System.EventHandler(this.mainButton_MouseHover);
            // 
            // alpha1
            // 
            this.alpha1.BackColor = System.Drawing.Color.Transparent;
            this.alpha1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.alpha1.Location = new System.Drawing.Point(111, 59);
            this.alpha1.Name = "alpha1";
            this.alpha1.Size = new System.Drawing.Size(30, 30);
            this.alpha1.TabIndex = 7;
            this.alpha1.Text = "¿";
            this.alpha1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alpha1.MouseLeave += new System.EventHandler(this.alpha_MouseLeave);
            this.alpha1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.alpha_MouseMove);
            this.alpha1.Click += new System.EventHandler(this.alpha_Click);
            // 
            // alpha2
            // 
            this.alpha2.BackColor = System.Drawing.Color.Transparent;
            this.alpha2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.alpha2.Location = new System.Drawing.Point(147, 59);
            this.alpha2.Name = "alpha2";
            this.alpha2.Size = new System.Drawing.Size(30, 30);
            this.alpha2.TabIndex = 8;
            this.alpha2.Text = "¡";
            this.alpha2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alpha2.MouseLeave += new System.EventHandler(this.alpha_MouseLeave);
            this.alpha2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.alpha_MouseMove);
            this.alpha2.Click += new System.EventHandler(this.alpha_Click);
            // 
            // alpha3
            // 
            this.alpha3.BackColor = System.Drawing.Color.Transparent;
            this.alpha3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.alpha3.Location = new System.Drawing.Point(183, 59);
            this.alpha3.Name = "alpha3";
            this.alpha3.Size = new System.Drawing.Size(30, 30);
            this.alpha3.TabIndex = 9;
            this.alpha3.Text = "á";
            this.alpha3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alpha3.MouseLeave += new System.EventHandler(this.alpha_MouseLeave);
            this.alpha3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.alpha_MouseMove);
            this.alpha3.Click += new System.EventHandler(this.alpha_Click);
            // 
            // alpha4
            // 
            this.alpha4.BackColor = System.Drawing.Color.Transparent;
            this.alpha4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.alpha4.Location = new System.Drawing.Point(219, 59);
            this.alpha4.Name = "alpha4";
            this.alpha4.Size = new System.Drawing.Size(30, 30);
            this.alpha4.TabIndex = 10;
            this.alpha4.Text = "é";
            this.alpha4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alpha4.MouseLeave += new System.EventHandler(this.alpha_MouseLeave);
            this.alpha4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.alpha_MouseMove);
            this.alpha4.Click += new System.EventHandler(this.alpha_Click);
            // 
            // alpha5
            // 
            this.alpha5.BackColor = System.Drawing.Color.Transparent;
            this.alpha5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.alpha5.Location = new System.Drawing.Point(255, 59);
            this.alpha5.Name = "alpha5";
            this.alpha5.Size = new System.Drawing.Size(30, 30);
            this.alpha5.TabIndex = 11;
            this.alpha5.Text = "í";
            this.alpha5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alpha5.MouseLeave += new System.EventHandler(this.alpha_MouseLeave);
            this.alpha5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.alpha_MouseMove);
            this.alpha5.Click += new System.EventHandler(this.alpha_Click);
            // 
            // alpha7
            // 
            this.alpha7.BackColor = System.Drawing.Color.Transparent;
            this.alpha7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.alpha7.Location = new System.Drawing.Point(327, 59);
            this.alpha7.Name = "alpha7";
            this.alpha7.Size = new System.Drawing.Size(30, 30);
            this.alpha7.TabIndex = 12;
            this.alpha7.Text = "ú";
            this.alpha7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alpha7.MouseLeave += new System.EventHandler(this.alpha_MouseLeave);
            this.alpha7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.alpha_MouseMove);
            this.alpha7.Click += new System.EventHandler(this.alpha_Click);
            // 
            // alpha6
            // 
            this.alpha6.BackColor = System.Drawing.Color.Transparent;
            this.alpha6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.alpha6.Location = new System.Drawing.Point(291, 59);
            this.alpha6.Name = "alpha6";
            this.alpha6.Size = new System.Drawing.Size(30, 30);
            this.alpha6.TabIndex = 13;
            this.alpha6.Text = "ó";
            this.alpha6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alpha6.MouseLeave += new System.EventHandler(this.alpha_MouseLeave);
            this.alpha6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.alpha_MouseMove);
            this.alpha6.Click += new System.EventHandler(this.alpha_Click);
            // 
            // alpha8
            // 
            this.alpha8.BackColor = System.Drawing.Color.Transparent;
            this.alpha8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.alpha8.Location = new System.Drawing.Point(363, 59);
            this.alpha8.Name = "alpha8";
            this.alpha8.Size = new System.Drawing.Size(30, 30);
            this.alpha8.TabIndex = 14;
            this.alpha8.Text = "ü";
            this.alpha8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alpha8.MouseLeave += new System.EventHandler(this.alpha_MouseLeave);
            this.alpha8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.alpha_MouseMove);
            this.alpha8.Click += new System.EventHandler(this.alpha_Click);
            // 
            // alpha9
            // 
            this.alpha9.BackColor = System.Drawing.Color.Transparent;
            this.alpha9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.alpha9.Location = new System.Drawing.Point(399, 59);
            this.alpha9.Name = "alpha9";
            this.alpha9.Size = new System.Drawing.Size(30, 30);
            this.alpha9.TabIndex = 15;
            this.alpha9.Text = "ñ";
            this.alpha9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alpha9.MouseLeave += new System.EventHandler(this.alpha_MouseLeave);
            this.alpha9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.alpha_MouseMove);
            this.alpha9.Click += new System.EventHandler(this.alpha_Click);
            // 
            // wikiBrowser
            // 
            this.wikiBrowser.AllowWebBrowserDrop = false;
            this.wikiBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wikiBrowser.IsWebBrowserContextMenuEnabled = false;
            this.wikiBrowser.Location = new System.Drawing.Point(50, 0);
            this.wikiBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wikiBrowser.Name = "wikiBrowser";
            this.wikiBrowser.ScriptErrorsSuppressed = true;
            this.wikiBrowser.Size = new System.Drawing.Size(734, 461);
            this.wikiBrowser.TabIndex = 16;
            this.wikiBrowser.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.wikiBrowser_ProgressChanged);
            this.wikiBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wikiBrowser_DocumentCompleted);
            // 
            // wikiPanel
            // 
            this.wikiPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wikiPanel.Controls.Add(this.wikiBrowserProgressBar);
            this.wikiPanel.Controls.Add(this.wikiBrowser);
            this.wikiPanel.Controls.Add(this.closeWiki);
            this.wikiPanel.Controls.Add(this.wmp);
            this.wikiPanel.Location = new System.Drawing.Point(0, 0);
            this.wikiPanel.Name = "wikiPanel";
            this.wikiPanel.Size = new System.Drawing.Size(784, 461);
            this.wikiPanel.TabIndex = 17;
            this.wikiPanel.Visible = false;
            // 
            // closeWiki
            // 
            this.closeWiki.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.closeWiki.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeWiki.ForeColor = System.Drawing.Color.DimGray;
            this.closeWiki.Location = new System.Drawing.Point(0, 0);
            this.closeWiki.Name = "closeWiki";
            this.closeWiki.Size = new System.Drawing.Size(54, 461);
            this.closeWiki.TabIndex = 17;
            this.closeWiki.Text = ">>";
            this.closeWiki.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeWiki.MouseLeave += new System.EventHandler(this.closeWiki_MouseLeave);
            this.closeWiki.Click += new System.EventHandler(this.closeWiki_Click);
            this.closeWiki.MouseHover += new System.EventHandler(this.closeWiki_MouseHover);
            // 
            // wmp
            // 
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(858, 35);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(10, 10);
            this.wmp.TabIndex = 18;
            // 
            // browserButton
            // 
            this.browserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browserButton.BackColor = System.Drawing.Color.Transparent;
            this.browserButton.Image = global::Spanish_Dictionary.Properties.Resources.browser;
            this.browserButton.Location = new System.Drawing.Point(490, 116);
            this.browserButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.browserButton.Name = "browserButton";
            this.browserButton.Size = new System.Drawing.Size(128, 128);
            this.browserButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.browserButton.TabIndex = 18;
            this.browserButton.TabStop = false;
            this.toolTip1.SetToolTip(this.browserButton, "Browse the Internet");
            this.browserButton.MouseLeave += new System.EventHandler(this.mainButton_MouseLeave);
            this.browserButton.Click += new System.EventHandler(this.browserButton_Click);
            this.browserButton.MouseHover += new System.EventHandler(this.mainButton_MouseHover);
            // 
            // musicButton
            // 
            this.musicButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.musicButton.BackColor = System.Drawing.Color.Transparent;
            this.musicButton.Image = global::Spanish_Dictionary.Properties.Resources.music;
            this.musicButton.Location = new System.Drawing.Point(490, 274);
            this.musicButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.musicButton.Name = "musicButton";
            this.musicButton.Size = new System.Drawing.Size(128, 128);
            this.musicButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.musicButton.TabIndex = 19;
            this.musicButton.TabStop = false;
            this.toolTip1.SetToolTip(this.musicButton, "Music");
            this.musicButton.MouseLeave += new System.EventHandler(this.mainButton_MouseLeave);
            this.musicButton.Click += new System.EventHandler(this.musicButton_Click);
            this.musicButton.MouseHover += new System.EventHandler(this.mainButton_MouseHover);
            // 
            // timerHide
            // 
            this.timerHide.Interval = 1;
            this.timerHide.Tick += new System.EventHandler(this.timerHide_Tick);
            // 
            // wikiBrowserProgressBar
            // 
            this.wikiBrowserProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wikiBrowserProgressBar.Location = new System.Drawing.Point(50, 451);
            this.wikiBrowserProgressBar.Name = "wikiBrowserProgressBar";
            this.wikiBrowserProgressBar.Size = new System.Drawing.Size(731, 10);
            this.wikiBrowserProgressBar.TabIndex = 20;
            this.wikiBrowserProgressBar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.musicButton);
            this.Controls.Add(this.browserButton);
            this.Controls.Add(this.alpha9);
            this.Controls.Add(this.alpha8);
            this.Controls.Add(this.alpha6);
            this.Controls.Add(this.alpha7);
            this.Controls.Add(this.alpha5);
            this.Controls.Add(this.alpha4);
            this.Controls.Add(this.alpha3);
            this.Controls.Add(this.alpha2);
            this.Controls.Add(this.alpha1);
            this.Controls.Add(this.reverseButton);
            this.Controls.Add(this.wikiButton);
            this.Controls.Add(this.pronounceButton);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.wordBox);
            this.Controls.Add(this.wikiPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Spanish to English";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.translateButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pronounceButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wikiButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reverseButton)).EndInit();
            this.wikiPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browserButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wordBox;
        private System.Windows.Forms.PictureBox translateButton;
        private System.Windows.Forms.PictureBox pronounceButton;
        private System.Windows.Forms.PictureBox wikiButton;
        private System.Windows.Forms.PictureBox reverseButton;
        private System.Windows.Forms.Label alpha1;
        private System.Windows.Forms.Label alpha2;
        private System.Windows.Forms.Label alpha3;
        private System.Windows.Forms.Label alpha4;
        private System.Windows.Forms.Label alpha5;
        private System.Windows.Forms.Label alpha7;
        private System.Windows.Forms.Label alpha6;
        private System.Windows.Forms.Label alpha8;
        private System.Windows.Forms.Label alpha9;
        private System.Windows.Forms.WebBrowser wikiBrowser;
        private System.Windows.Forms.Panel wikiPanel;
        private System.Windows.Forms.Label closeWiki;
        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timerHide;
        private System.Windows.Forms.PictureBox browserButton;
        private System.Windows.Forms.PictureBox musicButton;
        private System.Windows.Forms.ProgressBar wikiBrowserProgressBar;
    }
}

