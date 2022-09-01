using IdentityServer4.EntityFramework.Options;
using Microsoft.Extensions.Options;

namespace Company.WebApplication1
{
    internal class OperationalStoreOptionsMigrations : IOptions<OperationalStoreOptions>
    {
        public OperationalStoreOptions Value => new OperationalStoreOptions()
        {
        };
    }


}