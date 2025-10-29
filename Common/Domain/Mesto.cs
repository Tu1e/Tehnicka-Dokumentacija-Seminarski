using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Mesto : IEntity
    {
        [DisplayName("ID mesta")]
        public int IdMesto { get; set; }

        [DisplayName("Naziv mesta")]
        public string NazivMesta { get; set; }

        [DisplayName("Naziv države")]
        public string NazivDrzave { get; set; }

        public string TableName => "Mesto";
        public string Values => $"{IdMesto}, '{NazivMesta}', '{NazivDrzave}'";
        public string UpdateValues =>
            $"NazivMesta = '{NazivMesta}', " +
            $"NazivDrzave = '{NazivDrzave}'";

        public string PrimaryKeyCondition => $"IdMesto = {IdMesto}";
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            var list = new List<IEntity>();
            while (reader.Read())
            {
                list.Add(new Mesto
                {
                    IdMesto = (int)reader["IdMesto"],
                    NazivMesta = reader["NazivMesta"].ToString(),
                    NazivDrzave = reader["NazivDrzave"].ToString()
                });
            }
            return list;
        }

    }
}
