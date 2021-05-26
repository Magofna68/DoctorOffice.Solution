using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace DoctorOffice.Models
{
  public class Doctor
  {
    public Doctor()
    {
      this.JoinEntities = new HashSet<DoctorPatient>();
    }

    public int DoctorId { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    public virtual ICollection<DoctorPatient> JoinEntities { get; set; }
  }
}