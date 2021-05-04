using System;
using System.Collections.Generic;

#nullable disable

namespace Software_Accounting.Models
{
    public partial class UserType
    {
        public UserType()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
