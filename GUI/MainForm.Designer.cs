﻿namespace ja_learner
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            timerWindowAttach = new System.Windows.Forms.Timer(components);
            timerSelectWindow = new System.Windows.Forms.Timer(components);
            tabPageSettings = new TabPage();
            checkBoxUseProxy = new CheckBox();
            comboBoxExtraPrompts = new ComboBox();
            checkBoxUseExtraPrompt = new CheckBox();
            buttonUpdateExtraPrompt = new Button();
            checkBoxDark = new CheckBox();
            checkBoxTopmost = new CheckBox();
            textBoxHwnd = new TextBox();
            btnSelectWindow = new Button();
            checkBoxWindowAttach = new CheckBox();
            tabPageText = new TabPage();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabControl = new TabControl();
            timerGetClipboard = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            comboBoxTranslator = new ComboBox();
            checkBoxTranslateKatakana = new CheckBox();
            checkBoxAutoTranslate = new CheckBox();
            buttonTranslate = new Button();
            buttonShowDictForm = new Button();
            btnInputText = new Button();
            checkBoxClipboardMode = new CheckBox();
            tabPageSettings.SuspendLayout();
            tabPageText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            tabControl.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timerWindowAttach
            // 
            timerWindowAttach.Interval = 15;
            timerWindowAttach.Tick += timerWindowAttach_Tick;
            // 
            // timerSelectWindow
            // 
            timerSelectWindow.Tick += timerSelectWindow_Tick;
            // 
            // tabPageSettings
            // 
            tabPageSettings.Controls.Add(checkBoxUseProxy);
            tabPageSettings.Controls.Add(comboBoxExtraPrompts);
            tabPageSettings.Controls.Add(checkBoxUseExtraPrompt);
            tabPageSettings.Controls.Add(buttonUpdateExtraPrompt);
            tabPageSettings.Controls.Add(checkBoxDark);
            tabPageSettings.Controls.Add(checkBoxTopmost);
            tabPageSettings.Controls.Add(textBoxHwnd);
            tabPageSettings.Controls.Add(btnSelectWindow);
            tabPageSettings.Controls.Add(checkBoxWindowAttach);
            tabPageSettings.Location = new Point(4, 34);
            tabPageSettings.Margin = new Padding(5, 4, 5, 4);
            tabPageSettings.Name = "tabPageSettings";
            tabPageSettings.Padding = new Padding(5, 4, 5, 4);
            tabPageSettings.Size = new Size(878, 211);
            tabPageSettings.TabIndex = 0;
            tabPageSettings.Text = "系统设置";
            tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseProxy
            // 
            checkBoxUseProxy.AutoSize = true;
            checkBoxUseProxy.Enabled = false;
            checkBoxUseProxy.Location = new Point(13, 162);
            checkBoxUseProxy.Margin = new Padding(5, 4, 5, 4);
            checkBoxUseProxy.Name = "checkBoxUseProxy";
            checkBoxUseProxy.Size = new Size(118, 29);
            checkBoxUseProxy.TabIndex = 9;
            checkBoxUseProxy.Text = "HTTP代理";
            checkBoxUseProxy.UseVisualStyleBackColor = true;
            checkBoxUseProxy.CheckedChanged += checkBoxUseProxy_CheckedChanged;
            // 
            // comboBoxExtraPrompts
            // 
            comboBoxExtraPrompts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxExtraPrompts.FormattingEnabled = true;
            comboBoxExtraPrompts.Location = new Point(207, 116);
            comboBoxExtraPrompts.Margin = new Padding(5, 4, 5, 4);
            comboBoxExtraPrompts.Name = "comboBoxExtraPrompts";
            comboBoxExtraPrompts.Size = new Size(180, 33);
            comboBoxExtraPrompts.Sorted = true;
            comboBoxExtraPrompts.TabIndex = 8;
            comboBoxExtraPrompts.SelectedIndexChanged += comboBoxExtraPrompts_SelectedIndexChanged;
            comboBoxExtraPrompts.Click += comboBoxExtraPrompts_Click;
            // 
            // checkBoxUseExtraPrompt
            // 
            checkBoxUseExtraPrompt.AutoSize = true;
            checkBoxUseExtraPrompt.Enabled = false;
            checkBoxUseExtraPrompt.Location = new Point(13, 119);
            checkBoxUseExtraPrompt.Margin = new Padding(5, 4, 5, 4);
            checkBoxUseExtraPrompt.Name = "checkBoxUseExtraPrompt";
            checkBoxUseExtraPrompt.Size = new Size(175, 29);
            checkBoxUseExtraPrompt.TabIndex = 7;
            checkBoxUseExtraPrompt.Text = "使用额外Prompt";
            checkBoxUseExtraPrompt.UseVisualStyleBackColor = true;
            checkBoxUseExtraPrompt.CheckedChanged += checkBoxUseExtraPrompt_CheckedChanged;
            // 
            // buttonUpdateExtraPrompt
            // 
            buttonUpdateExtraPrompt.Location = new Point(399, 113);
            buttonUpdateExtraPrompt.Margin = new Padding(5, 4, 5, 4);
            buttonUpdateExtraPrompt.Name = "buttonUpdateExtraPrompt";
            buttonUpdateExtraPrompt.Size = new Size(118, 40);
            buttonUpdateExtraPrompt.TabIndex = 6;
            buttonUpdateExtraPrompt.Text = "重新读取";
            buttonUpdateExtraPrompt.UseVisualStyleBackColor = true;
            buttonUpdateExtraPrompt.Click += buttonUpdateExtraPrompt_Click;
            // 
            // checkBoxDark
            // 
            checkBoxDark.AutoSize = true;
            checkBoxDark.Location = new Point(178, 74);
            checkBoxDark.Margin = new Padding(5, 4, 5, 4);
            checkBoxDark.Name = "checkBoxDark";
            checkBoxDark.Size = new Size(107, 29);
            checkBoxDark.TabIndex = 6;
            checkBoxDark.Text = "深色模式";
            checkBoxDark.UseVisualStyleBackColor = true;
            checkBoxDark.Click += checkBoxDark_CheckedChanged;
            // 
            // checkBoxTopmost
            // 
            checkBoxTopmost.AutoSize = true;
            checkBoxTopmost.Location = new Point(13, 74);
            checkBoxTopmost.Margin = new Padding(5, 4, 5, 4);
            checkBoxTopmost.Name = "checkBoxTopmost";
            checkBoxTopmost.Size = new Size(145, 29);
            checkBoxTopmost.TabIndex = 5;
            checkBoxTopmost.Text = "保持窗口前置";
            checkBoxTopmost.UseVisualStyleBackColor = true;
            checkBoxTopmost.CheckedChanged += checkBoxTopmost_CheckedChanged;
            // 
            // textBoxHwnd
            // 
            textBoxHwnd.Location = new Point(140, 22);
            textBoxHwnd.Margin = new Padding(5, 4, 5, 4);
            textBoxHwnd.Name = "textBoxHwnd";
            textBoxHwnd.ReadOnly = true;
            textBoxHwnd.Size = new Size(155, 32);
            textBoxHwnd.TabIndex = 1;
            textBoxHwnd.Text = "114514";
            textBoxHwnd.TextChanged += textBoxHwnd_TextChanged;
            // 
            // btnSelectWindow
            // 
            btnSelectWindow.Location = new Point(9, 22);
            btnSelectWindow.Margin = new Padding(5, 4, 5, 4);
            btnSelectWindow.Name = "btnSelectWindow";
            btnSelectWindow.Size = new Size(118, 34);
            btnSelectWindow.TabIndex = 4;
            btnSelectWindow.Text = "选择窗口";
            btnSelectWindow.UseVisualStyleBackColor = true;
            btnSelectWindow.Click += btnSelectWindow_Click;
            // 
            // checkBoxWindowAttach
            // 
            checkBoxWindowAttach.AutoSize = true;
            checkBoxWindowAttach.Enabled = false;
            checkBoxWindowAttach.Location = new Point(306, 25);
            checkBoxWindowAttach.Margin = new Padding(5, 4, 5, 4);
            checkBoxWindowAttach.Name = "checkBoxWindowAttach";
            checkBoxWindowAttach.Size = new Size(126, 29);
            checkBoxWindowAttach.TabIndex = 3;
            checkBoxWindowAttach.Text = "与窗口对齐";
            checkBoxWindowAttach.UseVisualStyleBackColor = true;
            checkBoxWindowAttach.CheckedChanged += checkBoxWindowAttach_CheckedChanged;
            // 
            // tabPageText
            // 
            tabPageText.Controls.Add(webView);
            tabPageText.Location = new Point(4, 34);
            tabPageText.Margin = new Padding(5, 4, 5, 4);
            tabPageText.Name = "tabPageText";
            tabPageText.Padding = new Padding(5, 4, 5, 4);
            tabPageText.Size = new Size(878, 211);
            tabPageText.TabIndex = 1;
            tabPageText.Text = "语句分析";
            tabPageText.UseVisualStyleBackColor = true;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Dock = DockStyle.Fill;
            webView.Location = new Point(5, 4);
            webView.Margin = new Padding(5, 4, 5, 4);
            webView.Name = "webView";
            webView.Size = new Size(868, 203);
            webView.TabIndex = 1;
            webView.ZoomFactor = 1D;
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageText);
            tabControl.Controls.Add(tabPageSettings);
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(5, 4, 5, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(886, 249);
            tabControl.TabIndex = 2;
            // 
            // timerGetClipboard
            // 
            timerGetClipboard.Interval = 15;
            timerGetClipboard.Tick += timerGetClipboard_Tick;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxTranslator);
            panel1.Controls.Add(checkBoxTranslateKatakana);
            panel1.Controls.Add(checkBoxAutoTranslate);
            panel1.Controls.Add(buttonTranslate);
            panel1.Controls.Add(buttonShowDictForm);
            panel1.Controls.Add(btnInputText);
            panel1.Controls.Add(checkBoxClipboardMode);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 243);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(886, 53);
            panel1.TabIndex = 3;
            // 
            // comboBoxTranslator
            // 
            comboBoxTranslator.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxTranslator.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTranslator.FormattingEnabled = true;
            comboBoxTranslator.Items.AddRange(new object[] { "谷歌翻译", "ChatGPT", "谷歌生草机" });
            comboBoxTranslator.Location = new Point(495, 9);
            comboBoxTranslator.Margin = new Padding(5, 4, 5, 4);
            comboBoxTranslator.Name = "comboBoxTranslator";
            comboBoxTranslator.Size = new Size(133, 33);
            comboBoxTranslator.TabIndex = 12;
            // 
            // checkBoxTranslateKatakana
            // 
            checkBoxTranslateKatakana.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBoxTranslateKatakana.AutoSize = true;
            checkBoxTranslateKatakana.Location = new Point(778, 12);
            checkBoxTranslateKatakana.Margin = new Padding(5, 4, 5, 4);
            checkBoxTranslateKatakana.Name = "checkBoxTranslateKatakana";
            checkBoxTranslateKatakana.Size = new Size(107, 29);
            checkBoxTranslateKatakana.TabIndex = 10;
            checkBoxTranslateKatakana.Text = "片假不留";
            checkBoxTranslateKatakana.UseVisualStyleBackColor = true;
            checkBoxTranslateKatakana.CheckedChanged += checkBoxTranslateKatakana_CheckedChanged;
            // 
            // checkBoxAutoTranslate
            // 
            checkBoxAutoTranslate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBoxAutoTranslate.AutoSize = true;
            checkBoxAutoTranslate.Location = new Point(658, 12);
            checkBoxAutoTranslate.Margin = new Padding(5, 4, 5, 4);
            checkBoxAutoTranslate.Name = "checkBoxAutoTranslate";
            checkBoxAutoTranslate.Size = new Size(107, 29);
            checkBoxAutoTranslate.TabIndex = 9;
            checkBoxAutoTranslate.Text = "自动翻译";
            checkBoxAutoTranslate.UseVisualStyleBackColor = true;
            // 
            // buttonTranslate
            // 
            buttonTranslate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonTranslate.Location = new Point(415, 7);
            buttonTranslate.Margin = new Padding(5, 4, 5, 4);
            buttonTranslate.Name = "buttonTranslate";
            buttonTranslate.Size = new Size(71, 40);
            buttonTranslate.TabIndex = 8;
            buttonTranslate.Text = "翻译";
            buttonTranslate.UseVisualStyleBackColor = true;
            buttonTranslate.Click += buttonTranslate_Click;
            // 
            // buttonShowDictForm
            // 
            buttonShowDictForm.Location = new Point(267, 7);
            buttonShowDictForm.Margin = new Padding(5, 4, 5, 4);
            buttonShowDictForm.Name = "buttonShowDictForm";
            buttonShowDictForm.Size = new Size(113, 40);
            buttonShowDictForm.TabIndex = 7;
            buttonShowDictForm.Text = "词典窗口";
            buttonShowDictForm.UseVisualStyleBackColor = true;
            buttonShowDictForm.Click += buttonShowDictForm_Click;
            // 
            // btnInputText
            // 
            btnInputText.Location = new Point(151, 7);
            btnInputText.Margin = new Padding(5, 4, 5, 4);
            btnInputText.Name = "btnInputText";
            btnInputText.Size = new Size(107, 40);
            btnInputText.TabIndex = 1;
            btnInputText.Text = "手动输入";
            btnInputText.UseVisualStyleBackColor = true;
            btnInputText.Click += btnInputText_Click;
            // 
            // checkBoxClipboardMode
            // 
            checkBoxClipboardMode.AutoSize = true;
            checkBoxClipboardMode.Location = new Point(8, 12);
            checkBoxClipboardMode.Margin = new Padding(5, 4, 5, 4);
            checkBoxClipboardMode.Name = "checkBoxClipboardMode";
            checkBoxClipboardMode.Size = new Size(126, 29);
            checkBoxClipboardMode.TabIndex = 0;
            checkBoxClipboardMode.Text = "读取剪贴板";
            checkBoxClipboardMode.UseVisualStyleBackColor = true;
            checkBoxClipboardMode.CheckedChanged += checkBoxClipboardMode_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 296);
            Controls.Add(panel1);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MinimumSize = new Size(902, 332);
            Name = "MainForm";
            Text = "KS的日语学习工具";
            Load += MainForm_Load;
            SizeChanged += MainForm_SizeChanged;
            tabPageSettings.ResumeLayout(false);
            tabPageSettings.PerformLayout();
            tabPageText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            tabControl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerWindowAttach;
        private System.Windows.Forms.Timer timerSelectWindow;
        private TabPage tabPageSettings;
        private TabPage tabPageText;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private TabControl tabControl;
        private System.Windows.Forms.Timer timerGetClipboard;
        private TextBox textBoxHwnd;
        private Button btnSelectWindow;
        private CheckBox checkBoxWindowAttach;
        private Panel panel1;
        private Button buttonShowDictForm;
        private CheckBox checkBoxDark;
        private Button btnInputText;
        private CheckBox checkBoxClipboardMode;
        private GUI.TranslationPanel translationPanel;
        private Button buttonTranslate;
        private CheckBox checkBoxAutoTranslate;
        private CheckBox checkBoxTopmost;
        private CheckBox checkBoxUseExtraPrompt;
        private Button buttonUpdateExtraPrompt;
        private ComboBox comboBoxExtraPrompts;
        private CheckBox checkBoxTranslateKatakana;
        private ComboBox comboBoxTranslator;
        private CheckBox checkBoxUseProxy;
    }
}