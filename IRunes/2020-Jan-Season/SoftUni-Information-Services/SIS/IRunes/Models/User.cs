using System;
using Microsoft.Win32.SafeHandles;
using SIS.MvcFramework;

namespace IRunes.Models
{
    public class User : IdentityUser<string>
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
