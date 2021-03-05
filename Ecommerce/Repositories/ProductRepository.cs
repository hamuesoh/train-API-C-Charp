using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Repositories
{
    public class ProductRepository
    {
        public string GetProductName(int productId)
        {
            try
            {
                //var result = new DBConnection();
                string kkk = productId.ToString();
                return kkk;

            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                return "";
            }
        }
    }
}
