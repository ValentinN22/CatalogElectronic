namespace CatalogElectronic
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Exit = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boxStudenti = new System.Windows.Forms.ComboBox();
            this.addAbsente = new System.Windows.Forms.Button();
            this.addNote = new System.Windows.Forms.Button();
            this.dgv_Absente = new System.Windows.Forms.DataGridView();
            this.dgv_Note = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Absente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Note)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackgroundImage = global::CatalogElectronic.Properties.Resources.loginExit;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Location = new System.Drawing.Point(1223, 12);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(45, 44);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Back
            // 
            this.Back.BackgroundImage = global::CatalogElectronic.Properties.Resources.addBack_btn;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(45, 44);
            this.Back.TabIndex = 6;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Elev:";
            // 
            // boxStudenti
            // 
            this.boxStudenti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxStudenti.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxStudenti.FormattingEnabled = true;
            this.boxStudenti.Location = new System.Drawing.Point(207, 249);
            this.boxStudenti.Name = "boxStudenti";
            this.boxStudenti.Size = new System.Drawing.Size(327, 38);
            this.boxStudenti.TabIndex = 8;
            this.boxStudenti.SelectedIndexChanged += new System.EventHandler(this.boxStudenti_SelectedIndexChanged);
            // 
            // addAbsente
            // 
            this.addAbsente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addAbsente.BackColor = System.Drawing.Color.White;
            this.addAbsente.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.addAbsente.Location = new System.Drawing.Point(131, 476);
            this.addAbsente.Name = "addAbsente";
            this.addAbsente.Size = new System.Drawing.Size(427, 62);
            this.addAbsente.TabIndex = 11;
            this.addAbsente.Text = "Adauga absenta";
            this.addAbsente.UseVisualStyleBackColor = false;
            this.addAbsente.Click += new System.EventHandler(this.addAbsente_Click);
            // 
            // addNote
            // 
            this.addNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNote.BackColor = System.Drawing.Color.White;
            this.addNote.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNote.Location = new System.Drawing.Point(131, 320);
            this.addNote.Name = "addNote";
            this.addNote.Size = new System.Drawing.Size(427, 62);
            this.addNote.TabIndex = 12;
            this.addNote.Text = "Adauga note";
            this.addNote.UseVisualStyleBackColor = false;
            this.addNote.Click += new System.EventHandler(this.addNote_Click);
            // 
            // dgv_Absente
            // 
            this.dgv_Absente.AllowUserToAddRows = false;
            this.dgv_Absente.AllowUserToResizeColumns = false;
            this.dgv_Absente.AllowUserToResizeRows = false;
            this.dgv_Absente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Absente.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Absente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_Absente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Absente.GridColor = System.Drawing.Color.Black;
            this.dgv_Absente.Location = new System.Drawing.Point(995, 111);
            this.dgv_Absente.Name = "dgv_Absente";
            this.dgv_Absente.ReadOnly = true;
            this.dgv_Absente.RowHeadersVisible = false;
            this.dgv_Absente.Size = new System.Drawing.Size(225, 514);
            this.dgv_Absente.TabIndex = 13;
            this.dgv_Absente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Absente_CellContentClick);
            // 
            // dgv_Note
            // 
            this.dgv_Note.AllowUserToAddRows = false;
            this.dgv_Note.AllowUserToResizeColumns = false;
            this.dgv_Note.AllowUserToResizeRows = false;
            this.dgv_Note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Note.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Note.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_Note.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Note.GridColor = System.Drawing.Color.Black;
            this.dgv_Note.Location = new System.Drawing.Point(617, 111);
            this.dgv_Note.Name = "dgv_Note";
            this.dgv_Note.ReadOnly = true;
            this.dgv_Note.RowHeadersVisible = false;
            this.dgv_Note.Size = new System.Drawing.Size(378, 514);
            this.dgv_Note.TabIndex = 14;
            this.dgv_Note.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Note_CellContentClick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(131, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(427, 62);
            this.button1.TabIndex = 15;
            this.button1.Text = "Sterge Note";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.button2.Location = new System.Drawing.Point(131, 544);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(427, 62);
            this.button2.TabIndex = 16;
            this.button2.Text = "Sterge Absente";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CatalogElectronic.Properties.Resources.addImgFundal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_Note);
            this.Controls.Add(this.dgv_Absente);
            this.Controls.Add(this.addNote);
            this.Controls.Add(this.addAbsente);
            this.Controls.Add(this.boxStudenti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.btn_Exit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add";
            this.Text = "Add";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Absente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Note)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxStudenti;
        private System.Windows.Forms.Button addAbsente;
        private System.Windows.Forms.Button addNote;
        private System.Windows.Forms.DataGridView dgv_Absente;
        private System.Windows.Forms.DataGridView dgv_Note;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}