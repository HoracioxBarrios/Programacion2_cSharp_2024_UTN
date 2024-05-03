namespace FormularioSaludo
{
    partial class FrmSaludo
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
            lbTitulo = new Label();
            lbMensaje = new Label();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(64, 26);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(100, 25);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Hola todo";
            // 
            // lbMensaje
            // 
            lbMensaje.AutoSize = true;
            lbMensaje.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMensaje.Location = new Point(64, 67);
            lbMensaje.Name = "lbMensaje";
            lbMensaje.Size = new Size(75, 21);
            lbMensaje.TabIndex = 1;
            lbMensaje.Text = "Mauricio ";
            // 
            // FrmSaludo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(325, 163);
            Controls.Add(lbMensaje);
            Controls.Add(lbTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmSaludo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saludo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private Label lbMensaje;
    }
}
