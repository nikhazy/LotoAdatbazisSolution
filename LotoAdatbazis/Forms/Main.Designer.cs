namespace LotoAdatbazis
{
    partial class Main
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
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            catch
            {

            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbTerulet = new System.Windows.Forms.ComboBox();
            this.cbGep = new System.Windows.Forms.ComboBox();
            this.cbGepSzam = new System.Windows.Forms.ComboBox();
            this.cbVerzio = new System.Windows.Forms.ComboBox();
            this.panelBalMenu = new System.Windows.Forms.Panel();
            this.btnJelek = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOpenPdf = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pdfViewer = new AxAcroPDFLib.AxAcroPDF();
            this.pbDokuMegjelenes = new System.Windows.Forms.PictureBox();
            this.pbNikkoLogo = new System.Windows.Forms.PictureBox();
            this.panelPDFMenu = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokuJel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbDeleteSigns = new System.Windows.Forms.CheckBox();
            this.cbJelMod2 = new System.Windows.Forms.ComboBox();
            this.cbJelMod = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbJelMeret = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelPdfFejlec = new System.Windows.Forms.Panel();
            this.buttonHide = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnJelMindenKijeloles = new System.Windows.Forms.Button();
            this.btnJelekDokuKeszites = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panelBalMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDokuMegjelenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNikkoLogo)).BeginInit();
            this.panelPDFMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelPdfFejlec.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTerulet
            // 
            this.cbTerulet.FormattingEnabled = true;
            this.cbTerulet.Location = new System.Drawing.Point(13, 198);
            this.cbTerulet.Margin = new System.Windows.Forms.Padding(4);
            this.cbTerulet.Name = "cbTerulet";
            this.cbTerulet.Size = new System.Drawing.Size(291, 28);
            this.cbTerulet.TabIndex = 3;
            this.cbTerulet.SelectedIndexChanged += new System.EventHandler(this.cbTerulet_SelectedIndexChanged);
            // 
            // cbGep
            // 
            this.cbGep.FormattingEnabled = true;
            this.cbGep.Location = new System.Drawing.Point(13, 259);
            this.cbGep.Margin = new System.Windows.Forms.Padding(4);
            this.cbGep.Name = "cbGep";
            this.cbGep.Size = new System.Drawing.Size(291, 28);
            this.cbGep.TabIndex = 4;
            this.cbGep.SelectedIndexChanged += new System.EventHandler(this.cbGep_SelectedIndexChanged);
            // 
            // cbGepSzam
            // 
            this.cbGepSzam.FormattingEnabled = true;
            this.cbGepSzam.Location = new System.Drawing.Point(13, 321);
            this.cbGepSzam.Margin = new System.Windows.Forms.Padding(4);
            this.cbGepSzam.Name = "cbGepSzam";
            this.cbGepSzam.Size = new System.Drawing.Size(291, 28);
            this.cbGepSzam.TabIndex = 5;
            this.cbGepSzam.SelectedIndexChanged += new System.EventHandler(this.cbGepSzam_SelectedIndexChanged);
            // 
            // cbVerzio
            // 
            this.cbVerzio.FormattingEnabled = true;
            this.cbVerzio.Location = new System.Drawing.Point(16, 383);
            this.cbVerzio.Margin = new System.Windows.Forms.Padding(4);
            this.cbVerzio.Name = "cbVerzio";
            this.cbVerzio.Size = new System.Drawing.Size(291, 28);
            this.cbVerzio.TabIndex = 6;
            this.cbVerzio.SelectedIndexChanged += new System.EventHandler(this.cbVerzio_SelectedIndexChanged);
            // 
            // panelBalMenu
            // 
            this.panelBalMenu.Controls.Add(this.btnJelek);
            this.panelBalMenu.Controls.Add(this.btnOpen);
            this.panelBalMenu.Controls.Add(this.btnDelete);
            this.panelBalMenu.Controls.Add(this.btnOpenPdf);
            this.panelBalMenu.Controls.Add(this.pbLogo);
            this.panelBalMenu.Controls.Add(this.label4);
            this.panelBalMenu.Controls.Add(this.label3);
            this.panelBalMenu.Controls.Add(this.label2);
            this.panelBalMenu.Controls.Add(this.label1);
            this.panelBalMenu.Controls.Add(this.cbVerzio);
            this.panelBalMenu.Controls.Add(this.cbGepSzam);
            this.panelBalMenu.Controls.Add(this.cbGep);
            this.panelBalMenu.Controls.Add(this.cbTerulet);
            this.panelBalMenu.Location = new System.Drawing.Point(0, 64);
            this.panelBalMenu.Name = "panelBalMenu";
            this.panelBalMenu.Size = new System.Drawing.Size(325, 736);
            this.panelBalMenu.TabIndex = 8;
            // 
            // btnJelek
            // 
            this.btnJelek.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnJelek.Location = new System.Drawing.Point(0, 556);
            this.btnJelek.Name = "btnJelek";
            this.btnJelek.Size = new System.Drawing.Size(325, 60);
            this.btnJelek.TabIndex = 17;
            this.btnJelek.Text = "Dokumentumhoz tartozó jelek kigyűjtése";
            this.btnJelek.UseVisualStyleBackColor = true;
            this.btnJelek.Click += new System.EventHandler(this.btnJelek_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOpen.Location = new System.Drawing.Point(0, 616);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(325, 60);
            this.btnOpen.TabIndex = 16;
            this.btnOpen.Text = "Kiválasztott PDF megnyitása";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelete.Location = new System.Drawing.Point(0, 676);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(325, 60);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Kiválasztott PDF törlése";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOpenPdf
            // 
            this.btnOpenPdf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPdf.Location = new System.Drawing.Point(0, 100);
            this.btnOpenPdf.Name = "btnOpenPdf";
            this.btnOpenPdf.Size = new System.Drawing.Size(325, 60);
            this.btnOpenPdf.TabIndex = 14;
            this.btnOpenPdf.Text = "PDF hozzáadása a programhoz";
            this.btnOpenPdf.UseVisualStyleBackColor = true;
            this.btnOpenPdf.Click += new System.EventHandler(this.btnOpenPdf_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(325, 100);
            this.pbLogo.TabIndex = 13;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Verzió kiválasztása";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gépszám kiválasztása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gép kiválasztása";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Terület kiválasztása";
            // 
            // pdfViewer
            // 
            this.pdfViewer.Enabled = true;
            this.pdfViewer.Location = new System.Drawing.Point(325, 64);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfViewer.OcxState")));
            this.pdfViewer.Size = new System.Drawing.Size(563, 518);
            this.pdfViewer.TabIndex = 9;
            // 
            // pbDokuMegjelenes
            // 
            this.pbDokuMegjelenes.Location = new System.Drawing.Point(410, 150);
            this.pbDokuMegjelenes.Name = "pbDokuMegjelenes";
            this.pbDokuMegjelenes.Size = new System.Drawing.Size(500, 500);
            this.pbDokuMegjelenes.TabIndex = 10;
            this.pbDokuMegjelenes.TabStop = false;
            // 
            // pbNikkoLogo
            // 
            this.pbNikkoLogo.Location = new System.Drawing.Point(697, 688);
            this.pbNikkoLogo.Name = "pbNikkoLogo";
            this.pbNikkoLogo.Size = new System.Drawing.Size(200, 60);
            this.pbNikkoLogo.TabIndex = 11;
            this.pbNikkoLogo.TabStop = false;
            // 
            // panelPDFMenu
            // 
            this.panelPDFMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPDFMenu.Controls.Add(this.dataGridView1);
            this.panelPDFMenu.Controls.Add(this.panel1);
            this.panelPDFMenu.Controls.Add(this.panelPdfFejlec);
            this.panelPDFMenu.Controls.Add(this.btnJelMindenKijeloles);
            this.panelPDFMenu.Controls.Add(this.btnJelekDokuKeszites);
            this.panelPDFMenu.Location = new System.Drawing.Point(325, 64);
            this.panelPDFMenu.Name = "panelPDFMenu";
            this.panelPDFMenu.Size = new System.Drawing.Size(500, 733);
            this.panelPDFMenu.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileName,
            this.dokuJel});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(500, 373);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // fileName
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.fileName.DefaultCellStyle = dataGridViewCellStyle2;
            this.fileName.HeaderText = "Dokumentumok neve";
            this.fileName.MinimumWidth = 440;
            this.fileName.Name = "fileName";
            this.fileName.Width = 440;
            // 
            // dokuJel
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            this.dokuJel.DefaultCellStyle = dataGridViewCellStyle3;
            this.dokuJel.HeaderText = "";
            this.dokuJel.MinimumWidth = 40;
            this.dokuJel.Name = "dokuJel";
            this.dokuJel.Width = 40;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chbDeleteSigns);
            this.panel1.Controls.Add(this.cbJelMod2);
            this.panel1.Controls.Add(this.cbJelMod);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbJelMeret);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 180);
            this.panel1.TabIndex = 11;
            // 
            // chbDeleteSigns
            // 
            this.chbDeleteSigns.AutoSize = true;
            this.chbDeleteSigns.Location = new System.Drawing.Point(22, 153);
            this.chbDeleteSigns.Name = "chbDeleteSigns";
            this.chbDeleteSigns.Size = new System.Drawing.Size(199, 24);
            this.chbDeleteSigns.TabIndex = 9;
            this.chbDeleteSigns.Text = "Mentett jelek felülírása";
            this.chbDeleteSigns.UseVisualStyleBackColor = true;
            // 
            // cbJelMod2
            // 
            this.cbJelMod2.FormattingEnabled = true;
            this.cbJelMod2.Items.AddRange(new object[] {
            "Utasítás szöveges részéből",
            "Térkép mezőből"});
            this.cbJelMod2.Location = new System.Drawing.Point(21, 120);
            this.cbJelMod2.Name = "cbJelMod2";
            this.cbJelMod2.Size = new System.Drawing.Size(362, 28);
            this.cbJelMod2.TabIndex = 8;
            // 
            // cbJelMod
            // 
            this.cbJelMod.FormattingEnabled = true;
            this.cbJelMod.Items.AddRange(new object[] {
            "Csak a kiválasztott dokumentumból",
            "Jelek kigyűjtése több dokumentumból"});
            this.cbJelMod.Location = new System.Drawing.Point(22, 87);
            this.cbJelMod.Name = "cbJelMod";
            this.cbJelMod.Size = new System.Drawing.Size(362, 28);
            this.cbJelMod.TabIndex = 7;
            this.cbJelMod.SelectedIndexChanged += new System.EventHandler(this.cbJelMod_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Jelek kigyűjtésének módja";
            // 
            // cbJelMeret
            // 
            this.cbJelMeret.FormattingEnabled = true;
            this.cbJelMeret.Items.AddRange(new object[] {
            "1 cm x 1 cm",
            "2 cm x 2 cm",
            "3 cm x 3 cm",
            "4 cm x 4 cm",
            "5 cm x 5 cm"});
            this.cbJelMeret.Location = new System.Drawing.Point(22, 31);
            this.cbJelMeret.Name = "cbJelMeret";
            this.cbJelMeret.Size = new System.Drawing.Size(362, 28);
            this.cbJelMeret.TabIndex = 3;
            this.cbJelMeret.SelectedIndexChanged += new System.EventHandler(this.cbJelMeret_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Jelek mérete:";
            // 
            // panelPdfFejlec
            // 
            this.panelPdfFejlec.Controls.Add(this.buttonHide);
            this.panelPdfFejlec.Controls.Add(this.label5);
            this.panelPdfFejlec.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPdfFejlec.Location = new System.Drawing.Point(0, 0);
            this.panelPdfFejlec.Name = "panelPdfFejlec";
            this.panelPdfFejlec.Size = new System.Drawing.Size(500, 50);
            this.panelPdfFejlec.TabIndex = 1;
            // 
            // buttonHide
            // 
            this.buttonHide.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHide.Location = new System.Drawing.Point(400, 0);
            this.buttonHide.MaximumSize = new System.Drawing.Size(100, 50);
            this.buttonHide.MinimumSize = new System.Drawing.Size(100, 50);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(100, 50);
            this.buttonHide.TabIndex = 1;
            this.buttonHide.Text = "Vissza";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(500, 50);
            this.label5.TabIndex = 0;
            this.label5.Text = "Jelek kigyűjtéséhez tartozó beállítások";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnJelMindenKijeloles
            // 
            this.btnJelMindenKijeloles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnJelMindenKijeloles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJelMindenKijeloles.Location = new System.Drawing.Point(0, 603);
            this.btnJelMindenKijeloles.Name = "btnJelMindenKijeloles";
            this.btnJelMindenKijeloles.Size = new System.Drawing.Size(500, 30);
            this.btnJelMindenKijeloles.TabIndex = 12;
            this.btnJelMindenKijeloles.Text = "Minden dokumentum kiválasztása KI / BE";
            this.btnJelMindenKijeloles.UseVisualStyleBackColor = true;
            this.btnJelMindenKijeloles.Click += new System.EventHandler(this.btnJelMindenKijeloles_Click);
            // 
            // btnJelekDokuKeszites
            // 
            this.btnJelekDokuKeszites.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnJelekDokuKeszites.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJelekDokuKeszites.Location = new System.Drawing.Point(0, 633);
            this.btnJelekDokuKeszites.Name = "btnJelekDokuKeszites";
            this.btnJelekDokuKeszites.Size = new System.Drawing.Size(500, 100);
            this.btnJelekDokuKeszites.TabIndex = 9;
            this.btnJelekDokuKeszites.Text = "Dokumentum elkészítése";
            this.btnJelekDokuKeszites.UseVisualStyleBackColor = true;
            this.btnJelekDokuKeszites.Click += new System.EventHandler(this.btnJelekDokuKeszites_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(790, 24);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(200, 40);
            this.btnAdmin.TabIndex = 13;
            this.btnAdmin.Text = "Hozzáférések kezelése";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.panelPDFMenu);
            this.Controls.Add(this.pbNikkoLogo);
            this.Controls.Add(this.pbDokuMegjelenes);
            this.Controls.Add(this.pdfViewer);
            this.Controls.Add(this.panelBalMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOTO Hungary Kft. PDF Adatbázis";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.panelBalMenu.ResumeLayout(false);
            this.panelBalMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDokuMegjelenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNikkoLogo)).EndInit();
            this.panelPDFMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPdfFejlec.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbTerulet;
        private System.Windows.Forms.ComboBox cbGep;
        private System.Windows.Forms.ComboBox cbGepSzam;
        private System.Windows.Forms.ComboBox cbVerzio;
        private System.Windows.Forms.Panel panelBalMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AxAcroPDFLib.AxAcroPDF pdfViewer;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnOpenPdf;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pbDokuMegjelenes;
        private System.Windows.Forms.PictureBox pbNikkoLogo;
        private System.Windows.Forms.Button btnJelek;
        private System.Windows.Forms.Panel panelPDFMenu;
        private System.Windows.Forms.Panel panelPdfFejlec;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbJelMeret;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbJelMod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnJelekDokuKeszites;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnJelMindenKijeloles;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dokuJel;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.ComboBox cbJelMod2;
        private System.Windows.Forms.CheckBox chbDeleteSigns;
    }
}