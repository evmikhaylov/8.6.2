using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._6._2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			TDictionary dictionary = new TDictionary();
			Dictionary<int, string> phoneBook = dictionary.NewPerson();

			SearchDictionary search = new SearchDictionary();
			search.SDictionary(phoneBook);
		}
	}
}
