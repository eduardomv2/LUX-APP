using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_3_LUX.Forms_Contenido.Comunicacion.Secciones.Impresion
{
    public partial class SeccionPDFVocabulario : Form
    {
        private string mensaje = "Selecciona el apartado que deseas imprimir";
        SpeechSynthesizer speechSynthesizer;
        public string _SeleccionPDF { get; set; }

        public SeccionPDFVocabulario()
        {
            InitializeComponent();
            speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.SpeakAsync(mensaje);
        }

        private void SeleccionPDF_Load(object sender, EventArgs e)
        {
            tmMensaje.Interval = 15000;
            tmMensaje.Start();
        }

        #region OPCIONES - BOTONES
        private void btnAbecedario_Click(object sender, EventArgs e)
        {
            GeneratePdfFromImages(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Vocabulari\Abecedario"), "Abecedario");

        }

        private void btnColores_Click(object sender, EventArgs e)
        {
            GeneratePdfFromImages(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Vocabulari\Colores"), "Colores");
        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            GeneratePdfFromImages(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Comunicacion\Vocabulari\Animales"), "Animales");
        }
        #endregion

        public void GeneratePdfFromImages(string imageFolderPath, string fileName)
        {
            PdfDocument pdf = new PdfDocument();

            // Obtener todas las rutas de archivos de imagen en la carpeta
            string[] imageFiles = Directory.GetFiles(imageFolderPath, "*.*", SearchOption.TopDirectoryOnly)
                                           .Where(f => f.EndsWith(".png") || f.EndsWith(".jpg") || f.EndsWith(".jpeg"))
                                           .ToArray();

            int imagesPerPage = 8; // Número de imágenes por página
            int imagesPerRow = 4; // Número de imágenes por fila
            double spacing = 1.3; // Espaciado en mm (ajustar según sea necesario)
            double spacingInPoints = XUnit.FromMillimeter(spacing).Point; // Convertir a puntos

            for (int i = 0; i < imageFiles.Length; i++)
            {
                // Agregar una nueva página cada vez que se llene una página
                if (i % imagesPerPage == 0)
                {
                    PdfPage page = pdf.AddPage();
                    page.Orientation = PdfSharp.PageOrientation.Landscape; // Establecer orientación horizontal
                }

                PdfPage currentPage = pdf.Pages[pdf.PageCount - 1];

                // Cargar la imagen
                XImage image = XImage.FromFile(imageFiles[i]);

                // Obtener el tamaño de la página y calcular el tamaño y posición de la imagen
                using (XGraphics gfx = XGraphics.FromPdfPage(currentPage))
                {
                    double pageWidth = currentPage.Width;
                    double pageHeight = currentPage.Height;

                    double width = (pageWidth - (spacingInPoints * (imagesPerRow + 1))) / imagesPerRow;
                    double height = (pageHeight - (spacingInPoints * ((imagesPerPage / imagesPerRow) + 1))) / (imagesPerPage / imagesPerRow);

                    int row = (i % imagesPerPage) / imagesPerRow;
                    int column = (i % imagesPerPage) % imagesPerRow;

                    double x = spacingInPoints + column * (width + spacingInPoints);
                    double y = spacingInPoints + row * (height + spacingInPoints);

                    // Ajustar el tamaño de la imagen para mantener la relación de aspecto
                    double ratioX = width / image.PixelWidth;
                    double ratioY = height / image.PixelHeight;
                    double ratio = Math.Min(ratioX, ratioY);
                    double newWidth = image.PixelWidth * ratio;
                    double newHeight = image.PixelHeight * ratio;

                    // Centrar la imagen en su espacio asignado
                    double offsetX = (width - newWidth) / 2;
                    double offsetY = (height - newHeight) / 2;

                    // Dibujar la imagen en la página PDF
                    gfx.DrawImage(image, x + offsetX, y + offsetY, newWidth, newHeight);
                }
            }

            // Obtener la ruta del escritorio del usuario
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Combinar la ruta del escritorio con el nombre del archivo PDF
            string outputPath = Path.Combine(desktopPath, fileName + ".pdf");

            try
            {
                // Guardar el documento PDF en la ruta especificada
                pdf.Save(outputPath);
                speechSynthesizer.SpeakAsync("El archivo se ha copiado exitosamente en el escritorio.");
            }
            catch (Exception ex)
            {
                speechSynthesizer.SpeakAsync("Hubo un problema");
            }
            
            this.Close();
            this.Dispose();
        }

        private void tmMensaje_Tick(object sender, EventArgs e)
        {
            speechSynthesizer?.SpeakAsync(mensaje);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SeccionPDFVocabulario_Click(object sender, EventArgs e)
        {
            tmMensaje.Interval += 20000;
        }
    }
}
