namespace StudentProf.App
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
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label4 = new Label();
            lblYearLevel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            label1.Location = new Point(183, 86);
            label1.Name = "label1";
            label1.Size = new Size(122, 37);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F);
            label2.Location = new Point(40, 157);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 1;
            label2.Text = "USERNAME:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(183, 157);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(230, 23);
            txtUsername.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F);
            label3.Location = new Point(40, 219);
            label3.Name = "label3";
            label3.Size = new Size(140, 25);
            label3.TabIndex = 3;
            label3.Text = "PASSWORD:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(183, 219);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(230, 23);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(193, 276);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(101, 34);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            label4.Location = new Point(19, 339);
            label4.Name = "label4";
            label4.Size = new Size(233, 37);
            label4.TabIndex = 6;
            label4.Text = "YEAR LEVEL:";
            // 
            // lblYearLevel
            // 
            lblYearLevel.AutoSize = true;
            lblYearLevel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            lblYearLevel.Location = new Point(249, 339);
            lblYearLevel.Name = "lblYearLevel";
            lblYearLevel.Size = new Size(36, 37);
            lblYearLevel.TabIndex = 7;
            lblYearLevel.Text = "2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 418);
            Controls.Add(lblYearLevel);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
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
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label4;
        private Label lblYearLevel;
    }
}
