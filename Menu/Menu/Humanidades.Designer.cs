/*
 * Created by SharpDevelop.
 * User: CC2-PC14
 * Date: 24/10/2024
 * Time: 08:28 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Menu
{
	partial class Humanidades
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Humanidades));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnjuego = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(282, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "\"Materia: Humanidades\"\r\n";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(34, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(471, 45);
			this.label2.TabIndex = 1;
			this.label2.Text = "¿Que es?";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(34, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(544, 124);
			this.label3.TabIndex = 2;
			this.label3.Text = resources.GetString("label3.Text");
			// 
			// btnjuego
			// 
			this.btnjuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnjuego.Location = new System.Drawing.Point(263, 259);
			this.btnjuego.Name = "btnjuego";
			this.btnjuego.Size = new System.Drawing.Size(122, 36);
			this.btnjuego.TabIndex = 3;
			this.btnjuego.Text = "ir a jugar";
			this.btnjuego.UseVisualStyleBackColor = true;
			
			// 
			// Humanidades
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(752, 374);
			this.Controls.Add(this.btnjuego);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Humanidades";
			this.Text = "Humanidades";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnjuego;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
