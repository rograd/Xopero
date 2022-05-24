using Articles.Model;
using System.Collections.Generic;
using System.Data.SQLite;
using Dapper;

namespace Articles
{
    public class Database
    {
        private SQLiteConnection _cnn;

        public Database(SQLiteConnection cnn)
        {
            DefaultTypeMap.MatchNamesWithUnderscores = true;
            _cnn = cnn;
        }

        // CREATE
        public void CreateArticle(Article article)
        {
            string sql = @"INSERT INTO article (title, content, category_id)
                       VALUES (@Title, @Content, @CategoryId)";

            var parameters = new DynamicParameters(article);
            parameters.Add("@CategoryId", article.Category.Id);

            _cnn.Execute(sql, parameters);
        }

        // READ
        public List<Article> ReadArticles()
        {
            string sql = @"SELECT *
                        FROM article
                            LEFT JOIN category
                            ON article.category_id = category.id";

            List<Article> articles = _cnn.Query<Article, Category, Article>(sql, (article, category) =>
            {
                article.Category = category;
                return article;
            }).AsList();

            return articles;
        }

        public List<Category> ReadCategories()
        {
            string sql = "SELECT * FROM category";
            List<Category> categories = _cnn.Query<Category>(sql).AsList();

            return categories;
        }

        // UPDATE
        public void UpdateArticle(Article article)
        {
            string sql = @"UPDATE article
                       SET title = @Title,
                           content = @Content,
                           category_id = @CategoryId,
                           date_modified = @DateModified
                       WHERE id = @Id";

            var parameters = new DynamicParameters(article);
            parameters.Add("@CategoryId", article.Category.Id);

            _cnn.Execute(sql, parameters);
        }

        // DELETE
        public void DeleteArticle(Article article)
        {
            _cnn.Execute("DELETE FROM article WHERE id = @Id", article);
        }
    }
}