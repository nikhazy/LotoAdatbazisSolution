namespace LotoAdatbazis
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAddPdf = new System.Windows.Forms.Button();
            this.cbTerulet = new System.Windows.Forms.ComboBox();
            this.cbGepSzam = new System.Windows.Forms.ComboBox();
            this.cbGep = new System.Windows.Forms.ComboBox();
            this.cbVerzio = new System.Windows.Forms.ComboBox();
            this.labelTerulet = new System.Windows.Forms.Label();
            this.labelGep = new System.Windows.Forms.Label();
            this.labelGepSzama = new System.Windows.Forms.Label();
            this.labelVerzio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.pdfViewer = new AxAcroPDFLib.AxAcroPDF();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewer)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPdf
            // 
            this.btnAddPdf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddPdf.Location = new System.Drawing.Point(0, 0);
            this.btnAddPdf.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPdf.MaximumSize = new System.Drawing.Size(0, 123);
            this.btnAddPdf.MinimumSize = new System.Drawing.Size(0, 123);
            this.btnAddPdf.Name = "btnAddPdf";
            this.btnAddPdf.Size = new System.Drawing.Size(533, 123);
            this.btnAddPdf.TabIndex = 1;
            this.btnAddPdf.Text = "PDF hozzáadása";
            this.btnAddPdf.UseVisualStyleBackColor = true;
            this.btnAddPdf.Click += new System.EventHandler(this.btnOpenPdf_Click);
            // 
            // cbTerulet
            // 
            this.cbTerulet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTerulet.FormattingEnabled = true;
            this.cbTerulet.Location = new System.Drawing.Point(16, 180);
            this.cbTerulet.Margin = new System.Windows.Forms.Padding(4);
            this.cbTerulet.Name = "cbTerulet";
            this.cbTerulet.Size = new System.Drawing.Size(508, 28);
            this.cbTerulet.TabIndex = 2;
            this.cbTerulet.SelectedIndexChanged += new System.EventHandler(this.cbTerulet_SelectedIndexChanged);
            // 
            // cbGepSzam
            // 
            this.cbGepSzam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGepSzam.FormattingEnabled = true;
            this.cbGepSzam.Location = new System.Drawing.Point(16, 316);
            this.cbGepSzam.Margin = new System.Windows.Forms.Padding(4);
            this.cbGepSzam.Name = "cbGepSzam";
            this.cbGepSzam.Size = new System.Drawing.Size(508, 28);
            this.cbGepSzam.TabIndex = 3;
            this.cbGepSzam.SelectedIndexChanged += new System.EventHandler(this.cbGepSzam_SelectedIndexChanged);
            // 
            // cbGep
            // 
            this.cbGep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGep.FormattingEnabled = true;
            this.cbGep.Location = new System.Drawing.Point(16, 245);
            this.cbGep.Margin = new System.Windows.Forms.Padding(4);
            this.cbGep.Name = "cbGep";
            this.cbGep.Size = new System.Drawing.Size(508, 28);
            this.cbGep.TabIndex = 4;
            this.cbGep.SelectedIndexChanged += new System.EventHandler(this.cbGep_SelectedIndexChanged);
            // 
            // cbVerzio
            // 
            this.cbVerzio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbVerzio.FormattingEnabled = true;
            this.cbVerzio.Location = new System.Drawing.Point(16, 380);
            this.cbVerzio.Margin = new System.Windows.Forms.Padding(4);
            this.cbVerzio.Name = "cbVerzio";
            this.cbVerzio.Size = new System.Drawing.Size(508, 28);
            this.cbVerzio.TabIndex = 5;
            this.cbVerzio.SelectedIndexChanged += new System.EventHandler(this.cbVerzio_SelectedIndexChanged);
            // 
            // labelTerulet
            // 
            this.labelTerulet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTerulet.AutoSize = true;
            this.labelTerulet.Location = new System.Drawing.Point(16, 156);
            this.labelTerulet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTerulet.Name = "labelTerulet";
            this.labelTerulet.Size = new System.Drawing.Size(188, 20);
            this.labelTerulet.TabIndex = 7;
            this.labelTerulet.Text = "Terület megnevezése";
            // 
            // labelGep
            // 
            this.labelGep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGep.AutoSize = true;
            this.labelGep.Location = new System.Drawing.Point(16, 225);
            this.labelGep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGep.Name = "labelGep";
            this.labelGep.Size = new System.Drawing.Size(163, 20);
            this.labelGep.TabIndex = 8;
            this.labelGep.Text = "Gép megnevezése";
            // 
            // labelGepSzama
            // 
            this.labelGepSzama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGepSzama.AutoSize = true;
            this.labelGepSzama.Location = new System.Drawing.Point(16, 297);
            this.labelGepSzama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGepSzama.Name = "labelGepSzama";
            this.labelGepSzama.Size = new System.Drawing.Size(104, 20);
            this.labelGepSzama.TabIndex = 9;
            this.labelGepSzama.Text = "Gép száma";
            // 
            // labelVerzio
            // 
            this.labelVerzio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVerzio.AutoSize = true;
            this.labelVerzio.Location = new System.Drawing.Point(16, 361);
            this.labelVerzio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVerzio.Name = "labelVerzio";
            this.labelVerzio.Size = new System.Drawing.Size(63, 20);
            this.labelVerzio.TabIndex = 10;
            this.labelVerzio.Text = "Verzió";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddPdf);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.MaximumSize = new System.Drawing.Size(533, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(533, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 536);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.cbVerzio);
            this.panel2.Controls.Add(this.cbGep);
            this.panel2.Controls.Add(this.labelTerulet);
            this.panel2.Controls.Add(this.labelGep);
            this.panel2.Controls.Add(this.cbGepSzam);
            this.panel2.Controls.Add(this.labelVerzio);
            this.panel2.Controls.Add(this.labelGepSzama);
            this.panel2.Controls.Add(this.cbTerulet);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel2.Location = new System.Drawing.Point(0, 154);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 413);
            this.panel2.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(0, 307);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(533, 106);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Kiválasztott PDF törlése adatbázisból";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOpen.Location = new System.Drawing.Point(0, 413);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.MaximumSize = new System.Drawing.Size(0, 123);
            this.btnOpen.MinimumSize = new System.Drawing.Size(0, 123);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(533, 123);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Kiválasztott dokumentum megnyitása";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pdfViewer
            // 
            this.pdfViewer.Enabled = true;
            this.pdfViewer.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer.Margin = new System.Windows.Forms.Padding(4);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfViewer.OcxState")));
            this.pdfViewer.Size = new System.Drawing.Size(312, 280);
            this.pdfViewer.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pdfViewer);
            this.panel3.Location = new System.Drawing.Point(590, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(525, 548);
            this.panel3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1145, 728);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "Form1";
            this.Text = "LOTO Hungary Kft.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPdf;
        private System.Windows.Forms.ComboBox cbTerulet;
        private System.Windows.Forms.ComboBox cbGepSzam;
        private System.Windows.Forms.ComboBox cbGep;
        private System.Windows.Forms.ComboBox cbVerzio;
        private System.Windows.Forms.Label labelTerulet;
        private System.Windows.Forms.Label labelGep;
        private System.Windows.Forms.Label labelGepSzama;
        private System.Windows.Forms.Label labelVerzio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private AxAcroPDFLib.AxAcroPDF pdfViewer;
        private System.Windows.Forms.Panel panel3;
    }
}

