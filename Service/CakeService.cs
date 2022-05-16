using System.Data;
using System.Data.SqlClient;
using blazorapi.Dto;
using blazorapi.Interfaces;
using Dapper;
using gqlServer.Models;
using Microsoft.Extensions.Configuration;

namespace blazorapi.Service
{
  public class CakeService : ICake
  {

    public readonly DapperContext _context;

    public CakeService(DapperContext context)
    {
      _context = context;
    }

    public List<CakeDto> GetAll()
    {
      using(var conn = _context.CreateConnection())
      {
          conn.Open();

          var query = "SELECT * FROM cake";
          var cakes = conn.Query<CakeDto>(query).ToList();
          return cakes;
      }
    }
  }
}