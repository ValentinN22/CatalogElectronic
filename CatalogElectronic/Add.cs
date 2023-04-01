using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;


namespace CatalogElectronic
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        #region Variabile
        public DataGridViewButtonColumn deletebuttonColumnNote = new DataGridViewButtonColumn();
        public DataGridViewButtonColumn deletebuttonColumnabs = new DataGridViewButtonColumn();
        public static int idcls;
        public static int idProf = login.IdProfesor;
        public static int idel;
        public static int copie_idel;
        public static int idDisciplina;
        public static string username;
        #endregion
        #region ExitOrBack
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        void StyleDatagridview(DataGridView dataGridView1)
        {
            
            DataGridViewRow row = dataGridView1.RowTemplate;
            row.DefaultCellStyle.Font = new Font("Segoe UI", 15, FontStyle.Regular);
            row.DefaultCellStyle.BackColor = Color.White;
            row.DefaultCellStyle.ForeColor = Color.Black;
            row.Height = 35;
            row.MinimumHeight = 20;
            
            

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 16, FontStyle.Regular);
       

        }

        public void loadDataGridView(string usrnameElevi, int idProf)
        {

            SqlConnection con = new SqlConnection(login.constr);
            con.Open();
            string comanda = "Select IdElev from Elev where usrname = '" + usrnameElevi + "'" + "";
            SqlCommand cmd = new SqlCommand(comanda, con);
            idel = (int)cmd.ExecuteScalar();
            string comanda_nota = "Select IdNoteAbs,nota,data from NoteAbs where IdElev =" + idel + "and nota IS NOT NULL and IdProfesor =" + idProf;
            string comanda_absente = "Select IdNoteAbs,absenta from NoteAbs where IdElev =" + idel + "and absenta IS NOT NULL and IdProfesor =" + idProf;
            SqlDataAdapter daNote = new SqlDataAdapter(comanda_nota, con);
            SqlDataAdapter daAbs = new SqlDataAdapter(comanda_absente, con);
            DataSet note = new DataSet();
            DataSet absente = new DataSet();
            daNote.Fill(note, "Student");
            daAbs.Fill(absente, "Elev");

            if (note.Tables["Student"] != null)
            {
                dgv_Note.DataSource = note.Tables["Student"].DefaultView;
                if (dgv_Note.CurrentCell != null)
                    dgv_Note.CurrentCell.Selected = false;

            }
            if (absente.Tables["Elev"] != null)
            {
                dgv_Absente.DataSource = absente.Tables["Elev"].DefaultView;
                if (dgv_Absente.CurrentCell != null)
                    dgv_Absente.CurrentCell.Selected = false;
            }
            con.Close();


        }

        public void DeleteFromDataBase(int id) {
            SqlConnection con = new SqlConnection(login.constr);
            con.Open();
            string comanda =String.Format("Delete from NoteAbs where IdNoteAbs = {0}",id);
            SqlCommand cmd = new SqlCommand(comanda, con);
            cmd.ExecuteNonQuery();
            con.Close();
        
        }
        private void Add_Load(object sender, EventArgs e)
        {
            StyleDatagridview(dgv_Absente);
            StyleDatagridview(dgv_Note);
            boxStudenti.Enabled = true;
            addAbsente.Enabled = true;
            addNote.Enabled = true;
            
            string hex = "#ffecc4";
            Color color = System.Drawing.ColorTranslator.FromHtml(hex);
            label1.BackColor = color;
            //addNote.BackColor = color;addAbsente.BackColor = color;
            //StergeNota.BackColor = color;StergeAbsenta.BackColor = color;
            idcls = Profesor.checkID;
            string comanda = "Select usrname from Elev where IdClasa = " + idcls;
            string comanda2 = "Select IdDisciplina from Profesor where IdProfesor = " + idProf;
            SqlConnection con = new SqlConnection(login.constr);
            con.Open();
            SqlCommand cmd = new SqlCommand(comanda, con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (read.GetString(0) != null)
                    boxStudenti.Items.Add(read.GetString(0));
            }
            read.Close();
            if (boxStudenti.Items.Count == 0)
            {
                MessageBox.Show("Nu exista elevi inregistrati in aceasta clasa!");
                boxStudenti.Enabled = false;
                addAbsente.Enabled = false;
                addNote.Enabled = false;
        
            }
            else boxStudenti.SelectedIndex = 0;

            SqlCommand cmd2 = new SqlCommand(comanda2, con);
            SqlDataReader rd = cmd2.ExecuteReader();
            if (rd.Read()) idDisciplina = rd.GetInt32(0);
            rd.Close();
            con.Close();
            #region initializareColoaneDataGridView
            //coloana stergere nota sau absenta
            

            deletebuttonColumnNote.Name = "butonStergereNote";
            deletebuttonColumnNote.HeaderText = "Sterge";
            deletebuttonColumnNote.Text = "Sterge";
            deletebuttonColumnNote.UseColumnTextForButtonValue = true;

            deletebuttonColumnNote.Visible = false;

            
            deletebuttonColumnabs.Name = "butonStergereAbsente";
            deletebuttonColumnabs.HeaderText = "Sterge";
            deletebuttonColumnabs.Text = "Sterge";
            deletebuttonColumnabs.UseColumnTextForButtonValue = true;

            deletebuttonColumnabs.Visible = false;

            #endregion
            #region modificareDGV
            dgv_Note.Columns[1].Width = 50;
            dgv_Note.Columns[0].Visible = false;
            dgv_Note.Columns[1].HeaderText = "Nota";
            dgv_Note.Columns[2].HeaderText = "Data";
            dgv_Note.Columns.Add(deletebuttonColumnNote);
            dgv_Absente.Columns[0].Visible = false;
            dgv_Absente.Columns.Add(deletebuttonColumnabs);
            dgv_Absente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Note.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Absente.AllowUserToDeleteRows = true;
            dgv_Note.AllowUserToDeleteRows = true;
            #endregion

        }

        private void boxStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            username = boxStudenti.SelectedItem.ToString();
            loadDataGridView(username, idProf);
        }

        private void addNote_Click(object sender, EventArgs e)
        {
            
            AdaugaNota nt = new AdaugaNota(username, idel);
            nt.ShowDialog();
            this.Close();
        }

        private void addAbsente_Click(object sender, EventArgs e)
        {
            
            AdaugaAbsenta abs = new AdaugaAbsenta(username, idel);
            abs.ShowDialog();
            this.Close();
        }


        private void dgv_Note_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string text = "Motivul pentru care doriti sa stergeti nota:";
            string titlu = "Motivare stergere";
            if (e.ColumnIndex >= 0)
                if (dgv_Note.Columns[e.ColumnIndex].Name == "butonStergereNote")
                {
                    string motiv = Interaction.InputBox(text, titlu, default, 760, 540);
                    if (motiv != "")
                    {
                        
                        string identifier = dgv_Note.Rows[index].Cells["IdNoteAbs"].Value.ToString();
                        MessageBox.Show(identifier);
                        int id = Convert.ToInt32(identifier);
                        dgv_Note.Rows.RemoveAt(index);
                        DeleteFromDataBase(id);
                    }
                    else MessageBox.Show("Introduceti un motiv pentru confirmarea stergerii!");
                }    

        }

        private void dgv_Absente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string text = "Motivul pentru care doriti sa stergeti nota:";
            string titlu = "Motivare stergere";
            if (e.ColumnIndex >= 0)
                if (dgv_Absente.Columns[e.ColumnIndex].Name == "butonStergereAbsente")
                {
                    string motiv = Interaction.InputBox(text, titlu, default, 760, 540);
                    if (motiv != "")
                    {
                        string identifier = dgv_Absente.Rows[index].Cells["IdNoteAbs"].Value.ToString();
                        int id = Convert.ToInt32(identifier);
                        dgv_Absente.Rows.RemoveAt(index);
                        DeleteFromDataBase(id);
                    }
                    else MessageBox.Show("Introduceti un motiv pentru confirmarea stergerii!");
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deletebuttonColumnNote.Visible = true;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            deletebuttonColumnabs.Visible = true;
        }
    }
}
