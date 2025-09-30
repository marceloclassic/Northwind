using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities {
    public class UserEntity {
        [Key]
        public String Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
