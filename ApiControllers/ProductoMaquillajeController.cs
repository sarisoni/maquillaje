using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
    
    [ApiController]  
    [Route("conexion")]  
    public class ProductoMaquillajeController : Controller {
        [HttpGet("mongo")]
        public IActionResult ProductoMaquillajeMongoDb()
        {
            MongoClient client = new MongoClient(CadenasConexiones.MONGO_DB);  
            var db = client.GetDatabase("Practica2_atala_sari");  
            var collection = db.GetCollection<ProductoMaquillaje>("maquillaje"); 
            var list = collection.Find(FilterDefinition<ProductoMaquillaje>.Empty).ToList();
             
            return Ok(list);  
        }

}