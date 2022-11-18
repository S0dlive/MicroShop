using CatalogService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatalogService.Controllers;

[ApiController]
[Route("api/catalog")]
public class CatalogController : Controller
{
    [HttpPost()]
    public async Task<IActionResult> CreateCatalog([FromBody] Catalog catalog)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCatalogInformation(string id)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCatalog(string id)
    {
        throw new NotImplementedException();
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> UpdateCatalog(string id)
    {
        throw new NotImplementedException();
    }
}