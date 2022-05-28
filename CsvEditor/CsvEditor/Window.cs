using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CsvEditor
{
    public partial class Window : Form
    {
        private char _separator;
        private string _fileName;

        public Window()
        {
            InitializeComponent();
        }

        private void LoadFile()
        {
            if (_fileName is not null)
            {
                List<string[]> rows = File.ReadAllLines(_fileName)
                                          .Select(fileName => fileName.Split(_separator)).ToList();

                DataTable dataTable = new();
                rows.OrderBy(row => row.Length).Last().ToList().ForEach(_ => dataTable.Columns.Add());
                rows.ToList().ForEach(row => dataTable.Rows.Add(row));
                grdData.DataSource = dataTable;
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                _fileName = fileDialog.FileName;
                txtFile.Text = fileDialog.SafeFileName;
                LoadFile();
            }
        }

        private void txtSeparator_TextChanged(object sender, EventArgs e)
        {
            TextBox target = (TextBox)sender;
            _separator = target.Text.Length > 0 ? target.Text[0] : '\0';
            LoadFile();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save the file?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataTable dataTable = (DataTable)grdData.DataSource;

                var data = dataTable.AsEnumerable().Select(row => String.Join(_separator, row.ItemArray));
                string text = String.Join(Environment.NewLine, data);

                File.WriteAllText(_fileName, text);
                LoadFile();
            }
        }
    }
}
