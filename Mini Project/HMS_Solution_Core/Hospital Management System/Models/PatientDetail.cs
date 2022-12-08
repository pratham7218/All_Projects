using System;
using System.Collections.Generic;

namespace Hospital_Management_System.models
{
    public partial class PatientDetail
    {
        public int? PatientId { get; set; }
        public int? NoOfVisits { get; set; }
        public string? DeseaseCatagory { get; set; }

        public virtual Patient? Patient { get; set; }
    }
}
