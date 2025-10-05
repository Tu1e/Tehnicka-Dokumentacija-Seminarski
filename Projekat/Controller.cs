using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;
using DBBroker;
using Common;
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
                {
                    instance = new Controller();
                }

                return instance;
            }
        }

        private Controller() { }

        public Inzenjer? Login(Inzenjer inz)
        {
            Inzenjer? inzenjer = null;
            try
            {
                broker.OpenConnection();
                inzenjer = broker.GetInzenjerByKorisnickoIme(inz.Username, inz.Password);
            }
            finally
            {
                broker.CloseConnection();
            }

            return inzenjer;
        }

        public int GetNextFreeId(TableName tableName)
        {
            int nextId = 0;
            try
            {
                broker.OpenConnection();
                nextId = broker.GetNextId(tableName);
            }
            finally
            {
                broker.CloseConnection();
            }

            return nextId;
        }

        public TableDataBundle GetTableSupportData(TableName tableName)
        {
            TableDataBundle tehDokCmbData = null!;
            try
            {
                broker.OpenConnection();
                tehDokCmbData = broker.GetTableSupportData(tableName);
            }
            finally
            {
                broker.CloseConnection();
            }

            return tehDokCmbData;
        }

        public TableDataBundle GetTableData(TableName tableName)
        {
            TableDataBundle tdb = null!;
            try
            {
                broker.OpenConnection();
                tdb = broker.GetTableData(tableName);
            }
            finally
            {
                broker.CloseConnection();
            }

            return tdb;
        }

        public TableDataBundle AddTableMember(TableDataMember tdm)
        {
            TableDataBundle tdb = null!;
            try
            {
                broker.OpenConnection();
                tdb = broker.AddTableMember(tdm);
            }
            finally
            {
                broker.CloseConnection();
            }
            Debug.WriteLine("[SERVER] Ulazak u Controller.AddTableMember");
            return tdb;
        }

        public object DeleteTableMember(TableDataMember tdm)
        {
            TableDataBundle tdb = null!;
            try
            {
                broker.OpenConnection();
                tdb = broker.DeleteTableMember(tdm);
            }
            finally
            {
                broker.CloseConnection();
            }

            return tdb;
        }

        public object ChangeTableMember(TableName tableName)
        {
            throw new NotImplementedException();
        }

        /*private ManufacturerRepository manufacturerRepository = new ManufacturerRepository();
        public List<Manufacturer> GetAllManufacturers()
        {
            return manufacturerRepository.GetManufacturers();
        }

        private ProductRepository productRepository = new ProductRepository();
        public void AddProduct(Product newProduct)
        {
            productRepository.Add(newProduct);
        }

        public List<Product> GetAllProducts()
        {
            return productRepository.GetProducts();
        }

        public Array GetAllMesurementUnits()
        {
            return Enum.GetValues(typeof(MesurementUnit));
        }

        public void AddProducts(List<Product> products)
        {
            productRepository.AddAllProducts(products);
        }*/
    }
}
