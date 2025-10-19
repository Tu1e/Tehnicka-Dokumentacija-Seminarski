using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Common.Domain
{
    public class InzenjerTip : IEntity
    {
        [DisplayName("ID Inženjera")]
        public int IdInzenjer { get; set; }

        [DisplayName("ID stručne spreme")]
        public int IdStrucnaSprema { get; set; }

        [DisplayName("Opis")]
        public string? Opis { get; set; }

        [DisplayName("Godine iskustva")]
        public int GodineIskustva { get; set; }

        public Inzenjer Inzenjer { get; set; } = null!;
        public TipInzenjera TipInzenjera { get; set; } = null!;

        public string TableName => "InzenjerTip";

        public string Values =>
            $"{IdInzenjer}, {IdStrucnaSprema}, '{Opis}', {GodineIskustva}";

        public string UpdateValues =>
            $"Opis = '{Opis}', " +
            $"GodineIskustva = {GodineIskustva}";

        public string PrimaryKeyCondition =>
            $"IdInzenjer = {IdInzenjer} AND IdStrucnaSprema = {IdStrucnaSprema}";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            var list = new List<IEntity>();
            while (reader.Read())
            {
                list.Add(new InzenjerTip
                {
                    IdInzenjer = (int)reader["IdInzenjer"],
                    IdStrucnaSprema = (int)reader["IdStrucnaSprema"],
                    Opis = reader["Opis"] == DBNull.Value ? null : reader["Opis"].ToString(),
                    GodineIskustva = Convert.ToInt32(reader["GodineIskustva"])
                });
            }
            return list;
        }
    }
}
