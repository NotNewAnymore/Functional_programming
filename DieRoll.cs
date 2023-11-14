using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_programming
{
	public static class DieRoll
	{
		static Random rand = new Random();
		public static int Roll(int number)
		{
			
			return rand.Next(1, number + 1);
		}


		public static int FunctionalDieRoll(this int number)
		{
			return rand.Next(1, number + 1);
		}

		public static int Addtwo(this int num1, int num2) { return num1 + num2; }
		//Extension method
		//Static class
		//Static method
		//this
	}
}	//namespace
