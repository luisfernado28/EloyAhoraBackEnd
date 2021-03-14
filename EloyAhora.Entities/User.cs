using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace EloyAhora.DAL.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("firstname")]
        public string Firstname { get; set; }
        [BsonElement("lastname")]
        public string Lastname { get; set; }
        [BsonElement("mail")]
        public string Mail { get; set; }
        [BsonElement("typeofProduct")]
        public int TypeofProduct { get; set; }
        [BsonElement("cellphone")]
        public string Cellphone { get; set; }
        [BsonElement("direction")]
        public string Direction { get; set; }
        [BsonElement("contact")]
        public string Contact { get; set; }
    }

    public enum typeOfProduct
    {
        Vendedor=1,
        Comprador=2
    }
}
