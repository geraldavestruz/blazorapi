using blazorapi.Dto;
using blazorapi.Interfaces;
using blazorapi.Service;
using gqlServer.Models;

namespace blazorapi.Schemas.Types
{
  [ExtendObjectType("Query")]
  public class CakeQueryResolver
  {
    public List<CakeDto> GetAllCakes([Service] ICake cakeService)
    {
      return cakeService.GetAll();
    }
  }
}