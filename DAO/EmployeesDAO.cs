using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class EmployeesDAO
    {
        public static List<EmployeesDTO> loadListEmployDAO()
        {
            List<EmployeesDTO> LstEmp = new List<EmployeesDTO>();
            string StrSelect = @"select * from tblEmployees";
            try
            {
                SqlConnection SqlConn = DataProviderDAO.OpenConnect();
                SqlDataReader SqlSdr = DataProviderDAO.SelectData(StrSelect, SqlConn);
                while(SqlSdr.Read())
                {
                    EmployeesDTO EmpTemp = new EmployeesDTO();
                    if(!SqlSdr.IsDBNull(0))
                    {
                        EmpTemp.StrID = SqlSdr["ID"].ToString();
                    }
                    else
                    {
                        EmpTemp.StrID = "";
                    }
                    if(!SqlSdr.IsDBNull(1))
                    {
                        EmpTemp.StrFullName = SqlSdr["FullName"].ToString();
                    }
                    else
                    {
                        EmpTemp.StrFullName = "";
                    }
                    if (!SqlSdr.IsDBNull(2))
                    {
                        EmpTemp.StrNumberPhone = SqlSdr["NumberPhone"].ToString();
                    }
                    else
                    {
                        EmpTemp.StrNumberPhone = "";
                    }
                    if (!SqlSdr.IsDBNull(3))
                    {
                        EmpTemp.DTBirthDay = Convert.ToDateTime(SqlSdr["BirthDay"]);
                    }
                    else
                    {
                        EmpTemp.DTBirthDay = DateTime.Now;
                    }
                    if (!SqlSdr.IsDBNull(4))
                    {
                        EmpTemp.StrGender = SqlSdr["Gender"].ToString();
                    }
                    else
                    {
                        EmpTemp.StrGender = "";
                    }
                    if (!SqlSdr.IsDBNull(5))
                    {
                        EmpTemp.StrEmail = SqlSdr["Email"].ToString();
                    }
                    else
                    {
                        EmpTemp.StrEmail = "";
                    }
                    if (!SqlSdr.IsDBNull(6))
                    {
                        EmpTemp.StrPassword = SqlSdr["Password"].ToString();
                    }
                    else
                    {
                        EmpTemp.StrPassword= "";
                    }
                    if (!SqlSdr.IsDBNull(7))
                    {
                        EmpTemp.StrIDCard= SqlSdr["IDCard"].ToString();
                    }
                    else
                    {
                        EmpTemp.StrIDCard = "";
                    }
                    if (!SqlSdr.IsDBNull(8))
                    {
                        EmpTemp.DecSalary = Convert.ToDecimal(SqlSdr["Salary"].ToString());
                    }
                    else
                    {
                        EmpTemp.DecSalary = 0;
                    }
                    if (!SqlSdr.IsDBNull(9))
                    {
                        EmpTemp.StrEmployTypeID = SqlSdr["EmployOfTypeID"].ToString();
                    }
                    else
                    {
                        EmpTemp.StrEmployTypeID = "";
                    }
                    if (!SqlSdr.IsDBNull(10))
                    {
                        EmpTemp.BStatus = Convert.ToBoolean(SqlSdr["Status"]);
                    }
                    else
                    {
                        EmpTemp.BStatus = false;
                    }
                    LstEmp.Add(EmpTemp);
                }
                SqlSdr.Close();
                SqlConn.Close();
                return LstEmp;
            }
            catch
            {
                return null;
            }
        }
        public static bool addEmployeesDAO(EmployeesDTO Emps)
        {
            string StrInsertEmp = @"insert into dbo.tblEmployees(ID,FullName,NumberPhone,BirthDay,Gender,Email,Password,IDCard,Salary,EmployOfTypeID,Status) 
                values(@ID,@FullName,@NumberPhone,@BirthDay,@Gender,@Email,@Password,@IDCard,@Salary,@EmployOfTypeID,@Status)";

            List<SqlParameter> LstPar = new List<SqlParameter>();
           
            LstPar.Add(new SqlParameter("@ID", Emps.StrID));
            LstPar.Add(new SqlParameter("@FullName", Emps.StrFullName));
            LstPar.Add(new SqlParameter("@NumberPhone", Emps.StrNumberPhone));
            LstPar.Add(new SqlParameter("@BirthDay", Emps.DTBirthDay));
            LstPar.Add(new SqlParameter("@Gender",Emps.StrGender));
            LstPar.Add(new SqlParameter("@Email", Emps.StrEmail));
            LstPar.Add(new SqlParameter("@Password",Emps.StrPassword));
            LstPar.Add(new SqlParameter("@IDCard", Emps.StrIDCard));
            LstPar.Add(new SqlParameter("@Salary", Emps.DecSalary));
            LstPar.Add(new SqlParameter("@EmployOfTypeID", Emps.StrEmployTypeID));
            LstPar.Add(new SqlParameter("@Status", Emps.BStatus));

            foreach(var ParCheck in LstPar)
            {
                if(ParCheck.Value == null)
                {
                    ParCheck.Value = DBNull.Value;
                }    
            }

            SqlConnection conn = DataProviderDAO.OpenConnect();
            bool BResult = DataProviderDAO.exeCMD(StrInsertEmp, LstPar.ToArray(), conn);
            conn.Close();
            return BResult;
        }
    }
}
