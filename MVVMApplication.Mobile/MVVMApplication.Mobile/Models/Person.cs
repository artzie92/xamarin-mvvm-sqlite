using System;
using SQLite;

namespace MVVMApplication.Mobile.Models
{
    [Table("people")]
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int PersonId { get; set; }
        
        [MaxLength(250)]
        public string FirstName { get; set; }
        
        [MaxLength(250)]
        public  string LastName { get; set; }
        
        public DateTime? CreatedOn { get; set; }
    }
}