using System;
using System.Collections.Generic;

#nullable disable

namespace Software_Accounting.Models
{
    public partial class ProgressStatus
    {
        public ProgressStatus()
        {
            Softwares = new HashSet<Software>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Software> Softwares { get; set; }
    }
}
