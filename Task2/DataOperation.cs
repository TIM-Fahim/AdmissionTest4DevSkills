using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class DataOperation
    {
        public List<(string cutomerName, double purchaseAmount, DateTime purchaseDate)> MergeData(List<Customer> customers, List<Purchase> purchases)
        {
            var list = (from custo in customers

                    join pur in purchases on custo.Id equals pur.CustomerId

                    select new
                    {
                        cutomerName = custo.Name,
                        purchaseAmount = pur.Amount,
                        purchaseDate = pur.PurchasedOn,
                    }).ToList();
            return null;
                        // throw new NotImplementedException();
        }
    }
}
