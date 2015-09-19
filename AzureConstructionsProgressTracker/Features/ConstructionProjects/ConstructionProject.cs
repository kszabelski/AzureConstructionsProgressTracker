using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AzureConstructionsProgressTracker.Features.ConstructionProjects
{
    public class ConstructionProject
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
}