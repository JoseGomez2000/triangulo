using System;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.DataFormats;

namespace Graficar_Triangulo
{
    public class coordenadasABC
    {
        private Pen lapiz, lapizr;
        private Graphics graficos;
        private TextBox txt_XA, txt_XB, txt_XC, txt_YA, txt_YB, txt_YC;
        private TextBox txt_ABx, txt_BCx, txt_CAx, txt_ABy, txt_BCy, txt_CAy;
        private PictureBox PB_Grafica;

        // Inicializa los valores de las coordenadas en 0
        private double XA = 0, YA = 0, XB = 0, YB = 0, XC = 0, YC = 0, xToC, yToC;

        public coordenadasABC(TextBox txt_XA, TextBox txt_XB, TextBox txt_XC, TextBox txt_YA, TextBox txt_YB, TextBox txt_YC, TextBox txt_ABx, TextBox txt_BCx, TextBox txt_CAx, TextBox txt_ABy, TextBox txt_BCy, TextBox txt_CAy, PictureBox PB_Grafica)
        {
            this.txt_XA = txt_XA;
            this.txt_XB = txt_XB;
            this.txt_XC = txt_XC;
            this.txt_YA = txt_YA;
            this.txt_YB = txt_YB;
            this.txt_YC = txt_YC;
            this.txt_ABx = txt_ABx;
            this.txt_BCx = txt_BCx;
            this.txt_CAx = txt_CAx;
            this.txt_ABy = txt_ABy;
            this.txt_BCy = txt_BCy;
            this.txt_CAy = txt_CAy;
            this.PB_Grafica = PB_Grafica;

            // Inicializa el lápiz y los gráficos
            lapiz = new Pen(Color.Black);
            lapizr = new Pen(Color.Red);
            graficos = PB_Grafica.CreateGraphics();
        }

        public void verificarCoordenadas()
        {


            double desplazamientoX = 10;  // Desplazamiento en el eje X
            double desplazamientoY = 10;  // Desplazamiento en el eje Y

            // Verifica si los valores ingresados en los TextBox son números válidos
            if (double.TryParse(txt_XA.Text, out XA) &&
                double.TryParse(txt_YA.Text, out YA) &&
                double.TryParse(txt_XB.Text, out XB) &&
                double.TryParse(txt_YB.Text, out YB) &&
                double.TryParse(txt_XC.Text, out XC) &&
                double.TryParse(txt_YC.Text, out YC))
            {

                // Aplica el desplazamiento a las coordenadas
                XA += desplazamientoX;
                YA += desplazamientoY;
                XB += desplazamientoX;
                YB += desplazamientoY;
                XC += desplazamientoX;
                YC += desplazamientoY;

                YA = PB_Grafica.Height - YA;
                YB = PB_Grafica.Height - YB;
                YC = PB_Grafica.Height - YC;

                // Dibuja las líneas del triángulo utilizando las coordenadas calculadas
                graficos.DrawLine(lapiz, (float)XA, (float)YA, (float)XB, (float)YB); // Trazo de AB
                graficos.DrawLine(lapiz, (float)XB, (float)YB, (float)XC, (float)YC); // Trazo de BC
                graficos.DrawLine(lapiz, (float)XC, (float)YC, (float)XA, (float)YA); // Trazo de CA

                Font coorenadas = new Font("Arial", 10);
                Brush linea = Brushes.Black;

                graficos.DrawString("A", coorenadas, linea, (float)XA, (float)YA - 20);
                graficos.DrawString("B", coorenadas, linea, (float)XB, (float)YB - 20);
                graficos.DrawString("C", coorenadas, linea, (float)XC, (float)YC - 20);

                //lineas dentro del triangulo
                for (double j = 0; j <= 1; j += 0.1)
                {
                    double xToC = XA + j * (XC - XA);
                    double yToC = YA + j * (YC - YA);

                    double xBC = XB + j * (XC - XB);
                    double yBC = YB + j * (YC - YB);

                    graficos.DrawLine(lapizr, (float)XB, (float)YB, (float)xBC, (float)yBC);  // Dibuja línea BC

                    double xAB = XA + j * (XB - XA);
                    double yAB = YA + j * (YB - YA);           

                    double xCA = XC + j * (XA - XC);
                    double yCA = YC + j * (YA - YC);
                 
                    graficos.DrawLine(lapizr, (float)XB, (float)YB, (float)xToC, (float)yToC);  // Dibuja línea desde B a la intersección con C
                }


            }
            else
            {
                MessageBox.Show("Por favor, ingrese coordenadas válidas.");
            }

        }
    }
}





