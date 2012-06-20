using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ListService
{
    [ServiceContract]
    public interface IListService
    {
        [OperationContract]
        List<Entities.IListItem> GetList(int listId);
    }
}
