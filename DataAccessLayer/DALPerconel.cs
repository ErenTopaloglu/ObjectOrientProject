using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DALPerconel
    {
        public static List<EntityPerconel> PerconelList()
        {
            List<EntityPerconel> values = new List<EntityPerconel>();
            SqlCommand cmd = new SqlCommand("Select * from PerconelInformation", Connect0.conn);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EntityPerconel ent = new EntityPerconel();
                ent.ID1 = int.Parse(dr["ID"].ToString());
                ent.Name1 = dr["NAME"].ToString();
                ent.Surname1 = dr["SURNAME"].ToString();
                ent.City1 = dr["CITY"].ToString();
                ent.Duty1 = dr["DUTY"].ToString();
                ent.Salary1 = short.Parse(dr["SALARY"].ToString());
                values.Add(ent);

            }
            dr.Close();
            return values;
        }
        public static int AddPerconel(EntityPerconel p)
        {
            SqlCommand cmd2 = new SqlCommand("insert into PerconelInformation (Name,Surname,City,Duty,Salary) values (@p1,@p2,@p3,@p4,@p5)", Connect0.conn);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
                cmd2.Parameters.AddWithValue("@p1", p.Name1);
                cmd2.Parameters.AddWithValue("@p2", p.Surname1);
                cmd2.Parameters.AddWithValue("@p3", p.City1);
                cmd2.Parameters.AddWithValue("@p4", p.Duty1);
                cmd2.Parameters.AddWithValue("@p5", p.Salary1);
                return cmd2.ExecuteNonQuery();
        }

        public static bool DeletePerconel(int p)
        {
            SqlCommand cmd3 = new SqlCommand("Delete from PerconelInformation where ID=@p1", Connect0.conn);
            if (cmd3.Connection.State != ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }
            cmd3.Parameters.AddWithValue("@p1", p);
            return cmd3.ExecuteNonQuery() > 0;
        }
        public static bool UpdatePerconel(EntityPerconel p)
        {
            SqlCommand cmd4 = new SqlCommand("Update PerconelInformation set Name=@p0,Surname=@p1,Duty=@p2,Salary=@p3,City=@p4 where ID=@p5",Connect0.conn);
            if (cmd4.Connection.State != ConnectionState.Open)
            {
                cmd4.Connection.Open();
            }
            cmd4.Parameters.AddWithValue("@p0", p.Name1);
            cmd4.Parameters.AddWithValue("@p1",p.Surname1);
            cmd4.Parameters.AddWithValue("@p2", p.Duty1);
            cmd4.Parameters.AddWithValue("@p3", p.Salary1);
            cmd4.Parameters.AddWithValue("@p4", p.City1);
            cmd4.Parameters.AddWithValue("@p5", p.ID1);
            return cmd4.ExecuteNonQuery() > 0;
        }



    }
}
