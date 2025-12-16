using System;
using System.Text;
using System.Linq;

public class Book
{
    private string author = string.Empty;
    private string title = string.Empty;
    private decimal price;

    public Book(string author, string title, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    public string Author
    {
        get => this.author;
        protected set
        {
            if (value != null && value.Split().Length > 1 && char.IsDigit(value.Split().LastOrDefault()?[0] ?? ' '))
            {
                throw new ArgumentException("Автор не дійсний!");
            }
            this.author = value;
        }
    }

    public string Title
    {
        get => this.title;
        protected set
        {
            if (value == null || value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            this.title = value;
        }
    }

    public virtual decimal Price
    {
        get => this.price;
        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Ціна не дійсна!");
            }
            this.price = value;
        }
    }

    public override string ToString()
    {
        StringBuilder resultBuilder = new StringBuilder();
        resultBuilder.AppendLine($"Type: {this.GetType().Name}").AppendLine($"Title: {this.Title}").AppendLine($"Author: {this.Author}").AppendLine($"Price: {this.Price:f2}");

        string result = resultBuilder.ToString().TrimEnd();
        return result;
    }
}