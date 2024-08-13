using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TEST_3_LUX.FORMS;

namespace TEST_3_LUX.Forms_Contenido.Actividades.Secciones.Pictogramas.Puzzlee
{
    public partial class Puzzle : Form
    {
        private List<Bitmap> piezas;
        private Bitmap imagenCompleta;
        private List<string> imagenes;
        private int imagenActualIndex;

        public Puzzle()
        {
            InitializeComponent();

            // Obtener la ruta base del directorio donde se está ejecutando la aplicación
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            // Construir la ruta completa a la carpeta de imágenes relativa a la ruta base
            string carpetaImagenes = Path.Combine(basePath, @"Forms_Contenido\Actividades\Secciones\Pictogramas\Puzzlee\Recursos\");

            // Cargar las imágenes de la carpeta
            CargarImagenesDeCarpeta(carpetaImagenes);

            // Configurar el TableLayoutPanel
            ConfigureTableLayoutPanel();

            // Cargar la primera imagen y dividirla en piezas
            CargarImagenYDividir(imagenes[imagenActualIndex]);
        }

        public Puzzle(List<string> imagenes, int imagenActualIndex)
        {
            InitializeComponent();
            this.imagenes = imagenes;
            this.imagenActualIndex = imagenActualIndex;
            ConfigureTableLayoutPanel();
            CargarImagenYDividir(imagenes[imagenActualIndex]);
        }


        private void CargarImagenesDeCarpeta(string carpeta)
        {
            imagenes = Directory.GetFiles(carpeta, "*.*")
                                .Where(f => f.EndsWith(".png") || f.EndsWith(".jpg"))
                                .ToList();
            imagenActualIndex = 0;
        }

        private void ConfigureTableLayoutPanel()
        {
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.ColumnCount = 3;

            for (int i = 0; i < 3; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            }

            tableLayoutPanel.AllowDrop = true;
            tableLayoutPanel.DragEnter += TableLayoutPanel_DragEnter;
            tableLayoutPanel.DragDrop += TableLayoutPanel_DragDrop;
        }

        private void CargarImagenYDividir(string rutaImagen)
        {
            // Resetea las piezas antes de cargar una nueva imagen
            ResetearPiezas();

            // Cargar la nueva imagen y dividirla en piezas
            imagenCompleta = new Bitmap(rutaImagen);
            pictureBoxImagenCompleta.Image = imagenCompleta;
            pictureBoxImagenCompleta.SizeMode = PictureBoxSizeMode.StretchImage;
            piezas = DividirImagen(imagenCompleta, 3, 3);

            // Asignar las nuevas piezas a los paneles
            AsignarPiezasAPaneles();
        }

        private List<Bitmap> DividirImagen(Bitmap imagen, int filas, int columnas)
        {
            List<Bitmap> piezas = new List<Bitmap>();
            int anchoPieza = imagen.Width / columnas;
            int altoPieza = imagen.Height / filas;
            for (int y = 0; y < filas; y++)
            {
                for (int x = 0; x < columnas; x++)
                {
                    Rectangle rect = new Rectangle(x * anchoPieza, y * altoPieza, anchoPieza, altoPieza);
                    Bitmap pieza = imagen.Clone(rect, imagen.PixelFormat);
                    piezas.Add(pieza);
                }
            }
            return piezas;
        }

        private void AsignarPiezasAPaneles()
        {
            for (int i = 0; i < 9; i++)
            {
                Panel panel = Controls.Find($"panelPieza{i + 1}", true).FirstOrDefault() as Panel;
                if (panel != null)
                {
                    panel.BackgroundImage = piezas[i];
                    panel.BackgroundImageLayout = ImageLayout.Stretch;
                    panel.MouseDown -= Panel_MouseDown; // Remover eventos antiguos
                    panel.MouseDown += Panel_MouseDown;
                    panel.AllowDrop = true;
                    panel.DragEnter -= Panel_DragEnter; // Remover eventos antiguos
                    panel.DragEnter += Panel_DragEnter;
                    panel.DragDrop -= Panel_DragDrop; // Remover eventos antiguos
                    panel.DragDrop += Panel_DragDrop;
                }
            }
        }

        private void ResetearTableLayoutPanel()
        {
            tableLayoutPanel.Controls.Clear();
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Panel panel = sender as Panel;
                if (panel != null && panel.BackgroundImage != null)
                {
                    DoDragDrop(panel, DragDropEffects.Move);
                }
            }
        }

