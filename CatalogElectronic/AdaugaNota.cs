using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace CatalogElectronic
{
    public partial class AdaugaNota : Form
    {
        public static int idcls = Add.idcls;
        public static int idprof = Add.idProf;
        public static int idDisciplina = Add.idDisciplina;
        public static string username;
        public static int idElev;
        
        public AdaugaNota()
        {
            InitializeComponent();
        }
        public AdaugaNota(string nume, int id)
        {
            InitializeComponent();
            username = nume;
            idElev = id;

        }

        private void AdaugaNota_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 9;
            Nume_Elev.Text = username;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Parse(dateTimePicker1.Value.ToString());
            SqlConnection con = new SqlConnection(login.constr);
            try
            {
                con.Open();
                string comanda = String.Format("Insert into NoteAbs(IdElev,IdDisciplina,IdProfesor,nota,data) values({0},{1},{2},{3},N'{4}')", idElev,idDisciplina,idprof,comboBox1.SelectedItem.ToString(),data);
                SqlCommand cmd = new SqlCommand(comanda, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nota adaugata cu succes!");
                Add add = new Add();
                add.Show();
                this.Close();
                con.Close();
                

            }
            catch (Exception eee) { MessageBox.Show(eee.Message); }
        }
    }
}
