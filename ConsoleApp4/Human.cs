using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Human
    {
        public string Name { get; set; }
		private int age;

		public int Age
		{
			get { return age; }
			set {
				if (value > 0 && value < 110)
					age = value;
				else {
					Console.WriteLine("Возраст должен быть больше 0 и меньше 110");
					age = 0;
				}
			}
		}


		public Human(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public string SayHello()
		{
			return "Hello";
		}

		public virtual string Info()
		{
			return $"Меня зовут {Name} и мне {Age} лет";
		}

	}
}
