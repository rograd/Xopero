
namespace IssueObserver
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
            this.btnWatch = new System.Windows.Forms.Button();
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblConfig = new System.Windows.Forms.Label();
            this.btnConfig = new System.Windows.Forms.Button();
            this.txtConfig = new System.Windows.Forms.Label();
            this.dlgConfig = new System.Windows.Forms.OpenFileDialog();
            this.tblLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWatch
            // 
            this.btnWatch.AutoSize = true;
            this.btnWatch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWatch.Enabled = false;
            this.btnWatch.Location = new System.Drawing.Point(216, 6);
            this.btnWatch.Name = "btnWatch";
            this.tblLayout.SetRowSpan(this.btnWatch, 2);
            this.btnWatch.Size = new System.Drawing.Size(51, 50);
            this.btnWatch.TabIndex = 0;
            this.btnWatch.Text = "Watch";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 3;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayout.Controls.Add(this.lblConfig, 0, 1);
            this.tblLayout.Controls.Add(this.btnConfig, 0, 0);
            this.tblLayout.Controls.Add(this.btnWatch, 2, 0);
            this.tblLayout.Controls.Add(this.txtConfig, 1, 1);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(0, 0);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.Padding = new System.Windows.Forms.Padding(3);
            this.tblLayout.RowCount = 2;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayout.Size = new System.Drawing.Size(273, 62);
            this.tblLayout.TabIndex = 2;
            // 
            // lblConfig
            // 
            this.lblConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfig.AutoSize = true;
            this.lblConfig.Location = new System.Drawing.Point(6, 44);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(50, 15);
            this.lblConfig.TabIndex = 2;
            this.lblConfig.Text = "Current:";
            // 
            // btnConfig
            // 
            this.btnConfig.AutoSize = true;
            this.btnConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblLayout.SetColumnSpan(this.btnConfig, 2);
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfig.Location = new System.Drawing.Point(6, 6);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(204, 35);
            this.btnConfig.TabIndex = 1;
            this.btnConfig.Text = "Load config file";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // txtConfig
            // 
            this.txtConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfig.AutoEllipsis = true;
            this.txtConfig.Location = new System.Drawing.Point(62, 44);
            this.txtConfig.Name = "txtConfig";
            this.txtConfig.Size = new System.Drawing.Size(148, 15);
            this.txtConfig.TabIndex = 3;
            this.txtConfig.Text = "None";
            // 
            // dlgConfig
            // 
            this.dlgConfig.Filter = "Ini files|*.ini";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 62);
            this.Controls.Add(this.tblLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Window";
            this.Text = "IssueObserver";
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.Label txtConfig;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.OpenFileDialog dlgConfig;
    }
}

