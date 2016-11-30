using System;
using System.Collections.Generic;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagmentSystem.Interface
{
    public class Veichle
    {
        public Brand Brand { get; set; }

    }

    public class Brand
    {
        public string Name { get; set; }

        public Model Model { get; set; }
    }

    public class Model
    {
        public string Serial { get; set; }

        public string Name { get; set; }
        public DateTime ModelYear { get; set; }
    }
}
