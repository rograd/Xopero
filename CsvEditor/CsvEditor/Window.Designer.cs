
namespace CsvEditor
{
    partial class Window
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
            this.txtSeparator = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnFile = new System.Windows.Forms.Button();
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.tblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSeparator
            // 
            this.txtSeparator.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSeparator.Location = new System.Drawing.Point(446, 10);
            this.txtSeparator.MaxLength = 1;
            this.txtSeparator.Name = "txtSeparator";
            this.txtSeparator.PlaceholderText = "Delimiter";
            this.txtSeparator.Size = new System.Drawing.Size(100, 23);
            this.txtSeparator.TabIndex = 1;
            this.txtSeparator.TextChanged += new System.EventHandler(this.txtSeparator_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Location = new System.Drawing.Point(552, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(41, 25);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            this.fileDialog.Filter = "CSV|*.csv";
            // 
            // btnFile
            // 
            this.btnFile.AutoSize = true;
            this.btnFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFile.Location = new System.Drawing.Point(9, 9);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(57, 25);
            this.btnFile.TabIndex = 3;
            this.btnFile.Text = "Choose";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 4;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayout.Controls.Add(this.btnFile, 0, 0);
            this.tblLayout.Controls.Add(this.grdData, 0, 1);
            this.tblLayout.Controls.Add(this.txtFile, 1, 0);
            this.tblLayout.Controls.Add(this.btnSave, 3, 0);
            this.tblLayout.Controls.Add(this.txtSeparator, 2, 0);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(0, 0);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.Padding = new System.Windows.Forms.Padding(6);
            this.tblLayout.RowCount = 2;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.Size = new System.Drawing.Size(602, 408);
            this.tblLayout.TabIndex = 4;
            // 
            // grdData
            // 
            this.grdData.AllowUserToResizeRows = false;
            this.grdData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.ColumnHeadersVisible = false;
            this.tblLayout.SetColumnSpan(this.grdData, 4);
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.Location = new System.Drawing.Point(9, 40);
            this.grdData.MultiSelect = false;
            this.grdData.Name = "grdData";
            this.grdData.RowTemplate.Height = 25;
            this.grdData.Size = new System.Drawing.Size(584, 359);
            this.grdData.TabIndex = 0;
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.Enabled = false;
            this.txtFile.Location = new System.Drawing.Point(72, 10);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(234, 23);
            this.txtFile.TabIndex = 4;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 408);
            this.Controls.Add(this.tblLayout);
            this.Name = "Window";
            this.Text = "CSV Editor";
            this.Click += new System.EventHandler(this.btnFile_Click);
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSeparator;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.TextBox txtFile;
    }
}

