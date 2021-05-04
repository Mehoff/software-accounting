using Software_Accounting.Context;
using Software_Accounting.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Software_Accounting.Source
{
	public sealed class CurrentUser
	{
		public Employee Employee { get; set; }
		private CurrentUser() { }

		static CurrentUser() { }

		private static readonly CurrentUser instance = new CurrentUser();

		public static CurrentUser Instance
		{
			get
			{
				return instance;
			}
		}

		public void UpdateData()
		{
			using (var context = new DBContext())
			{
				Employee = context.Employees.SingleOrDefault(u => u.Id == Employee.Id);
			}
		}

        //TODO: Maybe Implement Windows Password System
        public static void LogOut()
        {
            Instance.Employee = null;
            //CredentialManager.DeleteCredential("TestSystem");
        }
    }
}
