using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using System.Text.Json;
using System.Security.Cryptography.X509Certificates;

namespace _8._6._2
{
	class TDictionary
	{
		public Dictionary<int, string> NewPerson() 
		{
			
			Dictionary<int, string> phoneBook = new Dictionary <int, string>();
            Console.WriteLine("Введите Имя");
            string name = Console.ReadLine();
			

            Console.WriteLine("Введите номер телефона, для окончания ввода номеров телефона введите пустую строку");
			while (true)
			{
				string phoneNumber = Console.ReadLine();
				if (string.IsNullOrEmpty(phoneNumber))
				{
					break;
				}
				int number = Int32.Parse(phoneNumber);
				phoneBook[number] = name;
			}
			return phoneBook;
			

        }
	}
}
