using System;
using System.Windows.Forms;

namespace Menu
{
    public partial class Humanidades : Form
    {
        public Humanidades()
        {
            InitializeComponent();

 
        }

        private void Btnjuego_Click(object sender, EventArgs e)
        {
            Form5 juegoForm = new Form5(); 
            juegoForm.Show(); 
            this.Hide(); 
        }
    } 
}