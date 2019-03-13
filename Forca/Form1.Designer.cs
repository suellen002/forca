namespace Forca
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMascara = new System.Windows.Forms.Label();
            this.letrasUsaveis = new System.Windows.Forms.Label();
            this.lblLetrasUsadas = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "forca_0.jpg");
            this.imageList1.Images.SetKeyName(1, "forca_1.jpg");
            this.imageList1.Images.SetKeyName(2, "forca_2.jpg");
            this.imageList1.Images.SetKeyName(3, "forca_3.jpg");
            this.imageList1.Images.SetKeyName(4, "forca_4.jpg");
            this.imageList1.Images.SetKeyName(5, "forca_5.jpg");
            this.imageList1.Images.SetKeyName(6, "forca_6.jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 179);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Iniciar Jogo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMascara
            // 
            this.lblMascara.AutoSize = true;
            this.lblMascara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascara.Location = new System.Drawing.Point(156, 155);
            this.lblMascara.Name = "lblMascara";
            this.lblMascara.Size = new System.Drawing.Size(32, 24);
            this.lblMascara.TabIndex = 2;
            this.lblMascara.Text = "__";
            // 
            // letrasUsaveis
            // 
            this.letrasUsaveis.AutoSize = true;
            this.letrasUsaveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letrasUsaveis.Location = new System.Drawing.Point(157, 22);
            this.letrasUsaveis.Name = "letrasUsaveis";
            this.letrasUsaveis.Size = new System.Drawing.Size(121, 16);
            this.letrasUsaveis.TabIndex = 3;
            this.letrasUsaveis.Text = "Letras utilizadas";
            // 
            // lblLetrasUsadas
            // 
            this.lblLetrasUsadas.AutoSize = true;
            this.lblLetrasUsadas.Location = new System.Drawing.Point(157, 47);
            this.lblLetrasUsadas.Name = "lblLetrasUsadas";
            this.lblLetrasUsadas.Size = new System.Drawing.Size(49, 13);
            this.lblLetrasUsadas.TabIndex = 4;
            this.lblLetrasUsadas.Text = "_______";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(290, 196);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(144, 90);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(200, 37);
            this.lblGameOver.TabIndex = 6;
            this.lblGameOver.Text = "Game Over!";
            this.lblGameOver.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 273);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblLetrasUsadas);
            this.Controls.Add(this.letrasUsaveis);
            this.Controls.Add(this.lblMascara);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Forca das cores";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMascara;
        private System.Windows.Forms.Label letrasUsaveis;
        private System.Windows.Forms.Label lblLetrasUsadas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblGameOver;
    }
}

