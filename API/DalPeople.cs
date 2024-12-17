using Models;
using System;
using System.Data;
using System.Text;
namespace API
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
         using (IDbCommand command = DbConnection.CreateCommand())
         {
            StringBuilder str = new StringBuilder();
            str.Append("INSERT INTO people(name, created_at, updated_at, status) ");
            str.Append("VALUES(@Name, @CreatedAt, @UpdatedAt, @Status); ");
            str.Append("SELECT LAST_INSERT_ID();");
            command.CommandText = str.ToString();

            IDbDataParameter p0 = command.CreateParameter();
            p0.ParameterName = "@Name";
            p0.Value = value.Name;
            command.Parameters.Add(p0);

            IDbDataParameter p1 = command.CreateParameter();
            p1.ParameterName = "@CreatedAt";
            p1.Value = value.CreatedAt;
            command.Parameters.Add(p1);

            IDbDataParameter p2 = command.CreateParameter();
            p2.ParameterName = "@UpdatedAt";
            p2.Value = (object)value.UpdatedAt ?? DBNull.Value;
            command.Parameters.Add(p2);

            IDbDataParameter p3 = command.CreateParameter();
            p3.ParameterName = "@Status";
            p3.Value = value.Status;
            command.Parameters.Add(p3);

            object result = command.ExecuteScalar();
            var t = result.GetType();
            if (result != null && result is UInt64 id)
            {
               value.Id = (int)id;
            }
            return value;
         }
      }
   }
}
