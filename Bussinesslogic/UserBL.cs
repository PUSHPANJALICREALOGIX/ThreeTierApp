using BussinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussinesslogic
{
    public class UserBL
    {
        public List<UserBO> GetUserDetail(UserBO objUserBL) // passing Bussiness object Here

        {

            try

            {

                UserDA objUserda = new UserDA(); // Creating object of Dataccess



                return objUserda.GetUserDetails(objUserBL); // calling Method of DataAccess



            }

            catch

            {

                throw;

            }

        }
    }
}
