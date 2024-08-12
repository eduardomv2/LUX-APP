using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_3_LUX.Forms_Contenido.Comunicacion.Secciones.Emergente.Eliminar
{
    public partial class ComunicacionEliminarTarjeta : Form
    {
        private string mensaje = "Selecciona un apartado para eliminar contenido";
        SpeechSynthesizer synth;
        public ComunicacionEliminarTarjeta()
        {
            InitializeComponent();
            synth = new SpeechSynthesizer();
        }

        private void ComunicacionEliminarTarjeta_Load(object sender, EventArgs e)
        {
            synth.SpeakAsync(mensaje);
            tmMensaje.Interval = 15000;
            tmMensaje.Start();
        }
        private void tmMensaje_Tick(object sender, EventArgs e)
        {
            synth.SpeakAsync(mensaje);
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            Eliminar(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Social\Bebidas"));
        }

        private void btnAlimentos_Click(object sender, EventArgs e)
        {
            Eliminar(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Social\Alimentos"));
        }

        private void btnObjetos_Click(object sender, EventArgs e)
        {
            Eliminar(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Social\Objetos"));
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            Eliminar(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Social\Personas"));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Eliminar(string directoryPath)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = directoryPath;
                openFileDialog.Filter = "All Files (*.*)|*.*";
                openFileDialog.Multiselect = true;
                openFileDialog.Title = "Selecciona la imagen a eliminar";

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    Close();
                }

                int archivosEliminados = 1;
                foreach (string filePath in openFileDialog.FileNames)
                {
                    if (Path.GetDirectoryName(filePath).Equals(directoryPath, StringComparison.OrdinalIgnoreCase))
                    {
                        try
                        {
                            File.Delete(filePath);
                            synth.SpeakAsync($"Archivo seleccionado numero {archivosEliminados++} eliminado correctamente");
                        }
                        catch (Exception ex)
                        {
                            synth.SpeakAsync($"Hubo un problema con el archivo {archivosEliminados++}");
                            archivosEliminados--;
                        }
                    }
                    else
                    {
                        synth.SpeakAsync("Esta no es una opción valida");
                    }
                }
                this.Close();
            }
        }

        private void ComunicacionEliminarTarjeta_Click(object sender, EventArgs e)
        {
            tmMensaje.Interval += 20000;
        }
    }
}
