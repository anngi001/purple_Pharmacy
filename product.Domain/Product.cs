using System;

namespace product.Domain
{
    public class Product
    {

        
        public string _id { get; set; }     


        public string id { get; set; }
        public string imagen { get; set; }

        public string nombre { get; set; }

        public string farmacia { get; set; }

        public int cantidad { get; set; }

        public string descripcion { get; set; }

        public double precio { get; set; }
    }
}
