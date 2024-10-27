using DatabasedProject.Commands;
using DatabasedProject.Contexts;
using DatabasedProject.Models;
using DatabasedProject.Repositories;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DatabasedProject.ViewModels
{
    internal class ApplicationViewModel : INotifyPropertyChanged
    {
        static UnitOfWork unitOfWork;

        // -------------------------- Общие команды ----------------------------
        private MyCommand back;
        public MyCommand Back
        {
            get
            {
                return back ?? (back = new MyCommand(
                    (obj) =>
                    {
                        SwitchPage = 0;
                    }));
            }
        }
        
        // ------------- Команды и свойства для CancelConsult.xaml --------------
        private MyCommand cancelConsult;
        public MyCommand CancelConsult
        {
            get
            {
                return cancelConsult ?? (cancelConsult = new MyCommand(
                    (obj) =>
                    {
                        foreach (var item in unitOfWork.Users.GetAll().ToList())
                        {
                            if (item.Fullname == UserName)
                            {
                                unitOfWork.Users.Delete(item.Id);
                            }
                        }
                        SwitchPage = 0;
                        unitOfWork.Save();
                        UserName = "";
                    },
                    (obj) =>
                    {
                        foreach (var item in unitOfWork.Users.GetAll().ToList())
                        {
                            if (item.Fullname == UserName)
                            {
                                return true;
                            }
                        }
                        return false;
                    }));
            }
        }

        private string userName = "";
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
                OnPropertyChanged("UserName");
            }
        }

        // ----------------------------------------------------------------------
        // -------------- Команды и свойства для ConsultList.xaml ---------------
        private List<Consult> infoUsers;
        public List<Consult> InfoUsers
        {
            get
            {
                List<Consult> list = new List<Consult>();
                if (SearchName != null && SearchName != "" && (SearchSubject == null || SearchSubject == ""))
                {
                    foreach (var user in unitOfWork.Users.GetAll().ToList())
                    {
                        foreach (var subject in unitOfWork.Subjects.GetAll().ToList())
                        {
                            foreach (var teacher in unitOfWork.Teachers.GetAll().ToList())
                            {
                                if (user.Subject == subject && subject.TeacherId == teacher.Id && user.Fullname.Contains(SearchName)) list.Add(new Consult { UserName = user.Fullname, SubjectName = subject.SubjectName, Date = subject.Date, StartTime = subject.TimeStart, EndTime = subject.TimeFinish, TeacherName = teacher.Fullname });
                            }
                        }
                    }
                }
                else if (SearchSubject != null && SearchSubject != "" && (SearchName == null || SearchName == ""))
                {
                    foreach (var user in unitOfWork.Users.GetAll().ToList())
                    {
                        foreach (var subject in unitOfWork.Subjects.GetAll().ToList())
                        {
                            foreach (var teacher in unitOfWork.Teachers.GetAll().ToList())
                            {
                                if (user.Subject == subject && subject.TeacherId == teacher.Id && subject.SubjectName.Contains(SearchSubject)) list.Add(new Consult { UserName = user.Fullname, SubjectName = subject.SubjectName, Date = subject.Date, StartTime = subject.TimeStart, EndTime = subject.TimeFinish, TeacherName = teacher.Fullname });
                            }
                        }
                    }
                }
                else if (SearchSubject != null && SearchSubject != "" && SearchName != null && SearchName != "")
                {
                    foreach (var user in unitOfWork.Users.GetAll().ToList())
                    {
                        foreach (var subject in unitOfWork.Subjects.GetAll().ToList())
                        {
                            foreach (var teacher in unitOfWork.Teachers.GetAll().ToList())
                            {
                                if (user.Subject == subject && subject.TeacherId == teacher.Id && subject.SubjectName.Contains(SearchSubject) && user.Fullname.Contains(SearchName)) list.Add(new Consult { UserName = user.Fullname, SubjectName = subject.SubjectName, Date = subject.Date, StartTime = subject.TimeStart, EndTime = subject.TimeFinish, TeacherName = teacher.Fullname });
                            }
                        }
                    }
                }
                else if ((SearchName == null || SearchName == "") && (SearchSubject == "" || SearchSubject == null))
                {
                    foreach (var user in unitOfWork.Users.GetAll().ToList())
                    {
                        foreach (var subject in unitOfWork.Subjects.GetAll().ToList())
                        {
                            foreach (var teacher in unitOfWork.Teachers.GetAll().ToList())
                            {
                                if (user.Subject == subject && subject.TeacherId == teacher.Id) list.Add(new Consult { UserName = user.Fullname, SubjectName = subject.SubjectName, Date = subject.Date, StartTime = subject.TimeStart, EndTime = subject.TimeFinish, TeacherName = teacher.Fullname });
                            }
                        }
                    }
                }
                return list;
            }
            set
            {
                infoUsers = value;
                OnPropertyChanged("InfoUsers");
            }
        }

        private string searchName;
        public string SearchName
        {
            get
            {
                return searchName;
            }
            set
            {
                SwitchPage = 0;
                SwitchPage = 6;
                searchName = value;
                OnPropertyChanged("SearchName");
            }
        }

        private string searchSubject;
        public string SearchSubject
        {
            get
            {
                return searchSubject;
            }
            set
            {
                SwitchPage = 0;
                SwitchPage = 6;
                searchSubject = value;
                OnPropertyChanged("SearchSubject");
            }
        }
        // ------------- Команды и свойства для CreateConsult.xaml --------------
        private MyCommand addTeacher;
        public MyCommand AddTeacher
        {
            get
            {
                return addTeacher ?? (addTeacher = new MyCommand(
                    (obj) =>
                    {
                        unitOfWork.Teachers.Create(AddingTeacher);
                        unitOfWork.Save();
                        AddingTeacher = new Teacher();
                        SwitchPage = 0;
                    },
                    (obj) =>
                    {
                        return !(String.IsNullOrEmpty(AddingTeacher.Fullname)) && AddingTeacher.Subjects != null;
                    }));
            }
        }

        private MyCommand goToCreatingSubject;
        public MyCommand GoToCreatingSubject
        {
            get
            {
                return goToCreatingSubject ?? (goToCreatingSubject = new MyCommand(
                    (obj) =>
                    {
                        SwitchPage = 3;
                    }));
            }
        }

        private Teacher addingTeacher = new Teacher();
        public Teacher AddingTeacher
        {
            get
            {
                return addingTeacher;
            }
            set
            {
                addingTeacher = value;
                OnPropertyChanged("AddingTeacher");
            }
        }
        
        // ------------- Команды и свойства для CreateSubject.xaml --------------
        private MyCommand back2;
        public MyCommand Back2
        {
            get
            {
                return back2 ?? (back2 = new MyCommand(
                    (obj) =>
                    {
                        SwitchPage = 2;
                    }));
            }
        }

        private MyCommand addSubject;
        public MyCommand AddSubject
        {
            get
            {
                return addSubject ?? (addSubject = new MyCommand(
                    (obj) =>
                    {
                        unitOfWork.Subjects.Create(AddingSubject);
                        AddingTeacher.Subjects.Add(AddingSubject);
                        AddingSubject = new Subject();
                        SwitchPage = 2;
                    },
                    (obj) =>
                    {
                        return !(String.IsNullOrEmpty(AddingSubject.SubjectName)) && AddingSubject.Date != null && AddingSubject.TimeFinish != null && AddingSubject.TimeStart != null;
                    }));
            }
        }

        private Subject addingSubject = new Subject();
        public Subject AddingSubject
        {
            get
            {
                return addingSubject;
            }
            set
            {
                addingSubject = value;
                OnPropertyChanged("AddingSubject");
            }
        }
        
        // -------------- Команды и свойства для CreateUser.xaml ----------------
        private MyCommand addUser;
        public MyCommand AddUser
        {
            get
            {
                return addUser ?? (addUser = new MyCommand(
                    (obj) =>
                    {
                        foreach (var u in unitOfWork.Users.GetAll().ToList())
                            if (u.Fullname == AddingUser.Fullname)
                            {
                                MessageBox.Show("Пользователь уже записан на консультацию..");
                                return;
                            }
                        AddingUser.Subject = selectedSubject;
                        unitOfWork.Users.Create(AddingUser);
                        unitOfWork.Save();
                        AddingUser = new User();
                        SwitchPage = 0;
                    },
                    (obj) =>
                    {
                        return !(String.IsNullOrEmpty(AddingUser.Fullname)) && selectedSubject != null;
                    }));
            }
        }

        private Subject selectedSubject;
        public Subject SelectedSubject
        {
            get
            {
                return selectedSubject;
            }
            set
            {
                selectedSubject = value;
                OnPropertyChanged("SelectedSubject");
            }
        }

        private List<Subject> subjects = new List<Subject> { };
        public List<Subject> Subjects
        {
            get
            {
                return subjects = unitOfWork.Subjects.GetAll().ToList();
            }
            set
            {
                subjects = value;
                OnPropertyChanged("Subjects");
            }
        }

        private User addingUser = new User();
        public User AddingUser
        {
            get
            {
                return addingUser;
            }
            set
            {
                addingUser = value;
                OnPropertyChanged("AddingUser");
            }
        }

        // ----------------------------------------------------------------------
        // ------------- Команды и свойства для DeleteConsult.xaml --------------
        private MyCommand deleteConsults;
        public MyCommand DeleteConsults
        {
            get
            {
                return deleteConsults ?? (deleteConsults = new MyCommand(
                    (obj) =>
                    {
                        foreach (var item in unitOfWork.Subjects.GetAll())
                        {
                            if (item.TeacherId == DeletingTeacher.Id)
                            {
                                unitOfWork.Subjects.Delete(item.Id);
                            }
                        }
                        unitOfWork.Teachers.Delete(DeletingTeacher.Id);
                        unitOfWork.Save();
                        DeletingTeacher = new Teacher();
                        foreach (var item in unitOfWork.Users.GetAll().ToList())
                        {
                            if (item.Subject.Id == 0) unitOfWork.Users.Delete(item.Id);
                        }
                        unitOfWork.Save();
                        SwitchPage = 0;
                    },
                    (obj) =>
                    {
                        return DeletingTeacher.Id != 0;
                    }));
            }
        }

        private Teacher deletingTeacher = new Teacher();
        public Teacher DeletingTeacher
        {
            get
            {
                return deletingTeacher;
            }
            set
            {
                deletingTeacher = value;
                OnPropertyChanged("DeletingTeacher");
            }
        }

        private IEnumerable<Teacher> allTeachers = new List<Teacher>();
        public IEnumerable<Teacher> AllTeachers
        {
            get
            {
                return allTeachers = unitOfWork.Teachers.GetAll().ToList();
            }
            set
            {
                allTeachers = value;
                OnPropertyChanged("AllTeachers");
            }
        }
        
        // -------------- Команды и свойства для Main.xaml ----------------------
        private MyCommand goToCreatingUser;
        public MyCommand GoToCreatingUser
        {
            get 
            {
                return goToCreatingUser ?? (goToCreatingUser = new MyCommand(
                    (obj) =>
                    {
                        SwitchPage = 1;
                    }));
            }
        }

        private MyCommand goToCreatingConsult;
        public MyCommand GoToCreatingConsult
        {
            get
            {
                return goToCreatingConsult ?? (goToCreatingConsult = new MyCommand(
                    (obj) =>
                    {
                        SwitchPage = 2;
                    }));
            }
        }

        private MyCommand goToDeletingConsult;
        public MyCommand GoToDeletingConsult
        {
            get
            {
                return goToDeletingConsult ?? (goToDeletingConsult = new MyCommand(
                    (obj) =>
                    {
                        SwitchPage = 4;
                    }));
            }
        }

        private MyCommand goToCancelingConsult;
        public MyCommand GoToCancelingConsult
        {
            get
            {
                return goToCancelingConsult ?? (goToCancelingConsult = new MyCommand(
                    (obj) =>
                    {
                        SwitchPage = 5;
                    }));
            }
        }
        private MyCommand goToConsultList;
        public MyCommand GoToConsultList
        {
            get
            {
                return goToConsultList ?? (goToConsultList = new MyCommand(
                    (obj) =>
                    {
                        SearchName = null;
                        SearchSubject = null;
                        SwitchPage = 6;
                    }));
            }
        }
        private int switchPage = 0;
        public int SwitchPage
        {
            get { return switchPage; }
            set
            {
                switchPage = value;
                OnPropertyChanged("SwitchPage");
            }
        }

        public ApplicationViewModel()
        {
            unitOfWork = new UnitOfWork();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
