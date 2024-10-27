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
    internal class User : INotifyPropertyChanged
    {
        private string fullname;
        [Key]
        private int id;
        private Subject subject;
        private int subjectId;

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
                OnPropertyChanged("UserId");
            }
        }

        public int SubjectId
        {
            get { return subjectId; }
            set
            {
                subjectId = value;
                OnPropertyChanged("SubjectId");
            }
        }

        public Subject Subject
        {
            get { return subject; }
            set
            {
                subject = value;
                OnPropertyChanged("Subject");
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
