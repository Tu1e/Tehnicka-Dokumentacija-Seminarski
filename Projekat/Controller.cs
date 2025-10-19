using Common;
using Common.Domain;
using DBBroker;
using Server.SystemOperations;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Serverr
{
    public class Controller
    {
        private static Controller instance;
        private Broker broker = new Broker();
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                    instance = new Controller();
                return instance;
            }
        }

        private Controller() { }

        // ------------------- LOGIN -------------------
        public Inzenjer? Login(Inzenjer inz)
        {
            var so = new LoginSO(inz);
            so.ExecuteTemplate();
            return so.Result;
        }

        // ------------------- GENERIC -------------------
        public int GetNextFreeId(TableName tableName)
        {
            try
            {
                broker.OpenConnection();
                return broker.GetNextId(tableName);
            }
            finally { broker.CloseConnection(); }
        }

        public TableDataBundle GetTableData(TableName tableName)
        {
            try
            {
                broker.OpenConnection();
                return broker.GetTableData(tableName);
            }
            finally { broker.CloseConnection(); }
        }

        public TableDataBundle GetTableSupportData(TableName tableName)
        {
            try
            {
                broker.OpenConnection();
                return broker.GetTableSupportData(tableName);
            }
            finally { broker.CloseConnection(); }
        }

        public TableDataBundle AddTableMember(TableDataMember tdm)
        {
            try
            {
                broker.OpenConnection();
                return broker.AddTableMember(tdm);
            }
            finally { broker.CloseConnection(); }
        }

        public TableDataBundle DeleteTableMember(TableDataMember tdm)
        {
            try
            {
                broker.OpenConnection();
                return broker.DeleteTableMember(tdm);
            }
            finally { broker.CloseConnection(); }
        }

        public object ChangeTableMember(TableName tableName)
        {
            throw new NotImplementedException();
        }

        // ------------------- INZENJER -------------------
        public object GetTableDataInzenjer()
        {
            var so = new GetAllInzenjeriSO();
            so.ExecuteTemplate();
            return so.Result.Inzenjeri;
        }

        public object AddTableMemberInzenjer(TableDataMember tdm)
        {
            // TODO: Implement AddInzenjerSO
            // var so = new AddInzenjerSO(tdm.Inzenjer);
            // so.ExecuteTemplate();
            // return so.Result;
            return null;
        }

        public object DeleteTableMemberInzenjer(TableDataMember tdm)
        {
            // TODO: Implement DeleteInzenjerSO
            return null;
        }

        // ------------------- KLIJENT -------------------
        public object GetTableDataKlijent()
        {
            var so = new GetAllKlijentiSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        internal TableDataBundle GetTableSupportDataKlijent()
        {
            TableDataBundle tdb = new TableDataBundle();

            var so1 = new GetAllMestaSO();
            so1.ExecuteTemplate();
            tdb.Mesta = so1.Result.Mesta;

            return tdb;
        }

        public object AddTableMemberKlijent(TableDataMember tdm)
        {
            // TODO: Implement AddKlijentSO
            return null;
        }

        public object DeleteTableMemberKlijent(TableDataMember tdm)
        {
            // TODO: Implement DeleteKlijentSO
            return null;
        }
        internal object ChangeTableMemberKlijent(TableDataMember tableDataMember)
        {
            throw new NotImplementedException();
        }

        // ------------------- MESTO -------------------
        public object GetTableDataMesto()
        {
            var so = new GetAllMestaSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        public object AddTableMemberMesto(TableDataMember tdm)
        {
            // TODO: Implement AddMestoSO
            return null;
        }

        public object DeleteTableMemberMesto(TableDataMember tdm)
        {
            // TODO: Implement DeleteMestoSO
            return null;
        }
        internal object ChangeTableMemberMesto(TableDataMember tableDataMember)
        {
            throw new NotImplementedException();
        }
        // ------------------- ZADATAK -------------------
        public object GetTableDataZadatak()
        {
            var so = new GetAllZadaciSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        public object AddTableMemberZadatak(TableDataMember tdm)
        {
            // TODO: Implement AddZadatakSO
            return null;
        }

        public object DeleteTableMemberZadatak(TableDataMember tdm)
        {
            // TODO: Implement DeleteZadatakSO
            return null;
        }

        // ------------------- TIP INZENJERA -------------------
        public object GetTableDataTipInzenjera()
        {
            var so = new GetAllTipoviInzenjeraSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        internal TableDataBundle GetTableSupportDataInzenjer()
        {
            TableDataBundle tdb = new TableDataBundle();

            var so1 = new GetAllTipoviInzenjeraSO();
            so1.ExecuteTemplate();
            tdb.Inzenjeri = so1.Result.Inzenjeri;

            return tdb;
        }

        public object AddTableMemberTipInzenjera(TableDataMember tdm)
        {
            // TODO: Implement AddTipInzenjeraSO
            return null;
        }

        public object DeleteTableMemberTipInzenjera(TableDataMember tdm)
        {
            // TODO: Implement DeleteTipInzenjeraSO
            return null;
        }
        internal object ChangeTableMemberInzenjer(TableDataMember tableDataMember)
        {
            throw new NotImplementedException();
        }

        // ------------------- TEHNICKA DOKUMENTACIJA -------------------
        public object GetTableDataTD()
        {
            var so = new GetAllTehnickeDokumentacijeSO();
            so.ExecuteTemplate();
            return so.Result;
        }
        internal TableDataBundle GetTableSupportDataTD()
        {
            TableDataBundle tdb = new TableDataBundle();

            var so1 = new GetAllInzenjeriSO();
            so1.ExecuteTemplate();
            tdb.Inzenjeri = so1.Result.Inzenjeri;

            var so2 = new GetAllKlijentiSO();
            so2.ExecuteTemplate();
            tdb.Klijenti = so2.Result.Klijenti;
            return tdb;
        }

        public object AddTableMemberTD(TableDataMember tdm)
        {
            var so = new AddTehnickaDokumentacijaSO(tdm.TehnickaDokumentacija);
            so.ExecuteTemplate();

            return GetTableDataTD();
        }

        public object DeleteTableMemberTD(TableDataMember tdm)
        {
            var so = new DeleteTehnickaDokumentacijaSO(tdm.TehnickaDokumentacija.IdTehnickaDokumentacija);
            so.ExecuteTemplate();
            return GetTableDataTD();
        }

        public object ChangeTableMemberTD(TableDataMember tdm)
        {
            var so = new AlterTDMemberSO(tdm.TehnickaDokumentacija);
            so.ExecuteTemplate();
            return GetTableDataTD();
        }

        // ------------------- STAVKA TD -------------------
        public object GetTableDataSTD()
        {
            // TODO: Implement GetAllStavkeTDSO
            return null;
        }

        public object AddTableMemberSTD(TableDataMember tdm)
        {
            // TODO: Implement AddStavkaTDSO
            return null;
        }

        public object DeleteTableMemberSTD(TableDataMember tdm)
        {
            // TODO: Implement DeleteStavkaTDSO
            return null;
        }

        internal object ChangeTableMemberSTD(TableDataMember tableDataMember)
        {
            throw new NotImplementedException();
        }

    }
}
