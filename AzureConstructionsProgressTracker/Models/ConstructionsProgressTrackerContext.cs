using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AzureConstructionsProgressTracker.Models
{
    public class ConstructionsProgressTrackerContext : DbContext
    {
        public ConstructionsProgressTrackerContext() : base("name=ConstructionsProgressTrackerContext")
        {
            Database.SetInitializer<ConstructionsProgressTrackerContext>(new DropCreateDatabaseIfModelChanges<ConstructionsProgressTrackerContext>());
        }

        public System.Data.Entity.DbSet<AzureConstructionsProgressTracker.Features.ConstructionProjects.ConstructionProject> ConstructionProjects { get; set; }

        public System.Data.Entity.DbSet<AzureConstructionsProgressTracker.Features.ProgressTracking.ProgressTrackingEntry> ProgressTrackingEntries { get; set; }
    }
}
