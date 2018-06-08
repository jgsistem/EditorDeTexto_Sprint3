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
        bool RedTipo;
        public Buscar(RichTextBox Texto)
        {           
            InitializeComponent();
            txtEditex = Texto;            
        }

        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
               //VerifiBusque(txtEditex, txtBuscar.Text, Color.Black);
               Busqueda(txtEditex, txtBuscar.Text, Color.Red);
            }
            catch (Exception)
            {

                throw;
            }
            finally {
                
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

        private void Buscar_Load(object sender, EventArgs e)
        {
           // Buscar.FormBorderStyle = FormBorderStyle.FixedSingle;
           
        } 
       
    }
}
