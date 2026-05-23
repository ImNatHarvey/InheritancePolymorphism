namespace InheritancePolymorphism
{
    partial class MessageDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageDialog));
            hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            lblMessage = new Label();
            btnOk = new ReaLTaiizor.Controls.HopeButton();
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
            hopeForm1.Size = new Size(350, 40);
            hopeForm1.TabIndex = 0;
            hopeForm1.ThemeColor = Color.FromArgb(218, 165, 32);
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.White;
            lblMessage.Font = new Font("Segoe UI", 11F);
            lblMessage.ForeColor = Color.FromArgb(64, 64, 64);
            lblMessage.Location = new Point(25, 60);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(300, 60);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "Message goes here.";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            btnOk.BorderColor = Color.FromArgb(220, 223, 230);
            btnOk.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnOk.Cursor = Cursors.Hand;
            btnOk.DangerColor = Color.FromArgb(245, 108, 108);
            btnOk.DefaultColor = Color.FromArgb(255, 255, 255);
            btnOk.Font = new Font("Segoe UI", 12F);
            btnOk.HoverTextColor = Color.White;
            btnOk.InfoColor = Color.FromArgb(144, 147, 153);
            btnOk.Location = new Point(125, 140);
            btnOk.Name = "btnOk";
            btnOk.PrimaryColor = Color.FromArgb(218, 165, 32);
            btnOk.Size = new Size(100, 35);
            btnOk.SuccessColor = Color.FromArgb(103, 194, 58);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.TextColor = Color.White;
            btnOk.WarningColor = Color.FromArgb(230, 162, 60);
            btnOk.Click += btnOk_Click;
            // 
            // MessageDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(350, 200);
            Controls.Add(btnOk);
            Controls.Add(lblMessage);
            Controls.Add(hopeForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1032);
            MinimumSize = new Size(190, 40);
            Name = "MessageDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "MessageDialog";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private System.Windows.Forms.Label lblMessage;
        private ReaLTaiizor.Controls.HopeButton btnOk;
    }
}