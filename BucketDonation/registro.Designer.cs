namespace BucketDonation
{
    partial class registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro));
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelRegistrarse = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelErrNombre = new System.Windows.Forms.Label();
            this.labelErrCorreo = new System.Windows.Forms.Label();
            this.labelErrTelefono = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(29, 115);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(205, 20);
            this.textBoxNombre.TabIndex = 0;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(29, 201);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(205, 20);
            this.textBoxCorreo.TabIndex = 1;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(29, 288);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(205, 20);
            this.textBoxTelefono.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(25, 80);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(86, 23);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Nombre";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(25, 164);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(76, 23);
            this.labelCorreo.TabIndex = 4;
            this.labelCorreo.Text = "Correo";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.Location = new System.Drawing.Point(25, 262);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(91, 23);
            this.labelTelefono.TabIndex = 5;
            this.labelTelefono.Text = "Télefono";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(29, 348);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(75, 30);
            this.btnRegistrarse.TabIndex = 6;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(147, 348);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelRegistrarse
            // 
            this.labelRegistrarse.AutoSize = true;
            this.labelRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrarse.Location = new System.Drawing.Point(80, 9);
            this.labelRegistrarse.Name = "labelRegistrarse";
            this.labelRegistrarse.Size = new System.Drawing.Size(154, 31);
            this.labelRegistrarse.TabIndex = 8;
            this.labelRegistrarse.Text = "Registrarse";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(253, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // labelErrNombre
            // 
            this.labelErrNombre.AutoSize = true;
            this.labelErrNombre.ForeColor = System.Drawing.Color.Red;
            this.labelErrNombre.Location = new System.Drawing.Point(26, 138);
            this.labelErrNombre.Name = "labelErrNombre";
            this.labelErrNombre.Size = new System.Drawing.Size(134, 13);
            this.labelErrNombre.TabIndex = 11;
            this.labelErrNombre.Text = "Por favor digite su nombre*";
            this.labelErrNombre.Visible = false;
            // 
            // labelErrCorreo
            // 
            this.labelErrCorreo.AutoSize = true;
            this.labelErrCorreo.ForeColor = System.Drawing.Color.Red;
            this.labelErrCorreo.Location = new System.Drawing.Point(26, 224);
            this.labelErrCorreo.Name = "labelErrCorreo";
            this.labelErrCorreo.Size = new System.Drawing.Size(129, 13);
            this.labelErrCorreo.TabIndex = 12;
            this.labelErrCorreo.Text = "Por favor digite su correo*";
            this.labelErrCorreo.Visible = false;
            // 
            // labelErrTelefono
            // 
            this.labelErrTelefono.AutoSize = true;
            this.labelErrTelefono.ForeColor = System.Drawing.Color.Red;
            this.labelErrTelefono.Location = new System.Drawing.Point(26, 311);
            this.labelErrTelefono.Name = "labelErrTelefono";
            this.labelErrTelefono.Size = new System.Drawing.Size(137, 13);
            this.labelErrTelefono.TabIndex = 13;
            this.labelErrTelefono.Text = "Por favor digite su télefono*";
            this.labelErrTelefono.Visible = false;
            // 
            // registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 401);
            this.ControlBox = false;
            this.Controls.Add(this.labelErrTelefono);
            this.Controls.Add(this.labelErrCorreo);
            this.Controls.Add(this.labelErrNombre);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelRegistrarse);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labelRegistrarse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelErrNombre;
        private System.Windows.Forms.Label labelErrCorreo;
        private System.Windows.Forms.Label labelErrTelefono;
    }
}