namespace AlapmuveletFeladat
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
            this.valasztottMuvelet = new System.Windows.Forms.ComboBox();
            this.probalkozas = new System.Windows.Forms.TextBox();
            this.probalkozasGomb = new System.Windows.Forms.Button();
            this.valasz = new System.Windows.Forms.Button();
            this.kerdesekSzama = new System.Windows.Forms.Label();
            this.probakSzam = new System.Windows.Forms.Label();
            this.eredmeny = new System.Windows.Forms.Label();
            this.kerdes = new System.Windows.Forms.Label();
            this.viszajelzes = new System.Windows.Forms.Label();
            this.statisztika = new System.Windows.Forms.Panel();
            this.ujkerdes = new System.Windows.Forms.Button();
            this.statisztika.SuspendLayout();
            this.SuspendLayout();
            // 
            // valasztottMuvelet
            // 
            this.valasztottMuvelet.FormattingEnabled = true;
            this.valasztottMuvelet.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.valasztottMuvelet.Location = new System.Drawing.Point(132, 136);
            this.valasztottMuvelet.Name = "valasztottMuvelet";
            this.valasztottMuvelet.Size = new System.Drawing.Size(266, 21);
            this.valasztottMuvelet.TabIndex = 0;
            this.valasztottMuvelet.Text = "MüveletVálasztás";
            this.valasztottMuvelet.SelectedIndexChanged += new System.EventHandler(this.valasztottMuvelet_SelectedIndexChanged);
            // 
            // probalkozas
            // 
            this.probalkozas.Location = new System.Drawing.Point(197, 174);
            this.probalkozas.Name = "probalkozas";
            this.probalkozas.Size = new System.Drawing.Size(100, 20);
            this.probalkozas.TabIndex = 1;
            this.probalkozas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // probalkozasGomb
            // 
            this.probalkozasGomb.Location = new System.Drawing.Point(516, 374);
            this.probalkozasGomb.Name = "probalkozasGomb";
            this.probalkozasGomb.Size = new System.Drawing.Size(75, 23);
            this.probalkozasGomb.TabIndex = 2;
            this.probalkozasGomb.Text = "Próbálkozás";
            this.probalkozasGomb.UseVisualStyleBackColor = true;
            this.probalkozasGomb.Click += new System.EventHandler(this.probalkozas_Click);
            // 
            // valasz
            // 
            this.valasz.Location = new System.Drawing.Point(628, 374);
            this.valasz.Name = "valasz";
            this.valasz.Size = new System.Drawing.Size(75, 23);
            this.valasz.TabIndex = 3;
            this.valasz.Text = "Válasz";
            this.valasz.UseVisualStyleBackColor = true;
            this.valasz.Click += new System.EventHandler(this.button2_Click);
            // 
            // kerdesekSzama
            // 
            this.kerdesekSzama.AutoSize = true;
            this.kerdesekSzama.Location = new System.Drawing.Point(16, 20);
            this.kerdesekSzama.Name = "kerdesekSzama";
            this.kerdesekSzama.Size = new System.Drawing.Size(114, 13);
            this.kerdesekSzama.TabIndex = 4;
            this.kerdesekSzama.Text = "Kérdések Száma: 0 db";
            // 
            // probakSzam
            // 
            this.probakSzam.AutoSize = true;
            this.probakSzam.Location = new System.Drawing.Point(16, 45);
            this.probakSzam.Name = "probakSzam";
            this.probakSzam.Size = new System.Drawing.Size(139, 13);
            this.probakSzam.TabIndex = 5;
            this.probakSzam.Text = "Próbálkozások Száma: 0 db";
            // 
            // eredmeny
            // 
            this.eredmeny.AutoSize = true;
            this.eredmeny.Location = new System.Drawing.Point(16, 68);
            this.eredmeny.Name = "eredmeny";
            this.eredmeny.Size = new System.Drawing.Size(94, 13);
            this.eredmeny.TabIndex = 6;
            this.eredmeny.Text = "Elért eredmény 0%";
            // 
            // kerdes
            // 
            this.kerdes.AutoSize = true;
            this.kerdes.Location = new System.Drawing.Point(129, 177);
            this.kerdes.Name = "kerdes";
            this.kerdes.Size = new System.Drawing.Size(0, 13);
            this.kerdes.TabIndex = 7;
            // 
            // viszajelzes
            // 
            this.viszajelzes.AutoSize = true;
            this.viszajelzes.Location = new System.Drawing.Point(129, 241);
            this.viszajelzes.Name = "viszajelzes";
            this.viszajelzes.Size = new System.Drawing.Size(50, 13);
            this.viszajelzes.TabIndex = 8;
            this.viszajelzes.Text = "A válasz:";
            // 
            // statisztika
            // 
            this.statisztika.Controls.Add(this.kerdesekSzama);
            this.statisztika.Controls.Add(this.probakSzam);
            this.statisztika.Controls.Add(this.eredmeny);
            this.statisztika.Location = new System.Drawing.Point(516, 196);
            this.statisztika.Name = "statisztika";
            this.statisztika.Size = new System.Drawing.Size(200, 100);
            this.statisztika.TabIndex = 9;
            // 
            // ujkerdes
            // 
            this.ujkerdes.Location = new System.Drawing.Point(401, 374);
            this.ujkerdes.Name = "ujkerdes";
            this.ujkerdes.Size = new System.Drawing.Size(75, 23);
            this.ujkerdes.TabIndex = 10;
            this.ujkerdes.Text = "Újkérdés";
            this.ujkerdes.UseVisualStyleBackColor = true;
            this.ujkerdes.Click += new System.EventHandler(this.ujkerdes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ujkerdes);
            this.Controls.Add(this.statisztika);
            this.Controls.Add(this.viszajelzes);
            this.Controls.Add(this.kerdes);
            this.Controls.Add(this.valasz);
            this.Controls.Add(this.probalkozasGomb);
            this.Controls.Add(this.probalkozas);
            this.Controls.Add(this.valasztottMuvelet);
            this.Name = "Form1";
            this.Text = "Alap Müvelet Gyakorlás";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statisztika.ResumeLayout(false);
            this.statisztika.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox valasztottMuvelet;
        private System.Windows.Forms.TextBox probalkozas;
        private System.Windows.Forms.Button probalkozasGomb;
        private System.Windows.Forms.Button valasz;
        private System.Windows.Forms.Label kerdesekSzama;
        private System.Windows.Forms.Label probakSzam;
        private System.Windows.Forms.Label eredmeny;
        private System.Windows.Forms.Label kerdes;
        private System.Windows.Forms.Label viszajelzes;
        private System.Windows.Forms.Panel statisztika;
        private System.Windows.Forms.Button ujkerdes;
    }
}

