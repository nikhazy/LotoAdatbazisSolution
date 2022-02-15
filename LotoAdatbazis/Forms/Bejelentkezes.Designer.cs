namespace LotoAdatbazis
{
    partial class Bejelentkezes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bejelentkezes));
            this.btnBejelentkezes = new System.Windows.Forms.Button();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbJelszo = new System.Windows.Forms.TextBox();
            this.panelHatter = new System.Windows.Forms.Panel();
            this.cbBelepVagyReg = new System.Windows.Forms.ComboBox();
            this.panelHatter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBejelentkezes
            // 
            this.btnBejelentkezes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBejelentkezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBejelentkezes.Location = new System.Drawing.Point(0, 205);
            this.btnBejelentkezes.Name = "btnBejelentkezes";
            this.btnBejelentkezes.Size = new System.Drawing.Size(350, 62);
            this.btnBejelentkezes.TabIndex = 0;
            this.btnBejelentkezes.Text = "Bejelentkezés";
            this.btnBejelentkezes.UseVisualStyleBackColor = true;
            this.btnBejelentkezes.Click += new System.EventHandler(this.btnBejelentkezes_Click);
            // 
            // tbNev
            // 
            this.tbNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNev.Location = new System.Drawing.Point(8, 87);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(324, 30);
            this.tbNev.TabIndex = 1;
            this.tbNev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNev_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(74, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bejelentkezési név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(129, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jelszó:";
            // 
            // tbJelszo
            // 
            this.tbJelszo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbJelszo.Location = new System.Drawing.Point(8, 150);
            this.tbJelszo.Name = "tbJelszo";
            this.tbJelszo.Size = new System.Drawing.Size(324, 30);
            this.tbJelszo.TabIndex = 3;
            this.tbJelszo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJelszo_KeyPress);
            // 
            // panelHatter
            // 
            this.panelHatter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHatter.Controls.Add(this.cbBelepVagyReg);
            this.panelHatter.Controls.Add(this.label2);
            this.panelHatter.Controls.Add(this.tbJelszo);
            this.panelHatter.Controls.Add(this.label1);
            this.panelHatter.Controls.Add(this.tbNev);
            this.panelHatter.Controls.Add(this.btnBejelentkezes);
            this.panelHatter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHatter.Location = new System.Drawing.Point(0, 83);
            this.panelHatter.Name = "panelHatter";
            this.panelHatter.Size = new System.Drawing.Size(350, 267);
            this.panelHatter.TabIndex = 5;
            // 
            // cbBelepVagyReg
            // 
            this.cbBelepVagyReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbBelepVagyReg.FormattingEnabled = true;
            this.cbBelepVagyReg.Items.AddRange(new object[] {
            "Meglévő fiókot használok",
            "Új fiókot hozok létre"});
            this.cbBelepVagyReg.Location = new System.Drawing.Point(8, 18);
            this.cbBelepVagyReg.Name = "cbBelepVagyReg";
            this.cbBelepVagyReg.Size = new System.Drawing.Size(324, 33);
            this.cbBelepVagyReg.TabIndex = 5;
            this.cbBelepVagyReg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbBelepVagyReg_KeyPress);
            // 
            // Bejelentkezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.panelHatter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 350);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "Bejelentkezes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezesi felület";
            this.Load += new System.EventHandler(this.Bejelentkezes_Load);
            this.panelHatter.ResumeLayout(false);
            this.panelHatter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBejelentkezes;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbJelszo;
        private System.Windows.Forms.Panel panelHatter;
        private System.Windows.Forms.ComboBox cbBelepVagyReg;
    }
}