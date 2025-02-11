﻿
namespace StudentAccounting.Model.DataBaseModels
{
    public class Project
    {
        public int Id { get; set; }
        public string Fullname { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime DateStart { get; set; } 
        public DateTime DateEnd { get; set; }
        public string Description { get; set; } = string.Empty;
        public string TechnicalSpecification { get; set; } = string.Empty;
        public decimal Budget { get; set; }
        public List<ProjectExecutor> ProjectExecutors { get; set; } = new();
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
