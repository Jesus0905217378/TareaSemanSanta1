using TareaSemanSanta1.Clase;
using System.Media;

namespace TareaSemanSanta1
{
    public partial class Form1 : Form
    {
        Carro carrito;
        public Form1()
        {
            InitializeComponent();
            carrito = new Carro("Nissan", 2022, 250, "Miguel");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelEstadoCarro.Text = carrito.EncenderMotor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelmsg.Text = carrito.acelerar();
        }

        private void buttonFrenar_Click(object sender, EventArgs e)
        {
            labelmsg.Text = carrito.frenar();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            SoundPlayer Player = new SoundPlayer();
            Player.SoundLocation = "C:/Users/Jesus Alberto/Downloads/DEJAME LLEGAR  Malacates Trebol Shop.wav";
            Player.Play();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            SoundPlayer Player = new SoundPlayer();
            Player.SoundLocation = "C:/Users/Jesus Alberto/Downloads/DEJAME LLEGAR  Malacates Trebol Shop.wav";
            Player.Stop();
        }

        private void buttonBocinar_Click(object sender, EventArgs e)
        {
            carrito.bocinar();
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            labelEstadoCarro.Text = carrito.ApagarMotor();
        }
    }
}

