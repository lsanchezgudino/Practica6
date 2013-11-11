/*
 * Creado por SharpDevelop.
 * Usuario: Luly
 * Fecha: 31/10/2013
 * Hora: 05:38 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Practica6
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cod = new System.Windows.Forms.TextBox();
			this.nom = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.df = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.portugal = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.reino_unido = new System.Windows.Forms.CheckBox();
			this.macedonia = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.estados = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.calFecha = new System.Windows.Forms.MonthCalendar();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.estados)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(5, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Código\r\n";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(145, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre\r\n\r\n";
			// 
			// cod
			// 
			this.cod.Location = new System.Drawing.Point(57, 18);
			this.cod.Name = "cod";
			this.cod.Size = new System.Drawing.Size(73, 20);
			this.cod.TabIndex = 2;
			// 
			// nom
			// 
			this.nom.Location = new System.Drawing.Point(216, 18);
			this.nom.Name = "nom";
			this.nom.Size = new System.Drawing.Size(304, 20);
			this.nom.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(21, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 21);
			this.label3.TabIndex = 4;
			this.label3.Text = "1.- Capital de México\r\n";
			// 
			// df
			// 
			this.df.Location = new System.Drawing.Point(21, 84);
			this.df.Name = "df";
			this.df.Size = new System.Drawing.Size(104, 24);
			this.df.TabIndex = 5;
			this.df.TabStop = true;
			this.df.Text = "D.F.";
			this.df.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(163, 84);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 6;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Guadalajara";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(314, 84);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(104, 24);
			this.radioButton3.TabIndex = 7;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Monterrey";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(21, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(136, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "2.- Paises de Europa";
			// 
			// portugal
			// 
			this.portugal.Location = new System.Drawing.Point(21, 149);
			this.portugal.Name = "portugal";
			this.portugal.Size = new System.Drawing.Size(104, 24);
			this.portugal.TabIndex = 9;
			this.portugal.Text = "Portugal";
			this.portugal.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(21, 169);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(104, 24);
			this.checkBox2.TabIndex = 10;
			this.checkBox2.Text = "Chile";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// reino_unido
			// 
			this.reino_unido.Location = new System.Drawing.Point(21, 190);
			this.reino_unido.Name = "reino_unido";
			this.reino_unido.Size = new System.Drawing.Size(111, 24);
			this.reino_unido.TabIndex = 11;
			this.reino_unido.Text = "Reino Unido";
			this.reino_unido.UseVisualStyleBackColor = true;
			// 
			// macedonia
			// 
			this.macedonia.Location = new System.Drawing.Point(21, 210);
			this.macedonia.Name = "macedonia";
			this.macedonia.Size = new System.Drawing.Size(115, 24);
			this.macedonia.TabIndex = 12;
			this.macedonia.Text = "Macedonia";
			this.macedonia.UseVisualStyleBackColor = true;
			// 
			// checkBox5
			// 
			this.checkBox5.Location = new System.Drawing.Point(21, 230);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(116, 24);
			this.checkBox5.TabIndex = 13;
			this.checkBox5.Text = "Australia";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 270);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(304, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "3.- Cantidad de estados de los que se compone México";
			// 
			// estados
			// 
			this.estados.Location = new System.Drawing.Point(16, 287);
			this.estados.Name = "estados";
			this.estados.Size = new System.Drawing.Size(120, 20);
			this.estados.TabIndex = 15;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(5, 371);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(284, 28);
			this.label6.TabIndex = 16;
			this.label6.Text = "4.- Día en que termino la segunda guerra mundial";
			// 
			// calFecha
			// 
			this.calFecha.Location = new System.Drawing.Point(257, 302);
			this.calFecha.Name = "calFecha";
			this.calFecha.TabIndex = 17;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(211, 513);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 18;
			this.button1.Text = "Terminar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(527, 582);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.calFecha);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.estados);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.checkBox5);
			this.Controls.Add(this.macedonia);
			this.Controls.Add(this.reino_unido);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.portugal);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.df);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nom);
			this.Controls.Add(this.cod);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Practica6";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.estados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MonthCalendar calFecha;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown estados;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox macedonia;
		private System.Windows.Forms.CheckBox reino_unido;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox portugal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton df;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox nom;
		private System.Windows.Forms.TextBox cod;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
