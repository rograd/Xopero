namespace Articles;

public partial class EditForm : Form
{
    private void InitializeComponent()
    {
            this.tblInternalLayout = new System.Windows.Forms.TableLayoutPanel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tblInternalLayout.SuspendLayout();
            this.tblLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblInternalLayout
            // 
            this.tblInternalLayout.ColumnCount = 2;
            this.tblLayout.SetColumnSpan(this.tblInternalLayout, 3);
            this.tblInternalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblInternalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInternalLayout.Controls.Add(this.txtTitle, 1, 1);
            this.tblInternalLayout.Controls.Add(this.lblTitle, 0, 1);
            this.tblInternalLayout.Controls.Add(this.lblContent, 0, 2);
            this.tblInternalLayout.Controls.Add(this.cboCategory, 1, 3);
            this.tblInternalLayout.Controls.Add(this.lblId, 0, 0);
            this.tblInternalLayout.Controls.Add(this.txtId, 1, 0);
            this.tblInternalLayout.Controls.Add(this.txtContent, 1, 2);
            this.tblInternalLayout.Controls.Add(this.lblCategory, 0, 3);
            this.tblInternalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInternalLayout.Location = new System.Drawing.Point(9, 9);
            this.tblInternalLayout.Name = "tblInternalLayout";
            this.tblInternalLayout.RowCount = 4;
            this.tblInternalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInternalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInternalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInternalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInternalLayout.Size = new System.Drawing.Size(456, 272);
            this.tblInternalLayout.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(64, 32);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(389, 23);
            this.txtTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(3, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(55, 15);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblContent
            // 
            this.lblContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(3, 143);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(55, 15);
            this.lblContent.TabIndex = 3;
            this.lblContent.Text = "Content";
            this.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCategory
            // 
            this.cboCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(64, 246);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(121, 23);
            this.cboCategory.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 7);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(55, 15);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.Location = new System.Drawing.Point(64, 3);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(389, 23);
            this.txtId.TabIndex = 5;
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(64, 61);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(389, 179);
            this.txtContent.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(3, 250);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 15);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(365, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(41, 25);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(412, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(53, 25);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 3;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayout.Controls.Add(this.btnCancel, 2, 1);
            this.tblLayout.Controls.Add(this.tblInternalLayout, 0, 0);
            this.tblLayout.Controls.Add(this.btnSave, 1, 1);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(0, 0);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.Padding = new System.Windows.Forms.Padding(6);
            this.tblLayout.RowCount = 2;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayout.Size = new System.Drawing.Size(474, 321);
            this.tblLayout.TabIndex = 3;
            // 
            // EditForm
            // 
            this.ClientSize = new System.Drawing.Size(474, 321);
            this.Controls.Add(this.tblLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditForm";
            this.Text = "New article";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.tblInternalLayout.ResumeLayout(false);
            this.tblInternalLayout.PerformLayout();
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            this.ResumeLayout(false);

    }

    private TableLayoutPanel tblInternalLayout;
    public TextBox txtTitle;
    public TextBox txtContent;
    private Label lblTitle;
    private Label lblContent;
    private Button btnSave;
    private Button btnCancel;
    private TableLayoutPanel tblLayout;
    private Label lblId;
    public TextBox txtId;
    private ComboBox cboCategory;
    private Label lblCategory;
}