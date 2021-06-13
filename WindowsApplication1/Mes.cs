using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Mes : Form
    {
        public Mes()
        {
            InitializeComponent();
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                Form1 obj = new Form1(int.Parse(comboBox1.SelectedItem.ToString()));
                obj.ShowDialog();
            }
            else
                MessageBox.Show("Debe seleccionar un mes antes de continuar");
        }

    }
}