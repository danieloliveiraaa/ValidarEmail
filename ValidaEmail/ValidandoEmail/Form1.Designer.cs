
namespace ValidandoEmail
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pctStatus = new System.Windows.Forms.PictureBox();
            this.txtRandomEnvia = new System.Windows.Forms.TextBox();
            this.btnEnvia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValido = new System.Windows.Forms.Label();
            this.pctValido = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRandomConfirma = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctValido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(44, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(253, 26);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // pctStatus
            // 
            this.pctStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctStatus.Location = new System.Drawing.Point(310, 45);
            this.pctStatus.Name = "pctStatus";
            this.pctStatus.Size = new System.Drawing.Size(31, 30);
            this.pctStatus.TabIndex = 2;
            this.pctStatus.TabStop = false;
            this.pctStatus.Visible = false;
            // 
            // txtRandomEnvia
            // 
            this.txtRandomEnvia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRandomEnvia.Location = new System.Drawing.Point(171, 94);
            this.txtRandomEnvia.Name = "txtRandomEnvia";
            this.txtRandomEnvia.Size = new System.Drawing.Size(23, 26);
            this.txtRandomEnvia.TabIndex = 4;
            this.txtRandomEnvia.Visible = false;
            // 
            // btnEnvia
            // 
            this.btnEnvia.BackColor = System.Drawing.Color.Transparent;
            this.btnEnvia.BackgroundImage = global::ValidandoEmail.Properties.Resources.gmail;
            this.btnEnvia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnvia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvia.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnEnvia.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnEnvia.Location = new System.Drawing.Point(134, 166);
            this.btnEnvia.Name = "btnEnvia";
            this.btnEnvia.Size = new System.Drawing.Size(97, 92);
            this.btnEnvia.TabIndex = 5;
            this.btnEnvia.UseVisualStyleBackColor = false;
            this.btnEnvia.Click += new System.EventHandler(this.btnEnvia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(163, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enviar";
            // 
            // lblValido
            // 
            this.lblValido.AutoSize = true;
            this.lblValido.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblValido.Location = new System.Drawing.Point(301, 355);
            this.lblValido.Name = "lblValido";
            this.lblValido.Size = new System.Drawing.Size(52, 17);
            this.lblValido.TabIndex = 7;
            this.lblValido.Text = "Válido.";
            this.lblValido.Visible = false;
            // 
            // pctValido
            // 
            this.pctValido.BackColor = System.Drawing.Color.Transparent;
            this.pctValido.BackgroundImage = global::ValidandoEmail.Properties.Resources.valido;
            this.pctValido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctValido.Location = new System.Drawing.Point(298, 381);
            this.pctValido.Name = "pctValido";
            this.pctValido.Size = new System.Drawing.Size(55, 50);
            this.pctValido.TabIndex = 8;
            this.pctValido.TabStop = false;
            this.pctValido.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(364, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Testes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRandomConfirma
            // 
            this.txtRandomConfirma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRandomConfirma.Location = new System.Drawing.Point(43, 396);
            this.txtRandomConfirma.Name = "txtRandomConfirma";
            this.txtRandomConfirma.Size = new System.Drawing.Size(224, 26);
            this.txtRandomConfirma.TabIndex = 10;
            this.txtRandomConfirma.Visible = false;
            this.txtRandomConfirma.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblA.Location = new System.Drawing.Point(45, 367);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(224, 15);
            this.lblA.TabIndex = 11;
            this.lblA.Text = "Digite o codigo enviado para seu email:";
            this.lblA.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(44, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Digite seu email:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(409, 482);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtRandomConfirma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pctValido);
            this.Controls.Add(this.lblValido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnvia);
            this.Controls.Add(this.txtRandomEnvia);
            this.Controls.Add(this.pctStatus);
            this.Controls.Add(this.txtEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validar Email";
            ((System.ComponentModel.ISupportInitialize)(this.pctStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctValido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pctStatus;
        private System.Windows.Forms.TextBox txtRandomEnvia;
        private System.Windows.Forms.Button btnEnvia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValido;
        private System.Windows.Forms.PictureBox pctValido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRandomConfirma;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label label5;
    }
}

