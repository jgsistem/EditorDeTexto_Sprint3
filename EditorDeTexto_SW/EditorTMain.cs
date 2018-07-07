using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Diagnostics;
using System.Threading;
using System.Configuration;
using System.Collections.Specialized;
using System.Reflection;

namespace EditorDeTexto_SW
//*****************************************************************************************************************************
//                        EDITOR DE TEXTO
//                          UNMSM - GPS
//*****************************************************************************************************************************
{
    public partial class EditorTMain : Form
    {
        String RutaArchivo, RutaApp = null;
        String TipoFuente = null;
        int TotalText, TotalTextTemp = 0;
        public EditorTMain()
        {
            InitializeComponent();
        }

        private void EditorTMain_Load(object sender, EventArgs e)
        {

            TipoFuente = ConfigurationManager.AppSettings.Get("Tipofuente");
            FontDialog font = new FontDialog();
            var ConvertFuente = StringToFont(TipoFuente);
            if (ConvertFuente != null)
            {
                font.Font = ConvertFuente;
                txtEditexRT_Ul.Font = font.Font;
            }
            txtEditexRT_Ul.Focus();
            txtEditexRT_Ul.AllowDrop = true;
            txtEditexRT_Ul.DragDrop += txtEditexRT_Ul_DragEnter;
            ToolVersion.Text = "v 1.00.4";           
            RutaApp = Directory.GetCurrentDirectory();
        }

        void EjecutarExe(string RutaApp)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.UseShellExecute = true;
                info.FileName = ConfigurationManager.AppSettings.Get("name");
                info.WorkingDirectory = RutaApp;
                Process.Start(info);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoArchivo();
        }

        void NuevoArchivo()
        {
            txtEditexRT_Ul.Clear();
            BarraName.Text = "";
            TotalText = 0;
            TotalTextTemp = 0;

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtEditexRT_Ul.TextLength > 0)
            {
                TotalTextTemp = txtEditexRT_Ul.TextLength;
                if ((TotalTextTemp > TotalText) || (TotalText == 0))
                {
                    if (MessageBox.Show("Desea Guardar los Cambios? ", "Editor De Texto",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        saveAs();
                    }
                    else
                    {
                        NuevoArchivo();
                        AbrirArchivo();
                    }

                }
                else
                {
                    NuevoArchivo();
                    AbrirArchivo();
                }
            }
            else
            {
                AbrirArchivo();
            }
        }

        void AbrirArchivo()
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "Text [*.txt*]|*.txt|All Files [*,*]|*,*";
            Open.CheckFileExists = true;
            Open.Title = "Abrir Archivo";
            Open.ShowDialog(this);
            RutaArchivo = Open.FileName;
            try
            {
                using (StreamReader sr = new StreamReader(Open.FileName))
                {
                    String line;
                    string Lines = null;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Lines = line + "\r\n";
                        txtEditexRT_Ul.Text += Lines;
                    }
                    TotalText = txtEditexRT_Ul.TextLength;                    
                }
                BarraName.Text = RutaArchivo;

            }
            catch (Exception)
            {

            }
            finally
            {
                Open.Dispose();
            }
        }


        void saveAs()
        {
            SaveFileDialog Save = new SaveFileDialog();
            System.IO.StreamWriter myStreamWriter = null;
            Save.Filter = "Text (*.txt)|*.txt|HTML(*.html*)|*.html|All files(*.*)|*.*";
            Save.CheckPathExists = true;
            Save.Title = "Guardar como";
            Save.ShowDialog(this);
            try
            {
                myStreamWriter = System.IO.File.AppendText(Save.FileName);
                myStreamWriter.Write(txtEditexRT_Ul.Text);
                myStreamWriter.Flush();
                RutaArchivo = Save.FileName;

            }
            catch (Exception) { }
            finally
            {
                BarraName.Text = RutaArchivo;
            }
        }

        void saveAsGuardar()
        {
            SaveFileDialog Save = new SaveFileDialog();
            System.IO.StreamWriter myStreamWriter = null;
            Save.Filter = "Text (*.txt)|*.txt|HTML(*.html*)|*.html|All files(*.*)|*.*";
            try
            {
                myStreamWriter = System.IO.File.AppendText(RutaArchivo);
                myStreamWriter.Write(txtEditexRT_Ul.Text);
                myStreamWriter.Flush();
                RutaArchivo = Save.FileName;
            }
            catch (Exception) { }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtEditexRT_Ul.Text == "")
            {
                if (MessageBox.Show("Favor de Escribir algun Mensaje para Guardar", "Editor De Texto",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtEditexRT_Ul.Focus();
                }
            }
            else
            {
                saveAs();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Process proceso in Process.GetProcesses())
            {
                if (proceso.ProcessName == ConfigurationManager.AppSettings.Get("nameN"))
                {
                    proceso.Kill();
                }
            }
            Close();
        }

        private void fuenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                FontDialog font = new FontDialog();
                String rutaApp = RutaApp + "\\" + "EditorDeTexto_SW.EXE.config";
                if (font.ShowDialog() == DialogResult.OK)
                {
                    var fontString = FontToString(font.Font);
                    txtEditexRT_Ul.Font = font.Font;
                    isPath(rutaApp);
                    Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                    config.AppSettings.Settings["Tipofuente"].Value = fontString;
                    config.Save(ConfigurationSaveMode.Modified);
                }
            }
            catch (Exception)
            {
                
                throw;
            }            
        }

        private void isPath(string rutaPath) {

            if (!File.Exists(rutaPath)){
                String RutaBackup = RutaApp + "\\backup\\" ;
                File.Copy(Path.Combine(RutaBackup, "EditorDeTexto_SW.EXE.config"), Path.Combine(RutaApp, "EditorDeTexto_SW.EXE.config"));
              }                 
        }



        public static string FontToString(Font font)
        {
            return font.FontFamily.Name + ":" + font.Size + ":" + (int)font.Style;
        }

        public static Font StringToFont(string font)
        {
            if (font != null)
            {
                string[] parts = font.Split(':');
                if (parts.Length != 3)
                    throw new ArgumentException("Not a valid font string", "font");

                Font loadedFont = new Font(parts[0], float.Parse(parts[1]), (FontStyle)int.Parse(parts[2]));
                return loadedFont;
            }
            return null;
        }

        private void colorDeLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                txtEditexRT_Ul.ForeColor = color.Color;
            }
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fondo = new ColorDialog();
            if (fondo.ShowDialog() == DialogResult.OK)
            {
                txtEditexRT_Ul.BackColor = fondo.Color;
            }
        }

        private void EditorTMain_ResizeBegin(Object sender, EventArgs e)
        {

            MessageBox.Show("You are in the Form.ResizeBegin event.");

        }

        private void nosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nostros frm = new Nostros();
            frm.Show();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtEditexRT_Ul.Text == "")
            {
                if (MessageBox.Show("Favor de Escribir algun Mensaje para Guardar", "Editor De Texto",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtEditexRT_Ul.Focus();
                }
                else
                {
                    if (MessageBox.Show("Se va Proceder a Cerrar el Editor de Texto", "Editor De Texto",
                  MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                    {

                        this.Close();
                    }
                }
            }
            else
            {
                if (System.IO.File.Exists(RutaArchivo))
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(RutaArchivo))
                        {
                            sw.Write(txtEditexRT_Ul.Text);
                        }
                    }
                    catch (Exception)
                    {
                        Thread.Sleep(100);
                        saveAsGuardar();
                    }
                    finally
                    {
                        BarraName.Text = RutaArchivo;
                    }
                }
                else
                {
                    saveAs();
                }
            }
        }

        private void SendToPrinter(String filePath)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "print";
            info.FileName = filePath;
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;

            using (Process p = new Process())
            {
                p.StartInfo = info;
                p.Start();
                p.WaitForInputIdle();
                System.Threading.Thread.Sleep(3000);
            }

        }

        void DragDrop_Input(DragEventArgs e)
        {
            try
            {

                if (ValidaTipo(e))
                {
                    RutaArchivo = null;
                    String Nombre = null;
                    DataObject data = (DataObject)e.Data;
                    if (data.ContainsFileDropList())
                    {
                        string[] rawFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
                        if (rawFiles != null)
                        {
                            List<string> lines = new List<string>();
                            foreach (string path in rawFiles)
                            {
                                Nombre = path;
                                lines.AddRange(File.ReadAllLines(path));
                            }
                            RutaArchivo = Nombre;
                            BarraName.Text = Nombre;
                            txtEditexRT_Ul.Text = "";
                            var ListaArchivos = lines.ToArray();
                            if (ListaArchivos.Count() > 1)
                            {
                                String Lines = null;
                                foreach (string paths in ListaArchivos)
                                {
                                    Lines = paths + "\r\n";
                                    txtEditexRT_Ul.Text += Lines;
                                }
                            }
                            else
                            {
                                foreach (string paths in ListaArchivos)
                                {
                                    txtEditexRT_Ul.Text = paths;
                                }
                            }
                            TotalText = txtEditexRT_Ul.TextLength;
                        }
                    }

                }

                else
                {

                    if (MessageBox.Show("Archivo No tiene Extenxion .TXT", "Editor De Texto",
                                   MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                    {

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        bool ValidaTipo(DragEventArgs e)
        {
            bool bandera = false;
            RutaArchivo = null;
            DataObject data = (DataObject)e.Data;
            if (data.ContainsFileDropList())
            {
                string[] rawFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (var item in rawFiles)
                {
                    string TipoArchv = item.ToString();
                    int Total = TipoArchv.Length;
                    string tipoArchvi = TipoArchv.Substring(Total - 3, 3);

                    if (tipoArchvi.Equals("txt"))
                    {
                        bandera = true;
                    }
                    else
                    {
                        bandera = false;
                        break;

                    }
                }
            }

            return bandera;
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            NuevoArchivo();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (txtEditexRT_Ul.TextLength > 0)
            {
                Buscar frm = new Buscar(txtEditexRT_Ul);
                frm.Show();
            }

            else
            {
                if (MessageBox.Show("No tiene Texto para Buscar", "Editor De Texto",
                     MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    txtEditexRT_Ul.Focus();
                }
                else
                {
                    Buscar frm = new Buscar(txtEditexRT_Ul);
                    frm.Show();
                }
            }
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            abrirToolStripMenuItem_Click(sender, e);
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            guardarToolStripMenuItem_Click(sender, e);
        }

        private void GuardarComo_Click(object sender, EventArgs e)
        {
            guardarComoToolStripMenuItem_Click(sender, e);
        }


        private void txtEditexRT_Ul_DragEnter(object sendesr, DragEventArgs es)
        {
            if (txtEditexRT_Ul.TextLength > 0)
            {
                TotalTextTemp = txtEditexRT_Ul.TextLength;
                if ((TotalTextTemp > TotalText) || (TotalText == 0))
                {
                    if (MessageBox.Show("Desea Guardar los Cambios? ", "Editor De Texto",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        saveAs();
                    }
                    else
                    {
                        NuevoArchivo();
                        DragDrop_Input(es);
                    }
                }
                else
                {
                    NuevoArchivo();
                    DragDrop_Input(es);
                }

            }
            else
            {
                DragDrop_Input(es);
            }
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar_Click(sender, e);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void correctorOrtográficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditexRT_Ul.Text = RevisarOrtografia(txtEditexRT_Ul.Text);
        }

        private static string RevisarOrtografia(string texto)
        {
            var app = new Microsoft.Office.Interop.Word.Application();
            int SpellingErrors = 0;
            string corregido = string.Empty;
            if (!String.IsNullOrEmpty(texto))
            {

                app.Visible = false;
                object template = Missing.Value;
                object newTemplate = Missing.Value;
                object documentType = Missing.Value;
                object visible = false;
                Microsoft.Office.Interop.Word._Document doc1 = app.Documents.Add(ref template, ref newTemplate,
                ref documentType, ref visible);
                doc1.Words.First.InsertBefore(texto);

                Microsoft.Office.Interop.Word.ProofreadingErrors docErrors = doc1.SpellingErrors;
                SpellingErrors = docErrors.Count;

                object optional = Missing.Value;
                doc1.CheckSpelling(
                ref optional, ref optional, ref optional, ref optional, ref optional, ref optional,
                ref optional, ref optional, ref optional, ref optional, ref optional, ref optional);
                object first = 0;
                object last = doc1.Characters.Count - 1;
                corregido = doc1.Range(ref first, ref last).Text;
            }

            if (SpellingErrors == 0)
            {
                MessageBox.Show("No se encontraron errores en el texto");
            }

            object saveChanges = false;
            object originalFormat = Missing.Value;
            object routeDocument = Missing.Value;
            app.Application.Quit(ref saveChanges, ref originalFormat, ref routeDocument);
            return corregido;
        }

        private void btnSpellCheck_Click(object sender, EventArgs e)
        {
            txtEditexRT_Ul.Text = RevisarOrtografia(txtEditexRT_Ul.Text);
        }

        private void EditorTMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Process proceso in Process.GetProcesses())
            {
                if (proceso.ProcessName == ConfigurationManager.AppSettings.Get("nameN"))
                {
                    proceso.Kill();
                }
            }
        }
    }

}
