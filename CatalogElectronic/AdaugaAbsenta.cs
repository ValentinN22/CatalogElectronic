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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CatalogElectronic
{
    public partial class AdaugaAbsenta : Form
    {
        public AdaugaAbsenta(string nume, int id)
        {
            InitializeComponent();
            username = nume;
            idElev = id;
        }
        public static int idcls = Add.idcls;
        public static int idprof = Add.idProf;
        public static int idDisciplina = Add.idDisciplina;
        public static string username;
        public static int idElev;
        private void AdaugaAbsenta_Load(object sender, EventArgs e)
        {
            Nume_Elev.Text = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(login.constr);
            con.Open();
            DateTime data = DateTime.Parse(dateTimePicker1.Value.ToString());
            string comanda = String.Format("Insert into NoteAbs(IdElev,IdDisciplina,IdProfesor,absenta,data) values({0},{1},{2},N'{3}',N'{4}')", idElev, idDisciplina, idprof, data, data);
            try
            {
                SqlCommand cmd = new SqlCommand(comanda, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Absenta adaugata cu succes!");
                Add add = new Add();
                add.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
