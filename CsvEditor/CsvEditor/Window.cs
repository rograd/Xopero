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
        private char[] _commonDelimiters = { ',', ';', '\t', ' ', '|' };
        private char _delimiter;
        private string _fileName;

        public Window()
        {
            InitializeComponent();
        }

        private char RecognizeDelimiter(string text)
        {
            Dictionary<char, int> occurrences =
                text.Where(character => _commonDelimiters.Contains(character))
                    .GroupBy(character => character)
                    .ToDictionary(c => c.Key, c => c.Count());

            int maxOccurred = occurrences.Values.Max();
            char delimiter =
                occurrences.Where(occurrence => occurrence.Value == maxOccurred)
                           .Select(o => o.Key)
                           .First();

            return delimiter;
        }

        private void LoadFile()
        {
            if (_fileName is null) return;


            string[] fileLines = File.ReadAllLines(_fileName);

            string fileText = String.Join(Environment.NewLine, fileLines);

            char delimiter = _delimiter == '\0' ? RecognizeDelimiter(fileText) : _delimiter;

            List<string[]> rows = fileLines.Select(line => line.Split(delimiter)).ToList();

            DataTable dataTable = new();
            rows.OrderBy(row => row.Length).Last().ToList().ForEach(_ => dataTable.Columns.Add());
            rows.ForEach(row => dataTable.Rows.Add(row));
            grdData.DataSource = dataTable;
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
            _delimiter = target.Text.Length > 0 ? target.Text[0] : '\0';
            LoadFile();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save the file?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataTable dataTable = (DataTable)grdData.DataSource;

                var data = dataTable.AsEnumerable().Select(row => String.Join(_delimiter, row.ItemArray));
                string text = String.Join(Environment.NewLine, data);

                File.WriteAllText(_fileName, text);
                LoadFile();
            }
        }
    }
}
