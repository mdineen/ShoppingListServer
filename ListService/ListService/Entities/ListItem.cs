using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListService.Entities
{
    public class ListItem : IListItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public bool CrossedOff { get; set; }
    }
}