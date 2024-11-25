using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma_de_dos_numeros
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            TxtN1.Text = "";
            TxtN2.Text = "";
            TxtR.Text = "";
        }   

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double N1, N2, R;
            N1=double.Parse(TxtN1.Text);
            N2 =double.Parse(TxtN2.Text);
            R=N1 + N2;
            TxtR.Text=R.ToString();
        }
    }
}
