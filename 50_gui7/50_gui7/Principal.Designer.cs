namespace _50_gui7
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
            lista1 = new ListBox();
            caja = new TextBox();
            agregar1 = new Button();
            agregar2 = new Button();
            editar = new Button();
            eliminar = new Button();
            limpiar = new Button();
            label1 = new Label();
            perros = new TextBox();
            gatos = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // lista1
            // 
            lista1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lista1.FormattingEnabled = true;
            lista1.ItemHeight = 30;
            lista1.Items.AddRange(new object[] { "Rojo", "Amarillo", "Azul" });
            lista1.Location = new Point(12, 67);
            lista1.Name = "lista1";
            lista1.Size = new Size(621, 364);
            lista1.TabIndex = 0;
            // 
            // caja
            // 
            caja.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caja.Location = new Point(12, 12);
            caja.Name = "caja";
            caja.Size = new Size(395, 39);
            caja.TabIndex = 1;
            // 
            // agregar1
            // 
            agregar1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregar1.Location = new Point(413, 12);
            agregar1.Name = "agregar1";
            agregar1.Size = new Size(220, 39);
            agregar1.TabIndex = 2;
            agregar1.Text = "Agregar (Metodo 1)";
            agregar1.UseVisualStyleBackColor = true;
            agregar1.Click += agregar1_Click;
            // 
            // agregar2
            // 
            agregar2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregar2.Location = new Point(639, 67);
            agregar2.Name = "agregar2";
            agregar2.Size = new Size(220, 39);
            agregar2.TabIndex = 3;
            agregar2.Text = "Agregar (Metodo 2)";
            agregar2.UseVisualStyleBackColor = true;
            agregar2.Click += agregar2_Click;
            // 
            // editar
            // 
            editar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editar.Location = new Point(639, 112);
            editar.Name = "editar";
            editar.Size = new Size(220, 39);
            editar.TabIndex = 4;
            editar.Text = "Editar";
            editar.UseVisualStyleBackColor = true;
            editar.Click += editar_Click;
            // 
            // eliminar
            // 
            eliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eliminar.Location = new Point(639, 209);
            eliminar.Name = "eliminar";
            eliminar.Size = new Size(220, 39);
            eliminar.TabIndex = 5;
            eliminar.Text = "Eliminar";
            eliminar.UseVisualStyleBackColor = true;
            eliminar.Click += eliminar_Click;
            // 
            // limpiar
            // 
            limpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            limpiar.Location = new Point(639, 287);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(220, 39);
            limpiar.TabIndex = 6;
            limpiar.Text = "Limpiar";
            limpiar.UseVisualStyleBackColor = true;
            limpiar.Click += limpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(639, 358);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 7;
            label1.Text = "Cantidad de perros:";
            // 
            // perros
            // 
            perros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            perros.Location = new Point(790, 355);
            perros.Name = "perros";
            perros.ReadOnly = true;
            perros.Size = new Size(69, 29);
            perros.TabIndex = 8;
            perros.Text = "0";
            perros.TextAlign = HorizontalAlignment.Right;
            // 
            // gatos
            // 
            gatos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gatos.Location = new Point(790, 390);
            gatos.Name = "gatos";
            gatos.ReadOnly = true;
            gatos.Size = new Size(69, 29);
            gatos.TabIndex = 10;
            gatos.Text = "0";
            gatos.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(639, 393);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 9;
            label2.Text = "Cantidad de gatos:";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 450);
            Controls.Add(gatos);
            Controls.Add(label2);
            Controls.Add(perros);
            Controls.Add(label1);
            Controls.Add(limpiar);
            Controls.Add(eliminar);
            Controls.Add(editar);
            Controls.Add(agregar2);
            Controls.Add(agregar1);
            Controls.Add(caja);
            Controls.Add(lista1);
            Name = "Principal";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lista1;
        private TextBox caja;
        private Button agregar1;
        private Button agregar2;
        private Button editar;
        private Button eliminar;
        private Button limpiar;
        private Label label1;
        private TextBox perros;
        private TextBox gatos;
        private Label label2;
    }
}
