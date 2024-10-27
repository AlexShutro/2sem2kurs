using DatabasedProject.Contexts;
using DatabasedProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasedProject.Repositories
{
    internal class TeachersRepository : IRepository<Teacher>
    {
        private ConsultContext db;
        public TeachersRepository(ConsultContext context)
        {
            this.db = context;
        }

        public IEnumerable<Teacher> GetAll()
        {
            return db.Teachers;
        }

        public Teacher Get(int id)
        {
            return db.Teachers.Find(id);
        }

        public async void Create(Teacher teacher)
        {
            db.Teachers.Add(teacher);
        }

        public void Update(Teacher teacher)
        {
            db.Entry(teacher).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Delete(int id)
        {
            Teacher teacher = db.Teachers.Find(id);
            if (teacher != null)
            {
                db.Teachers.Remove(teacher);
            }
        }
    }
}
