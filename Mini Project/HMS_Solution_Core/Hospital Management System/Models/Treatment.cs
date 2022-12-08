using System;
using System.Collections.Generic;

namespace Hospital_Management_System.models
{
    public partial class Treatment
    {
        public Treatment()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int TreatmentId { get; set; }
        public int? Quantity { get; set; }
        public byte[]? IsAdmitted { get; set; }
        public int? ConsumableId { get; set; }

        public virtual Consumable? Consumable { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
