using Postgrest.Attributes;
using Postgrest.Models;
using System;
using System.Globalization;

namespace ElectricReg.Models
{
    [Table("profile")]
     class ProfileModel : BaseModel
    {
        [PrimaryKey("id", false)]
        public Guid Id { get; set; }

        [Column("student_id")]
        public string StudentID { get; set; }

        [Column("student_name")]
        public string StudnetName { get; set; }

        [Column("avatar_url")]
        public string AvatarUrl { get; set; }

        [Column("updated_at")]
        public string UpdatedAt { get =>_updatedAt?.ToString("o"); set =>_updatedAt = ParseDate(value); }

        private DateTimeOffset? _updatedAt;

        protected static DateTimeOffset? ParseDate(string dateString)
        {
            if (DateTimeOffset.TryParse(dateString, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal, out var dateTime))
            {
                return dateTime;
            }
            return null;
        }
    }
}