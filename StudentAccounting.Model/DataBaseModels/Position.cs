﻿
namespace StudentAccounting.Model.DataBaseModels
{
    public class Position
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Participants> Participants { get; set; } = new();
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
