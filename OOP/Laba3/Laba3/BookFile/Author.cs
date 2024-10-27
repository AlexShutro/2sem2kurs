namespace Laba2.BookFile
{
    public class Author
    {
        public Author(string name, string country, int id)
        {
            Name = name;
            Country = country;
            Id = id;
        }

        public string Name { get; set; }
        public string Country { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return string.Format("Name - {0} , Country - {1} , ID - {2}", Name, Country, Id);
        }
    }
}