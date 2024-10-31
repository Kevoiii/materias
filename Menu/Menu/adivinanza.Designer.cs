/*
 * Created by SharpDevelop.
 * User: CC2_PC29
 * Date: 30/10/2024
 * Time: 07:41 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Menu
{
	partial class adivinanza
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adivinanza));
			this.label1 = new System.Windows.Forms.Label();
			this.lblAdivinanza = new System.Windows.Forms.Label();
			this.txtRespuesta1 = new System.Windows.Forms.TextBox();
			this.lblAdivinanza2 = new System.Windows.Forms.Label();
			this.txtRespuesta2 = new System.Windows.Forms.TextBox();
			this.btnVerificar = new System.Windows.Forms.Button();
			this.btnVolver2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(161, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Adivinanza...";
			// 
			// lblAdivinanza
			// 
			this.lblAdivinanza.BackColor = System.Drawing.SystemColors.Info;
			this.lblAdivinanza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAdivinanza.Location = new System.Drawing.Point(13, 52);
			this.lblAdivinanza.Name = "lblAdivinanza";
			this.lblAdivinanza.Size = new System.Drawing.Size(243, 81);
			this.lblAdivinanza.TabIndex = 1;
			this.lblAdivinanza.Text = "En mis páginas encuentras cuentos,\nsabiduría y sentimientos,\nhistorias de amor y " +
			"de guerra,\nen un mundo que siempre se aferra.\n¿Qué soy?";
			// 
			// txtRespuesta1
			// 
			this.txtRespuesta1.Location = new System.Drawing.Point(287, 68);
			this.txtRespuesta1.Name = "txtRespuesta1";
			this.txtRespuesta1.Size = new System.Drawing.Size(100, 20);
			this.txtRespuesta1.TabIndex = 2;
			// 
			// lblAdivinanza2
			// 
			this.lblAdivinanza2.BackColor = System.Drawing.SystemColors.Info;
			this.lblAdivinanza2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAdivinanza2.Location = new System.Drawing.Point(13, 167);
			this.lblAdivinanza2.Name = "lblAdivinanza2";
			this.lblAdivinanza2.Size = new System.Drawing.Size(243, 85);
			this.lblAdivinanza2.TabIndex = 3;
			this.lblAdivinanza2.Text = "Busco en el tiempo y en el lugar,\nlos ecos de un pasado a contar.\nCon fechas y no" +
			"mbres voy a jugar,\nen libros antiguos te voy a llevar.\n¿Qué soy?";
			// 
			// txtRespuesta2
			// 
			this.txtRespuesta2.Location = new System.Drawing.Point(287, 187);
			this.txtRespuesta2.Name = "txtRespuesta2";
			this.txtRespuesta2.Size = new System.Drawing.Size(100, 20);
			this.txtRespuesta2.TabIndex = 4;
			// 
			// btnVerificar
			// 
			this.btnVerificar.BackColor = System.Drawing.SystemColors.Menu;
			this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVerificar.Location = new System.Drawing.Point(71, 291);
			this.btnVerificar.Name = "btnVerificar";
			this.btnVerificar.Size = new System.Drawing.Size(75, 23);
			this.btnVerificar.TabIndex = 5;
			this.btnVerificar.Text = "Verificar";
			this.btnVerificar.UseVisualStyleBackColor = false;
			this.btnVerificar.Click += new System.EventHandler(this.BtnVerificarClick);
			// 
			// btnVolver2
			// 
			this.btnVolver2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolver2.Location = new System.Drawing.Point(250, 291);
			this.btnVolver2.Name = "btnVolver2";
			this.btnVolver2.Size = new System.Drawing.Size(75, 23);
			this.btnVolver2.TabIndex = 6;
			this.btnVolver2.Text = "Volver";
			this.btnVolver2.UseVisualStyleBackColor = true;
			this.btnVolver2.Click += new System.EventHandler(this.BtnVolver2Click);
			// 
			// adivinanza
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(435, 340);
			this.Controls.Add(this.btnVolver2);
			this.Controls.Add(this.btnVerificar);
			this.Controls.Add(this.txtRespuesta2);
			this.Controls.Add(this.lblAdivinanza2);
			this.Controls.Add(this.txtRespuesta1);
			this.Controls.Add(this.lblAdivinanza);
			this.Controls.Add(this.label1);
			this.Name = "adivinanza";
			this.Text = "adivinanza";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnVolver2;
		private System.Windows.Forms.Button btnVerificar;
		private System.Windows.Forms.TextBox txtRespuesta2;
		private System.Windows.Forms.Label lblAdivinanza2;
		private System.Windows.Forms.TextBox txtRespuesta1;
		private System.Windows.Forms.Label lblAdivinanza;
		private System.Windows.Forms.Label label1;
	}
}
