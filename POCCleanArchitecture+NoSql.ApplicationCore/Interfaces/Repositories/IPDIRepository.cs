using POCCleanArchitecture_NoSql.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace POCCleanArchitecture_NoSql.ApplicationCore.Interfaces
{
    public interface IPDIRepository
    {
        public List<PDI> Get();

        public PDI GetById(string id);

        public PDI Create(PDI pdi);

        public void Update(string id, PDI pdiIn);

        public void Remove(PDI pdiIn);

        public void Remove(string id);
    }
}
