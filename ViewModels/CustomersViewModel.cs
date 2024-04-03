using exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exercise.ViewModels
{
    public class CustomersViewModel
    {
        public Headers header { get; set; }
        public List<Customer> customers { get; set; }

    }
}