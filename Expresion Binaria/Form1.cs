using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expresion_Binaria
{
	public partial class frmPrincipal : Form
	{
		Arbol arbol;

		public frmPrincipal()
		{
			arbol = new Arbol();
			InitializeComponent();
		}

		private void btnCalcularPre_Click(object sender, EventArgs e)
		{
			mandarDatos(txtExpresion.Text);
			txtResultado.Text = arbol.evaluarPila();
		}

		private void btnCalcularPost_Click(object sender, EventArgs e)
		{
			mandarDatos(txtExpresion.Text);
			txtResultado.Text = arbol.evaluarCola();
		}

		public void mandarDatos(String expresion)
		{
			for (int i = 0; i < expresion.Length; i++)
			{ 
				arbol.crearListas(new Caracter(expresion[i]));
			}
			arbol.construirArbol();
		}
	}
}
