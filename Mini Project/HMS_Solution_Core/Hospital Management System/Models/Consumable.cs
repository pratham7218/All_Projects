using System;
using System.Collections.Generic;

namespace Hospital_Management_System.models
{
    public partial class Consumable
    {
        public Consumable()
        {
            Billings = new HashSet<Billing>();
            Treatments = new HashSet<Treatment>();
        }

        public int ConsumableId { get; set; }
        public string? ConsumableName { get; set; }
        public string? AvailabilityDetail { get; set; }
        public int? Price { get; set; }

        public virtual ICollection<Billing> Billings { get; set; }
        public virtual ICollection<Treatment> Treatments { get; set; }
    }
}
