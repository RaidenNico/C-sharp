namespace Evaluación_Final
{
    partial class frmRegistrarUsuario
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPregunta = new System.Windows.Forms.ComboBox();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            this.lblErrorUsuario = new System.Windows.Forms.Label();
            this.lblErrorRespuesta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.lblErrorRPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(151, 141);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(183, 24);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsuario_Validating);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(63, 671);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(122, 39);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(113, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Registro de Usuarios";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetroceder.Location = new System.Drawing.Point(316, 671);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(122, 39);
            this.btnRetroceder.TabIndex = 5;
            this.btnRetroceder.Text = "Regresar";
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(151, 269);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(183, 24);
            this.txtPassword.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(145, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(129, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña de usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(112, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pregunta de Recuperacion";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbPregunta
            // 
            this.cmbPregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPregunta.FormattingEnabled = true;
            this.cmbPregunta.Location = new System.Drawing.Point(63, 522);
            this.cmbPregunta.Name = "cmbPregunta";
            this.cmbPregunta.Size = new System.Drawing.Size(375, 26);
            this.cmbPregunta.TabIndex = 7;
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta.Location = new System.Drawing.Point(63, 573);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(375, 24);
            this.txtRespuesta.TabIndex = 6;
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.AutoSize = true;
            this.lblErrorPassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblErrorPassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.25F);
            this.lblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPassword.Location = new System.Drawing.Point(141, 312);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(0, 17);
            this.lblErrorPassword.TabIndex = 8;
            this.lblErrorPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblErrorUsuario
            // 
            this.lblErrorUsuario.AutoSize = true;
            this.lblErrorUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblErrorUsuario.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.25F);
            this.lblErrorUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUsuario.Location = new System.Drawing.Point(141, 179);
            this.lblErrorUsuario.Name = "lblErrorUsuario";
            this.lblErrorUsuario.Size = new System.Drawing.Size(0, 17);
            this.lblErrorUsuario.TabIndex = 9;
            this.lblErrorUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblErrorRespuesta
            // 
            this.lblErrorRespuesta.AutoSize = true;
            this.lblErrorRespuesta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblErrorRespuesta.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.25F);
            this.lblErrorRespuesta.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRespuesta.Location = new System.Drawing.Point(60, 613);
            this.lblErrorRespuesta.Name = "lblErrorRespuesta";
            this.lblErrorRespuesta.Size = new System.Drawing.Size(0, 17);
            this.lblErrorRespuesta.TabIndex = 10;
            this.lblErrorRespuesta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(78, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(324, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Confirmar Contraseña de usuario";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordConfirm.Location = new System.Drawing.Point(151, 397);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(183, 24);
            this.txtPasswordConfirm.TabIndex = 6;
            // 
            // lblErrorRPassword
            // 
            this.lblErrorRPassword.AutoSize = true;
            this.lblErrorRPassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblErrorRPassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.25F);
            this.lblErrorRPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRPassword.Location = new System.Drawing.Point(141, 443);
            this.lblErrorRPassword.Name = "lblErrorRPassword";
            this.lblErrorRPassword.Size = new System.Drawing.Size(0, 17);
            this.lblErrorRPassword.TabIndex = 8;
            this.lblErrorRPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(483, 742);
            this.Controls.Add(this.lblErrorRespuesta);
            this.Controls.Add(this.lblErrorUsuario);
            this.Controls.Add(this.lblErrorRPassword);
            this.Controls.Add(this.lblErrorPassword);
            this.Controls.Add(this.cmbPregunta);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "frmRegistrarUsuario";
            this.Text = "Registro de Usuarios";
            this.Load += new System.EventHandler(this.frmRegistrarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPregunta;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Label lblErrorPassword;
        private System.Windows.Forms.Label lblErrorUsuario;
        private System.Windows.Forms.Label lblErrorRespuesta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.Label lblErrorRPassword;
    }
}