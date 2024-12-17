using System;
namespace Models
{
   public class People
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public DateTime CreatedAt { get; set; }
      public DateTime? UpdatedAt { get; set; }
      public bool Status { get; set; }
   }
}