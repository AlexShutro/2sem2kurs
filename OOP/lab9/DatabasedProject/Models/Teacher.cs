using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DatabasedProject.Models
{
    internal class Teacher : INotifyPropertyChanged
    {
        private string fullname;
        [Key]
        private int id;
        private List<Subject> subjects = new List<Subject>() { };

        public string Fullname
        {
            get
            {
                return fullname;
            }
            set
            {
                fullname = value;
                OnPropertyChanged("Fullname");
            }
        }

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        public List<Subject> Subjects
        {
            get
            {
                return subjects;
            }
            set
            {
                subjects = value;
                OnPropertyChanged("Subjects");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
