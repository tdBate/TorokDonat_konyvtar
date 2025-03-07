using System.Linq.Expressions;

namespace TorokDonat_konyvtar
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Book b1 = new Book("Harry Potter", "JK Rowling", 100, 2000);
			Console.WriteLine(b1.Title);
			b1.EditBookData();
            Console.WriteLine(b1.Title);

			Book b2 = new Book("Pál utcai fiúk","nem tudom",102,1950);
			Book b3 = new Book("Gyűrűk ura", "nem tudom", 202, 1951);

			Book[] books = new Book[] { b1, b2, b3 };

			Console.WriteLine( (b1.GetBookByTitle(books,"Pál utcai fiúk")).Title);

		}
	}
}
