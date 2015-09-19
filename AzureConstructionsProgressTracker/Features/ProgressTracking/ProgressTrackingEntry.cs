using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzureConstructionsProgressTracker.Features.ConstructionProjects;

namespace AzureConstructionsProgressTracker.Features.ProgressTracking
{
    public class ProgressTrackingEntry
    {
        public int Id { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        public string PictureReference { get; set; }

        public DateTime EntryDate { get; set; }
        
        public int ConstructionProjectId { get; set; }

        public virtual ConstructionProject ConstructionProject { get; set; }
    }
}
