using System;
using System.Collections.Generic;
using System.Text;

namespace product.Domain
{
    public class ResponseProducts
    {
        public Boolean ok { get; set; }


        public List<Product> products { get; set; }
    }
}
