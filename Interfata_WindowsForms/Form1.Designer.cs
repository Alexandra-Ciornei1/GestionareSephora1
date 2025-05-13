namespace Interfata_WindowsForms
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
            this.btnClienti = new System.Windows.Forms.Button();
            this.btnProduse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClienti
            // 
            this.btnClienti.BackColor = System.Drawing.Color.LightCoral;
            this.btnClienti.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienti.Location = new System.Drawing.Point(136, 180);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(171, 44);
            this.btnClienti.TabIndex = 0;
            this.btnClienti.Text = "Gestionare Clienti";
            this.btnClienti.UseVisualStyleBackColor = false;
            this.btnClienti.Click += new System.EventHandler(this.btnClienti_Click);
            // 
            // btnProduse
            // 
            this.btnProduse.BackColor = System.Drawing.Color.LightCoral;
            this.btnProduse.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduse.Location = new System.Drawing.Point(422, 180);
            this.btnProduse.Name = "btnProduse";
            this.btnProduse.Size = new System.Drawing.Size(162, 44);
            this.btnProduse.TabIndex = 1;
            this.btnProduse.Text = "Gestionare produse";
            this.btnProduse.UseVisualStyleBackColor = false;
            this.btnProduse.Click += new System.EventHandler(this.btnProduse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProduse);
            this.Controls.Add(this.btnClienti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClienti;
        private System.Windows.Forms.Button btnProduse;

    }
}

