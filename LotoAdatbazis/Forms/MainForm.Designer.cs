
namespace LotoAdatbazis.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbVerzio = new System.Windows.Forms.ComboBox();
            this.cbTerulet = new System.Windows.Forms.ComboBox();
            this.cbGep = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGepSzam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnJelek = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOpenPdf = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.signCreatorMenu1 = new LotoAdatbazis.Forms.Controls.SignCreatorMenu();
            this.pbNikkoLogo = new System.Windows.Forms.PictureBox();
            this.pbDokuMegjelenes = new System.Windows.Forms.PictureBox();
            this.pdfViewer = new AxAcroPDFLib.AxAcroPDF();
            this.btnAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNikkoLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDokuMegjelenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 70);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.btnJelek);
            this.splitContainer1.Panel1.Controls.Add(this.btnOpen);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnOpenPdf);
            this.splitContainer1.Panel1.Controls.Add(this.pbLogo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.signCreatorMenu1);
            this.splitContainer1.Panel2.Controls.Add(this.pbNikkoLogo);
            this.splitContainer1.Panel2.Controls.Add(this.pbDokuMegjelenes);
            this.splitContainer1.Panel2.Controls.Add(this.pdfViewer);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 730);
            this.splitContainer1.SplitterDistance = 325;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cbVerzio, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbTerulet, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbGep, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbGepSzam, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 175);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(325, 235);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // cbVerzio
            // 
            this.cbVerzio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbVerzio.FormattingEnabled = true;
            this.cbVerzio.Location = new System.Drawing.Point(5, 208);
            this.cbVerzio.Margin = new System.Windows.Forms.Padding(5);
            this.cbVerzio.Name = "cbVerzio";
            this.cbVerzio.Size = new System.Drawing.Size(315, 28);
            this.cbVerzio.TabIndex = 27;
            this.cbVerzio.SelectedIndexChanged += new System.EventHandler(this.cbVerzio_SelectedIndexChanged);
            // 
            // cbTerulet
            // 
            this.cbTerulet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTerulet.FormattingEnabled = true;
            this.cbTerulet.Location = new System.Drawing.Point(5, 34);
            this.cbTerulet.Margin = new System.Windows.Forms.Padding(5);
            this.cbTerulet.Name = "cbTerulet";
            this.cbTerulet.Size = new System.Drawing.Size(315, 28);
            this.cbTerulet.TabIndex = 21;
            this.cbTerulet.SelectedIndexChanged += new System.EventHandler(this.cbTerulet_SelectedIndexChanged);
            // 
            // cbGep
            // 
            this.cbGep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbGep.FormattingEnabled = true;
            this.cbGep.Location = new System.Drawing.Point(5, 92);
            this.cbGep.Margin = new System.Windows.Forms.Padding(5);
            this.cbGep.Name = "cbGep";
            this.cbGep.Size = new System.Drawing.Size(315, 28);
            this.cbGep.TabIndex = 23;
            this.cbGep.SelectedIndexChanged += new System.EventHandler(this.cbGep_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Terület kiválasztása";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Gép kiválasztása";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Gépszám kiválasztása";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbGepSzam
            // 
            this.cbGepSzam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbGepSzam.FormattingEnabled = true;
            this.cbGepSzam.Location = new System.Drawing.Point(5, 150);
            this.cbGepSzam.Margin = new System.Windows.Forms.Padding(5);
            this.cbGepSzam.Name = "cbGepSzam";
            this.cbGepSzam.Size = new System.Drawing.Size(315, 28);
            this.cbGepSzam.TabIndex = 25;
            this.cbGepSzam.SelectedIndexChanged += new System.EventHandler(this.cbGepSzam_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Verzió kiválasztása";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJelek
            // 
            this.btnJelek.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnJelek.Location = new System.Drawing.Point(0, 550);
            this.btnJelek.Name = "btnJelek";
            this.btnJelek.Size = new System.Drawing.Size(325, 60);
            this.btnJelek.TabIndex = 27;
            this.btnJelek.Text = "Dokumentumhoz tartozó jelek kigyűjtése";
            this.btnJelek.UseVisualStyleBackColor = true;
            this.btnJelek.Click += new System.EventHandler(this.btnJelek_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOpen.Location = new System.Drawing.Point(0, 610);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(325, 60);
            this.btnOpen.TabIndex = 26;
            this.btnOpen.Text = "Kiválasztott PDF megnyitása";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelete.Location = new System.Drawing.Point(0, 670);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(325, 60);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Kiválasztott PDF törlése";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOpenPdf
            // 
            this.btnOpenPdf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPdf.Location = new System.Drawing.Point(0, 100);
            this.btnOpenPdf.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenPdf.Name = "btnOpenPdf";
            this.btnOpenPdf.Size = new System.Drawing.Size(325, 75);
            this.btnOpenPdf.TabIndex = 24;
            this.btnOpenPdf.Text = "PDF hozzáadása a programhoz";
            this.btnOpenPdf.UseVisualStyleBackColor = true;
            this.btnOpenPdf.Click += new System.EventHandler(this.btnOpenPdf_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(325, 100);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 23;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // signCreatorMenu1
            // 
            this.signCreatorMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.signCreatorMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.signCreatorMenu1.Location = new System.Drawing.Point(0, 0);
            this.signCreatorMenu1.Margin = new System.Windows.Forms.Padding(4);
            this.signCreatorMenu1.Name = "signCreatorMenu1";
            this.signCreatorMenu1.Size = new System.Drawing.Size(500, 730);
            this.signCreatorMenu1.TabIndex = 13;
            this.signCreatorMenu1.Visible = false;
            // 
            // pbNikkoLogo
            // 
            this.pbNikkoLogo.Location = new System.Drawing.Point(451, 659);
            this.pbNikkoLogo.Name = "pbNikkoLogo";
            this.pbNikkoLogo.Size = new System.Drawing.Size(200, 60);
            this.pbNikkoLogo.TabIndex = 12;
            this.pbNikkoLogo.TabStop = false;
            // 
            // pbDokuMegjelenes
            // 
            this.pbDokuMegjelenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDokuMegjelenes.Location = new System.Drawing.Point(0, 0);
            this.pbDokuMegjelenes.Name = "pbDokuMegjelenes";
            this.pbDokuMegjelenes.Size = new System.Drawing.Size(670, 730);
            this.pbDokuMegjelenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDokuMegjelenes.TabIndex = 11;
            this.pbDokuMegjelenes.TabStop = false;
            // 
            // pdfViewer
            // 
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.Enabled = true;
            this.pdfViewer.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfViewer.OcxState")));
            this.pdfViewer.Size = new System.Drawing.Size(670, 730);
            this.pdfViewer.TabIndex = 10;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(800, 23);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(200, 40);
            this.btnAdmin.TabIndex = 14;
            this.btnAdmin.Text = "Hozzáférések kezelése";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOTO Hungary Kft. PDF Adatbázis";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNikkoLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDokuMegjelenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnOpenPdf;
        private System.Windows.Forms.PictureBox pbLogo;
        private AxAcroPDFLib.AxAcroPDF pdfViewer;
        private System.Windows.Forms.PictureBox pbDokuMegjelenes;
        private System.Windows.Forms.PictureBox pbNikkoLogo;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnJelek;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbVerzio;
        private System.Windows.Forms.ComboBox cbTerulet;
        private System.Windows.Forms.ComboBox cbGep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGepSzam;
        private System.Windows.Forms.Label label4;
        private Controls.SignCreatorMenu signCreatorMenu1;
    }
}