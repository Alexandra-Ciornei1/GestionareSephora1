namespace Interfata_WindowsForms
{
    partial class FormAfisareProduse
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
            this.dataGridViewProduse = new System.Windows.Forms.DataGridView();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCautareA = new System.Windows.Forms.Button();
            this.InapoiB = new System.Windows.Forms.Button();
            this.txtCautareB = new System.Windows.Forms.TextBox();
            this.BtnModifica = new System.Windows.Forms.Button();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProduse
            // 
            this.dataGridViewProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nume,
            this.Pret,
            this.Cantitate,
            this.Categorie});
            this.dataGridViewProduse.Location = new System.Drawing.Point(35, 92);
            this.dataGridViewProduse.Name = "dataGridViewProduse";
            this.dataGridViewProduse.Size = new System.Drawing.Size(483, 178);
            this.dataGridViewProduse.TabIndex = 0;
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.Name = "Nume";
            // 
            // Pret
            // 
            this.Pret.HeaderText = "Pret";
            this.Pret.Name = "Pret";
            // 
            // Cantitate
            // 
            this.Cantitate.HeaderText = "Cantitate";
            this.Cantitate.Name = "Cantitate";
            // 
            // Categorie
            // 
            this.Categorie.HeaderText = "Categorie";
            this.Categorie.Name = "Categorie";
            // 
            // btnCautareA
            // 
            this.btnCautareA.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautareA.Location = new System.Drawing.Point(573, 45);
            this.btnCautareA.Name = "btnCautareA";
            this.btnCautareA.Size = new System.Drawing.Size(75, 23);
            this.btnCautareA.TabIndex = 1;
            this.btnCautareA.Text = "Cautare";
            this.btnCautareA.UseVisualStyleBackColor = true;
            // 
            // InapoiB
            // 
            this.InapoiB.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InapoiB.Location = new System.Drawing.Point(624, 400);
            this.InapoiB.Name = "InapoiB";
            this.InapoiB.Size = new System.Drawing.Size(75, 23);
            this.InapoiB.TabIndex = 2;
            this.InapoiB.Text = "Inapoi";
            this.InapoiB.UseVisualStyleBackColor = true;
            this.InapoiB.Click += new System.EventHandler(this.InapoiB_Click);
            // 
            // txtCautareB
            // 
            this.txtCautareB.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCautareB.Location = new System.Drawing.Point(442, 45);
            this.txtCautareB.Name = "txtCautareB";
            this.txtCautareB.Size = new System.Drawing.Size(100, 21);
            this.txtCautareB.TabIndex = 3;
            // 
            // BtnModifica
            // 
            this.BtnModifica.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifica.Location = new System.Drawing.Point(259, 400);
            this.BtnModifica.Name = "BtnModifica";
            this.BtnModifica.Size = new System.Drawing.Size(75, 23);
            this.BtnModifica.TabIndex = 4;
            this.BtnModifica.Text = "Modifica";
            this.BtnModifica.UseVisualStyleBackColor = true;
            this.BtnModifica.Click += new System.EventHandler(this.BtnModifica_Click);
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(60, 300);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(39, 15);
            this.lblNume.TabIndex = 5;
            this.lblNume.Text = "Nume";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPret.Location = new System.Drawing.Point(60, 326);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(29, 15);
            this.lblPret.TabIndex = 6;
            this.lblPret.Text = "Pret";
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantitate.Location = new System.Drawing.Point(60, 351);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(55, 15);
            this.lblCantitate.TabIndex = 7;
            this.lblCantitate.Text = "Cantitate";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorie.Location = new System.Drawing.Point(60, 375);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(57, 15);
            this.lblCategorie.TabIndex = 8;
            this.lblCategorie.Text = "Categorie";
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.Location = new System.Drawing.Point(142, 298);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 21);
            this.txtNume.TabIndex = 9;
            // 
            // txtPret
            // 
            this.txtPret.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPret.Location = new System.Drawing.Point(142, 326);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(100, 21);
            this.txtPret.TabIndex = 10;
            // 
            // txtCantitate
            // 
            this.txtCantitate.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantitate.Location = new System.Drawing.Point(142, 349);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(100, 21);
            this.txtCantitate.TabIndex = 11;
            // 
            // txtCategorie
            // 
            this.txtCategorie.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategorie.Location = new System.Drawing.Point(142, 375);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(100, 21);
            this.txtCategorie.TabIndex = 12;
            // 
            // FormAfisareProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.BtnModifica);
            this.Controls.Add(this.txtCautareB);
            this.Controls.Add(this.InapoiB);
            this.Controls.Add(this.btnCautareA);
            this.Controls.Add(this.dataGridViewProduse);
            this.Name = "FormAfisareProduse";
            this.Text = "FormAfisareProduse";
            this.Click += new System.EventHandler(this.btnCautareA_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProduse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pret;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantitate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorie;
        private System.Windows.Forms.Button btnCautareA;
        private System.Windows.Forms.Button InapoiB;
        private System.Windows.Forms.TextBox txtCautareB;
        private System.Windows.Forms.Button BtnModifica;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.TextBox txtCategorie;
    }
}