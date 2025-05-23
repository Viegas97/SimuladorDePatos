using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_Patos_POO
{


    public partial class FormPatolino : Form
    {


        private Timer esconderImagem1Timer = new Timer();
        private Timer esconderImagemCalcaTimer = new Timer();
        private Timer esconderImagemShTimer = new Timer();

        private RobotDuck pato;
        public FormPatolino(RobotDuck pato)
        {
            InitializeComponent();
            this.pato = pato;

            Patolino1.Load("https://super.abril.com.br/wp-content/uploads/2022/02/AMP_patolino.png");
        }



        private void EsconderImagem1(object sender, EventArgs e)
        {
            Patolino1.Visible = false;
            esconderImagem1Timer.Stop();
            esconderImagem1Timer.Tick -= EsconderImagem1;
            Patolino1.Visible = true;
        }

        private void ReiniciarTimerEsconderPatolino1()
        {
            esconderImagem1Timer.Stop();
            esconderImagem1Timer.Tick -= EsconderImagem1;

            esconderImagem1Timer.Interval = 2000;
            esconderImagem1Timer.Tick += EsconderImagem1;
            esconderImagem1Timer.Start();
        }
        private void EsconderImagemCalca(object sender, EventArgs e)
        {
            PatolinoCalca.Visible = false;
            esconderImagemCalcaTimer.Stop();
            esconderImagemCalcaTimer.Tick -= EsconderImagemCalca;
        }
        private void EsconderImagemSh(object sender, EventArgs e)
        {

            PatolinoSh.Visible = false;
            esconderImagemShTimer.Stop();
            esconderImagemShTimer.Tick -= EsconderImagemSh;
        }

        private void RoupaPatolino_Click(object sender, EventArgs e)
        {
            string resultado = pato.fly();
            ToolTip tooltip = new ToolTip();
            tooltip.Show(resultado, this, PointToClient(Cursor.Position), 2000);

            Patolino1.Visible = false;

            PatolinoCalca.Load("https://i.pinimg.com/736x/50/06/0a/50060a4336ff8474e686ec0fbb2edb12.jpg");
            PatolinoCalca.Visible = true;
            PatolinoCalca.SizeMode = PictureBoxSizeMode.Zoom;

            esconderImagemCalcaTimer.Interval = 2000;
            esconderImagemCalcaTimer.Tick += EsconderImagemCalca;
            esconderImagemCalcaTimer.Start();

            esconderImagem1Timer.Interval = 2000;
            esconderImagem1Timer.Tick += EsconderImagem1;
            esconderImagem1Timer.Start();

            ReiniciarTimerEsconderPatolino1();
        }

        private void btnShopping_Click(object sender, EventArgs e)
        {
            string resultado = pato.fly();
            ToolTip tooltip = new ToolTip();
            tooltip.Show(resultado, this, PointToClient(Cursor.Position), 2000);

            Patolino1.Visible = false;

            PatolinoSh.Load("https://p2.trrsf.com/image/fget/cf/1200/1600/middle/images.terra.com/2023/08/27/436500820-i786680.jpeg");
            PatolinoSh.Visible = true;
            PatolinoSh.SizeMode = PictureBoxSizeMode.Zoom;

            esconderImagemShTimer.Interval = 2000;
            esconderImagemShTimer.Tick += EsconderImagemSh;
            esconderImagemShTimer.Start();

            esconderImagem1Timer.Interval = 2000;
            esconderImagem1Timer.Tick += EsconderImagem1;
            esconderImagem1Timer.Start();

            ReiniciarTimerEsconderPatolino1();
        }

        private void btnFecharTudo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void NovoPato_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
