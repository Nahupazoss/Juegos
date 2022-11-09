using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoAuto
{
    public partial class Form1 : Form
    {
        List<PictureBox> listObstaculos;
        Random randomObstaculos = new Random();
        int velocidad = 3;
        int animacionAuto = 0;

        public Form1()
        {
            InitializeComponent();
            listObstaculos = new List<PictureBox>();
            listObstaculos.Add(new PictureBox());
            listObstaculos.Add(new PictureBox());
            listObstaculos.Add(new PictureBox());
            CrearObstaculo(listObstaculos, this, 10, 180);
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        public void CrearObstaculo(List<PictureBox> listObstaculos, Form panelJuegoUno, int distanciauno, int distanciados)
        {
            int numeroAuto = 1;
            int tipoObstaculo = randomObstaculos.Next(1, 3);
            int ubicacionObstaculo = randomObstaculos.Next(1, 3);

            int distanciaUbicacionObstaculo = (ubicacionObstaculo == 1) ? distanciauno : distanciados;

            PictureBox pb = new PictureBox();
            pb.Location = new Point(distanciaUbicacionObstaculo, 0);
            pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("Obstaculo"+numeroAuto+tipoObstaculo);
            pb.BackColor = Color.Transparent;
            pb.Tag = numeroAuto + "_" + tipoObstaculo;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;

            listObstaculos.Add(pb);
            panelJuegoUno.Controls.Add(pb);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Auto.Image = (animacionAuto == 0) ? Properties.Resources.Auto : Properties.Resources.Auto;
            animacionAuto = (animacionAuto == 0) ? 1 : 0;

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int cambioCarril = (Auto.Location.X == 180) ? 10 : 180;
            Auto.Location = new Point(cambioCarril, Auto.Location.Y);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            /*foreach (PictureBox imagenAuto in listObstaculos)
            {
                int movimientoY;
                movimientoY = imagenAuto.Location.Y;
                movimientoY = movimientoY + velocidad;
                imagenAuto.Location = new Point(imagenAuto.Location.X, movimientoY);
            }

            if(listObstaculos.Count > 0)
            {
                if (listObstaculos[(listObstaculos.Count) - 1].Location.Y > 259)
                {
                    CrearObstaculo(listObstaculos, this, 10, 80);
                }
            }

            
            if(listObstaculos.Count > 0)
            {
                for (int i = 0; i < listObstaculos.Count; i++)
                {
                    //si los elementos no chocaron
                    if (listObstaculos[i].Tag.ToString() == "1_1")
                    {
                        ReiniciarJuego();
                    }
                    this.Controls.Remove(listObstaculos[i]);
                    listObstaculos.Remove(listObstaculos[i]);

                    //si los elementos chocaron
                    if (listObstaculos[i].Tag.ToString() == "1_1")
                    {
                        this.Controls.Remove(listObstaculos[i]);
                        int totalPuntos = Convert.ToInt32(label1.Text) + 1;
                        if(totalPuntos % 2 == 0)
                        {
                            velocidad++;//incrementa velocidad
                        }
                        label1.Text = totalPuntos.ToString();
                        listObstaculos.Remove(listObstaculos[i]);
                    }
                    else
                    {
                        this.Controls.Remove(listObstaculos[i]);
                        listObstaculos.Remove(listObstaculos[i]);
                        ReiniciarJuego();
                    }
                }
            }

          
         */  
        }

        public void ReiniciarJuego()
        {
            label1.Text = "0";
            velocidad = 3;
        }
    }
}




