using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace VendasCRUD.Database
{
    public class Data
    {
        private readonly string conString = "Host=localhost;Port=5432;Username=postgres;Password=1122;Database=VendasCRUD";

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(conString);
        }
    }
}
