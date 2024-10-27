using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_2;

public class Organization : IStaff
{
    public int Id { get; private set; }
    public string Name { get; protected set; }
    public Type ShortName { get; protected set; }
    public string Address { get; protected set; }
    public DateTime timeStramp { get; protected set; }

    #region CONSTRUCTORS

    public Organization()
    {
        Name = string.Empty;
        ShortName = null;
        Address = string.Empty;
        timeStramp = DateTime.Now;
    }

    public Organization(Organization organization)
    {
        Name = organization.Name;
        ShortName = organization.ShortName;
        Address = organization.Address;
        timeStramp = organization.timeStramp;
    }

    public Organization(string name, Type shortName, string address)
    {
        Name = name;
        ShortName = shortName;
        Address = address;
        timeStramp = DateTime.Now;
    }

    #endregion CONSTRUCTORS

    public void printinfo()
    {
        Console.WriteLine($"Name: {Name}, ShortName: {ShortName}, Address: {Address}");
    }

    public List<JobVacancy> GetJobVacancies()
    {
        throw new NotImplementedException();
    }

    public List<Employee> GetEmployees()
    {
        throw new NotImplementedException();
    }

    public List<JobTitle> GetJobTitles()
    {
        throw new NotImplementedException();
    }

    public int AddJobTitle(JobTitle jobTitle)
    {
        throw new NotImplementedException();
    }

    public string PrintJobVacancies()
    {
        throw new NotImplementedException();
    }

    public bool DeleteJobTitle(int jobTitleId)
    {
        throw new NotImplementedException();
    }

    public bool OpenJobVacancy(JobVacancy jobVacancy)
    {
        throw new NotImplementedException();
    }

    public bool CloseJobVacancy(int jobVacancyId)
    {
        throw new NotImplementedException();
    }

    public Employee Recruit(JobVacancy jobVacancy, Person person)
    {
        Employee newEmployee = new Employee(jobVacancy, person);
        return newEmployee;
    }

    public bool Dismiss(int employeeId, string reason)
    {
        Employee employee = Eployee.FirstOrDefault(e => employeeId == employeeId);
        if (employee != null)
        {
            Employee.Remove(employee);
            reason = "Увольнение по собственному желанию";
            employee.Dismiss(reason);
            return true;
        }
        return false;
    }
    
    public class Eployee
    {
        public static Employee FirstOrDefault(Func<object, bool> func)
        {
            throw new NotImplementedException();
        }
    }
}