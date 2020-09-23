using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_CoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_CoreApp.Controllers
{
    public class AssignmentsController : Controller
    {
        private StudentContext context { get; set; }

        public AssignmentsController(StudentContext ctx)
        {
            context = ctx;
        }
        
    }
}
