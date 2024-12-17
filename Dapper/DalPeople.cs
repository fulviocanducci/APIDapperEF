using Dapper;
using Models;
using System;
using System.Data;
using System.Text;
namespace DapperBase
{
   public class DalPeople
   {
      protected IDbConnection DbConnection { get; }

      public DalPeople(IDbConnection dbConnection)
      {
         DbConnection = dbConnection;
      }

      public People Create(People value)
      {
         StringBuilder str = new StringBuilder();
         str.Append("INSERT INTO people(name, created_at, updated_at, status) ");
         str.Append("VALUES(@Name, @CreatedAt, @UpdatedAt, @Status); ");
         str.Append("SELECT LAST_INSERT_ID();");

         value.Id = (int)DbConnection.QueryFirst<UInt64>(str.ToString(), value);
         return value;
      }
   }
}
