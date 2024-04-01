using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using ZedGraph;

namespace BusinessLayer
{
    public class BL_ZedGraphUcret
    {
        private DataAccessLayer.Connection baglanti = new DataAccessLayer.Connection();
        public PointPairList GetMonthlyMembershipFee()
        {
            OleDbConnection connection = baglanti.ConnectionOpen();
            PointPairList monthlyMembershipFee = new PointPairList();
            {

                string query = "SELECT tarih, SUM(ucret) AS UcretToplam FROM aidat GROUP BY tarih";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime date = Convert.ToDateTime(reader["tarih"]);
                            double xValue = (double)new XDate(date);
                            double yValue = Convert.ToDouble(reader["UcretToplam"]);

                            monthlyMembershipFee.Add(xValue, yValue);
                        }
                    }
                }
            }

            return monthlyMembershipFee;
        }
    }
}
