using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLeerArchivo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        { 
            StreamWriter ManejoArchivo = new StreamWriter("ArchivoNuevo.txt", true);
            string Texto = txtGrabar.Text;
            using (StreamWriter sw = ManejoArchivo)
            {
                sw.WriteLine(Texto);
            }
            MessageBox.Show("Archivo guardado correctamente");

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Nuevo Archivo
            //StreamWriter ManejoArchivo = new StreamWriter("ArchivoNuevo.txt", true);

            //Usar archivo ya creado
            //StreamWriter LeerArchivo = new StreamWriter("Libro.txt");
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            StreamReader ManejoArchivo = new StreamReader("ArchivoNuevo.txt");
            using (StreamReader sr = new StreamReader("ArchivoNuevo.txt"))
            {
                string Contenido = sr.ReadToEnd();
                rtbTexto.Text = Contenido;
            }
            MessageBox.Show("Leido Correctamente");

            while (ManejoArchivo.EndOfStream == false)
            {
            
              string Auxiliar = ManejoArchivo.ReadLine();

              if (Auxiliar.Contains(txtDato.Text))
              {
                MessageBox.Show("Encontrado");
                break;
              }
              else
              {
                    MessageBox.Show("No encontrado");
              }

            } 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //StreamReader ManejoArchivo = new StreamReader("ArchivoNuevo.txt");

            //while (ManejoArchivo.EndOfStream == false)
            //{
            //    string Auxiliar = ManejoArchivo.ReadLine();

            //    if (Auxiliar.Contains(txtDato.Text))
            //    {
            //        MessageBox.Show("Encontrado");
            //        break;
            //    }
            //    else
            //    {
            //        MessageBox.Show("No encontrado");
            //    }

            //}
        }
    }
}
