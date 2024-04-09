namespace Assignment4.UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLogin = new Button();
            labelUsername = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            labelPassword = new Label();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(221, 227);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(129, 41);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.ForeColor = SystemColors.ButtonHighlight;
            labelUsername.Location = new Point(42, 52);
            labelUsername.Margin = new Padding(4, 0, 4, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(106, 28);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username";
            // 
            // textUsername
            // 
            textUsername.Location = new Point(42, 84);
            textUsername.Margin = new Padding(4);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(308, 34);
            textUsername.TabIndex = 2;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(42, 161);
            textPassword.Margin = new Padding(4);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(308, 34);
            textPassword.TabIndex = 4;
            textPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.ForeColor = SystemColors.ButtonHighlight;
            labelPassword.Location = new Point(42, 129);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(101, 28);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(42, 227);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(129, 41);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1024, 1024);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(50, 86, 112);
            groupBox1.Controls.Add(labelUsername);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(textUsername);
            groupBox1.Controls.Add(textPassword);
            groupBox1.Controls.Add(labelPassword);
            groupBox1.Location = new Point(60, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 321);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(522, 72);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 8;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(522, 100);
            label2.Name = "label2";
            label2.Size = new Size(221, 28);
            label2.TabIndex = 9;
            label2.Text = "Please login to continue";
            // 
            // Login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(110, 158, 178);
            CancelButton = btnExit;
            ClientSize = new Size(918, 436);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label labelUsername;
        private TextBox textUsername;
        private TextBox textPassword;
        private Label labelPassword;
        private Button btnExit;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
    }
}