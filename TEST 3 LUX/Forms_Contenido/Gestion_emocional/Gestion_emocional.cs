using System;
using System.IO;
using System.Windows.Forms;
using TEST_3_LUX.FORMS.Comunicacion3;
using TEST_3_LUX.Forms_Contenido.Gestion_emocional.Controles_personalizados;

namespace TEST_3_LUX.Forms_Contenido.Gestion_emocional
{
    public partial class Gestion_emocional : Form
    {
        private string cancionAnterior;
        private string cancionSiguiente;
        private string seleccion;
        private bool mediaVideo;
        private string[] imageFiles;
        private (string, int) cancionActual;
        private ComunicacionPrincipal principal;
        public Gestion_emocional(ComunicacionPrincipal principal)
        {
            InitializeComponent();
            mediaVideo = false;
            this.principal = principal;

            doubleBufferedTableLayoutPanel1.RowStyles.Clear();
            doubleBufferedTableLayoutPanel1.RowCount = 0;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.stop();
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {

            if (wmpVideo.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                wmpVideo.Ctlcontrols.pause();
                return;
            }

            if (wmpVideo.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                wmpVideo.Ctlcontrols.play();
                return;
            }

            wmpVideo.URL = Path.Combine(seleccion, mediaVideo ? cancionActual + ".mp4" : cancionActual + ".mp3");
            wmpVideo.Ctlcontrols.play();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int rowCount = cancionActual.Item2 - 1;
            int rwc = doubleBufferedTableLayoutPanel1.RowCount;

            if (rowCount >= 0)
            {
                object cancionAnterior = doubleBufferedTableLayoutPanel1.Controls[rowCount];
                RPictureBox cancion = cancionAnterior as RPictureBox;
                cancionActual = (cancion.NombreRecurso, rowCount);
            }
            else
            {
                cancionActual = ((doubleBufferedTableLayoutPanel1.GetControlFromPosition(0, rwc - 1) as RPictureBox).NombreRecurso, rwc - 1);
            }

            wmpVideo.URL = Path.Combine(seleccion, mediaVideo ? cancionActual + ".mp4" : cancionActual + ".mp3");
            wmpVideo.Ctlcontrols.play();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int rowCount = cancionActual.Item2 + 1;
            int rwc = doubleBufferedTableLayoutPanel1.RowCount;

            if (rowCount >= rwc)
            {
                TableLayoutPanelCellPosition cancionAnterior = doubleBufferedTableLayoutPanel1.GetPositionFromControl(doubleBufferedTableLayoutPanel1.Controls[0]);
                cancionActual = ((doubleBufferedTableLayoutPanel1.GetControlFromPosition(0, rowCount) as RPictureBox).NombreRecurso, cancionAnterior.Row);
            }
            else
            {
                cancionActual = ((doubleBufferedTableLayoutPanel1.GetControlFromPosition(0, rowCount) as RPictureBox).NombreRecurso, rowCount);
            }

            wmpVideo.URL = Path.Combine(seleccion, mediaVideo ? cancionActual.Item1 + ".mp4" : cancionActual + ".mp3");
            wmpVideo.Ctlcontrols.play();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            doubleBufferedTableLayoutPanel1.RowStyles.Clear();
            doubleBufferedTableLayoutPanel1.RowCount = 0;
            mediaVideo = true;
            doubleBufferedTableLayoutPanel1.Controls.Clear();
            seleccion = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Gestion_emocional\Videos\");
            imageFiles = Directory.GetFiles(seleccion);

            // Configurar la nueva fila
            doubleBufferedTableLayoutPanel1.RowCount += 1;
            doubleBufferedTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            foreach (string file in imageFiles)
            {
                var fi2le = TagLib.File.Create(file);

                // Extraer la imagen de portada
                var pictures = fi2le.Tag.Pictures;

                // Verificar si hay imágenes de portada antes de acceder a ellas
                if (pictures.Length > 0)
                {
                    var bin = (byte[])(pictures[0].Data.Data);
                    using (var ms = new MemoryStream(bin))
                    {
                        using (var originalImage = System.Drawing.Image.FromStream(ms))
                        {
                            var thumbnail = originalImage.GetThumbnailImage(200, 200, () => false, IntPtr.Zero);
                            RPictureBox pic = new RPictureBox(thumbnail, Path.GetFileNameWithoutExtension(file));
                            pic.Click += ClickButtons;

                            // Añadir el PictureBox al TableLayoutPanel
                            doubleBufferedTableLayoutPanel1.Controls.Add(pic, 0, 0);
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"No se encontró ninguna imagen de portada en el archivo: {file}");
                }
            }
        }

        private void btnCanciones_Click(object sender, EventArgs e)
        {
            doubleBufferedTableLayoutPanel1.RowStyles.Clear();
            doubleBufferedTableLayoutPanel1.RowCount = 0;
            mediaVideo = false;
            doubleBufferedTableLayoutPanel1.Controls.Clear();
            seleccion = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Gestion_emocional\Canciones\");
            imageFiles = Directory
            .GetFiles(seleccion);

            // Incrementar el número de filas
            doubleBufferedTableLayoutPanel1.RowCount += 1;

            // Configurar la nueva fila
            doubleBufferedTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));


            foreach (string file in imageFiles)
            {
                var fi2le = TagLib.File.Create(file);

                // Extraer la imagen de portada
                var pictures = fi2le.Tag.Pictures;

                var bin = (byte[])(pictures[0].Data.Data);
                using (var ms = new MemoryStream(bin))
                {
                    using (var originalImage = System.Drawing.Image.FromStream(ms))
                    {
                        var thumbnail = originalImage.GetThumbnailImage(200, 200, () => false, IntPtr.Zero);
                        RPictureBox pic = new RPictureBox(thumbnail, Path.GetFileNameWithoutExtension(file));
                        pic.Click += ClickButtons;

                        doubleBufferedTableLayoutPanel1.Controls.Add(pic, 0, 0);
                    }
                }
            }
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            Dispose();
            principal.Show();
        }

