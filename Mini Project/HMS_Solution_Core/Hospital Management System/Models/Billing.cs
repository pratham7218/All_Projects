using System;
using System.Collections.Generic;

namespace Hospital_Management_System.models
{
    public partial class Billing
    {
        public string BillNumber { get; set; } = null!;
        public int? PatientId { get; set; }
        public int? ConsumableId { get; set; }
        public int? UserId { get; set; }

        public virtual Consumable? Consumable { get; set; }
        public virtual Patient? Patient { get; set; }
        public virtual UserTable? User { get; set; }
    }
}
