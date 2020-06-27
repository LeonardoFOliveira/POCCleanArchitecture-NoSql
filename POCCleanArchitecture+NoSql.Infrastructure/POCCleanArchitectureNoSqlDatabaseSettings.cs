using System;
using System.Collections.Generic;
using System.Text;

namespace POCCleanArchitecture_NoSql.Infrastructure
{
    public class POCCleanArchitectureNoSqlDatabaseSettings : IPOCCleanArchitectureNoSqlDatabaseSettings
    {
        public string PDIsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set;}
    }

    public interface IPOCCleanArchitectureNoSqlDatabaseSettings
    {
        public string PDIsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
