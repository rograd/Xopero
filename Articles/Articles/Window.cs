using Articles.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Articles
{
    public partial class Window : Form
    {
        private Database _database;
        private List<Article> _articles;
        private Category _showAllCategoryPlaceholder = new Category() { Name = "< Show all >" };

        public Window()
        {
            InitializeComponent();
        }

        private Article GetSelectedArticle() => (Article)grdData.CurrentRow.DataBoundItem;

        private void CreateFilter()
        {
            List<Category> categories = _articles
                    .Select(article => article.Category)
                    .Where(category => category is not null)
                    .GroupBy(category => category.Id)
                    .Select(group => group.First())
                    .ToList();
            categories.Insert(0, _showAllCategoryPlaceholder);
            cboCategory.DataSource = categories;
        }

        private void LoadArticles()
        {
            _articles = _database.ReadArticles();
            LoadArticles(_articles);
            CreateFilter();
        }

        private void LoadArticles(List<Article> articles)
        {
            grdData.DataSource = null;
            grdData.Rows.Clear();
            grdData.DataSource = articles;
        }

        private void Window_Load(object sender, EventArgs e)
        {
            string cs = "Data Source=ProgramData.db";
            SQLiteConnection cnn = new(cs);
            _database = new Database(cnn);
            LoadArticles();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using EditForm form = new(_database);
            if (form.ShowDialog() != DialogResult.OK) return;

            Article article = new()
            {
                Title = form.txtTitle.Text,
                Content = form.txtContent.Text,
                Category = form.GetSelectedCategory()
            };

            _database.CreateArticle(article);
            LoadArticles();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Article selected = GetSelectedArticle();

            string message = $"Do you want to delete \"{selected.Title}\"?";
            DialogResult result = MessageBox.Show(message, "Confirm deletion", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            _database.DeleteArticle(selected);
            LoadArticles();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category = (Category)((ComboBox)sender).SelectedItem;
            if (category.Equals(_showAllCategoryPlaceholder))
            {
                LoadArticles();
            }
            else
            {
                List<Article> filtered = _articles.FindAll(article => article.Category?.Id == category.Id);
                LoadArticles(filtered);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Article selected = GetSelectedArticle();
            using EditForm form = new(_database, selected);
            if (form.ShowDialog() != DialogResult.OK) return;

            selected.Title = form.txtTitle.Text;
            selected.Content = form.txtContent.Text;
            selected.Category = form.GetSelectedCategory();
            selected.DateModified = DateTime.Now;

            _database.UpdateArticle(selected);
            LoadArticles();
        }
    }
}