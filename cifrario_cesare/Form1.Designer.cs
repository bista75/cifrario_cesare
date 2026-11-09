namespace cifrario_cesare
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_n1 = new System.Windows.Forms.Button();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.lbl_n4 = new System.Windows.Forms.Label();
            this.lbl_n5 = new System.Windows.Forms.Label();
            this.txt_n3 = new System.Windows.Forms.TextBox();
            this.lbl_n6 = new System.Windows.Forms.Label();
            this.txt_n4 = new System.Windows.Forms.TextBox();
            this.btn_n2 = new System.Windows.Forms.Button();
            this.lbl_n7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_n1
            // 
            this.btn_n1.Location = new System.Drawing.Point(12, 182);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(97, 37);
            this.btn_n1.TabIndex = 0;
            this.btn_n1.Text = "<CRIPTA>";
            this.btn_n1.UseVisualStyleBackColor = true;
            this.btn_n1.Click += new System.EventHandler(this.btn_n1_Click);
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_n1.Location = new System.Drawing.Point(7, 54);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(152, 18);
            this.lbl_n1.TabIndex = 1;
            this.lbl_n1.Text = "Inserire una stringa";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(12, 75);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(124, 20);
            this.txt_n1.TabIndex = 2;
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_n2.Location = new System.Drawing.Point(9, 126);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(150, 18);
            this.lbl_n2.TabIndex = 3;
            this.lbl_n2.Text = "Inserire la chiave >";
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n3.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_n3.Location = new System.Drawing.Point(115, 194);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(80, 18);
            this.lbl_n3.TabIndex = 5;
            this.lbl_n3.Text = "Risultato:";
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(165, 127);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(100, 20);
            this.txt_n2.TabIndex = 6;
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n4.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_n4.Location = new System.Drawing.Point(246, 20);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(219, 24);
            this.lbl_n4.TabIndex = 7;
            this.lbl_n4.Text = "CIFRARIO DI CESARE";
            // 
            // lbl_n5
            // 
            this.lbl_n5.AutoSize = true;
            this.lbl_n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n5.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_n5.Location = new System.Drawing.Point(481, 58);
            this.lbl_n5.Name = "lbl_n5";
            this.lbl_n5.Size = new System.Drawing.Size(142, 18);
            this.lbl_n5.TabIndex = 8;
            this.lbl_n5.Text = "Inserire un codice";
            // 
            // txt_n3
            // 
            this.txt_n3.Location = new System.Drawing.Point(484, 80);
            this.txt_n3.Name = "txt_n3";
            this.txt_n3.Size = new System.Drawing.Size(118, 20);
            this.txt_n3.TabIndex = 9;
            // 
            // lbl_n6
            // 
            this.lbl_n6.AutoSize = true;
            this.lbl_n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n6.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_n6.Location = new System.Drawing.Point(484, 133);
            this.lbl_n6.Name = "lbl_n6";
            this.lbl_n6.Size = new System.Drawing.Size(150, 18);
            this.lbl_n6.TabIndex = 10;
            this.lbl_n6.Text = "Inserire la chiave >";
            // 
            // txt_n4
            // 
            this.txt_n4.Location = new System.Drawing.Point(640, 134);
            this.txt_n4.Name = "txt_n4";
            this.txt_n4.Size = new System.Drawing.Size(100, 20);
            this.txt_n4.TabIndex = 11;
            // 
            // btn_n2
            // 
            this.btn_n2.Location = new System.Drawing.Point(484, 182);
            this.btn_n2.Name = "btn_n2";
            this.btn_n2.Size = new System.Drawing.Size(106, 37);
            this.btn_n2.TabIndex = 12;
            this.btn_n2.Text = "<CRIPTA>";
            this.btn_n2.UseVisualStyleBackColor = true;
            this.btn_n2.Click += new System.EventHandler(this.btn_n2_Click);
            // 
            // lbl_n7
            // 
            this.lbl_n7.AutoSize = true;
            this.lbl_n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n7.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_n7.Location = new System.Drawing.Point(596, 194);
            this.lbl_n7.Name = "lbl_n7";
            this.lbl_n7.Size = new System.Drawing.Size(80, 18);
            this.lbl_n7.TabIndex = 13;
            this.lbl_n7.Text = "Risultato:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 55);
            this.label1.TabIndex = 14;
            this.label1.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 55);
            this.label2.TabIndex = 15;
            this.label2.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 55);
            this.label3.TabIndex = 16;
            this.label3.Text = "|";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(758, 243);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_n7);
            this.Controls.Add(this.btn_n2);
            this.Controls.Add(this.txt_n4);
            this.Controls.Add(this.lbl_n6);
            this.Controls.Add(this.txt_n3);
            this.Controls.Add(this.lbl_n5);
            this.Controls.Add(this.lbl_n4);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.btn_n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_n1;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.Label lbl_n4;
        private System.Windows.Forms.Label lbl_n5;
        private System.Windows.Forms.TextBox txt_n3;
        private System.Windows.Forms.Label lbl_n6;
        private System.Windows.Forms.TextBox txt_n4;
        private System.Windows.Forms.Button btn_n2;
        private System.Windows.Forms.Label lbl_n7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

