using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace Server
{
    public class Controller
    {
        private static Controller instance;

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

        private Inzenjer userRepository = new UserRepository();
        public User currentUser { get; private set; }
        public User Login(User u)
        {
            List<User> users = userRepository.GetUsers();

            foreach (User user in users)
            {

                if (user.Username == u.Username && user.Password == u.Password)
                {
                    currentUser = user;
                    return user;
                }
            }
            return null;
        }

        private ManufacturerRepository manufacturerRepository = new ManufacturerRepository();
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
        }
    }
}
