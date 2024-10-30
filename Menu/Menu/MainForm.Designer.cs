/*
 * Created by SharpDevelop.
 * User: CC2-PC13
 * Date: 24/10/2024
 * Time: 04:21 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Menu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btningles = new System.Windows.Forms.Button();
			this.btnFisica = new System.Windows.Forms.Button();
			this.btneco = new System.Windows.Forms.Button();
			this.btnmate = new System.Windows.Forms.Button();
			this.btnhumanidades = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btningles
			// 
			this.btningles.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btningles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btningles.Location = new System.Drawing.Point(172, 131);
			this.btningles.Name = "btningles";
			this.btningles.Size = new System.Drawing.Size(124, 34);
			this.btningles.TabIndex = 0;
			this.btningles.Text = "Ingles";
			this.btningles.UseVisualStyleBackColor = false;
			this.btningles.Click += new System.EventHandler(this.BtninglesClick);
			// 
			// btnFisica
			// 
			this.btnFisica.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFisica.Location = new System.Drawing.Point(30, 213);
			this.btnFisica.Name = "btnFisica";
			this.btnFisica.Size = new System.Drawing.Size(124, 34);
			this.btnFisica.TabIndex = 1;
			this.btnFisica.Text = "Fisica";
			this.btnFisica.UseVisualStyleBackColor = false;
			this.btnFisica.Click += new System.EventHandler(this.BtnFisicaClick);
			// 
			// btneco
			// 
			this.btneco.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btneco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btneco.Location = new System.Drawing.Point(64, 323);
			this.btneco.Name = "btneco";
			this.btneco.Size = new System.Drawing.Size(124, 34);
			this.btneco.TabIndex = 2;
			this.btneco.Text = "Ecosistemas";
			this.btneco.UseVisualStyleBackColor = false;
			this.btneco.Click += new System.EventHandler(this.BtnecoClick);
			// 
			// btnmate
			// 
			this.btnmate.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnmate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnmate.Location = new System.Drawing.Point(313, 213);
			this.btnmate.Name = "btnmate";
			this.btnmate.Size = new System.Drawing.Size(124, 34);
			this.btnmate.TabIndex = 3;
			this.btnmate.Text = "Matematicas";
			this.btnmate.UseVisualStyleBackColor = false;
			this.btnmate.Click += new System.EventHandler(this.BtnmateClick);
			// 
			// btnhumanidades
			// 
			this.btnhumanidades.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnhumanidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnhumanidades.Location = new System.Drawing.Point(299, 323);
			this.btnhumanidades.Name = "btnhumanidades";
			this.btnhumanidades.Size = new System.Drawing.Size(124, 34);
			this.btnhumanidades.TabIndex = 4;
			this.btnhumanidades.Text = "Humanidades";
			this.btnhumanidades.UseVisualStyleBackColor = false;
			this.btnhumanidades.Click += new System.EventHandler(this.BtnhumanidadesClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.DarkGoldenrod;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(172, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 73);
			this.label1.TabIndex = 5;
			this.label1.Text = "  Menu\r\nMaterias";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(497, 468);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnhumanidades);
			this.Controls.Add(this.btnmate);
			this.Controls.Add(this.btneco);
			this.Controls.Add(this.btnFisica);
			this.Controls.Add(this.btningles);
			this.Name = "MainForm";
			this.Text = "Menu";
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button btningles;
		private System.Windows.Forms.Button btnFisica;
		private System.Windows.Forms.Button btneco;
		private System.Windows.Forms.Button btnmate;
		private System.Windows.Forms.Button btnhumanidades;
		private System.Windows.Forms.Label label1;
	}
}
