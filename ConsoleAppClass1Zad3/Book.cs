/*Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется:
Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать
одно строковое поле и метод void Show().
Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и
содержание.*/

namespace ConsoleAppClass1Zad3
{
    /// <summary>
    /// Класс книга
    /// </summary>
    public class Book
    {
        
        public Title title;
        public Author author;
        public Content content;
        /// <summary>
        /// Конструктор книги
        /// </summary>
        /// <param name="title">Название</param>
        /// <param name="author">Автор</param>
        /// <param name="content">Описание</param>
        public Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
        }
        /// <summary>
        /// Конструктор для пустых полей книги
        /// </summary>
        public Book()
        {
            this.title = new Title();
            this.author = new Author();
            this.content = new Content();
        }
        /// <summary>
        /// Метод вывода информации о книге
        /// </summary>
        public void Info()
        {
            title.Show();
            author.Show();
            content.Show();
        }


    }

}
