using System;

namespace HelloBlazorApp.Data
{
    public class Employee
    {
        public Guid EntityKey { get; set; }
        public string Name { get; set; }
        public Guid JobRoleEntityKey { get; set; }
    }
}
