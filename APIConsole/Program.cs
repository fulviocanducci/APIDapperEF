using API;
using Models;
using MySql.Data.MySqlClient;
namespace APIConsole
{
   internal class Program
   {
      static void Main(string[] args)
      {
         MySqlConnection connection = new MySqlConnection(MysqlConnnectionString.Value);
         connection.Open();

         People people = new People();
         people.Name = "Leonard S. S. Arnald";
         people.CreatedAt = DateTime.Now;
         people.UpdatedAt = DateTime.Now;
         people.Status = true;

         DalPeople dalPeople = new DalPeople(connection);
         people = dalPeople.Create(people);

         connection.Close();

         Console.WriteLine("Ok");
      }
   }
}
