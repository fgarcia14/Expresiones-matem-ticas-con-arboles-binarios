namespace Expresion_Binaria
{
	partial class frmPrincipal
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbl = new System.Windows.Forms.Label();
			this.txtExpresion = new System.Windows.Forms.TextBox();
			this.btnCalcularPre = new System.Windows.Forms.Button();
			this.btnCalcularPost = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.txtResultado = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lbl
			// 
			this.lbl.AutoSize = true;
			this.lbl.Location = new System.Drawing.Point(12, 9);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(300, 24);
			this.lbl.TabIndex = 0;
			this.lbl.Text = "Escribe una expresion matematica";
			// 
			// txtExpresion
			// 
			this.txtExpresion.Location = new System.Drawing.Point(16, 36);
			this.txtExpresion.Name = "txtExpresion";
			this.txtExpresion.Size = new System.Drawing.Size(435, 29);
			this.txtExpresion.TabIndex = 1;
			this.txtExpresion.Text = "2+4*3-6/3*4*5";
			// 
			// btnCalcularPre
			// 
			this.btnCalcularPre.Location = new System.Drawing.Point(16, 72);
			this.btnCalcularPre.Name = "btnCalcularPre";
			this.btnCalcularPre.Size = new System.Drawing.Size(212, 30);
			this.btnCalcularPre.TabIndex = 2;
			this.btnCalcularPre.Text = "Calcular con preOrder";
			this.btnCalcularPre.UseVisualStyleBackColor = true;
			this.btnCalcularPre.Click += new System.EventHandler(this.btnCalcularPre_Click);
			// 
			// btnCalcularPost
			// 
			this.btnCalcularPost.Location = new System.Drawing.Point(239, 71);
			this.btnCalcularPost.Name = "btnCalcularPost";
			this.btnCalcularPost.Size = new System.Drawing.Size(212, 30);
			this.btnCalcularPost.TabIndex = 3;
			this.btnCalcularPost.Text = "Calcular con postOrder";
			this.btnCalcularPost.UseVisualStyleBackColor = true;
			this.btnCalcularPost.Click += new System.EventHandler(this.btnCalcularPost_Click);
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Location = new System.Drawing.Point(12, 171);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(99, 24);
			this.lblResultado.TabIndex = 4;
			this.lblResultado.Text = "Resultado:";
			// 
			// txtResultado
			// 
			this.txtResultado.Location = new System.Drawing.Point(117, 168);
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.Size = new System.Drawing.Size(334, 29);
			this.txtResultado.TabIndex = 5;
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(476, 259);
			this.Controls.Add(this.txtResultado);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnCalcularPost);
			this.Controls.Add(this.btnCalcularPre);
			this.Controls.Add(this.txtExpresion);
			this.Controls.Add(this.lbl);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "frmPrincipal";
			this.Text = "Arboles binarios con expresiones matematicas";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.TextBox txtExpresion;
		private System.Windows.Forms.Button btnCalcularPre;
		private System.Windows.Forms.Button btnCalcularPost;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.TextBox txtResultado;
	}
}

