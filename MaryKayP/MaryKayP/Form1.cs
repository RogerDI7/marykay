using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MaryKayP
{
    public partial class Form1 : Form
    {
        //Variables
        int seccion = 1;
        bool read;
        int currentUser = 0;
        string input;
        string categoryIndex;
        int operacion = 0;

        //Categorias Lapiz Labial
        public Button Lapiz_1 = new Button();
        public Button Lapiz_2 = new Button();
        public Button Lapiz_3 = new Button();
        //Categorias Polvo compacto
        public Button PolvoC_1 = new Button();
        public Button PolvoC_2 = new Button();
        public Button PolvoC_3 = new Button();
        //crayones
        public Button Crayones_1 = new Button();
        public Button Crayones_2 = new Button();
        public Button Crayones_3 = new Button();
        //Categorias maquillaje
        public Button Maqui_1 = new Button();
        public Button Maqui_2 = new Button();
        public Button Maqui_3 = new Button();
        public Button Maqui_4 = new Button();
        public Button Maqui_5 = new Button();
        //Categorias Botanicos
        public Button Bota_1 = new Button();
        public Button Bota_2 = new Button();
        public Button Bota_3 = new Button();
        public Button Bota_4 = new Button();
        //Complementarios
        public Button Comp_1 = new Button();
        public Button Comp_2 = new Button();
        public Button Comp_3 = new Button();
        public object Response { get; private set; }

        //Inicialización
        public Form1()
        {
            InitializeComponent();
            vendedorToolStripMenuItem.PerformClick();



        }

        //Categorias
        //lapiz labial++

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "19";
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (!r.Cells[4].Value.ToString().Contains("19"))
                {
                    r.Visible = false;
                }
            }
            flowLayoutPanel1.Controls.Clear();
            //
            flowLayoutPanel1.Controls.Add(Lapiz_1);
            Lapiz_1.Click += Ev_humectante;
            Lapiz_1.Text = "Humectante";
            Lapiz_1.Width = 200;
            //
            flowLayoutPanel1.Controls.Add(Lapiz_2);
            Lapiz_2.Click += Ev_luminoso;
            Lapiz_2.Text = "Luminoso";
            Lapiz_2.Width = 200;
            //
            flowLayoutPanel1.Controls.Add(Lapiz_3);
            Lapiz_3.Click += Ev_cremoso;
            Lapiz_3.Text = "Cremoso";
            Lapiz_3.Width = 200;
            //

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "22";
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "22")
                {
                    r.Visible = false;
                }
            }

        }
        //polvos++
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "23";
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (!r.Cells[4].Value.ToString().Contains("23"))
                {
                    r.Visible = false;
                }
            }
            flowLayoutPanel1.Controls.Clear();
            //
            flowLayoutPanel1.Controls.Add(PolvoC_1);
            PolvoC_1.Click += Ev_IluminadorP;
            PolvoC_1.Text = "Iluminador";
            PolvoC_1.Width = 200;
            //
            flowLayoutPanel1.Controls.Add(PolvoC_2);
            PolvoC_2.Click += Ev_BronceadorP;
            PolvoC_2.Text = "Bronceador";
            PolvoC_2.Width = 200;
            //

        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "24";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "24")
                {
                    r.Visible = false;
                }
            }


        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "25";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "25")
                {
                    r.Visible = false;
                }
            }


        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "26";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "26")
                {
                    r.Visible = false;
                }
            }

        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "21";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "21")
                {
                    r.Visible = false;
                }
            }

        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "28";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "28")
                {
                    r.Visible = false;
                }
            }

        }
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "30";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "30")
                {
                    r.Visible = false;
                }
            }

        }
        //crayones++
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "31";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (!r.Cells[4].Value.ToString().Contains("31"))
                {
                    r.Visible = false;
                }
            }
            //cat1
            flowLayoutPanel1.Controls.Add(Crayones_1);
            Crayones_1.Click += Ev_Crayo1;
            Crayones_1.Text = "Labios";
            Crayones_1.Width = 200;
            //cat2
            flowLayoutPanel1.Controls.Add(Crayones_2);
            Crayones_2.Click += Ev_Crayo2;
            Crayones_2.Text = "Ojos";
            Crayones_2.Width = 200;
            //cat3

        }
        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "32";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "32")
                {
                    r.Visible = false;
                }
            }

        }
        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "1";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "1")
                {
                    r.Visible = false;
                }
            }
        }
        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "2";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "2")
                {
                    r.Visible = false;
                }
            }
        }
        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "3";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "3")
                {
                    r.Visible = false;
                }
            }
        }
        //
        //private void radioButton15_CheckedChanged(object sender, EventArgs e)
        //{
        //    categoryIndex = "4";
        //    flowLayoutPanel1.Controls.Clear();
        //    foreach (DataGridViewRow r in dataGridView1.Rows)
        //    {
        //        r.Visible = true;
        //        if (r.Cells[4].Value.ToString() != "4")
        //        {
        //            r.Visible = false;
        //        }
        //    }
        // }


        //Botanicos
        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "5";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString().Substring(0, 1) != "5")
                {
                    r.Visible = false;
                }
            }
            //
            flowLayoutPanel1.Controls.Add(Bota_1);
            Bota_1.Click += Ev_Bota1;
            Bota_1.Text = "Limpiadores";
            Bota_1.Width = 200;
            //
            flowLayoutPanel1.Controls.Add(Bota_2);
            Bota_2.Click += Ev_Bota2;
            Bota_2.Text = "Humectantes";
            Bota_2.Width = 200;
            //
            flowLayoutPanel1.Controls.Add(Bota_3);
            Bota_3.Click += Ev_Bota3;
            Bota_3.Text = "Refrescantes";
            Bota_3.Width = 200;
            //
            flowLayoutPanel1.Controls.Add(Bota_4);
            Bota_4.Click += Ev_Bota4;
            Bota_4.Text = "Mascarillas";
            Bota_4.Width = 200;
        }
        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "20";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "20")
                {
                    r.Visible = false;
                }
            }
        }
        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "27";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "27")
                {
                    r.Visible = false;
                }
            }
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "26";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "46")
                {
                    r.Visible = false;
                }
            }
        }
        //maquillajes
        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "6";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString().Substring(0, 1) != "6")
                {
                    r.Visible = false;
                }
            }
            flowLayoutPanel1.Controls.Clear();
            //
            flowLayoutPanel1.Controls.Add(Maqui_1);
            Maqui_1.Click += Ev_Maqui1;
            Maqui_1.Text = "Liquido Timewise";
            Maqui_1.Width = 200;
            //
            flowLayoutPanel1.Controls.Add(Maqui_2);
            Maqui_2.Click += Ev_Maqui2;
            Maqui_2.Text = "Liquido cobertura media";
            Maqui_2.Width = 200;
            //
            flowLayoutPanel1.Controls.Add(Maqui_3);
            Maqui_3.Click += Ev_Maqui3;
            Maqui_3.Text = "En polvo/suelto mineral";
            Maqui_3.Width = 200;
            //
            flowLayoutPanel1.Controls.Add(Maqui_4);
            Maqui_4.Click += Ev_Maqui4;
            Maqui_4.Text = "Crema endless performance";
            Maqui_4.Width = 200;
            //
            flowLayoutPanel1.Controls.Add(Maqui_5);
            Maqui_5.Click += Ev_Maqui5;
            Maqui_5.Text = "Polvo traslucido mineral";
            Maqui_5.Width = 200;


            //
        }
        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "11";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "11")
                {
                    r.Visible = false;
                }
            }
        }
        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "12";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (!r.Cells[4].Value.ToString().Contains("12"))
                {
                    r.Visible = false;
                }
            }
            flowLayoutPanel1.Controls.Add(Comp_1);
            Comp_1.Click += Ev_Comp1;
            Comp_1.Text = "Para la piel";
            Comp_1.Width = 200;
            //
            flowLayoutPanel1.Controls.Add(Comp_2);
            Comp_2.Click += Ev_Comp2;
            Comp_2.Text = "Para el cuidado de los ojos";
            Comp_2.Width = 200;
            //
            flowLayoutPanel1.Controls.Add(Comp_3);
            Comp_3.Click += Ev_Comp3;
            Comp_3.Text = "Para el cuidado de los labios";
            Comp_3.Width = 200;
        }
        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "13";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "13")
                {
                    r.Visible = false;
                }
            }
        }
        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "14";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "14")
                {
                    r.Visible = false;
                }
            }
        }
        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "15";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "15")
                {
                    r.Visible = false;
                }
            }
        }
        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "16";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "16")
                {
                    r.Visible = false;
                }
            }
        }
        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "17";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "17")
                {
                    r.Visible = false;
                }
            }
        }
        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "18";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "18")
                {
                    r.Visible = false;
                }
            }
        }
        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "34";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "34")
                {
                    r.Visible = false;
                }
            }
        }
        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "35";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "35")
                {
                    r.Visible = false;
                }
            }
        }
        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "36";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "36")
                {
                    r.Visible = false;
                }
            }
        }
        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "37";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "37")
                {
                    r.Visible = false;
                }
            }
        }
        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "38";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "38")
                {
                    r.Visible = false;
                }
            }
        }
        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "39";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "39")
                {
                    r.Visible = false;
                }
            }
        }
        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "40";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "40")
                {
                    r.Visible = false;
                }
            }
        }
        private void radioButton39_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "41";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "41")
                {
                    r.Visible = false;
                }
            }
        }
        private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "42";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "42")
                {
                    r.Visible = false;
                }
            }
        }
        private void radioButton41_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "43";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "43")
                {
                    r.Visible = false;
                }
            }
        }
        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "44";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "44")
                {
                    r.Visible = false;
                }
            }
        }
        private void AccDemostr_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = "45";
            flowLayoutPanel1.Controls.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "45")
                {
                    r.Visible = false;
                }
            }
        }
        private void radioTodo_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
            }
        }

        private void Ev_Comp3(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "12a")
                {
                    r.Visible = false;
                }
            }
        }
        private void Ev_Comp2(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "12b")
                {
                    r.Visible = false;
                }
            }
        }
        private void Ev_Comp1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "12c")
                {
                    r.Visible = false;
                }
            }
        }

        //Lapiz Labial
        private void Ev_cremoso(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "19c")
                {
                    r.Visible = false;
                }
            }
        }
        private void Ev_luminoso(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "19a")
                {
                    r.Visible = false;
                }
            }
        }
        private void Ev_humectante(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "19b")
                {
                    r.Visible = false;
                }
            }
        }
        //
        //Polvos
        private void Ev_BronceadorP(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "23b")
                {
                    r.Visible = false;
                }
            }
        }
        private void Ev_IluminadorP(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "23a")
                {
                    r.Visible = false;
                }
            }
        }
        //
        //Maquillajes
        private void Ev_Maqui1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "6a")
                {
                    r.Visible = false;
                }
            }
        }
        private void Ev_Maqui2(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "6b")
                {
                    r.Visible = false;
                }
            }
        }
        private void Ev_Maqui3(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "6c")
                {
                    r.Visible = false;
                }
            }
        }
        private void Ev_Maqui4(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "6d")
                {
                    r.Visible = false;
                }
            }
        }
        private void Ev_Maqui5(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "6e")
                {
                    r.Visible = false;
                }
            }
        }
        //
        //Crayones
        private void Ev_Crayo1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "31a")
                {
                    r.Visible = false;
                }
            }
        }
        private void Ev_Crayo2(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "31b")
                {
                    r.Visible = false;
                }
            }
        }
        //
        //Botanicales
        private void Ev_Bota4(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "5d")
                {
                    r.Visible = false;
                }
            }
        }
        private void Ev_Bota3(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "5c")
                {
                    r.Visible = false;
                }
            }
        }
        private void Ev_Bota2(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "5b")
                {
                    r.Visible = false;
                }
            }
        }
        private void Ev_Bota1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Visible = true;
                if (r.Cells[4].Value.ToString() != "5a")
                {
                    r.Visible = false;
                }
            }
        }
        //

        //Metodo para ingresar administrador
        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (currentUser != 1)
            {
                btnAceptarPass.Visible = true;
                lblAdmin.Visible = true;
                txtPass.Visible = true;
            }
        }

        //Metodo para cambiar a usuario simple
        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblInventario.Visible = false;
            label8.Text = "";
            button4.Visible = false;
            dataGridView1.ReadOnly = true;
            btnInventario.Visible = false;
            button5.Visible = false;
            currentUser = 0;
            lblAdmin.Visible = false;
            txtPass.Visible = false;
            btnAceptarPass.Visible = false;
        }

        //Metodo para escribir XML
        private void button3_Click(object sender, EventArgs e)
        {
            if (seccion == 1)
            {
                dataGridView1.ReadOnly = false;
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.TableName = "marykay";
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Precio");
                dt.Columns.Add("Cantidad");
                dt.Columns.Add("Cantidad_Ven");
                dt.Columns.Add("id");
                dt.Columns.Add("cantidadVendidos");
                ds.Tables.Add(dt);

                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    DataRow row1 = ds.Tables["marykay"].NewRow();
                    row1["Nombre"] = r.Cells[0].Value.ToString();
                    row1["Precio"] = r.Cells[1].Value.ToString();
                    row1["Cantidad"] = r.Cells[2].Value.ToString();
                    row1["Cantidad_Ven"] = r.Cells[3].Value.ToString();
                    row1["id"] = r.Cells[4].Value.ToString();
                    row1["cantidadVendidos"] = r.Cells[5].Value.ToString();
                    ds.Tables["marykay"].Rows.Add(row1);
                }
                //ds.WriteXml("C:\\Users\\Ara\\maryKayDB\\marykayDB.xml");
                ds.WriteXml("C:\\Users\\roger\\Desktop\\marykayDB.xml");
            }
            else if (seccion == 2)
            {
                dataGridView1.ReadOnly = false;
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.TableName = "marykay";
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Precio");
                dt.Columns.Add("Cantidad");
                dt.Columns.Add("Cantidad_Ven");
                dt.Columns.Add("id");
                dt.Columns.Add("cantidadVendidos");
                ds.Tables.Add(dt);
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    DataRow row1 = ds.Tables["marykay"].NewRow();
                    row1["Nombre"] = r.Cells[0].Value.ToString();
                    row1["Precio"] = r.Cells[1].Value.ToString();
                    row1["Cantidad"] = r.Cells[2].Value.ToString();
                    row1["Cantidad_Ven"] = r.Cells[3].Value.ToString();
                    row1["id"] = r.Cells[4].Value.ToString();
                    row1["cantidadVendidos"] = r.Cells[5].Value.ToString();
                    ds.Tables["marykay"].Rows.Add(row1);
                }
                //ds.WriteXml("C:\\Users\\Ara\\maryKayDB\\marykayDB2.xml");
                ds.WriteXml("C:\\Users\\roger\\Desktop\\marykayDB2.xml");
            }
            else if (seccion == 3)
            {
                dataGridView1.ReadOnly = false;
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.TableName = "marykay";
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Precio");
                dt.Columns.Add("Cantidad");
                dt.Columns.Add("Cantidad_Ven");
                dt.Columns.Add("id");
                dt.Columns.Add("cantidadVendidos");
                ds.Tables.Add(dt);
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    DataRow row1 = ds.Tables["marykay"].NewRow();
                    row1["Nombre"] = r.Cells[0].Value.ToString();
                    row1["Precio"] = r.Cells[1].Value.ToString();
                    row1["Cantidad"] = r.Cells[2].Value.ToString();
                    row1["Cantidad_Ven"] = r.Cells[3].Value.ToString();
                    row1["id"] = r.Cells[4].Value.ToString();
                    row1["cantidadVendidos"] = r.Cells[5].Value.ToString();
                    ds.Tables["marykay"].Rows.Add(row1);
                }
                //ds.WriteXml("C:\\Users\\Ara\\maryKayDB\\marykayDB3.xml");
                ds.WriteXml("C:\\Users\\roger\\Desktop\\marykayDB3.xml");
            }
            if (currentUser != 1)
            {
                dataGridView1.ReadOnly = true;
            }
        }

        //Agregar elemento
        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow newRow = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            newRow.Cells[0].Value = "0";
            newRow.Cells[1].Value = "0";
            newRow.Cells[2].Value = "0";
            newRow.Cells[3].Value = "0";
            newRow.Cells[4].Value = categoryIndex;
            newRow.Cells[5].Value = "0";
            newRow.Visible = true;
            dataGridView1.Rows.Add(newRow);
            dataGridView1.Refresh();
        }

        //Eliminar producto
        private void button5_Click_1(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            var confirmResult = MessageBox.Show("¿Seguro que quieres eliminar este producto?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(rowIndex);
                dataGridView1.Refresh();
            }
            else
            {

            }
        }

        //Venta a clientes
        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            if ((double.Parse(dataGridView1.Rows[rowIndex].Cells[2].Value.ToString()) - double.Parse(textBox1.Text)) >= 0)
            {
                DataGridViewRow producto = (DataGridViewRow)dataGridView1.Rows[rowIndex].Clone();
                producto.Cells[0].Value = dataGridView1.Rows[rowIndex].Cells[0].Value;
                producto.Cells[1].Value = dataGridView1.Rows[rowIndex].Cells[1].Value;
                producto.Cells[2].Value = textBox1.Text;
                producto.Cells[4].Value = rowIndex;
                dataGridView2.Rows.Insert(0, producto);
            }
            else
            {
                MessageBox.Show("Inventario no suficiente");
            }
        }

        //Venta a consultoras
        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            if ((double.Parse(dataGridView1.Rows[rowIndex].Cells[2].Value.ToString()) - double.Parse(textBox1.Text)) >= 0)
            {
                if (operacion == 1)
                {
                    double ventaTotal = 0;
                    double ventaRow = 0;
                    foreach (DataGridViewRow r in dataGridView2.Rows)
                    {
                        ventaRow = .65 * (double.Parse(r.Cells[1].Value.ToString()) * double.Parse(r.Cells[2].Value.ToString()));
                        ventaTotal += ventaRow;
                        dataGridView1.Rows[Int32.Parse(r.Cells[4].Value.ToString())].Cells[5].Value = Int32.Parse(dataGridView1.Rows[Int32.Parse(r.Cells[4].Value.ToString())].Cells[5].Value.ToString()) + Int32.Parse(r.Cells[2].Value.ToString());
                        dataGridView1.Rows[Int32.Parse(r.Cells[4].Value.ToString())].Cells[3].Value = double.Parse(dataGridView1.Rows[Int32.Parse(r.Cells[4].Value.ToString())].Cells[3].Value.ToString()) + ventaRow;
                        dataGridView1.Rows[Int32.Parse(r.Cells[4].Value.ToString())].Cells[2].Value = Int32.Parse(dataGridView1.Rows[Int32.Parse(r.Cells[4].Value.ToString())].Cells[2].Value.ToString()) - Int32.Parse(r.Cells[2].Value.ToString());
                        dataGridView1.Refresh();
                    }
                    label4.Text = "Total de venta: " + ventaTotal.ToString("C");
                }
                else if (operacion == 2)
                {
                    double ventaTotal = 0;
                    double ventaTotal1 = 0;
                    double ventaRow = 0;
                    double ventaRow1 = 0;
                    foreach (DataGridViewRow r in dataGridView2.Rows)
                    {
                        ventaRow = double.Parse(r.Cells[1].Value.ToString()) * double.Parse(r.Cells[2].Value.ToString());
                        ventaTotal += ventaRow;
                        dataGridView1.Rows[Int32.Parse(r.Cells[4].Value.ToString())].Cells[2].Value = Int32.Parse(dataGridView1.Rows[Int32.Parse(r.Cells[4].Value.ToString())].Cells[2].Value.ToString()) + Int32.Parse(r.Cells[2].Value.ToString());
                    }
                    foreach (DataGridViewRow r in dataGridView3.Rows)
                    {
                        ventaRow1 = double.Parse(r.Cells[1].Value.ToString()) * double.Parse(r.Cells[2].Value.ToString());
                        ventaTotal1 += ventaRow1;
                        dataGridView1.Rows[Int32.Parse(r.Cells[4].Value.ToString())].Cells[2].Value = Int32.Parse(dataGridView1.Rows[Int32.Parse(r.Cells[4].Value.ToString())].Cells[2].Value.ToString()) - Int32.Parse(r.Cells[2].Value.ToString());
                    }
                    label4.Text = "Diferencia: " + ((ventaTotal1 - ventaTotal) * .65).ToString("C");
                }
            }
            else
            {
                MessageBox.Show("Inventario no suficiente");
            }
        }

        //Calcular valor total de inventario
        private void button5_Click(object sender, EventArgs e)
        {
            double total = 0;
            double totalDeFila = 0;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                totalDeFila = Double.Parse(r.Cells[1].Value.ToString()) * Double.Parse(r.Cells[2].Value.ToString());
                total += totalDeFila;
            }
            label8.Text = total.ToString("C");
            label8.Update();
        }

        //Login de admin
        private void btnAceptarPass_Click(object sender, EventArgs e)
        {
            input = txtPass.Text;
            if (input == "1974alex0518")
            {
                button4.Visible = true;
                dataGridView1.ReadOnly = false;
                currentUser = 1;
                btnInventario.Visible = true;
                button5.Visible = true;
                lblAdmin.Visible = false;
                btnAceptarPass.Visible = false;
                txtPass.Visible = false;
                txtPass.Text = "";
                lblInventario.Visible = true;
            }
            else
            {

            }
        }

        //Abrir el primer Inventario
        private void sección1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label8.Text = "";
            panel1.Enabled = true;
            panel2.Enabled = false;
            panel3.Enabled = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            seccion = 1;

            read = dataGridView1.ReadOnly;
            dataGridView1.ReadOnly = false;
            DataSet ds = new DataSet();
            //ds.ReadXml("C:\\Users\\Ara\\maryKayDB\\marykayDB.xml");
            ds.ReadXml("C:\\Users\\roger\\Desktop\\marykayDB.xml");
            foreach (DataRow item in ds.Tables["marykay"].Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();

            }
            dataGridView1.ReadOnly = read;
        }

        //Abrir el segundo inventario
        private void sección2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label8.Text = "";
            panel1.Enabled = false;
            panel3.Enabled = false;
            panel2.Enabled = true;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            seccion = 2;
            read = dataGridView1.ReadOnly;
            dataGridView1.ReadOnly = false;
            DataSet ds = new DataSet();
            //ds.ReadXml("C:\\Users\\Ara\\maryKayDB\\marykayDB2.xml");
            ds.ReadXml("C:\\Users\\roger\\Desktop\\marykayDB2.xml");
            foreach (DataRow item in ds.Tables["marykay"].Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();

            }
            dataGridView1.ReadOnly = read;
        }

        //Abrir el tercer inventario
        private void sección3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label8.Text = "";
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = true;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            seccion = 3;

            read = dataGridView1.ReadOnly;
            dataGridView1.ReadOnly = false;
            DataSet ds = new DataSet();
            //ds.ReadXml("C:\\Users\\Ara\\maryKayDB\\marykayDB3.xml");
            ds.ReadXml("C:\\Users\\roger\\Desktop\\marykayDB3.xml");
            foreach (DataRow item in ds.Tables["marykay"].Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();

            }
            dataGridView1.ReadOnly = read;


        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            button2.Text = "Agregar";
            button6.Text = "Venta";
            button1.Text = "Ventra 35%";
            operacion = 1;
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            dataGridView3.Rows.Clear();
            dataGridView3.Refresh();
            dataGridView3.Enabled = false;
            label5.Text = "Tabla Venta";
            label10.Text = "";
            label2.Text = "Proceso Venta";
            panel4.Enabled = true;
            panel5.Enabled = true;
            dataGridView2.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            if ((double.Parse(dataGridView1.Rows[rowIndex].Cells[2].Value.ToString()) - double.Parse(textBox1.Text)) >= 0)
            {
                if (operacion == 1)
                {
                    double ventaTotal = 0;
                    double ventaRow = 0;
                    foreach (DataGridViewRow r in dataGridView2.Rows)
                    {
                        ventaRow = double.Parse(r.Cells[1].Value.ToString()) * double.Parse(r.Cells[2].Value.ToString());
                        ventaTotal += ventaRow;
                        dataGridView1.Rows[Int32.Parse(r.Cells[4].Value.ToString())].Cells[2].Value = Int32.Parse(dataGridView1.Rows[Int32.Parse(r.Cells[4].Value.ToString())].Cells[2].Value.ToString()) - Int32.Parse(r.Cells[2].Value.ToString());
                        dataGridView1.Rows[Int32.Parse(r.Cells[4].Value.ToString())].Cells[5].Value = Int32.Parse(dataGridView1.Rows[Int32.Parse(r.Cells[4].Value.ToString())].Cells[5].Value.ToString()) + Int32.Parse(r.Cells[2].Value.ToString());
                        dataGridView1.Rows[Int32.Parse(r.Cells[4].Value.ToString())].Cells[3].Value = double.Parse(dataGridView1.Rows[Int32.Parse(r.Cells[4].Value.ToString())].Cells[3].Value.ToString()) + ventaRow;
                        dataGridView1.Refresh();
                    }
                    label4.Text = "Total de venta: " + ventaTotal.ToString("C");
                }

                else if (operacion == 2)
                {
                    DataGridViewRow producto = (DataGridViewRow)dataGridView1.Rows[rowIndex].Clone();
                    producto.Cells[0].Value = dataGridView1.Rows[rowIndex].Cells[0].Value;
                    producto.Cells[1].Value = dataGridView1.Rows[rowIndex].Cells[1].Value;
                    producto.Cells[2].Value = textBox1.Text;
                    producto.Cells[4].Value = rowIndex;
                    dataGridView3.Rows.Insert(0, producto);
                }
            }
            else
            {
                MessageBox.Show("Inventario no suficiente");
            }
        }

        private void intercambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            operacion = 2;
            label2.Text = "Proceso Intercambio";
            panel4.Enabled = true;
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView3.Refresh();
            dataGridView2.Refresh();
            label5.Text = "Entrada";
            label10.Text = "Salida";
            button2.Text = "Agregar Entrada";
            button1.Text = "Aceptar";
            button6.Text = "Agregar Salida";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            dataGridView3.Refresh();
            textBox1.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            textBox1.Text = "0";
        }
    }//class

}//namespace
