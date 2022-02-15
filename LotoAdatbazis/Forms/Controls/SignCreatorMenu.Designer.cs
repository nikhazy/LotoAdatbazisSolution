
namespace LotoAdatbazis.Forms.Controls
{
    partial class SignCreatorMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbDeleteSigns = new System.Windows.Forms.CheckBox();
            this.cbJelMod2 = new System.Windows.Forms.ComboBox();
            this.cbJelMod = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbJelMeret = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokuJel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnJelMindenKijeloles = new System.Windows.Forms.Button();
            this.btnJelekDokuKeszites = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonHide = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.panel1.TabIndex = 17;
            // 
            // chbDeleteSigns
            // 
            this.chbDeleteSigns.AutoSize = true;
            this.chbDeleteSigns.Location = new System.Drawing.Point(22, 153);
            this.chbDeleteSigns.Name = "chbDeleteSigns";
            this.chbDeleteSigns.Size = new System.Drawing.Size(171, 21);
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
            this.cbJelMod2.Size = new System.Drawing.Size(362, 24);
            this.cbJelMod2.TabIndex = 8;
            this.cbJelMod2.SelectedIndexChanged += new System.EventHandler(this.cbJelMod2_SelectedIndexChanged);
            // 
            // cbJelMod
            // 
            this.cbJelMod.FormattingEnabled = true;
            this.cbJelMod.Items.AddRange(new object[] {
            "Csak a kiválasztott dokumentumból",
            "Jelek kigyűjtése több dokumentumból"});
            this.cbJelMod.Location = new System.Drawing.Point(22, 87);
            this.cbJelMod.Name = "cbJelMod";
            this.cbJelMod.Size = new System.Drawing.Size(362, 24);
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
            this.cbJelMeret.Size = new System.Drawing.Size(362, 24);
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
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
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
            // btnJelMindenKijeloles
            // 
            this.btnJelMindenKijeloles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnJelMindenKijeloles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJelMindenKijeloles.Location = new System.Drawing.Point(0, 603);
            this.btnJelMindenKijeloles.Name = "btnJelMindenKijeloles";
            this.btnJelMindenKijeloles.Size = new System.Drawing.Size(500, 30);
            this.btnJelMindenKijeloles.TabIndex = 18;
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
            this.btnJelekDokuKeszites.TabIndex = 15;
            this.btnJelekDokuKeszites.Text = "Dokumentum elkészítése";
            this.btnJelekDokuKeszites.UseVisualStyleBackColor = true;
            this.btnJelekDokuKeszites.Click += new System.EventHandler(this.btnJelekDokuKeszites_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHeader.Controls.Add(this.buttonHide);
            this.panelHeader.Controls.Add(this.label5);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(500, 50);
            this.panelHeader.TabIndex = 10;
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
            this.buttonHide.TabIndex = 3;
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
            this.label5.TabIndex = 2;
            this.label5.Text = "Jelek kigyűjtéséhez tartozó beállítások";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SignCreatorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnJelMindenKijeloles);
            this.Controls.Add(this.btnJelekDokuKeszites);
            this.Controls.Add(this.panelHeader);
            this.Name = "SignCreatorMenu";
            this.Size = new System.Drawing.Size(500, 733);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.CheckBox chbDeleteSigns;
        public System.Windows.Forms.ComboBox cbJelMod2;
        public System.Windows.Forms.ComboBox cbJelMod;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cbJelMeret;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        public System.Windows.Forms.DataGridViewCheckBoxColumn dokuJel;
        public System.Windows.Forms.Button btnJelMindenKijeloles;
        public System.Windows.Forms.Button btnJelekDokuKeszites;
        public System.Windows.Forms.Panel panelHeader;
        public System.Windows.Forms.Button buttonHide;
        public System.Windows.Forms.Label label5;
    }
}
