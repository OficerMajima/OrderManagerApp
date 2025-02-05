using OrderManagerApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagerApp.Domain.Interfaces
{
    public interface IMoneyArrivalRepository
    {
        Task<IEnumerable<MoneyArrival>> GetAllMoneyArrivalsAsync();
    }
}
