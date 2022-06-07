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
    public class SpareParts
    {
        [BsonElement("spare_part_id")]
        public int? SparePartId { get; set; }

        [BsonElement("name")]
        public string SparePartName { get; set; }

        [BsonElement("type")]
        public string SparePartType { get; set; }

        [BsonElement("release_date")]
        public string SparePartReleaseDate { get; set; }

        [BsonElement("additional_info")]
        public string? AdditionalInfo { get; set; }
    }
}
