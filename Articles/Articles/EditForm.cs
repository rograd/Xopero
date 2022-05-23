using Articles.Model;

namespace Articles;

public partial class EditForm : Form
{
    private Database _database;
    private Category NoCategoryPlaceholder = new Category() { Name = "< No category >" };

    public EditForm(Database database)
    {
        InitializeComponent();
        _database = database;
    }

    public EditForm(Database database, Article article) : this(database)
    {
        Text = "Article - " + article.Title;

        txtId.Text = article.Id.ToString();
        txtTitle.Text = article.Title;
        txtContent.Text = article.Content;
    }

    private void EditForm_Load(object sender, EventArgs e)
    {
        List<Category> categories = _database.ReadCategories();
        categories.Insert(0, NoCategoryPlaceholder);
        cboCategory.DataSource = categories;
    }

    public Category GetSelectedCategory() => (Category)cboCategory.SelectedItem;
}