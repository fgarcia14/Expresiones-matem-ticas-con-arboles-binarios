using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expresion_Binaria
{
	class Arbol
	{
		Caracter inicio, ultimo, temp;
		Caracter raiz;

		public Arbol() {
			inicio = null;
			ultimo = null;
		}

		public void crearListas(Caracter nuevo) {
			if (inicio==null)
			{
				inicio = nuevo;
				ultimo = nuevo;
			}
			else
			{
				temp = inicio;
				while (temp.siguiente!=null)
				{
					temp = temp.siguiente;	
				}
				temp.siguiente = nuevo;
				nuevo.anterior = temp;
				ultimo = nuevo;
			}
		}

		public void construirArbol()
		{
			String caracter;
			temp = inicio;
			Caracter anterior = null, siguiente = null;

			while (temp!=null)
			{
				siguiente = temp.siguiente;
				caracter = temp.ToString();

				if (caracter=="/" || caracter=="*")
				{
					raiz = temp;
					temp.izq = temp.anterior;
					temp.der = temp.siguiente;
					convertir(temp, anterior, siguiente);
				}
				anterior = temp;
				temp = temp.siguiente;
			}

			temp = inicio;
			anterior = null;
			siguiente = null;

			while (temp!=null)
			{
				siguiente = temp.siguiente;
				caracter = temp.ToString();

				if (caracter=="+" || caracter=="-")
				{
					raiz = temp;
					temp.izq = temp.anterior;
					temp.der = temp.siguiente;
					convertir(temp, anterior, siguiente);
				}
				anterior = temp;
				temp = temp.siguiente;
			}
			inicio = null;
		}

		private void convertir(Caracter n, Caracter anterior, Caracter siguiente)
		{
			if (n.anterior == inicio)
			{
				inicio = inicio.siguiente;
				inicio.anterior = null;
			}
			else
			{
				n.anterior = anterior.anterior;
				anterior.anterior.siguiente = n;
			}

			if (n.siguiente == ultimo)
			{
				ultimo.anterior.siguiente = null;
				ultimo = ultimo.anterior;
			}
			else
			{
				n.siguiente = siguiente.siguiente;
				siguiente.siguiente.anterior = n;
			}
		}

		public String preOrder()
		{
			if (raiz == null)
			{
				return "";
			}
			else
			{
				return preOrder(raiz);
			}
		}

		private String preOrder(Caracter c)
		{
			string text = "";
			text += c.ToString();
			if (c.izq != null)
			{
				text += preOrder(c.izq);
			}
			if (c.der != null)
			{
				text += preOrder(c.der);
			}
			return text;
		}

		public String posOrder()
		{
			if (raiz == null)
			{
				return "";
			}
			else
			{
				return posOrder(raiz);
			}
		}

		private String posOrder(Caracter c)
		{
			string text = "";
			
			if (c.izq != null)
			{
				text += posOrder(c.izq);
			}
			if (c.der != null)
			{
				text += posOrder(c.der);
			}
			text += c.ToString();
			return text;
		}

		public String evaluarPila() {
			String cadena = preOrder();
			char operador;
			Stack<String> pila = new Stack<String>();
			for (int i = cadena.Length-1; i >= 0; i--)
			{
				if (Char.IsNumber(cadena[i]))
				{
					pila.Push(cadena[i].ToString());
				}
				else
				{
					operador = cadena[i];
					switch (operador)
					{
						case '+': pila.Push(Convert.ToString(Convert.ToInt16(pila.Pop()) + Convert.ToInt16(pila.Pop()))); break;
						case '-': pila.Push(Convert.ToString(Convert.ToInt16(pila.Pop()) - Convert.ToInt16(pila.Pop()))); break;
						case '*': pila.Push(Convert.ToString(Convert.ToInt16(pila.Pop()) * Convert.ToInt16(pila.Pop()))); break;
						case '/': pila.Push(Convert.ToString(Convert.ToInt16(pila.Pop()) / Convert.ToInt16(pila.Pop()))); break;
					}
				}
			}
			return cadena + " = " + pila.Pop();
		}

		public String evaluarCola() {
			String cadena = posOrder();
			char operador;
			
			Stack<String> cola = new Stack<string>();
			for (int i = 0; i < cadena.Length; i++)
			{
				if (Char.IsNumber(cadena[i])) 
				{
					cola.Push(cadena[i].ToString());
				}
				else
				{
					operador = cadena[i];
					int n1, n2;
					switch (operador)
					{
						case '+':
							cola.Push((Convert.ToInt16(cola.Pop()) + Convert.ToInt16(cola.Pop())).ToString());
							break;

						case '-':
							n1 = Convert.ToInt16(cola.Pop());
							n2= Convert.ToInt16(cola.Pop());
							cola.Push((n2-n1).ToString());
							break;

						case '*':
							cola.Push((Convert.ToInt16(cola.Pop()) * Convert.ToInt16(cola.Pop())).ToString());
							break;

						case '/':
							n1 = Convert.ToInt16(cola.Pop());
							n2 = Convert.ToInt16(cola.Pop());
							cola.Push((n2 / n1).ToString());
							break;
					}
				}
			}

			return cadena + " = " + cola.Pop(); ;
		}
	}
}
