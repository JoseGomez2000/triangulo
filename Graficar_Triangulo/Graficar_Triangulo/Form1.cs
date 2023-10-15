using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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

            txt_ABx.Clear();
            txt_ABy.Clear();
            txt_BCx.Clear();
            txt_BCy.Clear();
            txt_CAx.Clear();
            txt_CAy.Clear();
            txt_pAB.Clear();
            txt_pBC.Clear();
            txt_pAC.Clear();

            double AX = double.Parse(txt_XA.Text);
            double AY = double.Parse(txt_YA.Text);
            double BX = double.Parse(txt_XB.Text);
            double BY = double.Parse(txt_YB.Text);
            double CX = double.Parse(txt_XC.Text);
            double CY = double.Parse(txt_YC.Text);
            double pAB = 0, pBC = 0, pAC = 0;
            double a, b, d, h, f, g;


           

            if (txt_pAB.Text == "" && txt_pBC.Text == "" && txt_pAC.Text == "")
            {
                if (BY < AY && BX < AX)
                {
                   

                    //pendiente ab
                    a = (BY - AY);
                    b = (BX - AX);
                    pAB = (a / b);

                    //pendiente bc
                    d = (CY - BY);
                    h = (CX - BX);
                    pBC = (d / h);

                    //pendiente ac
                    f = (AY - CY);
                    g = (AX - CX);
                    pAC = (f / g);

                    if ((CY < BY && CX < BX) || (CY > BY && CX > BX))
                    {
                        if ((AY < CY && AX < CX) || (AY > CY && AX > CX) || (AY == CY && AX == CX))
                        {
                            if (pAB < 1 || pBC < 1 || pAC < 1)
                            {
                                b = b * (-1);
                                a = a * (-1);
                                d = d * (-1);
                                h = h * (-1);
                                f = f * (-1);
                                g = g * (-1);
                                long c = Convert.ToInt64(a);
                                long y = Convert.ToInt64(b);
                                long yy = Convert.ToInt64(d);
                                long cc = Convert.ToInt64(h);
                                long yyy = Convert.ToInt64(f);
                                long ccc = Convert.ToInt64(g);
                                int k = Convert.ToInt32(AX);
                                int l = Convert.ToInt32(AY);
                                int m = Convert.ToInt32(BX);
                                int n = Convert.ToInt32(BY);
                                int o = Convert.ToInt32(CX);
                                int p = Convert.ToInt32(CY);

                                for (long i = 0; i <= y; i++) // pba
                                {
                                    double valorAY = AY - (pAB * i);
                                    txt_ABy.Text += valorAY.ToString() + Environment.NewLine;

                                }

                                for (int j = k; j >= m; j--)
                                {
                                    txt_ABx.Text += j.ToString() + Environment.NewLine;
                                }

                                for (long i = 0; i <= cc; i++) // pbc
                                {
                                    double nuevoValor = BY - (pBC * i);
                                    txt_BCy.Text += nuevoValor.ToString() + Environment.NewLine;

                                }
                                for (int j = m; j >= o; j--)
                                {
                                    txt_BCx.Text += j.ToString() + Environment.NewLine;
                                }

                                for (long i = 0; i <= y; i++) // pac
                                {
                                    double nuevoValor = AY - (pAC * i);
                                    txt_CAy.Text += nuevoValor.ToString() + Environment.NewLine;

                                }
                                for (int j = k; j >= o; j--)//aqui
                                {
                                    txt_CAx.Text += j.ToString() + Environment.NewLine;
                                }
                            }
                        }
                    }//ANIDADO
                }//acaba SEGUNDO IF
            }


            else
            {

            }
            txt_pAB.Text = pAB.ToString();
            txt_pBC.Text = pBC.ToString();
            txt_pAC.Text = pAC.ToString();

        }

        private void PB_Grafica_Paint(object sender, PaintEventArgs e)
        {
            // ob_graficaxy.grafica(PB_Grafica);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_XA.Clear();
            txt_YA.Clear();
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
            txt_pAB.Clear();
            txt_pBC.Clear();
            txt_pAC.Clear();

            PB_Grafica.Image = null;
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}