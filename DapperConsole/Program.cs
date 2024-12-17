using DapperBase;
using Models;
using MySql.Data.MySqlClient;

namespace DapperConsole
{
   internal class Program
   {
      static void Main(string[] args)
      {
         MySqlConnection connection = new MySqlConnection(MysqlConnnectionString.Value);

         DalPeople dalPeople = new DalPeople(connection);

         People people = new People();
         people.Name = "Nunes B.";
         people.CreatedAt = DateTime.Now;
         people.UpdatedAt = null;
         people.Status = true;

         people = dalPeople.Create(people);
      }
   }
}
