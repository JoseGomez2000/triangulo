using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Graficar_Triangulo
{
    public partial class Form1 : Form
    {
        GraaficaXY ob_graficaxy = new GraaficaXY();
        coordenadasABC cooABC;
        GraaficaXY grafica = new GraaficaXY();
        public Form1()
        {
            InitializeComponent();
            cooABC = new coordenadasABC(txt_XA, txt_XB, txt_XC, txt_YA, txt_YB, txt_YC, txt_ABx, txt_BCx, txt_CAx, txt_ABy, txt_BCy, txt_CAy, PB_Grafica);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PB_Grafica_Click(object sender, EventArgs e)
        {
            // ob_graficaxy.grafica(PB_Grafica);
        }

        private void txt_XA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ABx_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            ob_graficaxy.grafica(PB_Grafica);
            cooABC.verificarCoordenadas();
        }

        private void PB_Grafica_Paint(object sender, PaintEventArgs e)
        {
            // ob_graficaxy.grafica(PB_Grafica);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_XA.Clear();
            txt_YB.Clear();
            txt_XB.Clear();
            txt_YB.Clear();
            txt_XC.Clear();
            txt_YC.Clear();
            txt_ABx.Clear();
            txt_ABy.Clear();
            txt_BCx.Clear();
            txt_BCy.Clear();
            txt_CAx.Clear();
            txt_CAy.Clear();
            PB_Grafica.Image = null;
        }
    }
}