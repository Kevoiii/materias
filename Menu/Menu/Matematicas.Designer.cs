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
			this.SuspendLayout();
			// 
			// lblmatematicas
			// 
			this.lblmatematicas.Location = new System.Drawing.Point(247, 20);
			this.lblmatematicas.Name = "lblmatematicas";
			this.lblmatematicas.Size = new System.Drawing.Size(72, 26);
			this.lblmatematicas.TabIndex = 0;
			this.lblmatematicas.Text = "Matematicas";
			// 
			// Matematicas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(623, 342);
			this.Controls.Add(this.lblmatematicas);
			this.Name = "Matematicas";
			this.Text = "Matematicas";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblmatematicas;
	}
}
