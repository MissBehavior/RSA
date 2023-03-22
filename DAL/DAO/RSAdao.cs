using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class RSAdao : RSAContext
    {
        public static void AddNewSave(RSAtable rsadb)
        {
            try
            {
                db.RSAtables.InsertOnSubmit(rsadb);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
