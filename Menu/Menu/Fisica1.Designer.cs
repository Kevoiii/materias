/*
 * Created by SharpDevelop.
 * User: CC2_PC11
 * Date: 28/10/2024
 * Time: 08:29 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Menu
{
	partial class Fisica1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fisica1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtvo = new System.Windows.Forms.TextBox();
			this.txtt = new System.Windows.Forms.TextBox();
			this.txta = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(2, -1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(302, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "            Leyes de Newton";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(2, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 317);
			this.label2.TabIndex = 1;
			this.label2.Text = resources.GetString("label2.Text");
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(89, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(215, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "       Calculo de velocidad:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(230, 178);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 24);
			this.label4.TabIndex = 6;
			this.label4.Text = "vo";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(230, 212);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(20, 17);
			this.label5.TabIndex = 7;
			this.label5.Text = " t";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(230, 246);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(20, 20);
			this.label6.TabIndex = 8;
			this.label6.Text = " a";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(294, 2);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(10, 341);
			this.label7.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(89, 324);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(215, 19);
			this.label8.TabIndex = 13;
			// 
			// txtvo
			// 
			this.txtvo.Location = new System.Drawing.Point(251, 178);
			this.txtvo.Name = "txtvo";
			this.txtvo.Size = new System.Drawing.Size(38, 20);
			this.txtvo.TabIndex = 14;
			// 
			// txtt
			// 
			this.txtt.Location = new System.Drawing.Point(251, 212);
			this.txtt.Name = "txtt";
			this.txtt.Size = new System.Drawing.Size(38, 20);
			this.txtt.TabIndex = 15;
			// 
			// txta
			// 
			this.txta.Location = new System.Drawing.Point(251, 246);
			this.txta.Name = "txta";
			this.txta.Size = new System.Drawing.Size(38, 20);
			this.txta.TabIndex = 16;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(230, 272);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(59, 24);
			this.button1.TabIndex = 17;
			this.button1.Text = "Calcular";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(230, 302);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(59, 24);
			this.button2.TabIndex = 18;
			this.button2.Text = "Volver";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// Fisica1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(301, 336);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txta);
			this.Controls.Add(this.txtt);
			this.Controls.Add(this.txtvo);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Fisica1";
			this.Text = "Fisica1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox txta;
		private System.Windows.Forms.TextBox txtt;
		private System.Windows.Forms.TextBox txtvo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}
