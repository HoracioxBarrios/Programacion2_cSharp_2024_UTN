namespace WinFormsAppSingleAndSeparationResponsability
{
    partial class FormularioPrincipal
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
            textBoxNombreProducto = new TextBox();
            textBoxPrecioProducto = new TextBox();
            labelNombreProducto = new Label();
            label1 = new Label();
            label2 = new Label();
            textBoxTasaDeImpuesto = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            buttonCalcularImpuesto = new Button();
            SuspendLayout();
            // 
            // textBoxNombreProducto
            // 
            textBoxNombreProducto.Location = new Point(294, 122);
            textBoxNombreProducto.Name = "textBoxNombreProducto";
            textBoxNombreProducto.Size = new Size(180, 23);
            textBoxNombreProducto.TabIndex = 0;
            // 
            // textBoxPrecioProducto
            // 
            textBoxPrecioProducto.Location = new Point(293, 204);
            textBoxPrecioProducto.Name = "textBoxPrecioProducto";
            textBoxPrecioProducto.Size = new Size(180, 23);
            textBoxPrecioProducto.TabIndex = 1;
            // 
            // labelNombreProducto
            // 
            labelNombreProducto.AutoSize = true;
            labelNombreProducto.Location = new Point(294, 104);
            labelNombreProducto.Name = "labelNombreProducto";
            labelNombreProducto.Size = new Size(122, 15);
            labelNombreProducto.TabIndex = 2;
            labelNombreProducto.Text = "Nombre del Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 186);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(307, 31);
            label2.Name = "label2";
            label2.Size = new Size(136, 37);
            label2.TabIndex = 4;
            label2.Text = "Producto";
            // 
            // textBoxTasaDeImpuesto
            // 
            textBoxTasaDeImpuesto.Location = new Point(294, 277);
            textBoxTasaDeImpuesto.Name = "textBoxTasaDeImpuesto";
            textBoxTasaDeImpuesto.Size = new Size(98, 23);
            textBoxTasaDeImpuesto.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(293, 259);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 6;
            label3.Text = "Tasa de Impuesto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(523, 374);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 8;
            label4.Text = "Mostrar Impuesto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(524, 392);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            // 
            // buttonCalcularImpuesto
            // 
            buttonCalcularImpuesto.Location = new Point(398, 391);
            buttonCalcularImpuesto.Name = "buttonCalcularImpuesto";
            buttonCalcularImpuesto.Size = new Size(75, 23);
            buttonCalcularImpuesto.TabIndex = 10;
            buttonCalcularImpuesto.Text = "Calcular Impuesto";
            buttonCalcularImpuesto.UseVisualStyleBackColor = true;
            buttonCalcularImpuesto.Click += buttonCalcularImpuesto_Click;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCalcularImpuesto);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxTasaDeImpuesto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelNombreProducto);
            Controls.Add(textBoxPrecioProducto);
            Controls.Add(textBoxNombreProducto);
            Name = "FormularioPrincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombreProducto;
        private TextBox textBoxPrecioProducto;
        private Label labelNombreProducto;
        private Label label1;
        private Label label2;
        private TextBox textBoxTasaDeImpuesto;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Button buttonCalcularImpuesto;
    }
}
