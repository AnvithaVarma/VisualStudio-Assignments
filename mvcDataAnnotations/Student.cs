using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dataAnnotationsMvc.Models
{
    public class Student
    {
        [Key]
        public int stdID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollDate { get; set; }
    }


    public class Course
    {
        public int CourseID { get; set; }
        [ConcurrencyCheck]
        public string Title { get; set; }
        public int Credits { get; set; }
        [Timestamp,DataType("timestamp")]
        public byte[] TimeStamp { get; set; }
    }
    public class Course1
    {
        public int CourseID { get; set; }
        [ConcurrencyCheck]
        public string Title { get; set; }
        public int Credits { get; set; }
        [Timestamp]
        public byte[] TimeStamp { get; set; }

    }
}