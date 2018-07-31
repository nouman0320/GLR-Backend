using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GLR_Backend_API_NET_CORE.BusinessLogic
{
    public class RegistrationService
    {
        public static bool register(GLR_Backend_API_NET_CORE.Models.UserInfo userInfo)
        {
            try
            {
                ApplicationDBContext dbContext = new ApplicationDBContext();
                dbContext.Add(userInfo);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
            
        }

        public static bool login(GLR_Backend_API_NET_CORE.Models.UserInfo userInfo)
        {
            try
            {
                ApplicationDBContext dbContext = new ApplicationDBContext();
                List< GLR_Backend_API_NET_CORE.Models.UserInfo> users= dbContext.UserInfos.Where(x => x.Email.Equals(userInfo.Email) && x.Password == userInfo.Password).ToList();
                if (users !=null && users.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

                return false;
            }

        }
    }
}
