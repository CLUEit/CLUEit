namespace CLUEit
{
    partial class mainWindow
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
            this.tlpBasicLayout = new System.Windows.Forms.TableLayoutPanel();
            this.labelCLUEit = new System.Windows.Forms.Label();
            this.tBoxSearchTerms = new System.Windows.Forms.TextBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowserWikipedia = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowserGoogle = new System.Windows.Forms.WebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.webBrowserImages = new System.Windows.Forms.WebBrowser();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.webBrowserYouTube = new System.Windows.Forms.WebBrowser();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tlpBasicLayout.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBasicLayout
            // 
            this.tlpBasicLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBasicLayout.ColumnCount = 3;
            this.tlpBasicLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpBasicLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBasicLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpBasicLayout.Controls.Add(this.labelCLUEit, 0, 0);
            this.tlpBasicLayout.Controls.Add(this.tBoxSearchTerms, 1, 0);
            this.tlpBasicLayout.Controls.Add(this.tabControlMain, 0, 1);
            this.tlpBasicLayout.Controls.Add(this.btnUpdate, 2, 0);
            this.tlpBasicLayout.Location = new System.Drawing.Point(7, 12);
            this.tlpBasicLayout.Name = "tlpBasicLayout";
            this.tlpBasicLayout.RowCount = 2;
            this.tlpBasicLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpBasicLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBasicLayout.Size = new System.Drawing.Size(503, 372);
            this.tlpBasicLayout.TabIndex = 0;
            // 
            // labelCLUEit
            // 
            this.labelCLUEit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCLUEit.AutoSize = true;
            this.labelCLUEit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCLUEit.Location = new System.Drawing.Point(3, 0);
            this.labelCLUEit.Name = "labelCLUEit";
            this.labelCLUEit.Size = new System.Drawing.Size(104, 30);
            this.labelCLUEit.TabIndex = 0;
            this.labelCLUEit.Text = "CLUEit";
            this.labelCLUEit.Click += new System.EventHandler(this.label1_Click);
            // 
            // tBoxSearchTerms
            // 
            this.tBoxSearchTerms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxSearchTerms.Location = new System.Drawing.Point(113, 3);
            this.tBoxSearchTerms.Name = "tBoxSearchTerms";
            this.tBoxSearchTerms.Size = new System.Drawing.Size(327, 20);
            this.tBoxSearchTerms.TabIndex = 1;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBasicLayout.SetColumnSpan(this.tabControlMain, 3);
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Controls.Add(this.tabPage4);
            this.tabControlMain.Location = new System.Drawing.Point(3, 33);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(497, 336);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowserWikipedia);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(489, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowserWikipedia
            // 
            this.webBrowserWikipedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserWikipedia.Location = new System.Drawing.Point(3, 3);
            this.webBrowserWikipedia.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserWikipedia.Name = "webBrowserWikipedia";
            this.webBrowserWikipedia.Size = new System.Drawing.Size(483, 304);
            this.webBrowserWikipedia.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowserGoogle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(489, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowserGoogle
            // 
            this.webBrowserGoogle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserGoogle.Location = new System.Drawing.Point(3, 3);
            this.webBrowserGoogle.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserGoogle.Name = "webBrowserGoogle";
            this.webBrowserGoogle.Size = new System.Drawing.Size(469, 215);
            this.webBrowserGoogle.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.webBrowserImages);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(489, 310);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // webBrowserImages
            // 
            this.webBrowserImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowserImages.Location = new System.Drawing.Point(6, 0);
            this.webBrowserImages.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserImages.Name = "webBrowserImages";
            this.webBrowserImages.Size = new System.Drawing.Size(469, 218);
            this.webBrowserImages.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.webBrowserYouTube);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(489, 310);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // webBrowserYouTube
            // 
            this.webBrowserYouTube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserYouTube.Location = new System.Drawing.Point(3, 3);
            this.webBrowserYouTube.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserYouTube.Name = "webBrowserYouTube";
            this.webBrowserYouTube.Size = new System.Drawing.Size(483, 304);
            this.webBrowserYouTube.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(446, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(54, 24);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 400);
            this.Controls.Add(this.tlpBasicLayout);
            this.MinimumSize = new System.Drawing.Size(516, 349);
            this.Name = "mainWindow";
            this.Text = "CLUEit";
            this.tlpBasicLayout.ResumeLayout(false);
            this.tlpBasicLayout.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBasicLayout;
        private System.Windows.Forms.Label labelCLUEit;
        private System.Windows.Forms.TextBox tBoxSearchTerms;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.WebBrowser webBrowserWikipedia;
        private System.Windows.Forms.WebBrowser webBrowserGoogle;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser webBrowserImages;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.WebBrowser webBrowserYouTube;
    }
}

