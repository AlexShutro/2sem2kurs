using DatabasedProject.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabasedProject.Repositories
{
    internal class UnitOfWork : IDisposable
    {
        private ConsultContext db = new ConsultContext();
        private UsersRepository? usersRepository;
        private SubjectsRepository? subjectsRepository;
        private TeachersRepository? teachersRepository;

        public UsersRepository Users
        {
            get
            {
                if (usersRepository == null)
                {
                    usersRepository = new UsersRepository(db);
                }
                return usersRepository;
            }
        }

        public SubjectsRepository Subjects
        {
            get
            {
                if (subjectsRepository == null)
                {
                    subjectsRepository = new SubjectsRepository(db);
                }
                return subjectsRepository;
            }
        }

        public TeachersRepository Teachers
        {
            get
            {
                if(teachersRepository == null)
                {
                    teachersRepository = new TeachersRepository(db);
                }
                return teachersRepository;
            }
        }

        public void Save()
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
