namespace ja_learner
{
    partial class DictForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DictForm));
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabControl1 = new TabControl();
            tabPageDict = new TabPage();
            tabPageGpt = new TabPage();
            translationPanel = new GUI.TranslationPanel();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            tabControl1.SuspendLayout();
            tabPageDict.SuspendLayout();
            tabPageGpt.SuspendLayout();
            SuspendLayout();
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
            webView.Size = new Size(648, 632);
            webView.TabIndex = 0;
            webView.ZoomFactor = 1D;
            webView.WebMessageReceived += webView_WebMessageReceived;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageDict);
            tabControl1.Controls.Add(tabPageGpt);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(5, 4, 5, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(666, 678);
            tabControl1.TabIndex = 1;
            // 
            // tabPageDict
            // 
            tabPageDict.Controls.Add(webView);
            tabPageDict.Location = new Point(4, 34);
            tabPageDict.Margin = new Padding(5, 4, 5, 4);
            tabPageDict.Name = "tabPageDict";
            tabPageDict.Padding = new Padding(5, 4, 5, 4);
            tabPageDict.Size = new Size(658, 640);
            tabPageDict.TabIndex = 0;
            tabPageDict.Text = "词典";
            tabPageDict.UseVisualStyleBackColor = true;
            // 
            // tabPageGpt
            // 
            tabPageGpt.Controls.Add(translationPanel);
            tabPageGpt.Location = new Point(4, 34);
            tabPageGpt.Margin = new Padding(5, 4, 5, 4);
            tabPageGpt.Name = "tabPageGpt";
            tabPageGpt.Padding = new Padding(5, 4, 5, 4);
            tabPageGpt.Size = new Size(658, 640);
            tabPageGpt.TabIndex = 1;
            tabPageGpt.Text = "ChatGPT";
            tabPageGpt.UseVisualStyleBackColor = true;
            // 
            // translationPanel
            // 
            translationPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            translationPanel.BackColor = Color.FromArgb(40, 40, 40);
            translationPanel.Location = new Point(9, 9);
            translationPanel.Margin = new Padding(8, 6, 8, 6);
            translationPanel.Name = "translationPanel";
            translationPanel.Size = new Size(974, 1103);
            translationPanel.TabIndex = 0;
            // 
            // DictForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 678);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "DictForm";
            Text = "KS的日语学习工具";
            FormClosing += DictForm_FormClosing;
            Load += DictForm_Load;
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageDict.ResumeLayout(false);
            tabPageGpt.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private TabControl tabControl1;
        private TabPage tabPageDict;
        private TabPage tabPageGpt;
        private GUI.TranslationPanel translationPanel;
    }
}