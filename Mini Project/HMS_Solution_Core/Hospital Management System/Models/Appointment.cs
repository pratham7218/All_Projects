using System;
using System.Collections.Generic;

namespace Hospital_Management_System.models
{
    public partial class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime? AdmitDate { get; set; }
        public int? PatientId { get; set; }
        public int? TreatmentId { get; set; }
        public int? UserId { get; set; }

        public virtual Patient? Patient { get; set; }
        public virtual Treatment? Treatment { get; set; }
        public virtual UserTable? User { get; set; }
    }
}
