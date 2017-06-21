using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expresion_Binaria
{
	class Caracter
	{
		private char _caracter;
		public Caracter siguiente, anterior;
		public Caracter izq, der;

		public char caracter { get { return _caracter; } }

		public Caracter(char caracter){
			_caracter = caracter;
		}

		public override string ToString()
		{
			return _caracter.ToString();
		}
	}
}
