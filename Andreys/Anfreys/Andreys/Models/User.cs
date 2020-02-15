using System;

namespace Andreys.Models
{
    using SIS.MvcFramework;

    public class User : IdentityUser<string>
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
