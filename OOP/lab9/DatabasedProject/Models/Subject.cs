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
    internal class Subject : INotifyPropertyChanged
    {
        private string subjectName;
        [Key]
        private int id;
        private DateOnly? date;
        private DateTime? timeStart;
        private DateTime? timeFinish;
        private int teacherId;

        public string SubjectName
        {
            get
            {
                return subjectName;
            }
            set
            {
                subjectName = value;
                OnPropertyChanged("SubjectName");
            }
        }

        public int TeacherId
        {
            get
            {
                return teacherId;
            }
            set
            {
                teacherId = value;
                OnPropertyChanged("TeacherId");
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

        public DateOnly? Date
        {
            get { return date; }
            set { 
                date = value;
                OnPropertyChanged("Date");
            }
        }

        public DateTime? TimeStart
        {
            get { return timeStart; }
            set { 
                timeStart = value;
                OnPropertyChanged("TimeStart");
            }
        }
        public DateTime? TimeFinish
        {
            get { return timeFinish; }
            set
            {
                timeFinish = value;
                OnPropertyChanged("TimeFinish");
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
