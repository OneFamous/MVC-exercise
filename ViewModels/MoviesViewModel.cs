using exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace exercise.ViewModels
{
    public class MoviesViewModel
    {
        public Headers header { get; set; }

        public List<Movies> movies { get; set; }

    }
}