﻿using StudentAccounting.Model.DataBaseModels;
using StudentAccounting.Model;

namespace StudentAccounting.BusinessLogic.Implementations
{
    public class ProjectService
    {
        private readonly ApplicationDatabaseContext _context;
        public ProjectService(ApplicationDatabaseContext context)
        {
            _context = context;
        }
        public void Create(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
        }
        public IEnumerable<Project> Get()
        {
            return _context.Projects.ToList();
        }
        public Project Get(int id)
        {
            return _context.Projects.FirstOrDefault(x => x.Id == id);
        }
        public void Edit(Project project)
        {
            _context.Projects.Update(project);
            _context.SaveChanges();
        }
        public void Delete(Project project)
        {
            _context.Projects.Remove(project);
            _context.SaveChanges();
        }
    }
}
