using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentInfoAPI.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string S_FirstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string S_LastName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string S_MiddleName { get; set; }

        public int StudentLevel { get; set; }


        [Column(TypeName = "varchar(50)")]
        public string StudentContacts { get; set; }


        [Column(TypeName = "varchar(50)")]
        public string StudentEmail { get; set; }

        public DateTime TDT { get; set; }

        public DateTime UDT { get; set; }

    }
}
