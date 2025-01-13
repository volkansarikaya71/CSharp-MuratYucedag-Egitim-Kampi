using C_Sharp301.DataAccessLayer.Repositories;
using C_Sharp301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp301.BusinessLayer.Abstract
{
    public interface IOrderService:IGenericService<Order>
    {
    }
}
