using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class LoginSO : SystemOperationBase
    {
        private readonly Inzenjer inzenjer;
        public Inzenjer Result { get; set; }
        public LoginSO(Inzenjer i)
        {
            inzenjer = i;
        }

        public override void ExecuteOperation()
        {
            string condition = $"KorisnickoIme = '{inzenjer.Username}' AND Sifra = '{inzenjer.Password}'";
            List<IEntity> lista = broker.GetByCondition(inzenjer, condition);

            Result = lista.Cast<Inzenjer>().FirstOrDefault();

            if (Result == null)
            {
                Debug.WriteLine(">>> LoginSO > Ne postoji zaposleni sa unetim kredencijalima.");
                throw new Exception("Ne postoji zaposleni sa unetim kredencijalima.");
            }
        }
    }
}
