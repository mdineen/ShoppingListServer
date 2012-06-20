using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ListService.Entities;

namespace ListService.DataAccess
{
    public static class ListAccess
    {
        public static List<IListItem> GetList(int ListId)
        {
            List<IListItem> rtn = new List<IListItem>();

            using (SqlConnection con = ListDb.db)
            {
                SqlCommand cmd = new SqlCommand("List.GetList", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@listid", ListId);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                { rtn.Add(new ListItem() { Name = rdr.GetString(2), Quantity = rdr.GetInt32(3), CrossedOff = rdr.GetBoolean(4) }); }

                if (!rdr.IsClosed) { rdr.Close(); }
            }

            return rtn;
        }
    }
}