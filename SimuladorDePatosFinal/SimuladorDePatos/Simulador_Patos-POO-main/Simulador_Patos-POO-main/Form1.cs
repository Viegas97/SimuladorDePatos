using System;
using System.Drawing;
using System.Windows.Forms;
namespace Simulador_Patos_POO
{
    public partial class Form1 : Form
    {
        public int index = 0;

        public Form1()
        {
            InitializeComponent();
            index = 0;
            EscolherPato();
        }

        private void EscolherPato()
        {
            switch (index) 
            {
                case 0:
                    ImagemPato.Load("https://ndow-production-media.s3-us-gov-west-1.amazonaws.com/wp-content/uploads/2021/10/anas_platyrhynchos.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;
                    display_Pato.Text = "Mallard duck";                
                    this.BackColor = Color.LightGreen; // Mallard Duck - Verde
                    break;
                case 1:
                    ImagemPato.Load("https://fox4kc.com/wp-content/uploads/sites/16/2023/06/Worlds-Largest-Rubber-Duck.jpg?w=661");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;
                    display_Pato.Text = "Rubber duck";                   
                    this.BackColor = Color.Yellow; // Rubber Duck - Amarelo
                    break;
                case 2:
                    ImagemPato.Load("https://birdwatchingnc.com/wp-content/uploads/2024/02/Screenshot-2024-02-15-at-2.53.22%E2%80%AFPM.png");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;
                    display_Pato.Text = "Red head duck";
                    this.BackColor = Color.DarkRed; // Red Head Duck - Vermelho
                    break;
                case 3:
                    ImagemPato.Load("https://pm1.aminoapps.com/7254/3d9aabee363545e17505a85eead15ce8456d5133r1-720-719v2_uhq.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;
                    display_Pato.Text = "Fire Duck";
                    this.BackColor = Color.Orange; // Fire Duck - Laranja
                    break;
                case 4:
                    ImagemPato.Load("https://cdn.awsli.com.br/2500x2500/358/358188/produto/341313713/119-pato-de-madeira-h7nb55nrcw.jpg");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;
                    display_Pato.Text = "Wood Duck";
                    this.BackColor = Color.SaddleBrown; // Wood Duck - Marrom
                    break;
                case 5:
                    ImagemPato.Load("https://importacioneskurkich.com/cdn/shop/files/6e804353de21e7598629b475b107dcae405eb855-800.png?v=1731118893");
                    ImagemPato.SizeMode = PictureBoxSizeMode.Zoom;
                    display_Pato.Text = "Robot Duck";
                    this.BackColor = Color.MediumPurple; // Robot Duck - Cinza
                    break;
            }
        }
        private void Anterior_Click(object sender, EventArgs e)
        {
            if(index == 0)
            {
                index = 5;
            } else
            {
                index--;                
            }
            EscolherPato();
        }
        private void Proximo_Click(object sender, EventArgs e)
        {
            if(index < 5)
            {
                index++;
            } else
            {
                index = 0;
            }
            EscolherPato();
        }

        private void habilidade1_Click(object sender, EventArgs e)
        {

        }

        private void Escolhe_Pato_Click(object sender, EventArgs e)
        {                     

            Anterior.Visible = false;
            Proximo.Visible = false;

            hab1.Visible = true;
            hab2.Visible = true;
            hab3.Visible = true;

            menu.Visible = true;

            Escolhe_Pato.Visible = false;

            label1.Visible = false;
   
            CriarPato();
        }
        private void CriarPato()
        {         
            switch (index)
            {
                case 0:
                    MallardDuck patoMallard = new MallardDuck();
                    display_Pato.Text = patoMallard.display();
                    hab1.Text = patoMallard.quack();
                    hab2.Text = patoMallard.fly();
                    hab3.Text = patoMallard.Nadar();
                    break;
                case 1:
                    RubberDuck patoRubber = new RubberDuck();
                    display_Pato.Text = patoRubber.display();
                    hab1.Text = patoRubber.quack();
                    hab2.Visible = false;
                    hab3.Text = patoRubber.Nadar();
                    break;
                case 2:
                    RedHeadDuck patoRed = new RedHeadDuck();
                    display_Pato.Text = patoRed.display();
                    hab1.Text = patoRed.quack();
                    hab2.Text = patoRed.fly();
                    hab3.Text = patoRed.Nadar();
                    break;
                case 3:
                    FireDuck patoFire = new FireDuck();
                    display_Pato.Text = patoFire.display();
                    hab1.Text = patoFire.SoltarFogo();
                    hab2.Text = patoFire.fly();
                    hab3.Text = patoFire.quack();
                    break;
                case 4:
                    WoodDuck patoWood = new WoodDuck();
                    display_Pato.Text = patoWood.display();
                    hab1.Visible = false;
                    hab2.Text = patoWood.Reciclavel();
                    hab3.Visible = false;
                    break;
                case 5:
                    RobotDuck patoRobot = new RobotDuck();
                    display_Pato.Text = patoRobot.display();
                    hab1.Text = patoRobot.fly();
                    hab2.Text = patoRobot.quack();
                    hab3.Text= patoRobot.Enferrujar();
                    break;
            }           
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (index) 
            { 
                case 0:
                    MessageBox.Show("Quack!");
                    break;
                case 1:
                    MessageBox.Show("sons de borracha...");
                    break;

                case 2:
                    MessageBox.Show("Quack!");
                    break;

                case 3:
                    MessageBox.Show("Soltando fogo!");
                    break;

                case 4:
                    //sem habilidade
                    break;

                case 5:
                    MessageBox.Show("Olá!");
                    break;
            }
        }
        private void hab2_Click(object sender, EventArgs e)
        {
            switch (index)
            {
                case 0:
                    MessageBox.Show("Estou Voando!");
                    break;

                case 1:
                    //sem habilidade
                    break;

                case 2:
                    MessageBox.Show("Estou Voando!");
                    break;

                case 3:
                    MessageBox.Show("Estou voando!");
                    break;

                case 4:

                    MessageBox.Show("Sou reciclável!");
                    break;

                case 5:
                    MessageBox.Show("Estou voando!");
                    break;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            switch (index)
            {
                case 0:
                    MessageBox.Show("Estou nadando!");
                    break;

                case 1:
                    MessageBox.Show("Boiando!");
                    break;

                case 2:
                    MessageBox.Show("Estou nadando!");
                    break;

                case 3:
                    MessageBox.Show("Olá!");
                    break;

                case 4:
                    //sem habilidade
                    break;

                case 5:
                    MessageBox.Show("Posso enferrujar!");
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void menu_Click(object sender, EventArgs e)
        {
            EscolherPato();
            Anterior.Visible = true;
            Proximo.Visible = true;

            menu.Visible = false;

            hab1.Visible = false;
            hab2.Visible = false;
            hab3.Visible = false;

            Escolhe_Pato.Visible = true;
            label1.Visible = true;
        }

        private void ImagemPato_Click(object sender, EventArgs e)
        {
        }
        private void display_Pato_Click(object sender, EventArgs e)
        {
        }
    }
}
