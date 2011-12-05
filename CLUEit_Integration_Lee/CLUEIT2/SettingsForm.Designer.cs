namespace CLUEIT2
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tlpSettings = new System.Windows.Forms.TableLayoutPanel();
            this.labelDefaultNote = new System.Windows.Forms.Label();
            this.dgvChooseSettings = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.webService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.options = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChooseSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpSettings
            // 
            this.tlpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSettings.ColumnCount = 2;
            this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpSettings.Controls.Add(this.labelDefaultNote, 0, 1);
            this.tlpSettings.Controls.Add(this.dgvChooseSettings, 0, 0);
            this.tlpSettings.Controls.Add(this.btnOK, 0, 2);
            this.tlpSettings.Controls.Add(this.btnCancel, 1, 2);
            this.tlpSettings.Location = new System.Drawing.Point(-1, 0);
            this.tlpSettings.Name = "tlpSettings";
            this.tlpSettings.RowCount = 3;
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpSettings.Size = new System.Drawing.Size(224, 294);
            this.tlpSettings.TabIndex = 0;
            // 
            // labelDefaultNote
            // 
            this.labelDefaultNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDefaultNote.AutoSize = true;
            this.tlpSettings.SetColumnSpan(this.labelDefaultNote, 2);
            this.labelDefaultNote.Location = new System.Drawing.Point(3, 221);
            this.labelDefaultNote.Name = "labelDefaultNote";
            this.labelDefaultNote.Size = new System.Drawing.Size(218, 48);
            this.labelDefaultNote.TabIndex = 0;
            this.labelDefaultNote.Text = "Note: Selecting \"Default\" means that the corresponding web service tab will only " +
                "display if CLUEit\'s algorithms determine it is relevant for the text being searc" +
                "hed.";
            // 
            // dgvChooseSettings
            // 
            this.dgvChooseSettings.AllowDrop = true;
            this.dgvChooseSettings.AllowUserToAddRows = false;
            this.dgvChooseSettings.AllowUserToDeleteRows = false;
            this.dgvChooseSettings.AllowUserToResizeColumns = false;
            this.dgvChooseSettings.AllowUserToResizeRows = false;
            this.dgvChooseSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChooseSettings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChooseSettings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvChooseSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChooseSettings.ColumnHeadersVisible = false;
            this.dgvChooseSettings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.webService,
            this.options,
            this.ColumnSpace});
            this.tlpSettings.SetColumnSpan(this.dgvChooseSettings, 2);
            this.dgvChooseSettings.Location = new System.Drawing.Point(3, 3);
            this.dgvChooseSettings.Name = "dgvChooseSettings";
            this.dgvChooseSettings.RowHeadersVisible = false;
            this.dgvChooseSettings.Size = new System.Drawing.Size(218, 215);
            this.dgvChooseSettings.TabIndex = 1;
            this.dgvChooseSettings.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChooseSettings_CellValueChanged);
            this.dgvChooseSettings.CurrentCellChanged += new System.EventHandler(this.dgvChooseSettings_CurrentCellChanged);
            this.dgvChooseSettings.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvChooseSettings_CurrentCellDirtyStateChanged);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(50, 272);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 19);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(146, 272);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 19);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // webService
            // 
            this.webService.FillWeight = 112F;
            this.webService.HeaderText = "Web Service";
            this.webService.Name = "webService";
            this.webService.ReadOnly = true;
            this.webService.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // options
            // 
            this.options.FillWeight = 120F;
            this.options.HeaderText = "Options";
            this.options.Name = "options";
            this.options.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.options.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnSpace
            // 
            this.ColumnSpace.FillWeight = 10F;
            this.ColumnSpace.HeaderText = "Column Space";
            this.ColumnSpace.Name = "ColumnSpace";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(234, 302);
            this.Controls.Add(this.tlpSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(240, 330);
            this.MinimumSize = new System.Drawing.Size(240, 330);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.tlpSettings.ResumeLayout(false);
            this.tlpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChooseSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSettings;
        private System.Windows.Forms.Label labelDefaultNote;
        private System.Windows.Forms.DataGridView dgvChooseSettings;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn webService;
        private System.Windows.Forms.DataGridViewComboBoxColumn options;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSpace;

    }
}