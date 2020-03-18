using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    class User
    {
		private int userId;
		private String username;
		private String firstname;
		private String lastname;
		private String email;
		private String phonenumber;
		private String password;

		public int UserId
		{
			get { return userId; }
			set { userId = value; }
		}

		public String Username
		{
			get { return username; }
			set { username = value; }
		}

		public String Firstname
		{
			get { return firstname; }
			set { firstname = value; }
		}
		public String Lastname
		{
			get { return lastname; }
			set { lastname = value; }
		}
		public String Phonenumber
		{
			get { return phonenumber; }
			set { phonenumber = value; }
		}
		public String Password
		{
			get { return password; }
			set { password = value; }
		}
		public String Email
		{
			get { return email; }
			set { email = value; }
		}


	}
}
