using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorokDonat_konyvtar
{
	internal class Book
	{
		private string title;
		private string author;
		private int pageCount;
		private int releaseYear;

		public Book(string title, string author, int pageCount, int releaseYear)
		{
			this.title = title;
			this.author = author;
			this.pageCount = pageCount;
			this.releaseYear = releaseYear;
		}

		public string Title { get => title; }
		public string Author { get => author; }
		public int PageCount { get => pageCount; }
		public int ReleaseYear { get => releaseYear; }

		public Book GetBookByTitle(Book[] books)
		{
			foreach (Book book in books)
			{
				if (book.Title == this.title)
				{
					return book;
				}
			}
			return null;
		}

		public void EditBookData()
		{
            Console.Write("Cím: ");
			this.title = Console.ReadLine();

			Console.Write("Szerző: ");
			this.author = Console.ReadLine();

			Console.Write("Hossz lapokban: ");
			this.pageCount = int.Parse(Console.ReadLine());

			Console.Write("Kiadási év: ");
			this.releaseYear = int.Parse(Console.ReadLine());
		}


	}
}
