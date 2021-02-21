using System;

namespace HelloBlazorApp.Data
{
    public class JobRole
    {
        public Guid EntityKey { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid UpperHierarchyJobRoleKey { get; set; }
    }
}
