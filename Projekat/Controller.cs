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
            return so.Result;
        }

        public object AddTableMemberInzenjer(TableDataMember tdm)
        {
            var so = new AddInzenjerSO(tdm.Inzenjer);
            so.ExecuteTemplate();
            return GetTableDataInzenjer();
        }

        public object DeleteTableMemberInzenjer(TableDataMember tdm)
        {
            var so = new DeleteInzenjerSO(tdm.Inzenjer.IdInzenjer);
            so.ExecuteTemplate();
            return GetTableDataInzenjer();
        }

        internal object ChangeTableMemberInzenjer(TableDataMember tdm)
        {
            var so = new AlterInzenjerSO(tdm.Inzenjer);
            so.ExecuteTemplate();
            return GetTableDataInzenjer();
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
            var so = new AddKlijentSO(tdm.Klijent);
            so.ExecuteTemplate();
            return GetTableDataKlijent();
        }

        public object DeleteTableMemberKlijent(TableDataMember tdm)
        {
            var so = new DeleteKlijentSO(tdm.Klijent.IdKlijent);
            so.ExecuteTemplate();
            return GetTableDataKlijent();
        }

        internal object ChangeTableMemberKlijent(TableDataMember tdm)
        {
            var so = new AlterKlijentSO(tdm.Klijent);
            so.ExecuteTemplate();
            return GetTableDataKlijent();
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
            var so = new AddMestoSO(tdm.Mesto);
            so.ExecuteTemplate();
            return GetTableDataMesto();
        }

        public object DeleteTableMemberMesto(TableDataMember tdm)
        {
            var so = new DeleteMestoSO(tdm.Mesto.IdMesto);
            so.ExecuteTemplate();
            return GetTableDataMesto();
        }

        internal object ChangeTableMemberMesto(TableDataMember tdm)
        {
            var so = new AlterMestoSO(tdm.Mesto);
            so.ExecuteTemplate();
            return GetTableDataMesto();
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
            var so = new AddZadatakSO(tdm.Zadatak);
            so.ExecuteTemplate();
            return GetTableDataZadatak();
        }

        public object DeleteTableMemberZadatak(TableDataMember tdm)
        {
            var so = new DeleteZadatakSO(tdm.Zadatak.IdZadatak);
            so.ExecuteTemplate();
            return GetTableDataZadatak();
        }

        internal object ChangeTableMemberZadatak(TableDataMember tdm)
        {
            var so = new AlterZadatakSO(tdm.Zadatak);
            so.ExecuteTemplate();
            return GetTableDataZadatak();
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
            var so = new GetAllTipoviInzenjeraSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        public object AddTableMemberTipInzenjera(TableDataMember tdm)
        {
            var so = new AddTipInzenjeraSO(tdm.TipInzenjera);
            so.ExecuteTemplate();
            return GetTableDataTipInzenjera();
        }

        public object DeleteTableMemberTipInzenjera(TableDataMember tdm)
        {
            var so = new DeleteTipInzenjeraSO(tdm.TipInzenjera.IdStrucnaSprema);
            so.ExecuteTemplate();
            return GetTableDataTipInzenjera();
        }

        internal object ChangeTableMemberTipInzenjera(TableDataMember tdm)
        {
            var so = new AlterTipInzenjeraSO(tdm.TipInzenjera);
            so.ExecuteTemplate();
            return GetTableDataTipInzenjera();
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

        internal object GetAdditionalDataTD(int IdTD)
        {
            var so = new GetAdditionalDataTDSO(IdTD);
            so.ExecuteTemplate();
            return so.Result;
        }

        // ------------------- STAVKA TD -------------------
        public object GetTableDataSTD()
        {
            var so = new GetAllStavkeTDSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        public object AddTableMemberSTD(TableDataMember tdm)
        {
            var so = new AddStavkaTDSO(tdm.STDokumentacija);
            so.ExecuteTemplate();
            return GetTableDataSTD();
        }

        public object DeleteTableMemberSTD(TableDataMember tdm)
        {
            var so = new DeleteStavkaTDSO(tdm.STDokumentacija.IdTD, tdm.STDokumentacija.Rb);
            so.ExecuteTemplate();
            return GetTableDataSTD();
        }

        internal object ChangeTableMemberSTD(TableDataMember tdm)
        {
            var so = new AlterStavkaTDSO(tdm.STDokumentacija);
            so.ExecuteTemplate();
            return GetTableDataSTD();
        }
    }
}
