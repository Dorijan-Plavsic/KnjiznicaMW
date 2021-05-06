
namespace KnjiznicaMw
{
    partial class Knjiznica
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
            this.lbUcenici = new System.Windows.Forms.Label();
            this.lbKnjige = new System.Windows.Forms.Label();
            this.lbPosudjeneKnjige = new System.Windows.Forms.Label();
            this.btnUcenici = new System.Windows.Forms.Button();
            this.btnKnjige = new System.Windows.Forms.Button();
            this.lbPK = new System.Windows.Forms.ListBox();
            this.btnPosudi = new System.Windows.Forms.Button();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnVrati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUcenici
            // 
            this.lbUcenici.AutoSize = true;
            this.lbUcenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUcenici.Location = new System.Drawing.Point(24, 34);
            this.lbUcenici.Name = "lbUcenici";
            this.lbUcenici.Size = new System.Drawing.Size(61, 20);
            this.lbUcenici.TabIndex = 0;
            this.lbUcenici.Text = "Učenici";
            // 
            // lbKnjige
            // 
            this.lbKnjige.AutoSize = true;
            this.lbKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKnjige.Location = new System.Drawing.Point(110, 34);
            this.lbKnjige.Name = "lbKnjige";
            this.lbKnjige.Size = new System.Drawing.Size(52, 20);
            this.lbKnjige.TabIndex = 1;
            this.lbKnjige.Text = "Knjige";
            // 
            // lbPosudjeneKnjige
            // 
            this.lbPosudjeneKnjige.AutoSize = true;
            this.lbPosudjeneKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosudjeneKnjige.Location = new System.Drawing.Point(24, 109);
            this.lbPosudjeneKnjige.Name = "lbPosudjeneKnjige";
            this.lbPosudjeneKnjige.Size = new System.Drawing.Size(130, 20);
            this.lbPosudjeneKnjige.TabIndex = 2;
            this.lbPosudjeneKnjige.Text = "Posuđene knjige:";
            // 
            // btnUcenici
            // 
            this.btnUcenici.Location = new System.Drawing.Point(191, 105);
            this.btnUcenici.Name = "btnUcenici";
            this.btnUcenici.Size = new System.Drawing.Size(80, 30);
            this.btnUcenici.TabIndex = 3;
            this.btnUcenici.Text = "Učenici";
            this.btnUcenici.UseVisualStyleBackColor = true;
            this.btnUcenici.Click += new System.EventHandler(this.btnUcenici_Click);
            // 
            // btnKnjige
            // 
            this.btnKnjige.Location = new System.Drawing.Point(292, 105);
            this.btnKnjige.Name = "btnKnjige";
            this.btnKnjige.Size = new System.Drawing.Size(80, 30);
            this.btnKnjige.TabIndex = 4;
            this.btnKnjige.Text = "Knjige";
            this.btnKnjige.UseVisualStyleBackColor = true;
            this.btnKnjige.Click += new System.EventHandler(this.btnKnjige_Click);
            // 
            // lbPK
            // 
            this.lbPK.FormattingEnabled = true;
            this.lbPK.Location = new System.Drawing.Point(28, 145);
            this.lbPK.Name = "lbPK";
            this.lbPK.Size = new System.Drawing.Size(332, 251);
            this.lbPK.TabIndex = 5;
            // 
            // btnPosudi
            // 
            this.btnPosudi.Location = new System.Drawing.Point(447, 145);
            this.btnPosudi.Name = "btnPosudi";
            this.btnPosudi.Size = new System.Drawing.Size(80, 30);
            this.btnPosudi.TabIndex = 6;
            this.btnPosudi.Text = "Posudi";
            this.btnPosudi.UseVisualStyleBackColor = true;
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.Location = new System.Drawing.Point(447, 190);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(80, 30);
            this.btnIzmijeni.TabIndex = 7;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            // 
            // btnVrati
            // 
            this.btnVrati.Location = new System.Drawing.Point(447, 280);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(80, 30);
            this.btnVrati.TabIndex = 8;
            this.btnVrati.Text = "Vrati";
            this.btnVrati.UseVisualStyleBackColor = true;
            // 
            // Knjiznica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.btnVrati);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.btnPosudi);
            this.Controls.Add(this.lbPK);
            this.Controls.Add(this.btnKnjige);
            this.Controls.Add(this.btnUcenici);
            this.Controls.Add(this.lbPosudjeneKnjige);
            this.Controls.Add(this.lbKnjige);
            this.Controls.Add(this.lbUcenici);
            this.Name = "Knjiznica";
            this.Text = "Knjiznica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUcenici;
        private System.Windows.Forms.Label lbKnjige;
        private System.Windows.Forms.Label lbPosudjeneKnjige;
        private System.Windows.Forms.Button btnUcenici;
        private System.Windows.Forms.Button btnKnjige;
        private System.Windows.Forms.ListBox lbPK;
        private System.Windows.Forms.Button btnPosudi;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnVrati;
    }
}

