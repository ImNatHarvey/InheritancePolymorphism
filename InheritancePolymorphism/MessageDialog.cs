using System;
using System.Windows.Forms;

namespace InheritancePolymorphism
{
    public partial class MessageDialog : Form
    {
        public MessageDialog(string title, string message)
        {
            InitializeComponent();
            this.hopeForm1.Text = title;
            this.lblMessage.Text = message;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void ShowBox(string title, string message)
        {
            using (MessageDialog dialog = new MessageDialog(title, message))
            {
                dialog.ShowDialog();
            }
        }
    }
}