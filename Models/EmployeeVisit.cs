﻿namespace se_project.Models
{
    public class EmployeeVisit
    {
        public string Username { get; set; }
        public long VisitId { get; set; }
        public virtual Visit Visit { get; set; }
        public virtual User Employee { get; set; }
    }
}
