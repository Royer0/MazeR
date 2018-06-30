using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        void MoveToStart()
        {
            Point startPoint = panel1.Location;//imleçin başlangıç noktası için startPoint adında Point türünde bir değişken tanımlayıp panel1 in lokasyonuna eşitledik
            startPoint.Offset(10, 10);//imleç başlangıç noktası için 10x ve 10y koordinatlarını belirledik.
            Cursor.Position = PointToScreen(startPoint);//imleçin başlangıç pozisyonunu ekranın startPoint koordinatlarında çıkması için eşitledik.
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler!!!");//imleç label15 in (SON) üzerine geldiğinde mesaj boxdan bize "Tebrikler!!!" mesajı verecek 
            Close();//Mesajbox kapatıldığında programın kapatılmasını sağladık.
        }
        int flag = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                label14.Enabled = true;
                label14.Visible = true;
                flag = 1;
            }
            else
            {
                label14.Enabled = false;
                label14.Visible = false;
                flag = 0;
            }
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }
}
