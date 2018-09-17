using BussinessObject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserDA
    {
        SqlConnection con = new

          SqlConnection("data source=LAPTOP-KDDCK77K;initial catalog=DemoDB;persist security info=True;user id=sa;password=push1234");

        public List<UserBO> GetUserDetails(UserBO ObjBO) // passing Bussiness object Here

        {

            try

            {
                List<UserBO> lstBo = new List<UserBO>();

                con.Open();
                //using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Userinfo Where Name = ISNULL('" + ObjBO.Name + "', Name) or Address = ISNULL('" + ObjBO.address + "', Address)", con))
                string where = "Where " + ((!string.IsNullOrEmpty(ObjBO.Name)) ? "Name like '%" + ObjBO.Name + "%'" : "");
                if (!string.IsNullOrEmpty(ObjBO.Name) && !string.IsNullOrEmpty(ObjBO.address))
                    where = where + " or ";

                where = where + ((!string.IsNullOrEmpty(ObjBO.address)) ? "Address like '%" + ObjBO.address + "%'" : "");


                if (string.IsNullOrEmpty(ObjBO.Name) && string.IsNullOrEmpty(ObjBO.address))
                    where = string.Empty;

                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Userinfo " + where, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        lstBo.Add(new UserBO()
                        {
                            Name = dt.Rows[i]["Name"].ToString(),
                            address = dt.Rows[i]["Address"].ToString(),
                            EmailID = dt.Rows[i]["EmailID"].ToString(),
                            Mobilenumber = dt.Rows[i]["Mobilenumber"].ToString(),
                        });
                    }
                }
                con.Close();
                return lstBo;

            }

            catch

            {

                throw;

            }

        }
    }
}
