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

		public Book GetBookByTitle(Book[] books, string title)
		{
			foreach (Book book in books)
			{
				if (book.Title == title)
				{
					return book;
				}
			}
			return null;
		}

		public void EditBookData()
		{
			Console.Write("Cím: ");
			string inputTitle = Console.ReadLine();
			if (!string.IsNullOrEmpty(inputTitle))
			{
				this.title = inputTitle;
			}

			Console.Write("Szerző: ");
			string inputAuthor = Console.ReadLine();
			if (!string.IsNullOrEmpty(inputAuthor))
			{
				this.author = inputAuthor;
			}

			Console.Write("Hossz lapokban: ");
			string inputPageCount = Console.ReadLine();
			if (!string.IsNullOrEmpty(inputPageCount))
			{
				this.pageCount = int.Parse(inputPageCount);
			}

			Console.Write("Kiadási év: ");
			string inputReleaseYear = Console.ReadLine();
			if (!string.IsNullOrEmpty(inputReleaseYear))
			{
				this.releaseYear = int.Parse(inputReleaseYear);
			}
		}


	}
}
