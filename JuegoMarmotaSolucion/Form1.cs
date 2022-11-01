using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoMarmotaSolucion
{
    public partial class Form1 : Form
    {
        int NumeroMarmotaActual = 1;
        int TiempoNivel = 20;
        int Puntuacion = 0;
        int Fallas = 0;
        int LimiteFallas = 3;
        Random rnd = new Random();
        System.Media.SoundPlayer musicaFondo;

        public Form1()
        {
            InitializeComponent();
            Sonido("sonidoFondo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IniciarJuegoMarmota();
            System.IO.Stream audioFondo = Properties.Resources.sonidofondo;
            musicaFondo = new System.Media.SoundPlayer(audioFondo);
            musicaFondo.Play();
            this.pictureBox1.Image = Image.FromFile(@"C:\Users\Rodri\source\repos\JuegoMarmotaSolucion\ImagenesJuego\fondo.gif");
        }

        public void IniciarJuegoMarmota()
        {
            NumeroMarmotaActual = 1;
            TiempoNivel = 20;
            Puntuacion = 0;
            Fallas = 0;
            LimiteFallas = 3;
            this.lblPuntos.Text = "0";
            this.lblFallas.Text = "0";
            this.panelJuego.Controls.Clear();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var FichaJuego = new PictureBox();
                    FichaJuego.Image = Properties.Resources.AgujeroVacio;
                    FichaJuego.Name = string.Format("{0}", i + "_" + j);
                    FichaJuego.Dock = DockStyle.Fill;
                    FichaJuego.Cursor = Cursors.Hand;
                    FichaJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    FichaJuego.Click += Jugar;
                    FichaJuego.Tag = "No";
                    panelJuego.Controls.Add(FichaJuego, j, i);
                }
            }
            timer1.Start();
            timer2.Start();
        }

        private void Jugar(object sender, EventArgs e)
        {
            var fichaSeleccionadaUsuario = (PictureBox)sender;

            if (fichaSeleccionadaUsuario.Tag.ToString() != "No")
            {
                if (fichaSeleccionadaUsuario.Tag.ToString() == "marmota_" + NumeroMarmotaActual)
                {
                    Sonido("bien");
                    this.Puntuacion++;
                    this.lblPuntos.Text = Puntuacion.ToString();
                    this.timer1.Interval = timer1.Interval - TiempoNivel;
                }
                else
                {
                    Sonido("error");
                    this.Fallas++;
                    this.lblFallas.Text = Fallas.ToString();
                }
            }
            else
            {
                Sonido("error");
            }
        }

        public void Sonido(String NombreSonido)
        {
            var sonido = (Stream)Properties.Resources.ResourceManager.GetObject(NombreSonido);
            SoundPlayer SonidoCargado = new SoundPlayer(sonido);
            SonidoCargado.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    PictureBox pbOcultar = this.Controls.Find(i + "_" + j, true).FirstOrDefault() as PictureBox;
                    pbOcultar.Image = Properties.Resources.AgujeroVacio;
                    pbOcultar.Tag = "No";
                }
            }

            int rndColor = rnd.Next(1, 5);
            int rndi = rnd.Next(0, 3);
            int rndj = rnd.Next(0, 3);

            PictureBox pbx = this.Controls.Find(rndi + "_" + rndj, true).FirstOrDefault() as PictureBox;
            pbx.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("marmota_" + rndColor);

            pbx.Tag = "marmota_" + rndColor;

            if (Fallas == LimiteFallas)
            {
                timer1.Stop();
                MessageBox.Show("Juego terminado puntos = " + lblPuntos.Text);
                timer2.Stop();
                IniciarJuegoMarmota();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int numeroMarmota = rnd.Next(1, 5);
            NumeroMarmotaActual = numeroMarmota;
            this.pbxAtrapame.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("a" + NumeroMarmotaActual);
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola usuario..\nEl juego es sencillo,deberas pegarles a las marmotas que te apareces a tu derecha con el cartel de atraparme y asi sumar puntos." +
                "\nSolo tienes 3 vidas las cuales se descuentas si le pegas a una marmota distinta a la que se muestra a tu derecha\nSuerte!!!!","Informarcion!",MessageBoxButtons.OK,MessageBoxIcon.Question);
        }

        private void btn_cerrarApp_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir de la Aplicacion?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }


}
