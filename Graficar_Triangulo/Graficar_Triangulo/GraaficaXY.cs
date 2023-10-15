
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.DataFormats;


namespace Graficar_Triangulo
{
    internal class GraaficaXY
    {
        // Clase centrada en crear un plano cartesiano con solo los ejes X e Y en el primer cuadrante
        Pen lapiz = new Pen(Color.Black);

        Font etiquetaFont = new Font("Arial", 10); // Fuente para las etiquetas
        Brush etiquetaBrush = Brushes.Black;
        public void grafica(PictureBox PB_Grafica)
        {
            // Obtiene el ancho y alto del PictureBox
            int ancho = PB_Grafica.Width;
            int alto = PB_Grafica.Height;
            Graphics graf;

            // Dibuja el fondo del PictureBox en blanco
            graf = PB_Grafica.CreateGraphics();
            graf.Clear(Color.White);

              // Dibuja el eje Y (arriba, invertido)
              graf.DrawLine(lapiz, ancho / 40, alto / 20, ancho / 40, alto);
              graf.DrawString("Y", etiquetaFont, etiquetaBrush, new PointF(ancho / 40, alto / 20));

              int espacioEjeX = 20; // espacio del eje x 
              graf.DrawLine(lapiz, ancho / 40, alto - espacioEjeX, ancho, alto - espacioEjeX);

            int espacioEntreEjes = 2;
            int etiquetaIntervalo = 20; // Intervalo entre etiquetas

            // Agrega etiquetas al eje Y a la izquierda
            SizeF etiquetaSizeY = graf.MeasureString("Y", etiquetaFont);
           /* for (int i = etiquetaIntervalo; i <= 340; i += etiquetaIntervalo)
            {
                int yCoord = alto - espacioEjeX - espacioEntreEjes - (i * 2); //  coordenada Y para la etiqueta
                graf.DrawLine(lapiz, ancho / 50 - 5, yCoord, ancho / 40 + 5, yCoord); // Marca en el eje Y
                graf.DrawString(i.ToString(), etiquetaFont, etiquetaBrush, new PointF(ancho / 40 - espacioEntreEjes - etiquetaSizeY.Width, yCoord - etiquetaSizeY.Height / 2));
            }*/
        }
    } 
}
    


