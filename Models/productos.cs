using MongoDB.Bson.Serialization.Attributes;

public class Productos {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }
        public string marca { get; set; } = string.Empty;
        public string tono { get; set; } = string.Empty;
        public string tipo { get; set; } = string.Empty;
        public decimal precio { get; set; }
        public DateTime fecha_lanzamiento { get; set; }
        public List <string> ingredientes { get; set; }
        public bool disponibilidad { get; set; }
        public string categoria { get; set; } = string.Empty;
        public string producto { get; set; } 
    }