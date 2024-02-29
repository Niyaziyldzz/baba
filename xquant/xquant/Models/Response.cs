using System.Collections.Generic;

namespace xquant.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }

        public List<Users> listusers { get; set; }

        public Users user { get; set; }


        public List<Medicines> listMedicine { get; set; }

        public Medicines medicine { get; set; }


        public List<Cart> listCart { get; set; }

        public List<Orders> listOrders { get; set; }

        public Orders order { get; set; }

        public List<OrderItems> ListItems { get; set; }

        public OrderItems orderItems { get; set; }

    }
}