        private void doubleBufferedTableLayoutPanel1_Click(object sender, EventArgs e)
        {

            RPictureBox control = sender as RPictureBox;
            TableLayoutPanelCellPosition position = doubleBufferedTableLayoutPanel1.GetPositionFromControl(control);
            cancionActual = (control.NombreRecurso, position.Row);

            if (cancionActual.Item2 == 0)
            {
                object cancionAnterior = doubleBufferedTableLayoutPanel1.Controls[doubleBufferedTableLayoutPanel1.Controls.Count - 1];
                RPictureBox cancion = cancionAnterior as RPictureBox;
                this.cancionAnterior = cancion.NombreRecurso;
            }

            if (cancionActual.Item2 == doubleBufferedTableLayoutPanel1.Controls.Count - 1)
            {
                object cancionSiguiente = doubleBufferedTableLayoutPanel1.Controls[0];
                RPictureBox cancion = cancionSiguiente as RPictureBox;
                this.cancionSiguiente = cancion.NombreRecurso;
            }


            cancionAnterior = (doubleBufferedTableLayoutPanel1.GetControlFromPosition(0, cancionActual.Item2 - 1) as RPictureBox).NombreRecurso;
            cancionSiguiente = (doubleBufferedTableLayoutPanel1.GetControlFromPosition(0, cancionActual.Item2 + 1) as RPictureBox).NombreRecurso;
            wmpVideo.URL = Path.Combine(seleccion, mediaVideo ? cancionActual + ".mp4" : cancionActual + ".mp3");
            wmpVideo.Ctlcontrols.play();


        }

        private void ClickButtons(object sender, EventArgs e)
        {
            RPictureBox control = sender as RPictureBox;
            TableLayoutPanelCellPosition position = doubleBufferedTableLayoutPanel1.GetPositionFromControl(control);
            cancionActual = (control.NombreRecurso, position.Row);

            int rowCount = doubleBufferedTableLayoutPanel1.RowCount;
            if (cancionActual.Item2 == rowCount)
            {
                object cancionAnterior = doubleBufferedTableLayoutPanel1.Controls[doubleBufferedTableLayoutPanel1.Controls.Count - 1];
                RPictureBox cancion = cancionAnterior as RPictureBox;
                this.cancionAnterior = cancion.NombreRecurso;
            }
            else
            {
                cancionAnterior = (doubleBufferedTableLayoutPanel1.GetControlFromPosition(0, rowCount - 1) as RPictureBox).NombreRecurso;
            }

            
            if (cancionActual.Item2 == 0)
            {
                object cancionSiguiente = doubleBufferedTableLayoutPanel1.Controls[0];
                RPictureBox cancion = cancionSiguiente as RPictureBox;
                this.cancionSiguiente = cancion.NombreRecurso;
            }
            else
            {
                cancionSiguiente = (doubleBufferedTableLayoutPanel1.GetControlFromPosition(0, rowCount + 1) as RPictureBox).NombreRecurso;
            }
            
            wmpVideo.URL = Path.Combine(seleccion, mediaVideo ? cancionActual.Item1 + ".mp4" : cancionActual.Item1 + ".mp3");
            wmpVideo.Ctlcontrols.play();
        }

        private void Gestion_emocional_Load(object sender, EventArgs e)
        {

        }
    }
}
