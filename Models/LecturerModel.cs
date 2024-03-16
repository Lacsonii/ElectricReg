using Postgrest.Attributes;
using Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricReg.Models
{
    [Table("Lecturers")]
     class LecturerModel : BaseModel
    {
        [PrimaryKey("lecturer_id", false)]
        public int lecturerId { get; set; }

        [Column("lecturer_name")]
        public string LecturerName { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("phone_No")]
        public string phoneNo { get; set; }
    }
}