using MongoDB.Driver;
using POCCleanArchitecture_NoSql.ApplicationCore.Entities;
using POCCleanArchitecture_NoSql.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace POCCleanArchitecture_NoSql.Infrastructure.Repositories
{
    public class PDIRepository : IPDIRepository
    {
        private readonly IMongoCollection<PDI> _PDIs;

        public PDIRepository(IPOCCleanArchitectureNoSqlDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _PDIs = database.GetCollection<PDI>(settings.PDIsCollectionName);
        }

        public List<PDI> Get() =>
            _PDIs.Find(pdi => true).ToList();

        public PDI GetById(string id) =>
            _PDIs.Find<PDI>(pdi => pdi.Id == id).FirstOrDefault();

        public PDI Create(PDI pdi)
        {
            _PDIs.InsertOne(pdi);
            return pdi;
        }

        public void Update(string id, PDI pdiIn) =>
            _PDIs.ReplaceOne(pdi => pdi.Id == id, pdiIn);

        public void Remove(PDI pdiIn) =>
            _PDIs.DeleteOne(pdi => pdi.Id == pdiIn.Id);

        public void Remove(string id) =>
            _PDIs.DeleteOne(pdi => pdi.Id == id);
    }
}
