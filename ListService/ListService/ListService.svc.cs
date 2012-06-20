using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ListService
{
    public class ListService : IListService
    {
        public List<Entities.IListItem> GetList(int listId)
        { return DataAccess.ListAccess.GetList(listId); }
    }
}
