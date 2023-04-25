using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEjemplo20_04
{
    public partial class Form1 : Form
    {
        string textoA;
        string textoB;
        public Form1()
        {
            InitializeComponent();
            
        }

        public void txtA_TextChanged(object sender, EventArgs e)
        {


            
            textoA = txtA.Text;

            lblCaracteresA.Text = textoA.Length.ToString();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            

            textoB = txtB.Text;
            lblCaracteresB.Text = textoB.Length.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textoA.IndexOf(txtBuscar.Text) != -1)
            {
                txtBuscar.BackColor = Color.Green;
            }
            else
            {
                txtBuscar.BackColor = Color.Red;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Visible = true;
                 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            textoA = txtA.Text;
            textoB= txtB.Text;

            int resultado = string.Compare(textoA, textoB);
            if (resultado == 0)
            {
                MessageBox.Show("El contenido de ambas cadenas es igual");
            }
            else
            {
                if (resultado < 0)
                {
                    MessageBox.Show("El texto B contiene mayor cantidad de caracteres");
                }
                else
                {
                    if (resultado > 0)
                    {
                        MessageBox.Show("El texto A contiene mayor cantidad de caracteres");
                    }
                }
            }
            
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            DateTime A = dateTimePicker1.Value;
            string B = A.ToString("dd/MM/yyyy");
            lblFecha.Text = B;
        }

        private void btnReemplazar_Click(object sender, EventArgs e)
        {
            textoA = txtA.Text;
            string stringB = "";
            stringB = textoA.Replace(textoA, txtB.Text);
            txtA.Text = stringB;
            txtB.Clear();
        }
    }
}
