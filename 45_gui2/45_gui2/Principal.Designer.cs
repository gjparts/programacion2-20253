namespace _45_gui2
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
            components = new System.ComponentModel.Container();
            etiqueta1 = new Label();
            boton1 = new Button();
            boton2 = new Button();
            caja1 = new TextBox();
            boton3 = new Button();
            boton4 = new Button();
            etiqueta2 = new Label();
            reloj1 = new System.Windows.Forms.Timer(components);
            etiqueta3 = new Label();
            reloj2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // etiqueta1
            // 
            etiqueta1.BackColor = Color.FromArgb(128, 255, 128);
            etiqueta1.BorderStyle = BorderStyle.FixedSingle;
            etiqueta1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            etiqueta1.Location = new Point(12, 9);
            etiqueta1.Name = "etiqueta1";
            etiqueta1.Size = new Size(379, 161);
            etiqueta1.TabIndex = 0;
            etiqueta1.Text = "Sistemas 2025";
            etiqueta1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // boton1
            // 
            boton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton1.ForeColor = Color.Red;
            boton1.Location = new Point(397, 9);
            boton1.Name = "boton1";
            boton1.Size = new Size(391, 65);
            boton1.TabIndex = 1;
            boton1.Text = "Haga click aqui";
            boton1.UseVisualStyleBackColor = true;
            boton1.Click += boton1_Click;
            // 
            // boton2
            // 
            boton2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton2.Location = new Point(397, 80);
            boton2.Name = "boton2";
            boton2.Size = new Size(391, 70);
            boton2.TabIndex = 2;
            boton2.Text = "Cambiar titulo del form";
            boton2.UseVisualStyleBackColor = true;
            boton2.Click += boton2_Click;
            // 
            // caja1
            // 
            caja1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caja1.Location = new Point(12, 193);
            caja1.Name = "caja1";
            caja1.Size = new Size(379, 35);
            caja1.TabIndex = 3;
            caja1.Text = "soy una caja de texto";
            // 
            // boton3
            // 
            boton3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton3.Location = new Point(397, 185);
            boton3.Name = "boton3";
            boton3.Size = new Size(391, 43);
            boton3.TabIndex = 4;
            boton3.Text = "Deshabilitar caja1";
            boton3.UseVisualStyleBackColor = true;
            boton3.Click += boton3_Click;
            // 
            // boton4
            // 
            boton4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton4.Location = new Point(397, 234);
            boton4.Name = "boton4";
            boton4.Size = new Size(391, 43);
            boton4.TabIndex = 5;
            boton4.Text = "Habilitar caja1";
            boton4.UseVisualStyleBackColor = true;
            boton4.Click += boton4_Click;
            // 
            // etiqueta2
            // 
            etiqueta2.AutoSize = true;
            etiqueta2.BackColor = Color.Black;
            etiqueta2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            etiqueta2.ForeColor = Color.Lime;
            etiqueta2.Location = new Point(12, 332);
            etiqueta2.Name = "etiqueta2";
            etiqueta2.Size = new Size(143, 32);
            etiqueta2.TabIndex = 6;
            etiqueta2.Text = "soy un label";
            // 
            // reloj1
            // 
            reloj1.Enabled = true;
            reloj1.Interval = 500;
            reloj1.Tick += reloj1_Tick;
            // 
            // etiqueta3
            // 
            etiqueta3.BorderStyle = BorderStyle.FixedSingle;
            etiqueta3.Location = new Point(489, 323);
            etiqueta3.Name = "etiqueta3";
            etiqueta3.Size = new Size(241, 95);
            etiqueta3.TabIndex = 7;
            // 
            // reloj2
            // 
            reloj2.Enabled = true;
            reloj2.Interval = 1000;
            reloj2.Tick += reloj2_Tick;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(etiqueta3);
            Controls.Add(etiqueta2);
            Controls.Add(boton4);
            Controls.Add(boton3);
            Controls.Add(caja1);
            Controls.Add(boton2);
            Controls.Add(boton1);
            Controls.Add(etiqueta1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "20012002049 - Gerardo Portillo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label etiqueta1;
        private Button boton1;
        private Button boton2;
        private TextBox caja1;
        private Button boton3;
        private Button boton4;
        private Label etiqueta2;
        private System.Windows.Forms.Timer reloj1;
        private Label etiqueta3;
        private System.Windows.Forms.Timer reloj2;
    }
}
