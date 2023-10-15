namespace Graficar_Triangulo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_XA = new TextBox();
            txt_YA = new TextBox();
            txt_XB = new TextBox();
            txt_YB = new TextBox();
            txt_XC = new TextBox();
            txt_YC = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            PB_Grafica = new PictureBox();
            txt_ABx = new TextBox();
            txt_ABy = new TextBox();
            txt_BCx = new TextBox();
            txt_BCy = new TextBox();
            txt_CAx = new TextBox();
            txt_CAy = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            btn_mostrar = new Button();
            btn_limpiar = new Button();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            txt_pAB = new TextBox();
            txt_pBC = new TextBox();
            txt_pAC = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PB_Grafica).BeginInit();
            SuspendLayout();
            // 
            // txt_XA
            // 
            txt_XA.Location = new Point(147, 65);
            txt_XA.Name = "txt_XA";
            txt_XA.Size = new Size(125, 27);
            txt_XA.TabIndex = 0;
            txt_XA.TextChanged += txt_XA_TextChanged;
            // 
            // txt_YA
            // 
            txt_YA.Location = new Point(331, 65);
            txt_YA.Name = "txt_YA";
            txt_YA.Size = new Size(125, 27);
            txt_YA.TabIndex = 1;
            // 
            // txt_XB
            // 
            txt_XB.Location = new Point(147, 135);
            txt_XB.Name = "txt_XB";
            txt_XB.Size = new Size(125, 27);
            txt_XB.TabIndex = 2;
            // 
            // txt_YB
            // 
            txt_YB.Location = new Point(331, 135);
            txt_YB.Name = "txt_YB";
            txt_YB.Size = new Size(125, 27);
            txt_YB.TabIndex = 3;
            // 
            // txt_XC
            // 
            txt_XC.Location = new Point(147, 203);
            txt_XC.Name = "txt_XC";
            txt_XC.Size = new Size(125, 27);
            txt_XC.TabIndex = 4;
            // 
            // txt_YC
            // 
            txt_YC.Location = new Point(331, 203);
            txt_YC.Name = "txt_YC";
            txt_YC.Size = new Size(125, 27);
            txt_YC.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 135);
            label2.Name = "label2";
            label2.Size = new Size(96, 27);
            label2.TabIndex = 7;
            label2.Text = "Punto B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 203);
            label3.Name = "label3";
            label3.Size = new Size(102, 27);
            label3.TabIndex = 8;
            label3.Text = "Punto C";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 61);
            label1.Name = "label1";
            label1.Size = new Size(100, 27);
            label1.TabIndex = 6;
            label1.Text = "Punto A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(278, 65);
            label4.Name = "label4";
            label4.Size = new Size(39, 27);
            label4.TabIndex = 9;
            label4.Text = "X1";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(462, 65);
            label5.Name = "label5";
            label5.Size = new Size(39, 27);
            label5.TabIndex = 10;
            label5.Text = "Y1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(278, 135);
            label6.Name = "label6";
            label6.Size = new Size(39, 27);
            label6.TabIndex = 11;
            label6.Text = "X2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(278, 199);
            label7.Name = "label7";
            label7.Size = new Size(39, 27);
            label7.TabIndex = 12;
            label7.Text = "X3";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(462, 135);
            label8.Name = "label8";
            label8.Size = new Size(39, 27);
            label8.TabIndex = 13;
            label8.Text = "Y2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(462, 203);
            label9.Name = "label9";
            label9.Size = new Size(39, 27);
            label9.TabIndex = 14;
            label9.Text = "Y3";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(219, 9);
            label10.Name = "label10";
            label10.Size = new Size(138, 27);
            label10.TabIndex = 15;
            label10.Text = "Coordenas";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(129, 267);
            label11.Name = "label11";
            label11.Size = new Size(42, 27);
            label11.TabIndex = 16;
            label11.Text = "AB";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(412, 267);
            label12.Name = "label12";
            label12.Size = new Size(44, 27);
            label12.TabIndex = 17;
            label12.Text = "BC";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(712, 277);
            label13.Name = "label13";
            label13.Size = new Size(48, 27);
            label13.TabIndex = 18;
            label13.Text = "CA";
            // 
            // PB_Grafica
            // 
            PB_Grafica.BackColor = Color.FromArgb(255, 255, 192);
            PB_Grafica.Location = new Point(1033, 32);
            PB_Grafica.Name = "PB_Grafica";
            PB_Grafica.Size = new Size(792, 785);
            PB_Grafica.TabIndex = 19;
            PB_Grafica.TabStop = false;
            PB_Grafica.Click += PB_Grafica_Click;
            PB_Grafica.Paint += PB_Grafica_Paint;
            // 
            // txt_ABx
            // 
            txt_ABx.Location = new Point(-2, 400);
            txt_ABx.Multiline = true;
            txt_ABx.Name = "txt_ABx";
            txt_ABx.ReadOnly = true;
            txt_ABx.Size = new Size(163, 374);
            txt_ABx.TabIndex = 20;
            txt_ABx.TextChanged += txt_ABx_TextChanged;
            // 
            // txt_ABy
            // 
            txt_ABy.Location = new Point(167, 396);
            txt_ABy.Multiline = true;
            txt_ABy.Name = "txt_ABy";
            txt_ABy.ReadOnly = true;
            txt_ABy.Size = new Size(163, 374);
            txt_ABy.TabIndex = 21;
            // 
            // txt_BCx
            // 
            txt_BCx.Location = new Point(340, 396);
            txt_BCx.Multiline = true;
            txt_BCx.Name = "txt_BCx";
            txt_BCx.ReadOnly = true;
            txt_BCx.Size = new Size(163, 374);
            txt_BCx.TabIndex = 22;
            // 
            // txt_BCy
            // 
            txt_BCy.Location = new Point(509, 396);
            txt_BCy.Multiline = true;
            txt_BCy.Name = "txt_BCy";
            txt_BCy.ReadOnly = true;
            txt_BCy.Size = new Size(163, 374);
            txt_BCy.TabIndex = 23;
            // 
            // txt_CAx
            // 
            txt_CAx.Location = new Point(681, 396);
            txt_CAx.Multiline = true;
            txt_CAx.Name = "txt_CAx";
            txt_CAx.ReadOnly = true;
            txt_CAx.Size = new Size(164, 378);
            txt_CAx.TabIndex = 24;
            // 
            // txt_CAy
            // 
            txt_CAy.Location = new Point(851, 396);
            txt_CAy.Multiline = true;
            txt_CAy.Name = "txt_CAy";
            txt_CAy.ReadOnly = true;
            txt_CAy.Size = new Size(164, 382);
            txt_CAy.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(28, 366);
            label14.Name = "label14";
            label14.Size = new Size(26, 27);
            label14.TabIndex = 26;
            label14.Text = "X";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(188, 366);
            label15.Name = "label15";
            label15.Size = new Size(26, 27);
            label15.TabIndex = 27;
            label15.Text = "Y";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(392, 366);
            label16.Name = "label16";
            label16.Size = new Size(26, 27);
            label16.TabIndex = 28;
            label16.Text = "X";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(712, 366);
            label17.Name = "label17";
            label17.Size = new Size(26, 27);
            label17.TabIndex = 29;
            label17.Text = "X";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(548, 366);
            label18.Name = "label18";
            label18.Size = new Size(26, 27);
            label18.TabIndex = 30;
            label18.Text = "Y";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(896, 366);
            label19.Name = "label19";
            label19.Size = new Size(26, 27);
            label19.TabIndex = 31;
            label19.Text = "Y";
            // 
            // btn_mostrar
            // 
            btn_mostrar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_mostrar.Location = new Point(548, 56);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(120, 36);
            btn_mostrar.TabIndex = 32;
            btn_mostrar.Text = "Mostrar";
            btn_mostrar.UseVisualStyleBackColor = true;
            btn_mostrar.Click += btn_mostrar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpiar.Location = new Point(548, 135);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(101, 36);
            btn_limpiar.TabIndex = 33;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(-2, 330);
            label20.Name = "label20";
            label20.Size = new Size(132, 21);
            label20.TabIndex = 34;
            label20.Text = "pendiente AB";
            label20.Click += label20_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(286, 327);
            label21.Name = "label21";
            label21.Size = new Size(132, 21);
            label21.TabIndex = 35;
            label21.Text = "pendiente AB";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(589, 319);
            label22.Name = "label22";
            label22.Size = new Size(132, 21);
            label22.TabIndex = 36;
            label22.Text = "pendiente AB";
            label22.Click += label22_Click;
            // 
            // txt_pAB
            // 
            txt_pAB.Location = new Point(144, 327);
            txt_pAB.Name = "txt_pAB";
            txt_pAB.ReadOnly = true;
            txt_pAB.Size = new Size(125, 27);
            txt_pAB.TabIndex = 37;
            // 
            // txt_pBC
            // 
            txt_pBC.Location = new Point(432, 328);
            txt_pBC.Name = "txt_pBC";
            txt_pBC.ReadOnly = true;
            txt_pBC.Size = new Size(125, 27);
            txt_pBC.TabIndex = 38;
            // 
            // txt_pAC
            // 
            txt_pAC.Location = new Point(728, 321);
            txt_pAC.Name = "txt_pAC";
            txt_pAC.ReadOnly = true;
            txt_pAC.Size = new Size(125, 27);
            txt_pAC.TabIndex = 39;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1826, 959);
            Controls.Add(txt_pAC);
            Controls.Add(txt_pBC);
            Controls.Add(txt_pAB);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_mostrar);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(txt_CAy);
            Controls.Add(txt_CAx);
            Controls.Add(txt_BCy);
            Controls.Add(txt_BCx);
            Controls.Add(txt_ABy);
            Controls.Add(txt_ABx);
            Controls.Add(PB_Grafica);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_YC);
            Controls.Add(txt_XC);
            Controls.Add(txt_YB);
            Controls.Add(txt_XB);
            Controls.Add(txt_YA);
            Controls.Add(txt_XA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PB_Grafica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_XA;
        private TextBox txt_YA;
        private TextBox txt_XB;
        private TextBox txt_YB;
        private TextBox txt_XC;
        private TextBox txt_YC;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private PictureBox PB_Grafica;
        private TextBox txt_ABx;
        private TextBox txt_ABy;
        private TextBox txt_BCx;
        private TextBox txt_BCy;
        private TextBox txt_CAx;
        private TextBox txt_CAy;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Button btn_mostrar;
        private Button btn_limpiar;
        private Label label20;
        private Label label21;
        private Label label22;
        private TextBox txt_pAB;
        private TextBox txt_pBC;
        private TextBox txt_pAC;
    }
}