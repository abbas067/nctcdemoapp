using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nctcdemoapp.Models
{
   public interface IEmployee
    {
        List<EmployeeDetail> GetEmployeeList();
    }
}
