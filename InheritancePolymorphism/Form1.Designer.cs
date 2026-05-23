namespace InheritancePolymorphism
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            txtUserId = new ReaLTaiizor.Controls.HopeTextBox();
            txtPassword = new ReaLTaiizor.Controls.HopeTextBox();
            btnLogin = new ReaLTaiizor.Controls.HopeButton();
            lblSystemLogin = new Label();
            SuspendLayout();
            // 
            // hopeForm1
            // 
            hopeForm1.ControlBoxColorH = Color.FromArgb(228, 228, 228);
            hopeForm1.ControlBoxColorHC = Color.FromArgb(245, 108, 108);
            hopeForm1.ControlBoxColorN = Color.White;
            hopeForm1.Dock = DockStyle.Fill;
            hopeForm1.Font = new Font("Segoe UI", 12F);
            hopeForm1.ForeColor = Color.FromArgb(242, 246, 252);
            hopeForm1.Image = (Image)resources.GetObject("hopeForm1.Image");
            hopeForm1.Location = new Point(0, 0);
            hopeForm1.Name = "hopeForm1";
            hopeForm1.Size = new Size(400, 40);
            hopeForm1.TabIndex = 0;
            hopeForm1.Text = "System Access";
            hopeForm1.ThemeColor = Color.FromArgb(218, 165, 32);
            // 
            // txtUserId
            // 
            txtUserId.BackColor = Color.White;
            txtUserId.BaseColor = Color.White;
            txtUserId.BorderColorA = Color.FromArgb(218, 165, 32);
            txtUserId.BorderColorB = Color.FromArgb(220, 223, 230);
            txtUserId.Font = new Font("Segoe UI", 10F);
            txtUserId.ForeColor = Color.FromArgb(48, 49, 51);
            txtUserId.Hint = "User ID";
            txtUserId.Location = new Point(50, 120);
            txtUserId.MaxLength = 32767;
            txtUserId.Multiline = false;
            txtUserId.Name = "txtUserId";
            txtUserId.PasswordChar = '\0';
            txtUserId.ScrollBars = ScrollBars.None;
            txtUserId.SelectedText = "";
            txtUserId.SelectionLength = 0;
            txtUserId.SelectionStart = 0;
            txtUserId.Size = new Size(300, 34);
            txtUserId.TabIndex = 1;
            txtUserId.TabStop = false;
            txtUserId.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BaseColor = Color.White;
            txtPassword.BorderColorA = Color.FromArgb(218, 165, 32);
            txtPassword.BorderColorB = Color.FromArgb(220, 223, 230);
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.FromArgb(48, 49, 51);
            txtPassword.Hint = "Password";
            txtPassword.Location = new Point(50, 180);
            txtPassword.MaxLength = 32767;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.ScrollBars = ScrollBars.None;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.Size = new Size(300, 34);
            txtPassword.TabIndex = 2;
            txtPassword.TabStop = false;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BorderColor = Color.FromArgb(220, 223, 230);
            btnLogin.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.DangerColor = Color.FromArgb(245, 108, 108);
            btnLogin.DefaultColor = Color.FromArgb(255, 255, 255);
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.HoverTextColor = Color.White;
            btnLogin.InfoColor = Color.FromArgb(144, 147, 153);
            btnLogin.Location = new Point(50, 250);
            btnLogin.Name = "btnLogin";
            btnLogin.PrimaryColor = Color.FromArgb(218, 165, 32);
            btnLogin.Size = new Size(300, 40);
            btnLogin.SuccessColor = Color.FromArgb(103, 194, 58);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Authenticate";
            btnLogin.TextColor = Color.White;
            btnLogin.WarningColor = Color.FromArgb(230, 162, 60);
            btnLogin.Click += btnLogin_Click;
            // 
            // lblSystemLogin
            // 
            lblSystemLogin.AutoSize = true;
            lblSystemLogin.BackColor = Color.White;
            lblSystemLogin.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSystemLogin.ForeColor = Color.FromArgb(218, 165, 32);
            lblSystemLogin.Location = new Point(99, 65);
            lblSystemLogin.Name = "lblSystemLogin";
            lblSystemLogin.Size = new Size(188, 37);
            lblSystemLogin.TabIndex = 4;
            lblSystemLogin.Text = "System Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 350);
            Controls.Add(lblSystemLogin);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserId);
            Controls.Add(hopeForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1032);
            MinimumSize = new Size(190, 40);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "System Access";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private System.Windows.Forms.Label lblSystemLogin;
        private ReaLTaiizor.Controls.HopeTextBox txtUserId;
        private ReaLTaiizor.Controls.HopeTextBox txtPassword;
        private ReaLTaiizor.Controls.HopeButton btnLogin;
    }
}