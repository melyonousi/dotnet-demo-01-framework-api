using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dotnet_demo_framework_api_04.Models
{
    public class Book
    {
        [Required]
        [MaxLength(100, ErrorMessage = "title should be less then or equal 100 charactere")]
        [MinLength(5, ErrorMessage = "title should be grethear then or equal 5 charactere")]
        public string Title { get; set; }

        [Required]
        public int NumberOfPages { get; set; }
    }
}