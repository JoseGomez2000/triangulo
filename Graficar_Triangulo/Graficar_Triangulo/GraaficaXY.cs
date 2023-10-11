using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Graficar_Triangulo
{
    internal class GraaficaXY
    {
        //Clase centrada en crear el gafico para el eje X y eje Y
        Pen lapiz = new Pen(Color.Black);
       // Graphics graf;
        public void grafica(PictureBox PB_Grafica)
        {
            
            // Obtiene el ancho y alto del PictureBox
            int ancho = PB_Grafica.Width;
            int alto = PB_Grafica.Height;
            Graphics graf;

            // Dibuja el plano cartesiano
            graf = PB_Grafica.CreateGraphics();
            graf.DrawLine(lapiz, ancho / 2, 0, ancho / 2, alto); // Eje vertical
            graf.DrawLine(lapiz, 0, alto / 2, ancho, alto / 2); // Eje horizontal

            // Dibuja los números de los ejes
            Font fuente = new Font("Arial", 10);
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
   
            for (int i = -11; i <= 11; i++)
            {
                int x = ancho / 2 + i * 30; // Espaciado de las marcas en el eje X
                int y = alto / 2 - i * 30; // Espaciado de las marcas en el eje Y
                graf.DrawLine(lapiz, x, alto / 2 - 5, x, alto / 2 + 5); // Marcas en el eje X
                graf.DrawLine(lapiz, ancho / 2 - 5, y, ancho / 2 + 5, y); // Marcas en el eje Y

                string numero = i == 0 ? "0" : Math.Abs(i).ToString(); // Usa Math.Abs para asegurarte de que los valores sean positivos
                graf.DrawString(numero, fuente, Brushes.Black, new RectangleF(x - 15, alto / 2 + 10, 30, 20), formato); // Números en el eje X

                 numero = -i == 0 ? "0" : Math.Abs(i).ToString(); // Usa Math.Abs para asegurarte de que los valores sean positivos
                graf.DrawString(numero, fuente, Brushes.Black, new RectangleF( ancho/2- 25, y - 10, 30, 20), formato); // Números en el eje X
            }
        }
}
}
