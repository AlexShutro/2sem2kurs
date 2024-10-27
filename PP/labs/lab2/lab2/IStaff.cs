using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2;

namespace Lab_2
{
    
    public interface IStaff
    {
        List<JobVacancy> GetJobVacancies();
        List<Employee> GetEmployees();
        List<JobTitle> GetJobTitles();
        int AddJobTitle(JobTitle jobTitle);
        string PrintJobVacancies();
        bool DeleteJobTitle(int jobTitleId);
        bool OpenJobVacancy(JobVacancy jobVacancy);
        bool CloseJobVacancy(int jobVacancyId);
        Employee Recruit(JobVacancy jobVacancy, Person person);
        bool Dismiss(int employeeId, string reason);
    }
    public class Person
    {
    } 
    public class JobTitle
    {
    }
    public class Employee
    {
        public Employee(JobVacancy jobVacancy, Person person)
        {
            throw new NotImplementedException();
        }

        public static void Remove(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Dismiss(string reason)
        {
            throw new NotImplementedException();
        }
    }
}