namespace WinFormsAppPracticaLogin1
{
    partial class FormLogin
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
            label2 = new Label();
            txtUser = new TextBox();
            txtPassWord = new TextBox();
            txtIngresoDelUser = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 66);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 189);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(124, 84);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(128, 23);
            txtUser.TabIndex = 2;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(124, 207);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(128, 23);
            txtPassWord.TabIndex = 3;
            // 
            // txtIngresoDelUser
            // 
            txtIngresoDelUser.Location = new Point(27, 287);
            txtIngresoDelUser.Name = "txtIngresoDelUser";
            txtIngresoDelUser.ReadOnly = true;
            txtIngresoDelUser.Size = new Size(328, 23);
            txtIngresoDelUser.TabIndex = 4;
            txtIngresoDelUser.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 362);
            Controls.Add(txtIngresoDelUser);
            Controls.Add(txtPassWord);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPassWord;
        private TextBox txtIngresoDelUser;
    }
}
