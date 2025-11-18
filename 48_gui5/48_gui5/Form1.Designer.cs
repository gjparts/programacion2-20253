namespace _48_gui5
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
            caja4 = new TextBox();
            label4 = new Label();
            total = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(106, 37);
            label1.TabIndex = 0;
            label1.Text = "Valor 1:";
            // 
            // caja1
            // 
            caja1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caja1.Location = new Point(124, 12);
            caja1.Name = "caja1";
            caja1.Size = new Size(444, 43);
            caja1.TabIndex = 1;
            caja1.Text = "0.00";
            caja1.TextAlign = HorizontalAlignment.Right;
            caja1.TextChanged += caja1_TextChanged;
            // 
            // caja2
            // 
            caja2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caja2.Location = new Point(124, 61);
            caja2.Name = "caja2";
            caja2.Size = new Size(444, 43);
            caja2.TabIndex = 3;
            caja2.Text = "0.00";
            caja2.TextAlign = HorizontalAlignment.Right;
            caja2.TextChanged += caja2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(106, 37);
            label2.TabIndex = 2;
            label2.Text = "Valor 2:";
            // 
            // caja3
            // 
            caja3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caja3.Location = new Point(124, 110);
            caja3.Name = "caja3";
            caja3.Size = new Size(444, 43);
            caja3.TabIndex = 5;
            caja3.Text = "0.00";
            caja3.TextAlign = HorizontalAlignment.Right;
            caja3.TextChanged += caja3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(106, 37);
            label3.TabIndex = 4;
            label3.Text = "Valor 3:";
            // 
            // caja4
            // 
            caja4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caja4.Location = new Point(124, 159);
            caja4.Name = "caja4";
            caja4.Size = new Size(444, 43);
            caja4.TabIndex = 7;
            caja4.Text = "0.00";
            caja4.TextAlign = HorizontalAlignment.Right;
            caja4.TextChanged += caja4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 162);
            label4.Name = "label4";
            label4.Size = new Size(106, 37);
            label4.TabIndex = 6;
            label4.Text = "Valor 4:";
            // 
            // total
            // 
            total.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total.Location = new Point(124, 208);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(444, 43);
            total.TabIndex = 9;
            total.Text = "0.00";
            total.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 211);
            label5.Name = "label5";
            label5.Size = new Size(89, 37);
            label5.TabIndex = 8;
            label5.Text = "Suma:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 265);
            Controls.Add(total);
            Controls.Add(label5);
            Controls.Add(caja4);
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
        private TextBox caja4;
        private Label label4;
        private TextBox total;
        private Label label5;
    }
}
