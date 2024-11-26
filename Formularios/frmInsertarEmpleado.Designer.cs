namespace Unidad5PuntoDeVenta
{
    partial class frmInsertarEmpleado
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtNameEm = new System.Windows.Forms.TextBox();
            this.txtUsuaEm = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnRegEmp = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(65, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre: ";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNameEm
            // 
            this.txtNameEm.Location = new System.Drawing.Point(160, 56);
            this.txtNameEm.Name = "txtNameEm";
            this.txtNameEm.Size = new System.Drawing.Size(158, 20);
            this.txtNameEm.TabIndex = 1;
            // 
            // txtUsuaEm
            // 
            this.txtUsuaEm.Location = new System.Drawing.Point(160, 103);
            this.txtUsuaEm.Name = "txtUsuaEm";
            this.txtUsuaEm.Size = new System.Drawing.Size(158, 20);
            this.txtUsuaEm.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(65, 110);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(49, 13);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(160, 155);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(158, 20);
            this.txtPuesto.TabIndex = 5;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(65, 158);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(46, 13);
            this.lblPuesto.TabIndex = 4;
            this.lblPuesto.Text = "Puesto: ";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(160, 215);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(158, 20);
            this.txtPass.TabIndex = 7;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(65, 215);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(67, 13);
            this.lblPass.TabIndex = 6;
            this.lblPass.Text = "Contraseña: ";
            // 
            // btnRegEmp
            // 
            this.btnRegEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegEmp.Location = new System.Drawing.Point(179, 345);
            this.btnRegEmp.Name = "btnRegEmp";
            this.btnRegEmp.Size = new System.Drawing.Size(149, 33);
            this.btnRegEmp.TabIndex = 8;
            this.btnRegEmp.Text = "Registrar";
            this.btnRegEmp.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalir.Location = new System.Drawing.Point(392, 450);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 21);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // frmInsertarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(515, 496);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegEmp);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.txtUsuaEm);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtNameEm);
            this.Controls.Add(this.lblName);
            this.Name = "frmInsertarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNameEm;
        private System.Windows.Forms.TextBox txtUsuaEm;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnRegEmp;
        private System.Windows.Forms.Button btnSalir;
    }
}