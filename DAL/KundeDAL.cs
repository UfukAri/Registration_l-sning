using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KundeDAL
    {

        public Kunde Registrering(Kunde kunde)
        {
            using (var db = new DB())
            {
                var bruker = db.Kunder.SingleOrDefault(k => k.Email == kunde.Email);
                if(bruker == null)
                {
                    var nyBruker = new dbKunde();

                    byte[] passordDB = lagHash(kunde.Password);
                    nyBruker.Password = passordDB;
                    nyBruker.Email = kunde.Email;
                    nyBruker.Firstname = kunde.Firstname;
                    nyBruker.Lastname = kunde.Lastname;
                    nyBruker.Poststed = kunde.Poststed;

                    db.Kunder.Add(nyBruker);
                    db.SaveChanges();
                }
                
            }

            return kunde;
        }

       


        private static byte[] lagHash(string innPassord)
        {
            byte[] innData, utData;
            var algoritme = System.Security.Cryptography.SHA256.Create();
            innData = System.Text.Encoding.ASCII.GetBytes(innPassord);
            utData = algoritme.ComputeHash(innData);
            return utData;
        }

        public bool bruker_i_db(Kunde innbruker)
        {
            using (var db = new DB())
            {
                byte[] passordDB = lagHash(innbruker.Password);
                dbKunde funnetBruker = db.Kunder.FirstOrDefault(
                    b => b.Password == passordDB && b.Email == innbruker.Email);
                if (funnetBruker == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }

    }
}
