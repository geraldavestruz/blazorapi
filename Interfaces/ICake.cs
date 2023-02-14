using blazorapi.Dto;
using gqlServer.Models;

namespace blazorapi.Interfaces
{
    public interface ICake
    {
        IEnumerable<CakeDto> GetAll();
    }
}