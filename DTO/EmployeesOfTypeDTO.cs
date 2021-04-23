using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EmployeesOfTypeDTO
    {
        string _StrID;
        string _StrName;
        bool _BStatus;

        public string StrID { get => _StrID; set => _StrID = value; }
        public string StrName { get => _StrName; set => _StrName = value; }
        public bool BStatus { get => _BStatus; set => _BStatus = value; }
    }
}
