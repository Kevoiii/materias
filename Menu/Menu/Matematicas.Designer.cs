/*
 * Created by SharpDevelop.
 * User: CC2-PC15
 * Date: 24/10/2024
 * Time: 04:27 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Menu
{
	partial class Matematicas
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
			this.lblmatematicas = new System.Windows.Forms.Label();
			this.lblcal_2 = new System.Windows.Forms.Label();
			this.lblcal_3 = new System.Windows.Forms.Label();
			this.lblcal_4 = new System.Windows.Forms.Label();
			this.lblcal_5 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblcal_1 = new System.Windows.Forms.Label();
			this.btnregresar = new System.Windows.Forms.Button();
			this.btncalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblmatematicas
			// 
			this.lblmatematicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblmatematicas.Location = new System.Drawing.Point(117, 24);
			this.lblmatematicas.Name = "lblmatematicas";
			this.lblmatematicas.Size = new System.Drawing.Size(117, 26);
			this.lblmatematicas.TabIndex = 0;
			this.lblmatematicas.Text = "Matematicas";
			this.lblmatematicas.Click += new System.EventHandler(this.LblmatematicasClick);
			// 
			// lblcal_2
			// 
			this.lblcal_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblcal_2.Location = new System.Drawing.Point(47, 122);
			this.lblcal_2.Name = "lblcal_2";
			this.lblcal_2.Size = new System.Drawing.Size(64, 26);
			this.lblcal_2.TabIndex = 1;
			this.lblcal_2.Text = "Cal_2";
			// 
			// lblcal_3
			// 
			this.lblcal_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblcal_3.Location = new System.Drawing.Point(47, 148);
			this.lblcal_3.Name = "lblcal_3";
			this.lblcal_3.Size = new System.Drawing.Size(64, 26);
			this.lblcal_3.TabIndex = 2;
			this.lblcal_3.Text = "Cal_3";
			// 
			// lblcal_4
			// 
			this.lblcal_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblcal_4.Location = new System.Drawing.Point(47, 174);
			this.lblcal_4.Name = "lblcal_4";
			this.lblcal_4.Size = new System.Drawing.Size(64, 26);
			this.lblcal_4.TabIndex = 3;
			this.lblcal_4.Text = "Cal_4";
			// 
			// lblcal_5
			// 
			this.lblcal_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblcal_5.Location = new System.Drawing.Point(47, 200);
			this.lblcal_5.Name = "lblcal_5";
			this.lblcal_5.Size = new System.Drawing.Size(117, 26);
			this.lblcal_5.TabIndex = 4;
			this.lblcal_5.Text = "Cal_5";
			this.lblcal_5.Click += new System.EventHandler(this.Label4Click);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 70);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(172, 26);
			this.label5.TabIndex = 5;
			this.label5.Text = "Ingrese las calificaciones";
			// 
			// lblcal_1
			// 
			this.lblcal_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblcal_1.Location = new System.Drawing.Point(47, 96);
			this.lblcal_1.Name = "lblcal_1";
			this.lblcal_1.Size = new System.Drawing.Size(64, 26);
			this.lblcal_1.TabIndex = 6;
			this.lblcal_1.Text = "Cal_1";
			// 
			// btnregresar
			// 
			this.btnregresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnregresar.Location = new System.Drawing.Point(47, 260);
			this.btnregresar.Name = "btnregresar";
			this.btnregresar.Size = new System.Drawing.Size(75, 23);
			this.btnregresar.TabIndex = 7;
			this.btnregresar.Text = "Regresar";
			this.btnregresar.UseVisualStyleBackColor = true;
			// 
			// btncalcular
			// 
			this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncalcular.Location = new System.Drawing.Point(244, 260);
			this.btncalcular.Name = "btncalcular";
			this.btncalcular.Size = new System.Drawing.Size(75, 23);
			this.btncalcular.TabIndex = 8;
			this.btncalcular.Text = "Calcular";
			this.btncalcular.UseVisualStyleBackColor = true;
			// 
			// Matematicas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 324);
			this.Controls.Add(this.btncalcular);
			this.Controls.Add(this.btnregresar);
			this.Controls.Add(this.lblcal_1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblcal_5);
			this.Controls.Add(this.lblcal_4);
			this.Controls.Add(this.lblcal_3);
			this.Controls.Add(this.lblcal_2);
			this.Controls.Add(this.lblmatematicas);
			this.Name = "Matematicas";
			this.Text = "Matematicas";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btncalcular;
		private System.Windows.Forms.Button btnregresar;
		private System.Windows.Forms.Label lblcal_1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblcal_5;
		private System.Windows.Forms.Label lblcal_4;
		private System.Windows.Forms.Label lblcal_3;
		private System.Windows.Forms.Label lblcal_2;
		private System.Windows.Forms.Label lblmatematicas;
	}
}
