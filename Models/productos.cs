using MongoDB.Bson.Serialization.Attributes;
public class pruductos{ 
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string? producto {get; set;}
    public string marca {get; set;}
    public string tono {get; set;}
    public string tipo {get; set;}
    public decimal precio {get; set;}
    public DateTime FechaLanzamiento {get; set;}
    public List<string> ingredientes {get; set;}
    public string disponibilidad {get; set;}
}

