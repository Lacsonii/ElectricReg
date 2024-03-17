using Postgrest.Attributes;
using Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricReg.Models
{
    [Table("profile")]
     class ProfileModel : BaseModel
    {
        [PrimaryKey("id", false)]
        public string Id { get; set; }

        [Column("student_id")]
        public string StudentID { get; set; }

        [Column("student_name")]
        public string StudnetName { get; set; }

        [Column("avatar_url")]
        public string AvatarUrl { get; set; }
    }
}