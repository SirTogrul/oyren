using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core1
{
     public class Department
    {
        public int No { set; get; }
        public int EmployeeLimit
        {
            get
            {
                return EmployeeLimit;
            }
            set
            {
                if(EmployeeLimit>0 && EmployeeLimit <20)
                {
                    EmployeeLimit = value;
                }
            }
        }
    }
}
