/*
 * Creado por SharpDevelop.
 * Usuario: Luly
 * Fecha: 31/10/2013
 * Hora: 05:38 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Practica6
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{

					int aciertos = 0;
					string nombre = this.nom.Text;
					string codigo = this.cod.Text;
					if(this.df.Checked){
						aciertos++;
					}
					if (this.portugal.Checked){
						aciertos++;
					}
					if (this.reino_unido.Checked){
						aciertos++;
					}
					if (this.macedonia.Checked){
						aciertos++;
					}
					if (this.estados.Text == "31"){
						aciertos++;
					}
					string valorCalendario = calFecha.SelectionRange.Start.ToShortDateString();
					if (valorCalendario == "07/05/1945"){
						aciertos++;
					}
					MessageBox.Show("Nombre:" +  nombre + "\nCódigo" + codigo + "\n" + aciertos+ " Aciertos");

		}
	}
}
