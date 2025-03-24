using MongoDB.Driver;
using Microsoft.ApsNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ProductoMaquillaje : ControllerBase
{
    private readonly IMongoCollection<ProductoMaquillaje> _ProductoMaquillaje;

    public ProductoMaquillaje()
    {
        var client = new MongoClient(CadenasConexion.MONGO_DB);
        var database = client.GetDatabase("Practica2_atala_sari");
        _ProductoMaquillaje = database.GetCollection<ProductoMaquillaje>("producto");
    }

    [HttpGet]
    public ActionResult<List<ProductoMaquillaje>> Get()
    {
        return _ProductoMaquillaje.Find(ProductoMaquillaje => true).ToList();
    }

}