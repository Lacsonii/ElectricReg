using Postgrest.Attributes;
using Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricReg.Models
{
    [Table("register")]
     class RegisterModel : BaseModel
    {
        [PrimaryKey("id", false)]
        public int Id { get; set; }

        [Column("student_id")]
        public string StudentID { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}