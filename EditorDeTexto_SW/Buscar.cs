using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EditorDeTexto_SW;

namespace EditorDeTexto_SW
{

    public partial class Buscar : Form
    {
        RichTextBox txtEditex;
        static Color colorOriginal;
        static Color backColorOriginal;
        static String textoOriginalBusqueda;
        static int totalCoincidencias;
        static int coincidenciaActual;

        public Buscar(RichTextBox Texto)
        {
            InitializeComponent();
            txtEditex = Texto;
            colorOriginal = txtEditex.ForeColor;
            backColorOriginal = txtEditex.BackColor;
            textoOriginalBusqueda = "";
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            txtEditex.Select(0, txtEditex.Text.Length);
            txtEditex.SelectionColor = colorOriginal;
            txtEditex.SelectionBackColor = backColorOriginal;
            txtEditex.SelectionLength = 0;
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text == "")
                {
                    MessageBox.Show("Por favor ingresar el texto a buscar");
                    txtBuscar.Focus();
                }
                else
                {
                    Busqueda(txtEditex, txtBuscar.Text, Color.Red);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

            }

        }

        static void VerifiBusque(RichTextBox TextoTotal, String ListaTexto, Color color)
        {
            if (ListaTexto == "")
            {
                return;
            }
            int s_start = TextoTotal.SelectionStart, startIndex = 0, index;

            while ((index = TextoTotal.Text.IndexOf(ListaTexto, startIndex)) != -1)
            {
                TextoTotal.Select(index, ListaTexto.Length);
                TextoTotal.SelectionColor = color;
                startIndex = index + ListaTexto.Length;

            }

            TextoTotal.SelectionStart = s_start;
            TextoTotal.SelectionLength = 0;
            TextoTotal.SelectionColor = Color.Black;

        }

        static void Busqueda(RichTextBox TextoTotal, String ListaTexto, Color color)
        {
            if (ListaTexto == "")
            {
                return;
            }
            if (textoOriginalBusqueda == "" || textoOriginalBusqueda.CompareTo(ListaTexto) != 0)
            {
                textoOriginalBusqueda = ListaTexto;
                coincidenciaActual = 1;
            }
            else
            {
                coincidenciaActual++;
            }
           
            totalCoincidencias = 0;
            TextoTotal.Select(0, TextoTotal.Text.Length);
            TextoTotal.SelectionColor = colorOriginal;
            TextoTotal.SelectionBackColor = backColorOriginal;
            TextoTotal.SelectionLength = 0;           

            int s_start = TextoTotal.SelectionStart, startIndex = 0, index;
            int contador = 0;
            while ((index = TextoTotal.Text.IndexOf(ListaTexto, startIndex)) != -1)
            {
                TextoTotal.Select(index, ListaTexto.Length);
                TextoTotal.SelectionColor = color;
                startIndex = index + ListaTexto.Length;

                totalCoincidencias++;
                contador++;
                if (contador == coincidenciaActual)
                {
                    TextoTotal.ScrollToCaret();
                    TextoTotal.SelectionBackColor = Color.Cyan;
                }
            }
            if (coincidenciaActual == totalCoincidencias)
            {
                coincidenciaActual = 0;
            }
            if (totalCoincidencias == 0)
            {
                coincidenciaActual = 0;
                MessageBox.Show("No se encontraron resultados");
            }
            //textoOriginalBusqueda
            TextoTotal.SelectionStart = s_start;
            TextoTotal.SelectionLength = 0;
            TextoTotal.SelectionColor = Color.Black;

        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            // Buscar.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void Buscar_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtEditex.Select(0, txtEditex.Text.Length);
            txtEditex.SelectionColor = colorOriginal;
            txtEditex.SelectionBackColor = backColorOriginal;
            txtEditex.SelectionLength = 0;
        }
    }
}