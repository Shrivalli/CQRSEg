using CQRSEg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSEg.Repositories
{
    public interface IEmployeeQueriesRepository
    {
        Employee GetByID(int employeeID);
    }
}
