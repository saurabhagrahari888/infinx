using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartialViewplusView.Models
{
    public class multipleclasses
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string LName { get; set; }

    }
}