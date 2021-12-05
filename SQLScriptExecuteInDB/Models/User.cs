﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SQLScriptExecuteInDB1.Models
{
    [Table("Users", Schema = "UserRegistrations")]
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PhoneNo { get; set; }
    }
}