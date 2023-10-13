/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;



namespace Graficar_Triangulo
{
    public class coordenadasABC
    {
        private Pen lapiz;
        private Graphics interseccion;
        private TextBox txt_XA, txt_XB, txt_XC, txt_YA, txt_YB, txt_YC;
        private PictureBox PB_Grafica;
        private double AX, AY, BX, BY, CX, CY;
        private int ancho, alto;


        //iniciamos los metodos del windows form 
        public coordenadasABC(TextBox txt_XA, TextBox txt_XB, TextBox txt_XC, TextBox txt_YA, TextBox txt_YB, TextBox txt_YC, PictureBox PB_Grafica)
        {
            this.txt_XA = txt_XA;
            this.txt_XB = txt_XB;
            this.txt_XC = txt_XC;
            this.txt_YA = txt_YA;
            this.txt_YB = txt_YB;
            this.txt_YC = txt_YC;
            this.PB_Grafica = PB_Grafica;
            lapiz = new Pen(Color.Black);
            interseccion = PB_Grafica.CreateGraphics();

            int ancho = PB_Grafica.Width /2;
            int alto = PB_Grafica.Height /2;
        }
        public void verificarCoordenadas()//verificacion de los textbox no esten vacios
        {
            if (txt_XA.Text == "")
            {
                txt_XA.Focus();
            }
            else
            {
                if (txt_XB.Text == "")
                {
                    txt_XB.Focus();
                }
                else
                {
                    if (txt_XC.Text == "")
                    {
                        txt_XC.Focus();
                    }
                    else
                    {
                        if (txt_YA.Text == "")
                        {
                            txt_YA.Focus();
                        }
                        else
                        {
                            if (txt_YB.Text == "")
                            {
                                txt_YB.Focus();
                            }
                            else
                            {
                                if (txt_YC.Text == "")
                                {
                                    txt_YC.Focus();
                                }
                                else
                                {
                                    trazar();
                                }
                            }
                        }
                    }
                }
            }
        }//acabo
        private void trazar()
        {
           
           double XA = Convert.ToDouble(txt_XA.Text);
            double YA = Convert.ToDouble(txt_YA.Text);
            double XB = Convert.ToDouble(txt_XB.Text);
            double YB = Convert.ToDouble(txt_YB.Text);
            double XC = Convert.ToDouble(txt_XC.Text);
            double YC = Convert.ToDouble(txt_YC.Text);

             AX= (Convert.ToDouble(ancho) + Convert.ToDouble(txt_XA.Text));
             AY= (Convert.ToDouble(alto) - Convert.ToDouble(txt_YA.Text));
             BX= (Convert.ToDouble(ancho) + Convert.ToDouble(txt_XB.Text));
             BY= (Convert.ToDouble(alto) - Convert.ToDouble(txt_YB.Text));
             CX= (Convert.ToDouble(ancho) + Convert.ToDouble(txt_XC.Text));
             CY= (Convert.ToDouble(alto) - Convert.ToDouble(txt_YC.Text));

            interseccion = PB_Grafica.CreateGraphics();

            lapiz = new Pen(Color.Black);

            lapiz.Color = Color.Blue;

            interseccion.DrawLine(lapiz, Convert.ToInt32(AX), Convert.ToInt32(AY), Convert.ToInt32(BX), Convert.ToInt32(BY));//Trazo de AB
            interseccion.DrawLine(lapiz, Convert.ToInt32(BX), Convert.ToInt32(BY), Convert.ToInt32(CX), Convert.ToInt32(CY));//Trazo de BC
            interseccion.DrawLine(lapiz, Convert.ToInt32(CX), Convert.ToInt32(CY), Convert.ToInt32(AX), Convert.ToInt32(AY));//Trazo de CB 


            lapiz.Dispose();
            interseccion.Dispose();
        }

    }
}*/

using System;
using System.Windows.Forms;
using System.Drawing;

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
            // Verifica si los valores ingresados en los TextBox son números válidos
            if (double.TryParse(txt_XA.Text, out XA) &&
                double.TryParse(txt_YA.Text, out YA) &&
                double.TryParse(txt_XB.Text, out XB) &&
                double.TryParse(txt_YB.Text, out YB) &&
                double.TryParse(txt_XC.Text, out XC) &&
                double.TryParse(txt_YC.Text, out YC))
            {
                // Dibuja las líneas del triángulo utilizando las coordenadas calculadas
                graficos.DrawLine(lapiz, (float)XA, (float)YA, (float)XB, (float)YB); // Trazo de AB
                graficos.DrawLine(lapiz, (float)XB, (float)YB, (float)XC, (float)YC); // Trazo de BC
                graficos.DrawLine(lapiz, (float)XC, (float)YC, (float)XA, (float)YA); // Trazo de CA

                /*// Invierte el eje Y
                YA = PB_Grafica.Height - YA;
                YB = PB_Grafica.Height - YB;
                YC = PB_Grafica.Height - YC;*/

                Font coorenadas = new Font("Arial", 10);
                Brush linea = Brushes.Black;

                graficos.DrawString("A", coorenadas, linea, (float)XA, (float)YA - 20);
                graficos.DrawString("B", coorenadas, linea, (float)XB, (float)YB - 20);
                graficos.DrawString("C", coorenadas, linea, (float)XC, (float)YC - 20);

                //lineas del triangulo
                for (double i = 0; i <= 1; i += 0.1)
                {
                    double xAB = XA + i * (XB - XA);
                    double yAB = YA + i * (YB - YA);
                    txt_ABx.Text += $"({xAB}) {Environment.NewLine}";
                    txt_ABy.Text += $"({yAB}) {Environment.NewLine}";

                    double xBC = XB + i * (XC - XB);
                    double yBC = YB + i * (YC - YB);
                    txt_BCx.Text += $"({xBC}) {Environment.NewLine}";
                    txt_BCy.Text += $"({yBC}) {Environment.NewLine}";

                    double xCA = XC + i * (XA - XC);
                    double yCA = YC + i * (YA - YC);
                    txt_CAx.Text += $"({xCA})  {Environment.NewLine}";
                    txt_CAy.Text += $"({yCA}) {Environment.NewLine}";
                }

                //lineas dentro del triangulo
                for (double j = 0; j <= 1; j += 0.1)
                {
                    double xToC = XA + j * (XC - XA);
                    double yToC = YA + j * (YC - YA);

                    double xBC = XB + j * (XC - XB);
                    double yBC = YB + j * (YC - YB);

                    graficos.DrawLine(lapizr, (float)XB, (float)YB, (float)xBC, (float)yBC);  // Dibuja línea BC
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





