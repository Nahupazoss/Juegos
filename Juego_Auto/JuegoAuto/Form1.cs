using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Juego;
using JuegoAuto.Properties;

namespace JuegoAuto
{
    public partial class Form1 : Form
    {
        List<PictureBox> listImagenesJuego;
        SoundPlayer reproductor;
        Random randomObstaculos = new Random();
        int contadorFallos;
        int velocidad = 3;
        int puntaje;

        public Form1()
        {
            InitializeComponent();
            listImagenesJuego = new List<PictureBox>();
            CrearObstaculo(listImagenesJuego, this, 10, 180);
            puntaje = 0;
            contadorFallos = 3;
            reproductor = new SoundPlayer();
            label4.Text = contadorFallos.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                 
        }

        public void CrearObstaculo(List<PictureBox> listObstaculos, Form panelJuegoUno, int distanciauno, int distanciados)
        {
            int tipoObstaculo = randomObstaculos.Next(1, 3);
            int ubicacionObstaculo = randomObstaculos.Next(1, 3);
            int distanciaUbicacionObstaculo = (ubicacionObstaculo == 1) ? distanciauno : distanciados;
            string strObstaculo = GeneraSiNoRandom(tipoObstaculo);

            PictureBox pb = new PictureBox();
            pb.Location = new Point(distanciaUbicacionObstaculo, 0);
            pb.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(strObstaculo);
            pb.BackColor = Color.DarkGray;
            pb.Tag = strObstaculo;
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Size = new Size(150,100);

            listObstaculos.Add(pb);
            panelJuegoUno.Controls.Add(pb);
            pb.BringToFront();
        }

        public static string GeneraSiNoRandom(int entero)
        {
            string retorno;
            Random random = new Random();
            if (entero % 2 == 0)
            {
                retorno = "Obstaculo";
            }
            else
            {
                retorno = "Potenciador";
            }
            return retorno;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int cambioCarril = (Auto.Location.X == 180) ? 10 : 180;
            Auto.Location = new Point(cambioCarril, Auto.Location.Y);
            Auto.BringToFront();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox imagenAuto in listImagenesJuego)
            {
                int movimientoY;
                movimientoY = imagenAuto.Location.Y;
                movimientoY = movimientoY + velocidad;
                imagenAuto.Location = new Point(imagenAuto.Location.X, movimientoY);
            }

            if(listImagenesJuego.Count > 0)
            {
                if (listImagenesJuego[(listImagenesJuego.Count) - 1].Location.Y > 259)
                {
                    CrearObstaculo(listImagenesJuego, this, 10, 180);
                }
            }

            // Chequear colisiones
            for (int i = 0; i < listImagenesJuego.Count ; i++)
            {
                PictureBox pb = listImagenesJuego[i];
                // Auto es el PictureBox
                if (Auto.Bounds.IntersectsWith(pb.Bounds))
                {
                    if(pb.Tag.ToString() == "Obstaculo")
                    {
                        reproductor.Stream = Resources.ResourceManager.GetStream("SonidoObstaculo");
                        reproductor.Play();
                        velocidad = 3;
                        contadorFallos--;
                        this.label4.Text = contadorFallos.ToString();
                    }
                    else
                    {
                        if (pb.Tag.ToString() == "Potenciador")
                        {
                            reproductor.Stream = Resources.ResourceManager.GetStream("SonidoPotenciador");
                            reproductor.Play();
                            puntaje++;
                            velocidad++;
                            this.label1.Text = puntaje.ToString();
                        }
                    }
                    pb.Tag += "YaColisiono";
                    pb.Visible = false;
                    break;
                }
            }
            if(contadorFallos == 0)
            {
                reproductor.Stream = Resources.ResourceManager.GetStream("SonidoLosser");
                reproductor.Play();
                timer3.Enabled = false;
                DialogResult resultado = DialogResult.No;
                resultado = MessageBox.Show("Perdiste", "Perdedor,Queres jugar devuelta?", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    ReiniciarJuego();
                }
            }
            else
            {
                if (puntaje == 10)
                {
                    reproductor.Stream = Resources.ResourceManager.GetStream("SonidoWinner");
                    reproductor.Play();
                    timer3.Enabled = false;
                    DialogResult resultado = DialogResult.No;
                    resultado = MessageBox.Show("Ganaste!!","Deseas jugar devuelta?",MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {              
                        ReiniciarJuego();
                    }       
                }
            }
        }

        public void ReiniciarJuego()
        {
            label1.Text = "0";
            velocidad = 3;
            puntaje =  0;
            contadorFallos = 3;
            timer3.Enabled = true;
            int cantidad = listImagenesJuego.Count;
            for (int i = cantidad - 1; i >= 1; i--)
            {
                Controls.Remove(listImagenesJuego[i]);
                listImagenesJuego.RemoveAt(i);
            }
        }
    }
}
