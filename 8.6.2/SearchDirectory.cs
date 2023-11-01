using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._6._2
{
	class SearchDictionary
	{
		public void SDictionary(Dictionary<int, string> pBook)
		{
			Console.WriteLine("Введите номер телефона для поиска абонента");
			int sNumber = Int32.Parse(Console.ReadLine());
			if(pBook.TryGetValue(sNumber, out string person))
			{
				Console.WriteLine($"Владелец номера {sNumber}: {person}");
			}
			else
			{
                Console.WriteLine("Владелец номера не найден");
            }
			Console.ReadLine();
		}
	}
}
