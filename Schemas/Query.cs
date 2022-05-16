using gqlServer.Data;
using gqlServer.Models;

namespace gqlServer.Schemas
{
    public class Query
    {
        public IQueryable<Cake> GetCakes([Service] CakeContext ctx) => ctx.Cake;
    }
}