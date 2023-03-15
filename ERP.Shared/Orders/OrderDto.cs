using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Shared.Orders
{
    public class OrderDto
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderStatus { get; set; }
        public List<ProductDto> Products { get; set; }

    }

}
