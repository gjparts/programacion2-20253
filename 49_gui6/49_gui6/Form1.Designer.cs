namespace _49_gui6
{
    partial class Form1
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
            check1 = new CheckBox();
            label1 = new Label();
            boton1 = new Button();
            frutas = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            boton2 = new Button();
            boton3 = new Button();
            SuspendLayout();
            // 
            // check1
            // 
            check1.AutoSize = true;
            check1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            check1.Location = new Point(12, 12);
            check1.Name = "check1";
            check1.Size = new Size(214, 36);
            check1.TabIndex = 0;
            check1.Text = "Soy un checkbox";
            check1.UseVisualStyleBackColor = true;
            check1.CheckedChanged += check1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // boton1
            // 
            boton1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton1.Location = new Point(324, 12);
            boton1.Name = "boton1";
            boton1.Size = new Size(385, 70);
            boton1.TabIndex = 2;
            boton1.Text = "Que valor tiene check1?";
            boton1.UseVisualStyleBackColor = true;
            boton1.Click += boton1_Click;
            // 
            // frutas
            // 
            frutas.BackColor = Color.FromArgb(255, 128, 128);
            frutas.DropDownStyle = ComboBoxStyle.DropDownList;
            frutas.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            frutas.FormattingEnabled = true;
            frutas.Items.AddRange(new object[] { "Honduras", "Guatemala", "El Salvador", "Nicaragua" });
            frutas.Location = new Point(12, 189);
            frutas.Name = "frutas";
            frutas.Size = new Size(296, 40);
            frutas.TabIndex = 3;
            frutas.SelectedIndexChanged += frutas_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 243);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 285);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // boton2
            // 
            boton2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton2.Location = new Point(432, 180);
            boton2.Name = "boton2";
            boton2.Size = new Size(277, 56);
            boton2.TabIndex = 6;
            boton2.Text = "Seleccionar la Sandia";
            boton2.UseVisualStyleBackColor = true;
            boton2.Click += boton2_Click;
            // 
            // boton3
            // 
            boton3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton3.Location = new Point(432, 243);
            boton3.Name = "boton3";
            boton3.Size = new Size(277, 56);
            boton3.TabIndex = 7;
            boton3.Text = "Seleccionar el item 5";
            boton3.UseVisualStyleBackColor = true;
            boton3.Click += boton3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(boton3);
            Controls.Add(boton2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(frutas);
            Controls.Add(boton1);
            Controls.Add(label1);
            Controls.Add(check1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerardo 20012002049";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox check1;
        private Label label1;
        private Button boton1;
        private ComboBox frutas;
        private Label label2;
        private Label label3;
        private Button boton2;
        private Button boton3;
    }
}
