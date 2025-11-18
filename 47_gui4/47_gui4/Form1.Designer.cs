namespace _47_gui4
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
            caja3 = new TextBox();
            label3 = new Label();
            sol1 = new TextBox();
            label4 = new Label();
            sol2 = new TextBox();
            label5 = new Label();
            botonCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 37);
            label1.TabIndex = 0;
            label1.Text = "a:";
            // 
            // caja1
            // 
            caja1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caja1.Location = new Point(55, 9);
            caja1.Name = "caja1";
            caja1.Size = new Size(358, 43);
            caja1.TabIndex = 1;
            caja1.Text = "0.00";
            caja1.TextAlign = HorizontalAlignment.Right;
            // 
            // caja2
            // 
            caja2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caja2.Location = new Point(55, 58);
            caja2.Name = "caja2";
            caja2.Size = new Size(358, 43);
            caja2.TabIndex = 3;
            caja2.Text = "0.00";
            caja2.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(39, 37);
            label2.TabIndex = 2;
            label2.Text = "b:";
            // 
            // caja3
            // 
            caja3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caja3.Location = new Point(55, 107);
            caja3.Name = "caja3";
            caja3.Size = new Size(358, 43);
            caja3.TabIndex = 5;
            caja3.Text = "0.00";
            caja3.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(35, 37);
            label3.TabIndex = 4;
            label3.Text = "c:";
            // 
            // sol1
            // 
            sol1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sol1.Location = new Point(55, 156);
            sol1.Name = "sol1";
            sol1.ReadOnly = true;
            sol1.Size = new Size(358, 43);
            sol1.TabIndex = 7;
            sol1.Text = "0.00";
            sol1.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1, 156);
            label4.Name = "label4";
            label4.Size = new Size(50, 37);
            label4.TabIndex = 6;
            label4.Text = "x1:";
            // 
            // sol2
            // 
            sol2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sol2.Location = new Point(55, 205);
            sol2.Name = "sol2";
            sol2.ReadOnly = true;
            sol2.Size = new Size(358, 43);
            sol2.TabIndex = 9;
            sol2.Text = "0.00";
            sol2.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(1, 205);
            label5.Name = "label5";
            label5.Size = new Size(50, 37);
            label5.TabIndex = 8;
            label5.Text = "x2:";
            // 
            // botonCalcular
            // 
            botonCalcular.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonCalcular.Location = new Point(126, 269);
            botonCalcular.Name = "botonCalcular";
            botonCalcular.Size = new Size(203, 71);
            botonCalcular.TabIndex = 10;
            botonCalcular.Text = "Cuadrática";
            botonCalcular.UseVisualStyleBackColor = true;
            botonCalcular.Click += botonCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 361);
            Controls.Add(botonCalcular);
            Controls.Add(sol2);
            Controls.Add(label5);
            Controls.Add(sol1);
            Controls.Add(label4);
            Controls.Add(caja3);
            Controls.Add(label3);
            Controls.Add(caja2);
            Controls.Add(label2);
            Controls.Add(caja1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "20012002049 - Gerardo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox caja1;
        private TextBox caja2;
        private Label label2;
        private TextBox caja3;
        private Label label3;
        private TextBox sol1;
        private Label label4;
        private TextBox sol2;
        private Label label5;
        private Button botonCalcular;
    }
}
