using DAL;
using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBll
    {
        IUser dal = null;
        private UserBll()
        {
            if (dal == null)
            {
                dal = new UserDal();
            }
        }

        public int Add(User model)
        {
            if (dal!=null)
            {
                return dal.Add(model);
            }
            else
            {
                return -1;
            }
        }
        public int Update(User model)
        {
            if (dal!=null)
            {
                return dal.Update(model);
            }
            else
            {
                return -1;
            }
        }
        public int Delete(User model)
        {
            if (dal!=null)
            {
                return dal.Delete(model);
            }
            else
            {
                return -1;
            }
        }
    }
}
