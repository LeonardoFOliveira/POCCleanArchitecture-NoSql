using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace POCCleanArchitecture_NoSql.ApplicationCore.Entities
{
    public class PDI
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string ReuniaoPDM { get; set; }

        public string DueDate { get; set; }
        
        public string Descricao { get; set; }

        public string Observacoes { get; set; }

        public string Status { get; set; }
    }
}
