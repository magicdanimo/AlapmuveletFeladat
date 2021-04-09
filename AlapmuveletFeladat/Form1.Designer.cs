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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kerdes = new System.Windows.Forms.Label();
            this.viszajelzes = new System.Windows.Forms.Label();
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(628, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Válasz";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kérdések Száma: n db";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Próbálkozások Száma: n db";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Elért eredmény n%";
            // 
            // kerdes
            // 
            this.kerdes.AutoSize = true;
            this.kerdes.Location = new System.Drawing.Point(129, 174);
            this.kerdes.Name = "kerdes";
            this.kerdes.Size = new System.Drawing.Size(49, 13);
            this.kerdes.TabIndex = 7;
            this.kerdes.Text = "30+500=";
            // 
            // viszajelzes
            // 
            this.viszajelzes.AutoSize = true;
            this.viszajelzes.Location = new System.Drawing.Point(129, 280);
            this.viszajelzes.Name = "viszajelzes";
            this.viszajelzes.Size = new System.Drawing.Size(83, 13);
            this.viszajelzes.TabIndex = 8;
            this.viszajelzes.Text = "A válasz: helyes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viszajelzes);
            this.Controls.Add(this.kerdes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.probalkozasGomb);
            this.Controls.Add(this.probalkozas);
            this.Controls.Add(this.valasztottMuvelet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox valasztottMuvelet;
        private System.Windows.Forms.TextBox probalkozas;
        private System.Windows.Forms.Button probalkozasGomb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label kerdes;
        private System.Windows.Forms.Label viszajelzes;
    }
}

