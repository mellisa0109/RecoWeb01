using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecoWeb01.Models
{
    public class DbModels
    {
        [Required]
        public string SpName { get; set; }

        public string SpValueJson { get; set; }
        public List<string> SpValueList { get; set; }
        public string SpOutput { get; set; }
    }
}