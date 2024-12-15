namespace Users;

public class User
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Password { get; set; }
        public string Email_Address { get; set; }

        public User(string fname, string lname ,string password,string email_Address )
        {
             FName = fname;
             LName = lname;
            Password = password;
             Email_Address = email_Address;
        }
    }

