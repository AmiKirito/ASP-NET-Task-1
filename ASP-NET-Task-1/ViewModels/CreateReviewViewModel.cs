using ASP_NET_Task_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_NET_Task_1.ViewModels
{
    public class CreateReviewViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Content { get; set; }
        public Survey MyProperty { get; set; }
    }
}