using API.Data;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController: ControllerBase
    {
        private readonly IConfiguration _config;

        public ProductsController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public async Task<ActionResult<Product>> GetProducts()
        {
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            var products = await connection.QueryAsync<Product>("SELECT * FROM Product");
            return Ok(products);
        }

    }
}
