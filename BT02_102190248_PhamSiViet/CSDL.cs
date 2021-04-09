using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02_102190248_PhamSiViet
{
    class CSDL
    {
        public DataTable DTSV { get; set; }
        public DataTable DTLSH { get; set; }

       
        public static CSDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CSDL();
                }
                return _Instance;
            }
            private set 
            {
               
            }
        }
        private static CSDL _Instance;
        private CSDL()
        {
            DTSV = new DataTable();
            SV[] array = new SV[]
               {
                   
                new SV{NameSV="NVA", MSSV="23", Gender= true, ID_Lop=1,NS= Convert.ToDateTime("12/4/2001") },
                new SV{NameSV="NVB", MSSV="24", Gender= true, ID_Lop=2,NS=Convert.ToDateTime("9/5/2001") },
                new SV{NameSV="NVC", MSSV="69", Gender= true, ID_Lop=1,NS=Convert.ToDateTime("6/6/2001") },
                new SV{NameSV="NVD", MSSV="01", Gender= false, ID_Lop=1,NS=Convert.ToDateTime("2/1/2001") },
                new SV{NameSV="NVC", MSSV="29",  Gender= false, ID_Lop=2, NS=Convert.ToDateTime("11/6/2001") }
               };
            DTSV.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("NameSV", typeof(string)),
                new DataColumn("MSSV", typeof(string)),
                new DataColumn("Gender", typeof(bool)),
                new DataColumn("LopSH", typeof(int)),
                new DataColumn("ns", typeof(DateTime)),
            });
            foreach(SV i in array)
            {
                DataRow dr = DTSV.NewRow();
                dr["NameSV"] = i.NameSV;
                dr["MSSV"] = i.MSSV;
                dr["Gender"] = i.Gender;
                dr["LopSH"] = i.ID_Lop;
                dr["ns"] = i.NS;
                DTSV.Rows.Add(dr);
            }
            DTLSH = new DataTable();
            DTLSH.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID_LOP", typeof(int)),
                new DataColumn("NameLop", typeof(string)),
            });
            DataRow dtr = DTLSH.NewRow();
            dtr["ID_Lop"] = 1;
            dtr["NameLop"] = "1";
            DTLSH.Rows.Add(dtr);
            DataRow dtr1 = DTLSH.NewRow();
            dtr1["ID_Lop"] = 2;
            dtr1["NameLop"] = "2";
            DTLSH.Rows.Add(dtr1);


        }
        /*public void addSV(List<SV> listsv)
        {
            DTSV.Rows.Clear();
            foreach (var s in listsv)
            {
                DataRow dr = DTSV.NewRow();
                dr["NameSV"] = s.NameSV;
                dr["MSSV"] = s.MSSV;
                dr["Gender"] = s.Gender;
                dr["LopSH"] = s.ID_Lop;
                dr["ns"] = s.NS;
                DTSV.Rows.Add(dr);
            }
            
        }*/
        /*public void addSV(SV s)
        {
            
                DataRow dr = DTSV.NewRow();
                dr["NameSV"] = s.NameSV;
                dr["MSSV"] = s.MSSV;
                dr["Gender"] = s.Gender;
                dr["LopSH"] = s.ID_Lop;
                dr["ns"] = s.NS;
                DTSV.Rows.Add(dr);
            
        }*/
        public void setSV(List<SV> listsv) // tao  1 csdl moi sau khi thao tac
        {
            DTSV.Rows.Clear();
            foreach(var s in listsv)
            {
                DataRow sv = DTSV.NewRow();
                sv["MSSV"] = s.MSSV;
                sv["NameSV"] = s.NameSV;
                sv["Gender"] = s.Gender;
                sv["NS"] = s.NS;
                sv["LopSH"] = s.ID_Lop;
                DTSV.Rows.Add(sv);
            }
        }

        }
}
