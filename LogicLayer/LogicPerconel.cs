using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace LogicLayer
{
    public class LogicPerconel
    {
        public static List<EntityPerconel> LogicLayerPerconelList()
        {
            return DALPerconel.PerconelList();
        }
        public static int LogicLayerPerconelAdd(EntityPerconel p)
        {
            if (p.Name1 != null && p.Surname1 != null && p.Salary1 <= 31999 && p.City1 != null && p.Duty1 != null)
            {
                return DALPerconel.AddPerconel(p);


            }
            else
            {

                return -1;

            }
        }
        public static bool LogicLayerPerconelDelete(int per)
        {
            if(per>1 && per != null)
            {
                return DALPerconel.DeletePerconel(per);
            }
            else
            {
                return false;
            }
        }
        public static bool LogicLayerPerconelUpdate(EntityPerconel ent)
        {
            if(ent.ID1>1 && ent.Salary1!=short.Parse(""))
            {
                return DALPerconel.UpdatePerconel(ent);
            }
            else
            {
                return false;
            }
        }
    }
}
