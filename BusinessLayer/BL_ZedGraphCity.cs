using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data.OleDb;
using ZedGraph;


namespace BusinessLayer
{
    public class BL_ZedGraphCity
    {
        private DataAccessLayer.Connection baglanti = new DataAccessLayer.Connection();
        public PointPairList LoadGraphData()
        {
            OleDbConnection connection = baglanti.ConnectionOpen();
            PointPairList list = new PointPairList();
            {
                string query = "SELECT sehir, COUNT(*) AS uyeSayisi FROM uye GROUP BY sehir";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string sehir = reader["sehir"].ToString();
                            int uyeSayisi = Convert.ToInt32(reader["uyeSayisi"]);

                            list.Add(list.Count + 1, uyeSayisi, sehir);
                        }
                    }
                }
            }

            return list;
        }
    }
}