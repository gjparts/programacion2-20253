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
            etiqueta1 = new Label();
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
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(etiqueta1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "20012002049 - Gerardo Portillo";
            ResumeLayout(false);
        }

        #endregion

        private Label etiqueta1;
    }
}
