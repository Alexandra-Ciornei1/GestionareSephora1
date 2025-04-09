namespace Interfata_WindowsForms
{
    partial class FormProduse
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeProdus = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.btnAdaugaProdus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCategorie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInapoip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume produs";
            // 
            // txtNumeProdus
            // 
            this.txtNumeProdus.Location = new System.Drawing.Point(26, 108);
            this.txtNumeProdus.Name = "txtNumeProdus";
            this.txtNumeProdus.Size = new System.Drawing.Size(100, 20);
            this.txtNumeProdus.TabIndex = 1;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(167, 108);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(100, 20);
            this.txtPret.TabIndex = 2;
            // 
            // txtCantitate
            // 
            this.txtCantitate.Location = new System.Drawing.Point(299, 108);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(100, 20);
            this.txtCantitate.TabIndex = 3;
            // 
            // btnAdaugaProdus
            // 
            this.btnAdaugaProdus.BackColor = System.Drawing.Color.Thistle;
            this.btnAdaugaProdus.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaProdus.Location = new System.Drawing.Point(239, 153);
            this.btnAdaugaProdus.Name = "btnAdaugaProdus";
            this.btnAdaugaProdus.Size = new System.Drawing.Size(95, 23);
            this.btnAdaugaProdus.TabIndex = 4;
            this.btnAdaugaProdus.Text = "Adauga produs";
            this.btnAdaugaProdus.UseVisualStyleBackColor = false;
            this.btnAdaugaProdus.Click += new System.EventHandler(this.btnAdaugaProdus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantitate";
            // 
            // comboCategorie
            // 
            this.comboCategorie.FormattingEnabled = true;
            this.comboCategorie.Items.AddRange(new object[] {
            "Machiaj",
            "",
            "Skincare",
            "",
            "Parfumuri",
            "",
            "Bodycare",
            "",
            "Par",
            "",
            "Accesorii",
            "",
            "KoreanBeauty"});
            this.comboCategorie.Location = new System.Drawing.Point(428, 108);
            this.comboCategorie.Name = "comboCategorie";
            this.comboCategorie.Size = new System.Drawing.Size(121, 21);
            this.comboCategorie.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Categorie";
            // 
            // btnInapoip
            // 
            this.btnInapoip.BackColor = System.Drawing.Color.Thistle;
            this.btnInapoip.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInapoip.Location = new System.Drawing.Point(438, 270);
            this.btnInapoip.Name = "btnInapoip";
            this.btnInapoip.Size = new System.Drawing.Size(75, 23);
            this.btnInapoip.TabIndex = 10;
            this.btnInapoip.Text = "Inapoi";
            this.btnInapoip.UseVisualStyleBackColor = false;
            this.btnInapoip.Click += new System.EventHandler(this.btnInapoip_click);
            // 
            // FormProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInapoip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboCategorie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdaugaProdus);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtNumeProdus);
            this.Controls.Add(this.label1);
            this.Name = "FormProduse";
            this.Text = "FormProduse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeProdus;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.Button btnAdaugaProdus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCategorie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInapoip;
    }
}