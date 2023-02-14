using blazorapi.Dto;
using blazorapi.Interfaces;
using blazorapi.Service;
using gqlServer.Models;

namespace blazorapi.Schemas.Types
{
  // [ExtendObjectType("Query")]
  public class CakeQueryResolver
  {
    public IEnumerable<CakeDto> GetCakes([Service] ICake cakeService)
    {
      return cakeService.GetAll();
    }
  }
}