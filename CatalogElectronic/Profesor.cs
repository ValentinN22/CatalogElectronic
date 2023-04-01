using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogElectronic
{
    public partial class Profesor : Form
    {
        public Profesor()
        {
            InitializeComponent();
        }

        public static string constr = login.constr;
        
        public static int checkID = 0;
        public void checkAcces(int tag)
        {
            SqlConnection con = new SqlConnection(constr);
            int isGranted = 0;
            string comanda = "Select IdClasa from Orar where IdProfesor = " + login.IdProfesor;
            con.Open();
            SqlCommand cmd = new SqlCommand(comanda, con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read() != false)
            {
                checkID = read.GetInt32(0);
                if (checkID == tag)
                {
                    isGranted = 1;
                    Add nota = new Add();
                    nota.Show();
                    break;
                }

            }
            if (isGranted == 0) MessageBox.Show("Fara Acces!");
            con.Close();
        }


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cls5_Click(object sender, EventArgs e)
        {
            checkAcces(50);
        }

        private void cls124_Click(object sender, EventArgs e)
        {
            checkAcces(124);
        }

        private void cls123_Click(object sender, EventArgs e)
        {
            checkAcces(123);
        }

        private void cls122_Click(object sender, EventArgs e)
        {
            checkAcces(122);
        }

        private void cls115_Click(object sender, EventArgs e)
        {
            checkAcces(115);
        }

        private void cls114_Click(object sender, EventArgs e)
        {
            checkAcces(114);
        }

        private void cls113_Click(object sender, EventArgs e)
        {
            checkAcces(113);
        }

        private void cls112_Click(object sender, EventArgs e)
        {
            checkAcces(112);
        }

        private void cls105_Click(object sender, EventArgs e)
        {
            checkAcces(105);
        }

        private void cls104_Click(object sender, EventArgs e)
        {
            checkAcces(104);
        }

        private void cls103_Click(object sender, EventArgs e)
        {
            checkAcces(103);

        }

        private void cls102_Click(object sender, EventArgs e)
        {
            checkAcces(102);
        }

        private void cls95_Click(object sender, EventArgs e)
        {
            checkAcces(95);
        }

        private void cls94_Click(object sender, EventArgs e)
        {
            checkAcces(94);
        }

        private void cls93_Click(object sender, EventArgs e)
        {
            checkAcces(93);
        }

        private void cls92_Click(object sender, EventArgs e)
        {
            checkAcces(92);
        }

        private void cls121_Click(object sender, EventArgs e)
        {
            checkAcces(121);
        }

        private void cls111_Click(object sender, EventArgs e)
        {
            checkAcces(111);
        }

        private void cls101_Click(object sender, EventArgs e)
        {
            checkAcces(101);
        }

        private void cls91_Click(object sender, EventArgs e)
        {
            checkAcces(91);
        }

        private void cls8_Click(object sender, EventArgs e)
        {
            checkAcces(80);
        }

        private void cls6_Click(object sender, EventArgs e)
        {
            checkAcces(60);
        }

        private void cls7_Click(object sender, EventArgs e)
        {
            checkAcces(70);
        }

        private void cls125_Click(object sender, EventArgs e)
        {
            checkAcces(125);
        }

        private void Profesor_Load(object sender, EventArgs e)
        {

        }
    }
}
