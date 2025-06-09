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
            voltar_skills.Visible = false;
            skill_text.Visible = false;
            skill_text.AutoSize = false;
            skill_text.Size = new Size(300, 30);
            skill_text.Location = new Point(
                (this.ClientSize.Width - skill_text.Width) / 2,
                voltar_skills.Location.Y - skill_text.Height - 10
            );

            skill_text.TextAlign = ContentAlignment.MiddleCenter;
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
                    ImagemPato.Load("https://cdn.pixabay.com/photo/2023/03/14/08/34/duck-7851828_1280.jpg");
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
            skill_text.Visible = false;
            voltar_skills.Visible = false;
   
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
            skill_text.Visible = true;
            hab1.Visible = false;
            hab2.Visible = false;
            hab3.Visible = false;
            voltar_skills.Visible = true;

            switch (index)
            {
                case 0:
                    skill_text.Text = "Quack!";
                    break;
                case 1:
                    skill_text.Text = "sons de borracha...";
                    break;
                case 2:
                    skill_text.Text = "Quack!";
                    break;
                case 3:
                    skill_text.Text = "Soltando fogo!";
                    break;
                case 4:
                    skill_text.Text = ""; // Sem habilidade
                    break;
                case 5:
                    skill_text.Text = "Olá!";
                    break;
            }
        }


        private void hab2_Click(object sender, EventArgs e)
        {
            skill_text.Visible = true;
            hab1.Visible = false;
            hab2.Visible = false;
            hab3.Visible = false;
            voltar_skills.Visible = true;

            switch (index)
            {
                case 0:
                    skill_text.Text = "Estou Voando!";
                    break;
                case 1:
                    skill_text.Text = "";
                    break;
                case 2:
                    skill_text.Text = "Estou Voando!";
                    break;
                case 3:
                    skill_text.Text = "Estou voando!";
                    break;
                case 4:
                    skill_text.Text = "Sou reciclável!";
                    break;
                case 5:
                    skill_text.Text = "Estou voando!";
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            skill_text.Visible = true;
            hab1.Visible = false;
            hab2.Visible = false;
            hab3.Visible = false;
            voltar_skills.Visible = true;
            




            switch (index)
            {
                case 0:
                    skill_text.Text = "Estou nadando!";
                    break;
                case 1:
                    skill_text.Text = "Boiando!";
                    break;
                case 2:
                    skill_text.Text = "Estou nadando!";
                    break;
                case 3:
                    skill_text.Text = "Olá!";
                    break;
                case 4:
                    skill_text.Text = ""; // Sem habilidade
                    break;
                case 5:
                    skill_text.Text = "Posso enferrujar!";
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
            voltar_skills.Visible = false;
            skill_text.Visible = false;
        }

        private void ImagemPato_Click(object sender, EventArgs e)
        {
        }
        private void display_Pato_Click(object sender, EventArgs e)
        {
        }

        private void voltar_skills_Click(object sender, EventArgs e)
        {
            Anterior.Visible = false;
            Proximo.Visible = false;

            menu.Visible = true;

            Escolhe_Pato.Visible = false;
            label1.Visible = false;
            voltar_skills.Visible = false;
            skill_text.Visible = false;

            // Garantir que as habilidades sejam configuradas corretamente ao voltar
            switch (index)
            {
                case 0: // MallardDuck tem todas as habilidades
                case 2: // RedHeadDuck tem todas as habilidades
                case 3: // FireDuck tem todas as habilidades
                case 5: // RobotDuck tem todas as habilidades
                    hab1.Visible = true;
                    hab2.Visible = true;
                    hab3.Visible = true;
                    break;

                case 1: // RubberDuck não tem a segunda habilidade
                    hab1.Visible = true;
                    hab2.Visible = false;
                    hab3.Visible = true;
                    break;

                case 4: // WoodDuck não tem hab1 e hab3
                    hab1.Visible = false;
                    hab2.Visible = true;
                    hab3.Visible = false;
                    break;
            }
        }

        private void skill_text_Click(object sender, EventArgs e)
        {

        }
    }
}
