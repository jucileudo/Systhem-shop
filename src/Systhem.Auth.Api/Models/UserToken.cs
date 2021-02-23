using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Systhem.Auth.Api.Models
{
    public class UserToken
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public IEnumerable<UserClaim> Claims { get; set; }
    }
}
