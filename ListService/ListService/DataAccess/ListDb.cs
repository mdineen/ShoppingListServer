using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Configuration;

namespace ListService.DataAccess
{
    public static class ListDb
    {
        private static SqlConnection _db;
        public static SqlConnection db { 
            get 
            {
                if (_db == null || _db.State != ConnectionState.Open)
                { _db = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString); }
                return db;
            } 
        }
    }
}