        private void Panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Panel)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Panel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Panel)))
            {
                Panel sourcePanel = e.Data.GetData(typeof(Panel)) as Panel;
                Panel targetPanel = sender as Panel;

                if (sourcePanel != null && targetPanel != null && sourcePanel != targetPanel)
                {
                    Bitmap tempImage = (Bitmap)targetPanel.BackgroundImage;
                    targetPanel.BackgroundImage = sourcePanel.BackgroundImage;
                    sourcePanel.BackgroundImage = tempImage;
                }
            }
        }

        private void TableLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Panel)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void TableLayoutPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Panel)))
            {
                Panel draggedPanel = e.Data.GetData(typeof(Panel)) as Panel;
                if (draggedPanel != null)
                {
                    Point clientPoint = tableLayoutPanel.PointToClient(new Point(e.X, e.Y));
                    Control targetControl = tableLayoutPanel.GetChildAtPoint(clientPoint);

                    int col, row;

                    if (targetControl == null)
                    {
                        col = Math.Min(tableLayoutPanel.ColumnCount - 1, clientPoint.X / (tableLayoutPanel.Width / tableLayoutPanel.ColumnCount));
                        row = Math.Min(tableLayoutPanel.RowCount - 1, clientPoint.Y / (tableLayoutPanel.Height / tableLayoutPanel.RowCount));
                    }
                    else
                    {
                        col = tableLayoutPanel.GetColumn(targetControl);
                        row = tableLayoutPanel.GetRow(targetControl);
                    }

                    Panel targetPanel = tableLayoutPanel.GetControlFromPosition(col, row) as Panel;

                    if (targetPanel != null && targetPanel != draggedPanel)
                    {
                        Bitmap tempImage = (Bitmap)targetPanel.BackgroundImage;
                        targetPanel.BackgroundImage = draggedPanel.BackgroundImage;
                        draggedPanel.BackgroundImage = tempImage;
                    }
                    else if (targetPanel == null)
                    {
                        tableLayoutPanel.Controls.Add(draggedPanel, col, row);
                        draggedPanel.Dock = DockStyle.Fill;
                        draggedPanel.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
            }
        }

        private void Puzzle_Load(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Avanzar al siguiente índice de la imagen
            imagenActualIndex = (imagenActualIndex + 1) % imagenes.Count;

            // Crear una nueva instancia del formulario con la siguiente imagen
            Puzzle nuevoPuzzle = new Puzzle(imagenes, imagenActualIndex);

            // Mostrar el nuevo formulario
            nuevoPuzzle.Show();

            // Cerrar el formulario actual
            this.Close();
        }

     

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            Principal_actividades pa = new Principal_actividades();
            pa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (VerificarRompecabezas())
            {
                MessageBox.Show("¡Felicidades! Has completado el rompecabezas correctamente.", "Rompecabezas Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSiguiente_Click(sender, e);  // Al verificar, si está correcto, avanza a la siguiente imagen
            }
            else
            {
                MessageBox.Show("El rompecabezas no está resuelto correctamente.", "Rompecabezas Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ResetearPiezas()
        {
            // Recorrer cada pieza y devolverla a su panel original si está en el TableLayoutPanel
            for (int i = 0; i < 9; i++)
            {
                Panel panelOriginal = Controls.Find($"panelPieza{i + 1}", true).FirstOrDefault() as Panel;
                if (panelOriginal != null)
                {
                    // Si la pieza está en el TableLayoutPanel, moverla de vuelta al panel original
                    if (tableLayoutPanel.Controls.Contains(panelOriginal))
                    {
                        tableLayoutPanel.Controls.Remove(panelOriginal);
                        panelOriginal.BackgroundImage = piezas[i]; // Mantener la imagen correcta en el panel
                        panelOriginal.AllowDrop = true;
                        panelOriginal.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
            }
        }


        private bool VerificarRompecabezas()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Panel panel = tableLayoutPanel.GetControlFromPosition(col, row) as Panel;
                    if (panel == null || !ImagenesIguales(panel.BackgroundImage, piezas[row * 3 + col]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool ImagenesIguales(Image img1, Image img2)
        {
            if (img1 == null || img2 == null) return false;

            using (MemoryStream ms1 = new MemoryStream(), ms2 = new MemoryStream())
            {
                img1.Save(ms1, System.Drawing.Imaging.ImageFormat.Png);
                img2.Save(ms2, System.Drawing.Imaging.ImageFormat.Png);

                byte[] img1Bytes = ms1.ToArray();
                byte[] img2Bytes = ms2.ToArray();

                return img1Bytes.SequenceEqual(img2Bytes);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar imagen";
                openFileDialog.Filter = "Imágenes (*.png;*.jpg)|*.png;*.jpg|Todos los archivos (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaImagenSeleccionada = openFileDialog.FileName;

                    // Agregar la imagen seleccionada a la lista de imágenes
                    imagenes.Add(rutaImagenSeleccionada);

                    // Mostrar un mensaje de confirmación
                    MessageBox.Show("Imagen agregada con éxito.", "Imagen agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Cargar y mostrar la nueva imagen agregada
                    imagenActualIndex = imagenes.Count - 1;  // Establecer el índice a la nueva imagen
                    CargarImagenYDividir(rutaImagenSeleccionada);
                }
            }
        }
    }
}
