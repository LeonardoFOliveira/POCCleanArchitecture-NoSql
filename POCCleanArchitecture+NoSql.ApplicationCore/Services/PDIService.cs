using MongoDB.Driver;
using POCCleanArchitecture_NoSql.ApplicationCore.Entities;
using POCCleanArchitecture_NoSql.ApplicationCore.Interfaces;
using POCCleanArchitecture_NoSql.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace POCCleanArchitecture_NoSql.ApplicationCore.Services
{
    public class PDIService : IPDIService
    {
        private readonly IPDIRepository _PDIRepository;

        public PDIService(IPDIRepository PDIRepository)
        {
            _PDIRepository = PDIRepository;
        }

        public List<PDI> GetAllPDIs() =>
            _PDIRepository.Get();

        public PDI GetPDIById(string id) =>
            _PDIRepository.GetById(id);

        public PDI CreatePDI(PDI pdi) =>
            _PDIRepository.Create(pdi);

        public PDI UpdatePDI(string id, PDI pdiIn)
        {
            var pdi = _PDIRepository.GetById(id);

            if(pdi != null)
            {
                _PDIRepository.Update(id, pdiIn);
            }

            return pdi;
        }

        public PDI DeletePDI(string id)
        {
            var pdi = _PDIRepository.GetById(id);

            if( pdi != null)
            {
                _PDIRepository.Remove(pdi);
            }

            return pdi;
        }

    }
}
