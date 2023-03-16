using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Shared.Orders.Interfaces
{
    public interface ICreateOrderMsg
    {
        public int Id { get; set; }
        public ProductDto Product { get; set; }
        public string OrderType { get; set; }
    }
}
