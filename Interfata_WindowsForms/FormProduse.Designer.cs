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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduse));
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
            this.txtCautareP = new System.Windows.Forms.TextBox();
            this.btnCautareP = new System.Windows.Forms.Button();
            this.RezultateP = new System.Windows.Forms.ListBox();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelPret = new System.Windows.Forms.Label();
            this.labelCantitate = new System.Windows.Forms.Label();
            this.labelCategorie = new System.Windows.Forms.Label();
            this.errorNume = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPret = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCantitate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCategorie = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorNume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCantitate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume produs";
            // 
            // txtNumeProdus
            // 
            this.txtNumeProdus.Location = new System.Drawing.Point(76, 50);
            this.txtNumeProdus.Name = "txtNumeProdus";
            this.txtNumeProdus.Size = new System.Drawing.Size(100, 20);
            this.txtNumeProdus.TabIndex = 1;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(76, 101);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(100, 20);
            this.txtPret.TabIndex = 2;
            // 
            // txtCantitate
            // 
            this.txtCantitate.Location = new System.Drawing.Point(76, 159);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(100, 20);
            this.txtCantitate.TabIndex = 3;
            // 
            // btnAdaugaProdus
            // 
            this.btnAdaugaProdus.BackColor = System.Drawing.Color.Thistle;
            this.btnAdaugaProdus.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaProdus.Location = new System.Drawing.Point(197, 284);
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
            this.label2.Location = new System.Drawing.Point(102, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 141);
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
            this.comboCategorie.Location = new System.Drawing.Point(76, 223);
            this.comboCategorie.Name = "comboCategorie";
            this.comboCategorie.Size = new System.Drawing.Size(121, 21);
            this.comboCategorie.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Categorie";
            // 
            // btnInapoip
            // 
            this.btnInapoip.BackColor = System.Drawing.Color.Thistle;
            this.btnInapoip.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInapoip.Location = new System.Drawing.Point(650, 344);
            this.btnInapoip.Name = "btnInapoip";
            this.btnInapoip.Size = new System.Drawing.Size(75, 23);
            this.btnInapoip.TabIndex = 10;
            this.btnInapoip.Text = "Inapoi";
            this.btnInapoip.UseVisualStyleBackColor = false;
            this.btnInapoip.Click += new System.EventHandler(this.btnInapoip_click);
            // 
            // txtCautareP
            // 
            this.txtCautareP.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCautareP.Location = new System.Drawing.Point(482, 77);
            this.txtCautareP.Name = "txtCautareP";
            this.txtCautareP.Size = new System.Drawing.Size(100, 21);
            this.txtCautareP.TabIndex = 11;
            // 
            // btnCautareP
            // 
            this.btnCautareP.BackColor = System.Drawing.Color.Thistle;
            this.btnCautareP.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautareP.Location = new System.Drawing.Point(634, 75);
            this.btnCautareP.Name = "btnCautareP";
            this.btnCautareP.Size = new System.Drawing.Size(117, 23);
            this.btnCautareP.TabIndex = 12;
            this.btnCautareP.Text = "Cautare produs";
            this.btnCautareP.UseVisualStyleBackColor = false;
            this.btnCautareP.Click += new System.EventHandler(this.btnCautaP_Click);
            // 
            // RezultateP
            // 
            this.RezultateP.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RezultateP.FormattingEnabled = true;
            this.RezultateP.ItemHeight = 15;
            this.RezultateP.Location = new System.Drawing.Point(482, 151);
            this.RezultateP.Name = "RezultateP";
            this.RezultateP.Size = new System.Drawing.Size(306, 94);
            this.RezultateP.TabIndex = 13;
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume.ForeColor = System.Drawing.Color.Red;
            this.labelNume.Location = new System.Drawing.Point(252, 55);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(191, 15);
            this.labelNume.TabIndex = 14;
            this.labelNume.Text = "Numele produsului este obligatoriu!";
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPret.ForeColor = System.Drawing.Color.Red;
            this.labelPret.Location = new System.Drawing.Point(252, 106);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(124, 15);
            this.labelPret.TabIndex = 15;
            this.labelPret.Text = "Pretul este obligatoriu!";
            // 
            // labelCantitate
            // 
            this.labelCantitate.AutoSize = true;
            this.labelCantitate.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantitate.ForeColor = System.Drawing.Color.Red;
            this.labelCantitate.Location = new System.Drawing.Point(252, 164);
            this.labelCantitate.Name = "labelCantitate";
            this.labelCantitate.Size = new System.Drawing.Size(145, 15);
            this.labelCantitate.TabIndex = 16;
            this.labelCantitate.Text = "Cantitatea este obligatorie!";
            // 
            // labelCategorie
            // 
            this.labelCategorie.AutoSize = true;
            this.labelCategorie.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategorie.ForeColor = System.Drawing.Color.Red;
            this.labelCategorie.Location = new System.Drawing.Point(252, 225);
            this.labelCategorie.Name = "labelCategorie";
            this.labelCategorie.Size = new System.Drawing.Size(141, 15);
            this.labelCategorie.TabIndex = 17;
            this.labelCategorie.Text = "Categoria este obligatorie!";
            // 
            // errorNume
            // 
            this.errorNume.ContainerControl = this;
            this.errorNume.Icon = ((System.Drawing.Icon)(resources.GetObject("errorNume.Icon")));
            // 
            // errorPret
            // 
            this.errorPret.ContainerControl = this;
            this.errorPret.Icon = ((System.Drawing.Icon)(resources.GetObject("errorPret.Icon")));
            // 
            // errorCantitate
            // 
            this.errorCantitate.ContainerControl = this;
            this.errorCantitate.Icon = ((System.Drawing.Icon)(resources.GetObject("errorCantitate.Icon")));
            // 
            // errorCategorie
            // 
            this.errorCategorie.ContainerControl = this;
            this.errorCategorie.Icon = ((System.Drawing.Icon)(resources.GetObject("errorCategorie.Icon")));
            // 
            // FormProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCategorie);
            this.Controls.Add(this.labelCantitate);
            this.Controls.Add(this.labelPret);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.RezultateP);
            this.Controls.Add(this.btnCautareP);
            this.Controls.Add(this.txtCautareP);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorNume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCantitate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategorie)).EndInit();
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
        private System.Windows.Forms.TextBox txtCautareP;
        private System.Windows.Forms.Button btnCautareP;
        private System.Windows.Forms.ListBox RezultateP;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelPret;
        private System.Windows.Forms.Label labelCantitate;
        private System.Windows.Forms.Label labelCategorie;
        private System.Windows.Forms.ErrorProvider errorNume;
        private System.Windows.Forms.ErrorProvider errorPret;
        private System.Windows.Forms.ErrorProvider errorCantitate;
        private System.Windows.Forms.ErrorProvider errorCategorie;
    }
}