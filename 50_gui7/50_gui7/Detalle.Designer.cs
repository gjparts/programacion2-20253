namespace _50_gui7
{
    partial class Detalle
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
            label1 = new Label();
            valor = new TextBox();
            cancelar = new Button();
            aceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(72, 32);
            label1.TabIndex = 0;
            label1.Text = "Valor:";
            // 
            // valor
            // 
            valor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            valor.Location = new Point(90, 15);
            valor.Name = "valor";
            valor.Size = new Size(625, 39);
            valor.TabIndex = 1;
            // 
            // cancelar
            // 
            cancelar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelar.Location = new Point(547, 74);
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(168, 46);
            cancelar.TabIndex = 2;
            cancelar.Text = "Cancelar";
            cancelar.UseVisualStyleBackColor = true;
            cancelar.Click += cancelar_Click;
            // 
            // aceptar
            // 
            aceptar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aceptar.Location = new Point(373, 74);
            aceptar.Name = "aceptar";
            aceptar.Size = new Size(168, 46);
            aceptar.TabIndex = 3;
            aceptar.Text = "Aceptar";
            aceptar.UseVisualStyleBackColor = true;
            aceptar.Click += aceptar_Click;
            // 
            // Detalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 132);
            Controls.Add(aceptar);
            Controls.Add(cancelar);
            Controls.Add(valor);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Detalle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button cancelar;
        private Button aceptar;
        public TextBox valor;
    }
}