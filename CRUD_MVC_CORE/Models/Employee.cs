﻿using System.ComponentModel.DataAnnotations;

namespace CRUD_MVC_CORE.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Department {  get; set; }

        [Required]
        public int Salary { get; set; }
    }
}
