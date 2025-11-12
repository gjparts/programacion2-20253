namespace _44_gui1
{
    partial class Principal
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
            etiqueta1 = new Label();
            boton1 = new Button();
            caja = new TextBox();
            boton2 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // etiqueta1
            // 
            etiqueta1.AutoSize = true;
            etiqueta1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            etiqueta1.ForeColor = Color.Red;
            etiqueta1.Location = new Point(12, 9);
            etiqueta1.Name = "etiqueta1";
            etiqueta1.Size = new Size(206, 37);
            etiqueta1.TabIndex = 0;
            etiqueta1.Text = "Gerardo Portillo";
            etiqueta1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // boton1
            // 
            boton1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton1.ForeColor = Color.FromArgb(218, 71, 112);
            boton1.Location = new Point(12, 66);
            boton1.Name = "boton1";
            boton1.Size = new Size(281, 98);
            boton1.TabIndex = 1;
            boton1.Text = "Haga click aqui";
            boton1.UseVisualStyleBackColor = true;
            boton1.Click += boton1_Click;
            // 
            // caja
            // 
            caja.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caja.Location = new Point(12, 191);
            caja.Name = "caja";
            caja.Size = new Size(396, 39);
            caja.TabIndex = 2;
            caja.Text = "valor predeterminado";
            // 
            // boton2
            // 
            boton2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton2.Location = new Point(414, 180);
            boton2.Name = "boton2";
            boton2.Size = new Size(179, 61);
            boton2.TabIndex = 3;
            boton2.Text = "Ver Mensaje";
            boton2.UseVisualStyleBackColor = true;
            boton2.Click += boton2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 272);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(281, 269);
            textBox1.TabIndex = 4;
            textBox1.Text = "Caja de texto de varios renglones";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(172, 216, 236);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(605, 586);
            Controls.Add(textBox1);
            Controls.Add(boton2);
            Controls.Add(caja);
            Controls.Add(boton1);
            Controls.Add(etiqueta1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerardo Portillo - 20012002049";
            FormClosed += Principal_FormClosed;
            Load += Principal_Load;
            Shown += Principal_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label etiqueta1;
        private Button boton1;
        private TextBox caja;
        private Button boton2;
        private TextBox textBox1;
    }
}
