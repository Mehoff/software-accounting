using System;
using System.Collections.Generic;

#nullable disable

namespace Software_Accounting.Models
{
    public partial class Software
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? BeginDateTime { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public string SourceUrl { get; set; }
        public int? ProjectFk { get; set; }
        public int? AuthorFk { get; set; }
        public int? ProgressStatusFk { get; set; }

        public virtual Employee AuthorFkNavigation { get; set; }
        public virtual ProgressStatus ProgressStatusFkNavigation { get; set; }
        public virtual Project ProjectFkNavigation { get; set; }
    }
}
