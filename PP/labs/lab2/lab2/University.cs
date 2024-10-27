using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class University : Organization
    {
        protected List<Faculty> faculties;

        public University()
        {
            faculties = new List<Faculty>();
        }

        public University(University university)
        {

        }

        public University(string name, string shortname, string address)
        {

        }

        public int addFaculty(Faculty faculty)
        {
            faculties.Add(faculty);
            return 0;
        }

        public bool DelFaculty(int index)
        {
            if (VerFaculty(index))
            {
                faculties.RemoveAt(index);
                return true;
            }
            else
                return false;
        }

        public bool updFaculty(Faculty faculty)
        {
            if (!faculties.Contains(faculty))
                return false;

            int index = faculties.IndexOf(faculty);

            faculties[index] = new Faculty();
            return true;
        }

        private bool VerFaculty(int index)
        {
            if (index >= 0 && index < faculties.Count)
                return true;
            else
                return false;
        }

        public List<Faculty> GetFaculties()
        {
            return faculties;

        }
        
    }

}