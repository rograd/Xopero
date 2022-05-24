using System.Windows.Forms;

namespace Articles
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.articleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdData = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.tblLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(6, 9);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 25);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.AutoSize = true;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Location = new System.Drawing.Point(644, 9);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnEdit.Size = new System.Drawing.Size(43, 25);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // articleBindingSource1
            // 
            this.articleBindingSource1.DataSource = typeof(Articles.Model.Article);
            // 
            // articleBindingSource
            // 
            this.articleBindingSource.DataSource = typeof(Articles.Model.Article);
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.AllowUserToDeleteRows = false;
            this.grdData.AllowUserToResizeRows = false;
            this.grdData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblLayout.SetColumnSpan(this.grdData, 4);
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.Location = new System.Drawing.Point(9, 40);
            this.grdData.MultiSelect = false;
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.RowHeadersVisible = false;
            this.grdData.RowTemplate.Height = 25;
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.ShowEditingIcon = false;
            this.grdData.Size = new System.Drawing.Size(740, 382);
            this.grdData.TabIndex = 3;
            this.grdData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(693, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnDelete.Size = new System.Drawing.Size(56, 25);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(517, 10);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(121, 23);
            this.cboCategory.TabIndex = 4;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 4;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayout.Controls.Add(this.btnAdd, 0, 0);
            this.tblLayout.Controls.Add(this.btnDelete, 3, 0);
            this.tblLayout.Controls.Add(this.cboCategory, 1, 0);
            this.tblLayout.Controls.Add(this.btnEdit, 2, 0);
            this.tblLayout.Controls.Add(this.grdData, 0, 1);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(0, 0);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.Padding = new System.Windows.Forms.Padding(6);
            this.tblLayout.RowCount = 2;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.Size = new System.Drawing.Size(758, 431);
            this.tblLayout.TabIndex = 5;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 431);
            this.Controls.Add(this.tblLayout);
            this.Name = "Window";
            this.Text = "Articles";
            this.Load += new System.EventHandler(this.Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAdd;
        private Button btnEdit;
        private BindingSource articleBindingSource1;
        private BindingSource articleBindingSource;
        private DataGridView grdData;
        private Button btnDelete;
        private ComboBox cboCategory;
        private TableLayoutPanel tblLayout;
    }
}