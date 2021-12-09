using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        // nujno inicializacija, ne le deklaracija, ker če ne se nič ne premika!
        int hitrost = 20;
        int gravitacija = 5;
        int rezultat = 0;
       

        public Form1()
        {
            InitializeComponent();
           // playSimpleSound();
        }

       /* private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\StarWars3");
            simpleSound.Play();
        }*/
        private void eventUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode == Keys.Space)
            {
                case true:
                    gravitacija = 15;
                    break;
            }
        }

        private void eventDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode == Keys.Space)
            {
                case true:
                gravitacija = -15;
                    break;
            }

        }

        private void casovnikEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravitacija;
            pipaVrhNavzdol.Left -= hitrost;
            pipaVrh2.Left -= hitrost;
            pipaVrh3.Left -= hitrost;
            pipaDol2.Left -= hitrost;
            pipaDol3.Left -= hitrost;
               
            pipaDolNaVrh.Left -= hitrost;
            scoreText.Text = rezultat.ToString();

            if(pipaDolNaVrh.Right < -50 || pipaDol2.Right < -50 || pipaDol3.Right < -50)
            {
                pipaDolNaVrh.Left = 500;
                pipaDol2.Left = 500;
                pipaDol3.Left = 500;
                rezultat++;
            }
            if(pipaVrhNavzdol.Right < -80)
            {
                pipaVrhNavzdol.Left = 550;
                pipaVrh2.Left = 550;
                pipaVrh3.Left = 550;
                rezultat++;
            }

            if(flappyBird.Bounds.IntersectsWith(pipaDolNaVrh.Bounds) || (flappyBird.Bounds.IntersectsWith(pipaVrhNavzdol.Bounds) || (flappyBird.Bounds.IntersectsWith(tla.Bounds)
                || flappyBird.Bounds.IntersectsWith(pipaDol2.Bounds)) || flappyBird.Bounds.IntersectsWith(pipaDol3.Bounds)) || flappyBird.Bounds.IntersectsWith(pipaVrh2.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipaVrh3.Bounds))
                    {

                konecIgre();

            }


        }

        private void konecIgre()
        {
            timer1.Stop();
            scoreText.Text += "Konec igre, žal!";

          
        }

        private void pictureBox3_Click(object sender, EventArgs e) 
        {

        }

        private void flappyBird_Click(object sender, EventArgs e)
        {

        }

        private void pipaDol3_Click(object sender, EventArgs e)
        {

        }
    }
}
