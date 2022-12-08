using System;
using System.Collections.Generic;

namespace Hospital_Management_System.models
{
    public partial class Patient
    {
        public Patient()
        {
            Appointments = new HashSet<Appointment>();
            Billings = new HashSet<Billing>();
        }

        public int PatientId { get; set; }
        public string? PrevHistory { get; set; }
        public string? Reports { get; set; }
        public int? UserId { get; set; }

        public virtual UserTable? User { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Billing> Billings { get; set; }
    }
}
