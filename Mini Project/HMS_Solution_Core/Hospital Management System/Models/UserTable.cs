using System;
using System.Collections.Generic;

namespace Hospital_Management_System.models
{
    public partial class UserTable
    {
        public UserTable()
        {
            Appointments = new HashSet<Appointment>();
            Billings = new HashSet<Billing>();
            Patients = new HashSet<Patient>();
        }

        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? Age { get; set; }
        public string? ContactNumber { get; set; }
        public string? Gender { get; set; }
        public string? StaffCategory { get; set; }
        public string? Specialization { get; set; }
        public int? RoleId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Billing> Billings { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
