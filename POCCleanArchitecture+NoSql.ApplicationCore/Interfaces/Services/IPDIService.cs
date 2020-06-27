using POCCleanArchitecture_NoSql.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace POCCleanArchitecture_NoSql.ApplicationCore.Interfaces.Services
{
    public interface IPDIService
    {
        public List<PDI> GetAllPDIs();

        public PDI GetPDIById(string id);

        public PDI CreatePDI(PDI pdi);

        public PDI UpdatePDI(string id, PDI pdiIn);

        public PDI DeletePDI(string id);
    }
}
