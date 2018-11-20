using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w08tl
{
	class w08t7
	{
		public static void Main4()
		{

		}
	}

	class PhotoAlbum
	{
		private int numberOfPages;
		
		public int GetNumberOfPages()
		{
			return numberOfPages;
		}

		public PhotoAlbum(int numberOfPages)
		{
			Console.WriteLine("Number of Pages: ");
			numberOfPages = Convert.ToInt32(Console.ReadLine());
		}

		static PhotoAlbum()
		{
			
		}


	}			
}
