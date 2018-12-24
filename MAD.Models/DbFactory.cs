using System.Data.Entity;
using System.Runtime.Remoting.Messaging;

namespace MAD.Models
{
    public class DbFactory
    {
        public static DbContext GetContext()
        {
            BaseContext db = CallContext.GetData("Context") as BaseContext;
            if (db == null)
            {
                db = new BaseContext();
                CallContext.SetData("Context", db);
            }

            return db;
        }
    }
}