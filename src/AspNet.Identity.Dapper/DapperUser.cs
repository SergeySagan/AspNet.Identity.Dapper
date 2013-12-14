using Microsoft.AspNet.Identity;

namespace AspNet.Identity.Dapper
{
    public class DapperUser : IUser
    {
        public string Id { get; set; }
        public string UserName { get; set; }
    }
}
