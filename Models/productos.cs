using MongoDB.Bson.Serialization.Attributes;

public class Productos {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? ObjectId { get; set; }
        public string Marca { get; set; } = string.Empty;
        public string Tono { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public List <string> Ingredientes { get; set; }
        public string Disponibilidad { get; set; } = string.Empty;
        public string Especificaciones { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
    }