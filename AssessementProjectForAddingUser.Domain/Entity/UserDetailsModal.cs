using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AssessementProjectForAddingUser.Domain.Entity
{
    [Table("userDetails_Ankit")]
    public class UserDetailsModal
    {
        public BigInteger UserId { get; set; }

        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string? LastName { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public string? Gender { get; set; }

        public DateOnly DateOfjoining { get; set; }

        public DateOnly Dob {  get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? Phone { get; set; }

        public string? AlternatePhone { get; set; }

        public string? EmailPath { get; set; }
    }
}
