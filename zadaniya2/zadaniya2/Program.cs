using System;

namespace zadaniya2
{
	class Program
	{
		class Book
		{
			private string author;
			private string title;
			private string publisher;
			private int pages;
			private int year;
			private static double price = 9;

			public Book(string author, string title, string publisher, int pages, int year)
			{
				Author = author;
				Title = title;
				Publisher = publisher;
				Pages = pages;
				Year = year;
			}

			public static void setprice(double price)
			{
				Book.price = price;
			}
			public void Show()
			{
				Console.WriteLine("\n книга: \n автор: {0}\n название: {1}\n год издания: {2}\n {3} стр. ", author, title, year, pages, Book.price);
			}
			public double pricebook(int s)
			{
				double cust = s * price;
				return cust;
			}
			public string Author
			{
				get
				{
					return author;
				}
				set
				{
					author = value;
				}
			}
			public string Title
			{
				get
				{
					return title;
				}
				set
				{
					title = value;
				}
			}
			public string Publisher
			{
				get
				{
					return publisher;
				}
				set
				{
					publisher = value;
				}
			}
			public int Pages
			{
				get
				{
					return pages;
				}
				set
				{
					pages = value;
				}
			}
			public int Year
			{
				get
				{
					return year;
				}
				set
				{
					year = value;
				}
			}
		}
		static void Main()
		{
			Book b1 = new Book("Пушкин.А.С", "Капитанская дочка", "Вильямс", 123, 2012);

			b1.Show();
			Book b2 = new Book("Толстой Л.Н", "Война и Мир", "Наука и жизнь", 1234, 2013);
			b2.Show();

			Console.ReadKey();
		}
	}
}
