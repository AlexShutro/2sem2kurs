using DatabasedProject.Contexts;
using DatabasedProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasedProject.Repositories
{
    internal class SubjectsRepository : IRepository<Subject>
    {
        private ConsultContext db;
        public SubjectsRepository(ConsultContext context)
        {
            this.db = context;
        }

        public IEnumerable<Subject> GetAll()
        {
            return db.Subjects;
        }

        public Subject Get(int id)
        {
            return db.Subjects.Find(id);
        }

        public async void Create(Subject subject)
        {
            db.Subjects.Add(subject);
        }

        public void Update(Subject subject)
        {
            db.Entry(subject).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Delete(int id)
        {
            Subject subject = db.Subjects.Find(id);
            if (subject != null)
            {
                db.Subjects.Remove(subject);
            }
        }
    }
}
