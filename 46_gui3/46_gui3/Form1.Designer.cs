namespace _46_gui3
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
            label1 = new Label();
            caja1 = new TextBox();
            caja2 = new TextBox();
            label2 = new Label();
            total = new TextBox();
            label3 = new Label();
            botonSumar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(88, 32);
            label1.TabIndex = 0;
            label1.Text = "Cifra 1:";
            // 
            // caja1
            // 
            caja1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caja1.Location = new Point(106, 10);
            caja1.Name = "caja1";
            caja1.Size = new Size(459, 39);
            caja1.TabIndex = 1;
            caja1.Text = "0.00";
            caja1.TextAlign = HorizontalAlignment.Right;
            // 
            // caja2
            // 
            caja2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caja2.Location = new Point(106, 55);
            caja2.Name = "caja2";
            caja2.Size = new Size(459, 39);
            caja2.TabIndex = 3;
            caja2.Text = "0.00";
            caja2.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(88, 32);
            label2.TabIndex = 2;
            label2.Text = "Cifra 2:";
            // 
            // total
            // 
            total.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total.Location = new Point(106, 100);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(459, 39);
            total.TabIndex = 5;
            total.Text = "0.00";
            total.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 103);
            label3.Name = "label3";
            label3.Size = new Size(79, 32);
            label3.TabIndex = 4;
            label3.Text = "Suma:";
            // 
            // botonSumar
            // 
            botonSumar.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonSumar.Location = new Point(228, 155);
            botonSumar.Name = "botonSumar";
            botonSumar.Size = new Size(169, 61);
            botonSumar.TabIndex = 6;
            botonSumar.Text = "Sumar";
            botonSumar.UseVisualStyleBackColor = true;
            botonSumar.Click += botonSumar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 243);
            Controls.Add(botonSumar);
            Controls.Add(total);
            Controls.Add(label3);
            Controls.Add(caja2);
            Controls.Add(label2);
            Controls.Add(caja1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox caja1;
        private TextBox caja2;
        private Label label2;
        private TextBox total;
        private Label label3;
        private Button botonSumar;
    }
}
