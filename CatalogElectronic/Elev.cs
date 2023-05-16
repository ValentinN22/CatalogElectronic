using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogElectronic
{
    public partial class Elev : Form
    {
        public Elev()
        {
            InitializeComponent();
        }
        
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            con.Close();
            Application.Exit();
        }
        public static int idElev = login.IdElev;
        public SqlConnection con = new SqlConnection(login.constr);
        public void AddNote(int tag, DataGridView dataGridView1)
        {
            try
            {
                DataGridViewRow row = dataGridView1.RowTemplate;
                row.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                row.DefaultCellStyle.BackColor = Color.FromArgb(49, 69, 68);
                row.DefaultCellStyle.ForeColor = Color.White;
                row.Height = 35;
                row.MinimumHeight = 20;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(49, 69, 68);
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 12, FontStyle.Regular);
                string comanda = String.Format("Select nota,data from NoteAbs where IdElev = {0} and IdDisciplina = {1} and nota is not null", idElev, tag);
                SqlDataAdapter daNote = new SqlDataAdapter(comanda, con);
                DataSet note = new DataSet();
                daNote.Fill(note, "Student");
                if (note.Tables["Student"] != null)
                {
                    dataGridView1.DataSource = note.Tables["Student"].DefaultView;
                    if (dataGridView1.CurrentCell != null)
                        dataGridView1.CurrentCell.Selected = false;
                }
                
            }
            catch (Exception eee) { MessageBox.Show(eee.ToString()); }

        }

        public void AddAbsente(int tag, DataGridView dataGridView1)
        {
            try
            {
                DataGridViewRow row = dataGridView1.RowTemplate;
                row.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                row.DefaultCellStyle.BackColor = Color.FromArgb(49, 69, 68);
                row.DefaultCellStyle.ForeColor = Color.White;
                row.Height = 35;
                row.MinimumHeight = 20;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(49, 69, 68);
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 12, FontStyle.Regular);
                string comanda = String.Format("Select absenta from NoteAbs where IdElev = {0} and IdDisciplina = {1} and absenta is not null", idElev, tag);
                SqlDataAdapter daNote = new SqlDataAdapter(comanda, con);
                DataSet note = new DataSet();
                daNote.Fill(note, "Student");
                if (note.Tables["Student"] != null)
                {
                    dataGridView1.DataSource = note.Tables["Student"].DefaultView;
                    if (dataGridView1.CurrentCell != null)
                        dataGridView1.CurrentCell.Selected = false;
                }
                
            }
            catch (Exception eee) { MessageBox.Show(eee.ToString()); }

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Elev_Load(object sender, EventArgs e)
        {
            label2.Text = "Selectati materia!";
            this.dataGridView1.GridColor = Color.White;
            this.dataGridView2.GridColor = Color.White;
            con.Open();
            



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void Matematica_Click(object sender, EventArgs e)
        {
            label2.Text = "Matematica";
            AddNote(10, dataGridView1);
            AddAbsente(10, dataGridView2);

        }

        private void Informatica_Click(object sender, EventArgs e)
        {
            label2.Text = "Informatica";
            AddNote(11, dataGridView1);
            AddAbsente(11, dataGridView2);

        }

        private void Romana_Click(object sender, EventArgs e)
        {
            label2.Text = "Limba Romana";
            AddNote(12, dataGridView1);
            AddAbsente(12, dataGridView2);

        }

        private void Istorie_Click(object sender, EventArgs e)
        {
            label2.Text = "Istorie";
            AddNote(13, dataGridView1);
            AddAbsente(13, dataGridView2);

        }

        private void Geografie_Click(object sender, EventArgs e)
        {
            label2.Text = "Geografie";
            AddNote(14, dataGridView1);
            AddAbsente(14, dataGridView2);

        }

        private void Fizica_Click(object sender, EventArgs e)
        {
            label2.Text = "Fizica";
            AddNote(15, dataGridView1);
            AddAbsente(15, dataGridView2);
        }

        private void Chimie_Click(object sender, EventArgs e)
        {
            label2.Text = "Chimie";
            AddNote(16, dataGridView1);
            AddAbsente(16, dataGridView2);

        }

        private void Biologie_Click(object sender, EventArgs e)
        {
            label2.Text = "Biologie";
            AddNote(17, dataGridView1);
            AddAbsente(17, dataGridView2);
        }

        private void Sport_Click(object sender, EventArgs e)
        {
            label2.Text = "Sport";
            AddNote(18, dataGridView1);
            AddAbsente(18, dataGridView2);

        }

        private void Franceza_Click(object sender, EventArgs e)
        {
            label2.Text = "Limba Franceza/Germana";
            AddNote(19, dataGridView1);
            AddAbsente(19, dataGridView2);
        }

        private void Engleza_Click(object sender, EventArgs e)
        {
            label2.Text = "Limba Engleza";
            AddNote(20, dataGridView1);
            AddAbsente(20, dataGridView2);
        }

        private void StiinteSocioUmane_Click(object sender, EventArgs e)
        {
            label2.Text = "Stiinte Socio-Umane";
            AddNote(24, dataGridView1);
            AddAbsente(24, dataGridView2);

        }

        private void Logica_Click(object sender, EventArgs e)
        {
            label2.Text = "Logica";
            AddNote(23, dataGridView1);
            AddAbsente(23, dataGridView2);
        }

        private void Religie_Click(object sender, EventArgs e)
        {
            label2.Text = "Religie";
            AddNote(27, dataGridView1);
            AddAbsente(27, dataGridView2);
        }

        private void ArtePlastice_Click(object sender, EventArgs e)
        {
            label2.Text = "Arte Plastice";
            AddNote(22, dataGridView1);
            AddAbsente(22, dataGridView2);
        }

        private void Medie_Click(object sender, EventArgs e)
        {
            label2.Text = "Optional";
            AddNote(29,dataGridView1);
            AddAbsente(29,dataGridView2);
        }
    }
}
