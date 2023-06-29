using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopCommerce.Class.User
{
	public class User
	{
		public User() { }
		private string username;
		private string password;
		private int Id;
		private string Name;
		private string Surname;
		private string Email;
		private string PhoneNumber;



		public bool LoginOperation()
		{

		return true;
		}

		public bool StringCheck(string input)
		{
			string pattern = @"^a-zA-Z";
			
			if(Regex.IsMatch(input, pattern))
			{
				MessageBox.Show("Invalid");
				return false;
			}
			else
			{
				MessageBox.Show("Valid");
				return true;
			}

		}
		public string Username
		{
			get { return username; }
			set { 
			if(!StringCheck(value))
				{
					username = value;
				}
			

			}

		}

	
	
	}

}
