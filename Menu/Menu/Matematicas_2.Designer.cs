/*
 * Created by SharpDevelop.
 * User: CC2_PC23
 * Date: 31/10/2024
 * Time: 07:26 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Menu
{
	partial class Matematicas_2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matematicas_2));
			this.lblpromedio = new System.Windows.Forms.Label();
			this.lblmayor = new System.Windows.Forms.Label();
			this.lblmenor = new System.Windows.Forms.Label();
			this.lblp_aprobados = new System.Windows.Forms.Label();
			this.lblreprobados = new System.Windows.Forms.Label();
			this.lblaprobados = new System.Windows.Forms.Label();
			this.lblmoda = new System.Windows.Forms.Label();
			this.lblmedia = new System.Windows.Forms.Label();
			this.txtpromedio = new System.Windows.Forms.TextBox();
			this.txtmenor = new System.Windows.Forms.TextBox();
			this.txtp_aprobados = new System.Windows.Forms.TextBox();
			this.txtmayor = new System.Windows.Forms.TextBox();
			this.txtmoda = new System.Windows.Forms.TextBox();
			this.txtmedia = new System.Windows.Forms.TextBox();
			this.txtaprobados = new System.Windows.Forms.TextBox();
			this.txtreprobados = new System.Windows.Forms.TextBox();
			this.btnregresar_menu = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblpromedio
			// 
			this.lblpromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblpromedio.Location = new System.Drawing.Point(12, 26);
			this.lblpromedio.Name = "lblpromedio";
			this.lblpromedio.Size = new System.Drawing.Size(83, 23);
			this.lblpromedio.TabIndex = 0;
			this.lblpromedio.Text = "Promedio";
			// 
			// lblmayor
			// 
			this.lblmayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblmayor.Location = new System.Drawing.Point(12, 95);
			this.lblmayor.Name = "lblmayor";
			this.lblmayor.Size = new System.Drawing.Size(83, 23);
			this.lblmayor.TabIndex = 1;
			this.lblmayor.Text = "Mayor";
			// 
			// lblmenor
			// 
			this.lblmenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblmenor.Location = new System.Drawing.Point(12, 118);
			this.lblmenor.Name = "lblmenor";
			this.lblmenor.Size = new System.Drawing.Size(83, 23);
			this.lblmenor.TabIndex = 2;
			this.lblmenor.Text = "Menor";
			// 
			// lblp_aprobados
			// 
			this.lblp_aprobados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblp_aprobados.Location = new System.Drawing.Point(12, 187);
			this.lblp_aprobados.Name = "lblp_aprobados";
			this.lblp_aprobados.Size = new System.Drawing.Size(146, 23);
			this.lblp_aprobados.TabIndex = 3;
			this.lblp_aprobados.Text = "Promedio de aprobados";
			// 
			// lblreprobados
			// 
			this.lblreprobados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblreprobados.Location = new System.Drawing.Point(12, 164);
			this.lblreprobados.Name = "lblreprobados";
			this.lblreprobados.Size = new System.Drawing.Size(83, 23);
			this.lblreprobados.TabIndex = 4;
			this.lblreprobados.Text = "Reprobados";
			// 
			// lblaprobados
			// 
			this.lblaprobados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblaprobados.Location = new System.Drawing.Point(12, 141);
			this.lblaprobados.Name = "lblaprobados";
			this.lblaprobados.Size = new System.Drawing.Size(83, 23);
			this.lblaprobados.TabIndex = 5;
			this.lblaprobados.Text = "Aprobados";
			// 
			// lblmoda
			// 
			this.lblmoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblmoda.Location = new System.Drawing.Point(12, 72);
			this.lblmoda.Name = "lblmoda";
			this.lblmoda.Size = new System.Drawing.Size(83, 23);
			this.lblmoda.TabIndex = 6;
			this.lblmoda.Text = "Moda";
			// 
			// lblmedia
			// 
			this.lblmedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblmedia.Location = new System.Drawing.Point(12, 49);
			this.lblmedia.Name = "lblmedia";
			this.lblmedia.Size = new System.Drawing.Size(83, 23);
			this.lblmedia.TabIndex = 7;
			this.lblmedia.Text = "Media";
			// 
			// txtpromedio
			// 
			this.txtpromedio.Location = new System.Drawing.Point(146, 23);
			this.txtpromedio.Name = "txtpromedio";
			this.txtpromedio.Size = new System.Drawing.Size(146, 20);
			this.txtpromedio.TabIndex = 8;
			// 
			// txtmenor
			// 
			this.txtmenor.Location = new System.Drawing.Point(146, 115);
			this.txtmenor.Name = "txtmenor";
			this.txtmenor.Size = new System.Drawing.Size(146, 20);
			this.txtmenor.TabIndex = 9;
			// 
			// txtp_aprobados
			// 
			this.txtp_aprobados.Location = new System.Drawing.Point(164, 184);
			this.txtp_aprobados.Name = "txtp_aprobados";
			this.txtp_aprobados.Size = new System.Drawing.Size(128, 20);
			this.txtp_aprobados.TabIndex = 10;
			// 
			// txtmayor
			// 
			this.txtmayor.Location = new System.Drawing.Point(146, 92);
			this.txtmayor.Name = "txtmayor";
			this.txtmayor.Size = new System.Drawing.Size(146, 20);
			this.txtmayor.TabIndex = 11;
			// 
			// txtmoda
			// 
			this.txtmoda.Location = new System.Drawing.Point(146, 69);
			this.txtmoda.Name = "txtmoda";
			this.txtmoda.Size = new System.Drawing.Size(146, 20);
			this.txtmoda.TabIndex = 12;
			// 
			// txtmedia
			// 
			this.txtmedia.Location = new System.Drawing.Point(146, 46);
			this.txtmedia.Name = "txtmedia";
			this.txtmedia.Size = new System.Drawing.Size(146, 20);
			this.txtmedia.TabIndex = 13;
			// 
			// txtaprobados
			// 
			this.txtaprobados.Location = new System.Drawing.Point(146, 138);
			this.txtaprobados.Name = "txtaprobados";
			this.txtaprobados.Size = new System.Drawing.Size(146, 20);
			this.txtaprobados.TabIndex = 14;
			// 
			// txtreprobados
			// 
			this.txtreprobados.Location = new System.Drawing.Point(146, 161);
			this.txtreprobados.Name = "txtreprobados";
			this.txtreprobados.Size = new System.Drawing.Size(146, 20);
			this.txtreprobados.TabIndex = 15;
			// 
			// btnregresar_menu
			// 
			this.btnregresar_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnregresar_menu.Location = new System.Drawing.Point(12, 234);
			this.btnregresar_menu.Name = "btnregresar_menu";
			this.btnregresar_menu.Size = new System.Drawing.Size(119, 23);
			this.btnregresar_menu.TabIndex = 16;
			this.btnregresar_menu.Text = "Regresar ";
			this.btnregresar_menu.UseVisualStyleBackColor = true;
			this.btnregresar_menu.Click += new System.EventHandler(this.Btnregresar_menuClick);
			// 
			// Matematicas_2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(304, 269);
			this.Controls.Add(this.btnregresar_menu);
			this.Controls.Add(this.txtreprobados);
			this.Controls.Add(this.txtaprobados);
			this.Controls.Add(this.txtmedia);
			this.Controls.Add(this.txtmoda);
			this.Controls.Add(this.txtmayor);
			this.Controls.Add(this.txtp_aprobados);
			this.Controls.Add(this.txtmenor);
			this.Controls.Add(this.txtpromedio);
			this.Controls.Add(this.lblmedia);
			this.Controls.Add(this.lblmoda);
			this.Controls.Add(this.lblaprobados);
			this.Controls.Add(this.lblreprobados);
			this.Controls.Add(this.lblp_aprobados);
			this.Controls.Add(this.lblmenor);
			this.Controls.Add(this.lblmayor);
			this.Controls.Add(this.lblpromedio);
			this.Name = "Matematicas_2";
			this.Text = "Matematicas_2";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnregresar_menu;
		private System.Windows.Forms.TextBox txtreprobados;
		private System.Windows.Forms.TextBox txtaprobados;
		private System.Windows.Forms.TextBox txtmedia;
		private System.Windows.Forms.TextBox txtmoda;
		private System.Windows.Forms.TextBox txtmayor;
		private System.Windows.Forms.TextBox txtp_aprobados;
		private System.Windows.Forms.TextBox txtmenor;
		private System.Windows.Forms.TextBox txtpromedio;
		private System.Windows.Forms.Label lblmedia;
		private System.Windows.Forms.Label lblmoda;
		private System.Windows.Forms.Label lblaprobados;
		private System.Windows.Forms.Label lblreprobados;
		private System.Windows.Forms.Label lblp_aprobados;
		private System.Windows.Forms.Label lblmenor;
		private System.Windows.Forms.Label lblmayor;
		private System.Windows.Forms.Label lblpromedio;
	}
}
