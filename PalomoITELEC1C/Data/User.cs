using System;
using Microsoft.AspNetCore.Identity;

namespace PalomoITELEC1C.Data

{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set;}

    }
}
