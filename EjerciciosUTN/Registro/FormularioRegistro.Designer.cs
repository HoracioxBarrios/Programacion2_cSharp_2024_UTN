namespace Registro
{
    partial class FormularioRegistro
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
            groupBoxDetallesUsuario = new GroupBox();
            labelErrorDireccion = new Label();
            labelErrorNombre = new Label();
            numericUDownEdad = new NumericUpDown();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            labelEdad = new Label();
            labelDireccion = new Label();
            labelNombre = new Label();
            groupBoxGenero = new GroupBox();
            radioButonNoBinario = new RadioButton();
            radioButtonFemenino = new RadioButton();
            radioButtonMasculino = new RadioButton();
            groupBoxCursos = new GroupBox();
            checkBoxJavaScript = new CheckBox();
            checkBoxCplusPlus = new CheckBox();
            checkBoxCSharp = new CheckBox();
            Pais = new ListBox();
            buttonIngresar = new Button();
            groupBoxDetallesUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUDownEdad).BeginInit();
            groupBoxGenero.SuspendLayout();
            groupBoxCursos.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxDetallesUsuario
            // 
            groupBoxDetallesUsuario.Controls.Add(labelErrorDireccion);
            groupBoxDetallesUsuario.Controls.Add(labelErrorNombre);
            groupBoxDetallesUsuario.Controls.Add(numericUDownEdad);
            groupBoxDetallesUsuario.Controls.Add(txtDireccion);
            groupBoxDetallesUsuario.Controls.Add(txtNombre);
            groupBoxDetallesUsuario.Controls.Add(labelEdad);
            groupBoxDetallesUsuario.Controls.Add(labelDireccion);
            groupBoxDetallesUsuario.Controls.Add(labelNombre);
            groupBoxDetallesUsuario.Location = new Point(24, 36);
            groupBoxDetallesUsuario.Name = "groupBoxDetallesUsuario";
            groupBoxDetallesUsuario.Size = new Size(284, 181);
            groupBoxDetallesUsuario.TabIndex = 0;
            groupBoxDetallesUsuario.TabStop = false;
            groupBoxDetallesUsuario.Text = "Detalles del Usuario";
            groupBoxDetallesUsuario.TextChanged += ComprobarDetalleUsuarioDireccion;
            // 
            // labelErrorDireccion
            // 
            labelErrorDireccion.AutoSize = true;
            labelErrorDireccion.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorDireccion.ForeColor = Color.FromArgb(192, 0, 0);
            labelErrorDireccion.Location = new Point(107, 112);
            labelErrorDireccion.Name = "labelErrorDireccion";
            labelErrorDireccion.Size = new Size(111, 13);
            labelErrorDireccion.TabIndex = 7;
            labelErrorDireccion.Text = "Dirección requerida.";
            labelErrorDireccion.Visible = false;
            // 
            // labelErrorNombre
            // 
            labelErrorNombre.AutoSize = true;
            labelErrorNombre.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorNombre.ForeColor = Color.FromArgb(192, 0, 0);
            labelErrorNombre.Location = new Point(107, 65);
            labelErrorNombre.Name = "labelErrorNombre";
            labelErrorNombre.Size = new Size(105, 13);
            labelErrorNombre.TabIndex = 6;
            labelErrorNombre.Text = "Nombre requerido.";
            labelErrorNombre.Visible = false;
            // 
            // numericUDownEdad
            // 
            numericUDownEdad.Location = new Point(90, 141);
            numericUDownEdad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUDownEdad.Name = "numericUDownEdad";
            numericUDownEdad.Size = new Size(74, 23);
            numericUDownEdad.TabIndex = 5;
            numericUDownEdad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(90, 86);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(141, 23);
            txtDireccion.TabIndex = 4;
            txtDireccion.TextChanged += ComprobarDetalleUsuarioDireccion;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(90, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(141, 23);
            txtNombre.TabIndex = 3;
            txtNombre.TextChanged += ComprobarDetalleUsuarioNombre;
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Location = new Point(17, 149);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(33, 15);
            labelEdad.TabIndex = 2;
            labelEdad.Text = "Edad";
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(17, 94);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(57, 15);
            labelDireccion.TabIndex = 1;
            labelDireccion.Text = "Direccion";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(17, 47);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre";
            // 
            // groupBoxGenero
            // 
            groupBoxGenero.Controls.Add(radioButonNoBinario);
            groupBoxGenero.Controls.Add(radioButtonFemenino);
            groupBoxGenero.Controls.Add(radioButtonMasculino);
            groupBoxGenero.Location = new Point(347, 36);
            groupBoxGenero.Name = "groupBoxGenero";
            groupBoxGenero.Size = new Size(124, 145);
            groupBoxGenero.TabIndex = 1;
            groupBoxGenero.TabStop = false;
            groupBoxGenero.Text = "Genero";
            // 
            // radioButonNoBinario
            // 
            radioButonNoBinario.AutoSize = true;
            radioButonNoBinario.Location = new Point(19, 110);
            radioButonNoBinario.Name = "radioButonNoBinario";
            radioButonNoBinario.Size = new Size(81, 19);
            radioButonNoBinario.TabIndex = 2;
            radioButonNoBinario.TabStop = true;
            radioButonNoBinario.Text = "No Binario";
            radioButonNoBinario.UseVisualStyleBackColor = true;
            radioButonNoBinario.CheckedChanged += ComprobarDetalleGenero;
            // 
            // radioButtonFemenino
            // 
            radioButtonFemenino.AutoSize = true;
            radioButtonFemenino.Location = new Point(19, 73);
            radioButtonFemenino.Name = "radioButtonFemenino";
            radioButtonFemenino.Size = new Size(78, 19);
            radioButtonFemenino.TabIndex = 1;
            radioButtonFemenino.TabStop = true;
            radioButtonFemenino.Text = "Femenino";
            radioButtonFemenino.UseVisualStyleBackColor = true;
            radioButtonFemenino.CheckedChanged += ComprobarDetalleGenero;
            // 
            // radioButtonMasculino
            // 
            radioButtonMasculino.AutoSize = true;
            radioButtonMasculino.Location = new Point(19, 39);
            radioButtonMasculino.Name = "radioButtonMasculino";
            radioButtonMasculino.Size = new Size(80, 19);
            radioButtonMasculino.TabIndex = 0;
            radioButtonMasculino.TabStop = true;
            radioButtonMasculino.Text = "Masculino";
            radioButtonMasculino.UseVisualStyleBackColor = true;
            radioButtonMasculino.CheckedChanged += ComprobarDetalleGenero;
            // 
            // groupBoxCursos
            // 
            groupBoxCursos.Controls.Add(checkBoxJavaScript);
            groupBoxCursos.Controls.Add(checkBoxCplusPlus);
            groupBoxCursos.Controls.Add(checkBoxCSharp);
            groupBoxCursos.Location = new Point(347, 187);
            groupBoxCursos.Name = "groupBoxCursos";
            groupBoxCursos.Size = new Size(124, 100);
            groupBoxCursos.TabIndex = 2;
            groupBoxCursos.TabStop = false;
            groupBoxCursos.Text = "Cursos";
            // 
            // checkBoxJavaScript
            // 
            checkBoxJavaScript.AutoSize = true;
            checkBoxJavaScript.Location = new Point(17, 76);
            checkBoxJavaScript.Name = "checkBoxJavaScript";
            checkBoxJavaScript.Size = new Size(81, 19);
            checkBoxJavaScript.TabIndex = 2;
            checkBoxJavaScript.Text = "Java Script";
            checkBoxJavaScript.UseVisualStyleBackColor = true;
            // 
            // checkBoxCplusPlus
            // 
            checkBoxCplusPlus.AutoSize = true;
            checkBoxCplusPlus.Location = new Point(17, 51);
            checkBoxCplusPlus.Name = "checkBoxCplusPlus";
            checkBoxCplusPlus.Size = new Size(50, 19);
            checkBoxCplusPlus.TabIndex = 1;
            checkBoxCplusPlus.Text = "C++";
            checkBoxCplusPlus.UseVisualStyleBackColor = true;
            // 
            // checkBoxCSharp
            // 
            checkBoxCSharp.AutoSize = true;
            checkBoxCSharp.Location = new Point(17, 26);
            checkBoxCSharp.Name = "checkBoxCSharp";
            checkBoxCSharp.Size = new Size(41, 19);
            checkBoxCSharp.TabIndex = 0;
            checkBoxCSharp.Text = "C#";
            checkBoxCSharp.UseVisualStyleBackColor = true;
            // 
            // Pais
            // 
            Pais.FormattingEnabled = true;
            Pais.ItemHeight = 15;
            Pais.Items.AddRange(new object[] { "Argentina", "Chile", "Uruguay", "China" });
            Pais.Location = new Point(28, 241);
            Pais.Name = "Pais";
            Pais.Size = new Size(280, 94);
            Pais.TabIndex = 3;
            Pais.SelectedValueChanged += ComprobarDetallePais;
            // 
            // buttonIngresar
            // 
            buttonIngresar.Location = new Point(347, 306);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(123, 29);
            buttonIngresar.TabIndex = 4;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = true;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // FormularioRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 341);
            Controls.Add(buttonIngresar);
            Controls.Add(Pais);
            Controls.Add(groupBoxCursos);
            Controls.Add(groupBoxGenero);
            Controls.Add(groupBoxDetallesUsuario);
            Name = "FormularioRegistro";
            Text = "Registro";
            groupBoxDetallesUsuario.ResumeLayout(false);
            groupBoxDetallesUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUDownEdad).EndInit();
            groupBoxGenero.ResumeLayout(false);
            groupBoxGenero.PerformLayout();
            groupBoxCursos.ResumeLayout(false);
            groupBoxCursos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxDetallesUsuario;
        private NumericUpDown numericUDownEdad;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label labelEdad;
        private Label labelDireccion;
        private Label labelNombre;
        private GroupBox groupBoxGenero;
        private RadioButton radioButonNoBinario;
        private RadioButton radioButtonFemenino;
        private RadioButton radioButtonMasculino;
        private GroupBox groupBoxCursos;
        private CheckBox checkBoxJavaScript;
        private CheckBox checkBoxCplusPlus;
        private CheckBox checkBoxCSharp;
        private ListBox Pais;
        private Button buttonIngresar;
        private Label labelErrorNombre;
        private Label labelErrorDireccion;
    }
}
