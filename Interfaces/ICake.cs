using blazorapi.Dto;
using gqlServer.Models;

namespace blazorapi.Interfaces
{
    public interface ICake
    {
        List<CakeDto> GetAll();
    }
}