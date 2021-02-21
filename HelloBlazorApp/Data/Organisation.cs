using System;
using System.Collections.Generic;

namespace HelloBlazorApp.Data
{
    public class Organisation
    {
        public string Name { get; set; }
        public Guid EntityKey { get => Guid.Empty; }

        public List<JobRole> JobRoles { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
