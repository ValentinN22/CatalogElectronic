using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogElectronic
{
    public partial class login : Form
    {


        //variabile
        public static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\database.mdf;Integrated Security=True;Connect Timeout=30";
        public static int IdProfesor;
        public static int IdElev;


        public login()
        {
            InitializeComponent();
        }


        private void login_Load(object sender, EventArgs e)
        {
            
            
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.Shown += new EventHandler(Form1_Shown);
            
        }
        #region tryFixFlickering
        private void Form1_Shown(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.loginImgFundal;
            panel2.Visible = true;
            Profesor.Enabled = true;
            Elev.Enabled = true;
            Profesor.Checked = true;
            tbox_password.Enabled = true;
            tbox_username.Enabled = true;
            btn_Confirm.Enabled = true;
        }
        #endregion
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by ValentinN21!");
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                string Uname = tbox_username.Text.ToString();
                string pass = tbox_password.Text.ToString();
                if (Elev.Checked == true)
                {
                    SqlConnection con = new SqlConnection(constr);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"Select * from Elev where usrname='" + Uname + "' and parola='" + pass + "'", con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {

                        string copie_idelev = dr[@"IdElev"].ToString();
                        IdElev = Convert.ToInt32(copie_idelev);
                        dr.Close();
                        Elev Elev = new Elev();
                        Elev.ShowDialog();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Datele introduse nu sunt corecte!");
                    }
                    con.Close();

                }
                else
                    if (Profesor.Checked == true)
                {
                    SqlConnection con = new SqlConnection(constr);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"Select * from Profesor where usrname='" + Uname + "' and parola='" + pass + "'", con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        string copie_IdProfesor = dr[@"IdProfesor"].ToString();
                        IdProfesor = Convert.ToInt32(copie_IdProfesor);
                        dr.Close();
                        Profesor prof = new Profesor();
                        prof.ShowDialog();
                        this.Hide();
                        //MessageBox.Show(copie_IdProfesor);
                        
                    }
                    else
                    {
                        MessageBox.Show("Datele introduse nu sunt corecte!");
                    }
                    con.Close();
                }
                else
                    MessageBox.Show("Selectati casuta corespunzatoare contului introdus!");
            }
            catch(Exception eee) { MessageBox.Show(eee.Message); }
        }
    }
}
