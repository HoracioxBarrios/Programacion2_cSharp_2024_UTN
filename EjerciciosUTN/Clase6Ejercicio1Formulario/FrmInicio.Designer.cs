namespace Clase6Ejercicio1Formulario
{
    partial class FrmInicio
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lbNombre = new Label();
            lbApellido = new Label();
            btnSaludo = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(175, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(115, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(175, 154);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(115, 23);
            txtApellido.TabIndex = 1;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombre.Location = new Point(175, 80);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(53, 15);
            lbNombre.TabIndex = 2;
            lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbApellido.Location = new Point(175, 136);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(52, 15);
            lbApellido.TabIndex = 3;
            lbApellido.Text = "Apellido";
            // 
            // btnSaludo
            // 
            btnSaludo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaludo.Location = new Point(175, 204);
            btnSaludo.Name = "btnSaludo";
            btnSaludo.Size = new Size(116, 30);
            btnSaludo.TabIndex = 4;
            btnSaludo.Text = "Saludar";
            btnSaludo.UseVisualStyleBackColor = true;
            btnSaludo.Click += btnSaludo_Click;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 450);
            Controls.Add(btnSaludo);
            Controls.Add(lbApellido);
            Controls.Add(lbNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lbNombre;
        private Label lbApellido;
        private Button btnSaludo;
    }
}
