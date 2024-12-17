using EF;
using Models;

namespace EFConsole
{
   internal class Program
   {
      static void Main(string[] args)
      {

         DatabaseEF database = new DatabaseEF(DatabaseEFDbContextOptions.Value);

         People people = new People();
         people.Name = "Paulo Souza Cruz";
         people.CreatedAt = DateTime.Now;
         people.UpdatedAt = people.CreatedAt;
         people.Status = true;

         database.People.Add(people);
         database.SaveChanges();

         Console.WriteLine(people.Id);
      }
   }
}
