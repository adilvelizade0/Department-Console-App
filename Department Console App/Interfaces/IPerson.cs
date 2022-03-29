namespace Department_Console_App.Interfaces
{
    public interface IPerson
    {
         string Name { get; set; }
         int Age { get; set; }

         string ShowInfo();
    }
}