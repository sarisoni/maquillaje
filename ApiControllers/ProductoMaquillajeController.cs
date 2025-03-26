using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
   
    [ApiController]  
    [Route("conexion")]  
    public class ProductoMaquillajeController : Controller {
        [HttpGet("mongo")]
         public IActionResult ListarSalonesMongoDb()
         { 
   
            MongoClient client = new MongoClient(CadenasConexiones.MONGO_DB);  
            var db = client.GetDatabase("Practica2_atala_sari");  
            var collection = db.GetCollection<Productos>("maquillaje"); 
            var list = collection.Find(FilterDefinition<Productos>.Empty).ToList();

            return Ok(list);
        }
        
}