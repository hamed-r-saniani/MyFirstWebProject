using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model_ViewModel.Models
{
    public class Degree
    {
        [Key]
        public int DegreeID { get; set; }
        public string DegreeName { get; set; }
        public List<Degree> GetDegrees()
        {
            var Degrees = new List<Degree>
            {
                new Degree{DegreeID=1,DegreeName="دیپلم"},
                new Degree{DegreeID=2,DegreeName="فوق دیپلم"},
                new Degree{DegreeID=3,DegreeName="لیسانس"},
                new Degree{DegreeID=4,DegreeName="فوق لیسانس"},
                new Degree{DegreeID=5,DegreeName="دکترا"},
            };
            return Degrees;
        }
    }
}
