using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace DoctorOffice.Models
{
  public class Patient
  {
    public Item()
    {
      this.JoinEntities = new HashSet<DoctorPatient>();
    }

    public int PatientId { get; set; }
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
  }
}