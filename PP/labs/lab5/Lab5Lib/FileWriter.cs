namespace Lab5Lib
{
    public class FileWriter : IWriter 
    {
        string filename = Constant.FileName; 
        public string FileName {  get { return this.filename; } }
        public FileWriter(string? filename = null)
        {
            this.filename = filename ?? Constant.FileName; 
        }
        public string? Save(string? text)
        {
            try
            {
                using StreamWriter writer = new StreamWriter(filename);
                writer.WriteLine(text);
            }
            catch (Exception)
            {
                return null;
            }

            return this.filename; 
        }
    }
}