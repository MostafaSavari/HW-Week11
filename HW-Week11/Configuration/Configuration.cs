using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Week11.Configuration
{
    public static class Configuration
    {
        public static string ConnectionString { get; set; }

        static Configuration()
        {
            ConnectionString = "Data Source=DESKTOP-CMB0AK2\\SQL_2017;Initial Catalog=ShopDb;User ID=sa;Password=Aa@123456; TrustServerCertificate=true";
        }
    }
}
