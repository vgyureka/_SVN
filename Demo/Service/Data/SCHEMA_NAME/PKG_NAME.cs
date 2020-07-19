using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Data.SCHEMA_NAME
{
    public static class PKG_NAME
    {
        public static void Save(
            int id,
            string name,
            string in_dataset
            )
        {
            var proc = new StoredProc("SCHEMA.PROC_NAME");
                //.param("id", id)
                //.param("name", name)
                //.param("in_dataset", in_dataset, SqlDbType.Xml)
                //.Execute("ConnectionStringName");
        }
        public static void Load(
          
           )
        {
            var proc = new StoredProc("SCHEMA.PROC_NAME");
            //.param("id", id)
            //.param("name", name)
            //.param("in_dataset", in_dataset, SqlDbType.Xml)
            //.Execute("ConnectionStringName");
        }

        internal static void GetLoginAuth(string name, out DataTable dt)
        {
            throw new NotImplementedException();
        }
    }
}
