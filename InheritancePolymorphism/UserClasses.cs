using System;

namespace UserNamespace 
{
    public class User 
    {
        private string user_id;
        protected string user_password; 

        public User(string id, string pass) 
        {
            this.user_id = id;
            this.user_password = pass;
        }

        public bool verifyLogin(string id, string pass) 
        {
            return this.user_id.Equals(id) && this.user_password.Equals(pass);
        }
        public virtual void updatePassword(string newPassword) 
        {
            this.user_password = newPassword;
        }
    }

    public class Administrator : User
    {
        private string admin_name; 

        public Administrator(string name, string id, string pass) : base(id, pass) 
        {
            this.admin_name = name;
        }

        public override void updatePassword(string newPassword) 
        {
            this.user_password = newPassword;
        }

        public void updateAdminName(string name) 
        {
            this.admin_name = name;
        }
    }
}