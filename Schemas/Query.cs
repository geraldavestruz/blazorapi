using blazorapi.Dto;
using blazorapi.Interfaces;
using blazorapi.Service;
using gqlServer.Data;
using gqlServer.Models;
using HotChocolate.Data;

namespace gqlServer.Schemas
{
    public class Query
    {
        [UseFiltering]
        public IQueryable<CakeDto> GetAllCakes([Service] ICake cakeRepo) => 
            cakeRepo.GetAll().AsQueryable();
    }
}