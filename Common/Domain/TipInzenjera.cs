using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class TipInzenjera : IEntity
    {
        [DisplayName("ID stručne spreme")]
        public int IdStrucnaSprema { get; set; }

        [DisplayName("Stručna sprema")]
        public string Naziv { get; set; } = null!;
        public string TableName => "TipInzenjera";
        public string Values => $"{IdStrucnaSprema}, '{Naziv}'";
        public string UpdateValues => $"Naziv = '{Naziv}'";
        public string PrimaryKeyCondition => $"IdStrucnaSprema = {IdStrucnaSprema}";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            var list = new List<IEntity>();
            while (reader.Read())
            {
                list.Add(new TipInzenjera
                {
                    IdStrucnaSprema = (int)reader["IdStrucnaSprema"],
                    Naziv = reader["Naziv"].ToString()
                });
            }
            return list;
        }


    }
}
