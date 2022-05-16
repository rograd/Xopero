namespace Hashing;

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
            Hashing.MD5Strategy mD5Strategy1 = new Hashing.MD5Strategy();
            Hashing.SHA1Strategy shA1Strategy1 = new Hashing.SHA1Strategy();
            Hashing.SHA256Strategy shA256Strategy1 = new Hashing.SHA256Strategy();
            Hashing.BCryptStrategy bCryptStrategy1 = new Hashing.BCryptStrategy();
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblHash = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.optMD5 = new System.Windows.Forms.RadioButton();
            this.optSHA1 = new System.Windows.Forms.RadioButton();
            this.optSHA256 = new System.Windows.Forms.RadioButton();
            this.optBCrypt = new System.Windows.Forms.RadioButton();
            this.tblLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 5;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout.Controls.Add(this.lblHash, 0, 2);
            this.tblLayout.Controls.Add(this.lblPassword, 0, 1);
            this.tblLayout.Controls.Add(this.txtHash, 1, 2);
            this.tblLayout.Controls.Add(this.txtPassword, 1, 1);
            this.tblLayout.Controls.Add(this.optMD5, 1, 0);
            this.tblLayout.Controls.Add(this.optSHA1, 2, 0);
            this.tblLayout.Controls.Add(this.optSHA256, 3, 0);
            this.tblLayout.Controls.Add(this.optBCrypt, 4, 0);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(0, 0);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.Padding = new System.Windows.Forms.Padding(6);
            this.tblLayout.RowCount = 3;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblLayout.Size = new System.Drawing.Size(552, 108);
            this.tblLayout.TabIndex = 0;
            // 
            // lblHash
            // 
            this.lblHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHash.AutoSize = true;
            this.lblHash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHash.Location = new System.Drawing.Point(9, 78);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(73, 15);
            this.lblHash.TabIndex = 1;
            this.lblHash.Text = "HASH";
            this.lblHash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(9, 45);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 15);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "PASSWORD";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHash
            // 
            this.txtHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayout.SetColumnSpan(this.txtHash, 4);
            this.txtHash.Location = new System.Drawing.Point(88, 74);
            this.txtHash.Name = "txtHash";
            this.txtHash.ReadOnly = true;
            this.txtHash.Size = new System.Drawing.Size(455, 23);
            this.txtHash.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayout.SetColumnSpan(this.txtPassword, 4);
            this.txtPassword.Location = new System.Drawing.Point(88, 41);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(455, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.PasswordChangedHandler);
            // 
            // optMD5
            // 
            this.optMD5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optMD5.AutoSize = true;
            this.optMD5.Location = new System.Drawing.Point(117, 12);
            this.optMD5.Name = "optMD5";
            this.optMD5.Size = new System.Drawing.Size(50, 19);
            this.optMD5.TabIndex = 3;
            this.optMD5.TabStop = true;
            this.optMD5.Tag = mD5Strategy1;
            this.optMD5.Text = "MD5";
            this.optMD5.UseVisualStyleBackColor = true;
            this.optMD5.CheckedChanged += new System.EventHandler(this.RadioCheckedHandler);
            // 
            // optSHA1
            // 
            this.optSHA1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optSHA1.AutoSize = true;
            this.optSHA1.Location = new System.Drawing.Point(230, 12);
            this.optSHA1.Name = "optSHA1";
            this.optSHA1.Size = new System.Drawing.Size(54, 19);
            this.optSHA1.TabIndex = 4;
            this.optSHA1.TabStop = true;
            this.optSHA1.Tag = shA1Strategy1;
            this.optSHA1.Text = "SHA1";
            this.optSHA1.UseVisualStyleBackColor = true;
            this.optSHA1.CheckedChanged += new System.EventHandler(this.RadioCheckedHandler);
            // 
            // optSHA256
            // 
            this.optSHA256.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optSHA256.AutoSize = true;
            this.optSHA256.Location = new System.Drawing.Point(339, 12);
            this.optSHA256.Name = "optSHA256";
            this.optSHA256.Size = new System.Drawing.Size(66, 19);
            this.optSHA256.TabIndex = 5;
            this.optSHA256.TabStop = true;
            this.optSHA256.Tag = shA256Strategy1;
            this.optSHA256.Text = "SHA256";
            this.optSHA256.UseVisualStyleBackColor = true;
            this.optSHA256.CheckedChanged += new System.EventHandler(this.RadioCheckedHandler);
            // 
            // optBCrypt
            // 
            this.optBCrypt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optBCrypt.AutoSize = true;
            this.optBCrypt.Location = new System.Drawing.Point(457, 12);
            this.optBCrypt.Name = "optBCrypt";
            this.optBCrypt.Size = new System.Drawing.Size(61, 19);
            this.optBCrypt.TabIndex = 6;
            this.optBCrypt.TabStop = true;
            this.optBCrypt.Tag = bCryptStrategy1;
            this.optBCrypt.Text = "BCrypt";
            this.optBCrypt.UseVisualStyleBackColor = true;
            this.optBCrypt.CheckedChanged += new System.EventHandler(this.RadioCheckedHandler);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 108);
            this.Controls.Add(this.tblLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Window";
            this.Text = "Hashing";
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private TableLayoutPanel tblLayout;
    private Label lblHash;
    private Label lblPassword;
    private TextBox txtHash;
    private TextBox txtPassword;
    private RadioButton optMD5;
    private RadioButton optSHA1;
    private RadioButton optSHA256;
    private RadioButton optBCrypt;
}
