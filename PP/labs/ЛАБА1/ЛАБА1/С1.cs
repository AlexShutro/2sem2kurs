using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1;

class C1
{
    #region CONST
    private const string Album = "Vultures 1";
    public const int Year = 2024;
    protected const string Artist = "Kanye West";
    #endregion

    #region FIELDS
    private int _id;
    public string _name;
    protected string _surname;
    #endregion

    #region PROPERTIES
    private int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    protected string Surname
    {
        get { return _surname; }
        set { _surname = value; }
    }
    #endregion

    #region CONSTRUCTORS

    public C1()
    {
        Id = 0;
        Name = "Alexander";
        Surname = "Shutro";
    }

    public C1(int id, string name, string surname)
    {
        Id = id;
        Name = name;
        Surname = surname;
    }

    public C1(C1 c1)
    {
        Id = c1._id;
        Name = c1._name;
        Surname = c1._surname;
    }
    #endregion

    #region METHODS

    private void Print()
    {
        Console.WriteLine("Id: {0}, Name: {1}, Surname: {2}", Id, Name, Surname);
    }

    public void PrintInfo()
    {
        Console.WriteLine("Album: {0}, Year: {1}, Artist: {2}", Album, Year, Artist);
    }

    protected void PrintInfos()
    {
        Console.WriteLine("Test");
    }
    #endregion


}