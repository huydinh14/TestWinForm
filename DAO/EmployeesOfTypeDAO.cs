using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class EmployeesOfTypeDAO
    {
        public static List<EmployeesOfTypeDTO> loadListEmployeesOfTypeDAO()
        {
            List<EmployeesOfTypeDTO> LstEmpOfType = new List<EmployeesOfTypeDTO>();
            string StrSelect = @"select * from tblEmployeeOfType";
            try
            {
                SqlConnection SqlConn = DataProviderDAO.OpenConnect();
                SqlDataReader SqlSdr = DataProviderDAO.SelectData(StrSelect, SqlConn);
                while (SqlSdr.Read())
                {
                    EmployeesOfTypeDTO EmpTempOfType = new EmployeesOfTypeDTO();
                    if (!SqlSdr.IsDBNull(0))
                    {
                        EmpTempOfType.StrID = SqlSdr["ID"].ToString();
                    }
                    else
                    {
                        EmpTempOfType.StrID = "";
                    }
                    if (!SqlSdr.IsDBNull(1))
                    {
                        EmpTempOfType.StrName = SqlSdr["Name"].ToString();
                    }
                    else
                    {
                        EmpTempOfType.StrName = "";
                    }
                    if (!SqlSdr.IsDBNull(2))
                    {
                        EmpTempOfType.BStatus = Convert.ToBoolean(SqlSdr["Status"]);
                    }
                    else
                    {
                        EmpTempOfType.BStatus = false;
                    }

                    LstEmpOfType.Add(EmpTempOfType);
                }
                SqlSdr.Close();
                SqlConn.Close();
                return LstEmpOfType;
            }
            catch
            {
                return null;
            }
        }
    }
}
