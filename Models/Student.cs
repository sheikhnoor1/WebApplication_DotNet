using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net.Cache;
using WebApplication_DotNet.Validations;

namespace WebApplication_DotNet.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Student id Required")]
        [StringLength(10, ErrorMessage = "Student cannot exceed 10 characters")]
        public string StudentId { get; set; }

        [Required(ErrorMessage = "Student name Required")]
        [StringLength(100, MinimumLength =3, ErrorMessage ="Student name must be between 3 to 100 Character")]
        public string Name { get; set; }

        [Required(ErrorMessage="Email is required")]
        [EmailAddress(ErrorMessage ="Email Address Must Be Valid ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is Required")]
        [Range(16,40, ErrorMessage = "Age must be between 16 and 40")]
        public int Age { get; set; }

        [Required(ErrorMessage = "CGPA is Required")]
        [Range(0.0, 4.0, ErrorMessage ="CGPA must be between 0.0 to 4.0")]
        public double CGPA { get; set; }
        
        // Add this property to the Student class
        [Required(ErrorMessage = "Date of birth is required")]
        [MinimumAge(16)]
        public DateTime DateOfBirth { get; set; }

    }
}
