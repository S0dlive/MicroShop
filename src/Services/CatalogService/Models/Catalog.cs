namespace CatalogService.Models;

/// <summary>
/// First version of this class !
/// </summary>
public class Catalog
{
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Description { get; set; }
    public string Id { get; set; }
    public string OwnerId { get; set; }
    public decimal Price { get; set; }
}