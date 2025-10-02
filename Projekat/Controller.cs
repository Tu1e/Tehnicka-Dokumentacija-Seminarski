using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;
using DBBroker;

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

        private Controller()
        {

        }

        public Inzenjer? Login(Inzenjer inz)
        {
            Inzenjer? inzenjer = null;

            inzenjer = broker.GetInzenjerByKorisnickoIme(inz.Username, inz.Password);
            return inzenjer;
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
