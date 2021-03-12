using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EloyAhora.DAL.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("nameofproduct")]
        public string NameOfProduct { get; set; }
        [BsonElement("weight")]
        public string Weight { get; set; }
        [BsonElement("dimentions")]
        public string Dimentions { get; set; }
        [BsonElement("color")]
        public string Color { get; set; }
        [BsonElement("brand")]
        public string Brand { get; set; }
        [BsonElement("owner")]
        public string Owner { get; set; }
        [BsonElement("tags")]
        public string Tags { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }
    }
}
