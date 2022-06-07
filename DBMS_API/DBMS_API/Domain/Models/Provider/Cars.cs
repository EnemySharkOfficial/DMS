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
    public class Cars
    {
        [BsonElement("car_id")]
        public int? CarId { get; set; }

        [BsonElement("brand")]
        public string Brand { get; set; }

        [BsonElement("model")]
        public string Model { get; set; }

        [BsonElement("release_year")]
        public int? ReleaseYear { get; set; }

        [BsonElement("body")]
        public string Body { get; set; }

        [BsonElement("engine")]
        public int? Engine { get; set; }

        [BsonElement("power")]
        public int? Power { get; set; }

        [BsonElement("max_speed")]
        public int? MaxSpeed { get; set; }

        [BsonElement("transmission")]
        public string Transmission { get; set; }
    }
}
