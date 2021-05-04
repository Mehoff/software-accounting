using System;
using System.Collections.Generic;

#nullable disable

namespace Software_Accounting.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Softwares = new HashSet<Software>();
        }

        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? PositionFk { get; set; }
        public int? UserTypeFk { get; set; }

        public virtual Position PositionFkNavigation { get; set; }
        public virtual UserType UserTypeFkNavigation { get; set; }
        public virtual ICollection<Software> Softwares { get; set; }
    }
}
