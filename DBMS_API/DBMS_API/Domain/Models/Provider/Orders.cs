using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_API.Domain.Models.Provider
{
    [BsonIgnoreExtraElements]
    public class Orders
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("provider")]
        public string ProviderName { get; set; }

        [BsonElement("order_date")]
        public string OrderDate { get; set; }

        [BsonElement("cars")]
        public List<Cars>? CarsObj { get; set; }

        [BsonElement("spare_parts")]
        public List<SpareParts>? SparePartsObj { get; set; }

        [BsonElement("manager_id")]
        public int? ManagerId { get; set; }
    }

    

    
}