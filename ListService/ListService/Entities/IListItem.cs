using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListService.Entities
{
    public interface IListItem
    {
        string Name { get; set; }
        int Quantity { get; set; }
        bool CrossedOff { get; set; }
    }
}
