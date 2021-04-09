using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT02_102190248_PhamSiViet
{
    class CSDL_OOP
    {
        
        public static CSDL_OOP Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new CSDL_OOP();
                return _Instance;
            }
            private set { }
        }
        private static CSDL_OOP _Instance;

        private CSDL_OOP()
        {
            
        }

        public List<SV> GetAllSV()
        {
            
            List<SV> listsv = new List<SV>();
            foreach( DataRow SV in CSDL.Instance.DTSV.Rows)
            {
                listsv.Add(GetSV(SV));
                
            }
            return listsv;
        }
        public SV GetSV(DataRow i)
        {
            SV s = new SV();
            s.MSSV = i["MSSV"].ToString();
            s.NameSV = i["NameSV"].ToString();
            s.Gender = Convert.ToBoolean(i["Gender"]);
            s.ID_Lop = Convert.ToInt32(i["LopSH"]);
            s.NS =Convert.ToDateTime( i["ns"]);
            return s;
            // tra ve  1 doi tuuong sinh vien tuong ung 1 datarow
        }
        public List<LopSH> GetAllLopSH()
        {
            List<LopSH> LSH = new List<LopSH>();
            foreach(DataRow LopSH in CSDL.Instance.DTLSH.Rows)
            {
                LSH.Add(GetLopSH(LopSH));
            }
            //tra ve tat ca cac doi tuong LSH  tuong ung Datatable LSH
            return LSH;
        }

        public LopSH GetLopSH( DataRow i) // lay du lieu lop sh
        {
            LopSH lsh = new LopSH();
            lsh.ID_lop = Convert.ToInt32( i["ID_Lop"]);
            lsh.namelop = i["NameLop"].ToString();
            // tra ve  1 doi tuuong sinh vien tuong ung 1 datarow
            return lsh;
        }
        public  List<SV> GetListSV(int ID_lop, string name) // lay du lieu cua sinh vien theo idlop va name
        {
            List<SV> listsv = new List<SV>();
            foreach (DataRow SV in CSDL.Instance.DTSV.Rows)
            {
                if (ID_lop == 0)
                {
                    if (name != "")
                    {
                        if (SV["NameSV"].ToString() == name)
                            listsv.Add(GetSV(SV));// them SV vao thanh 1 row trong datarow
                    }
                    else
                        listsv.Add(GetSV(SV));
                }
                else
                {
                    if (name != "" &&  Convert.ToInt32(SV["LopSH"])==ID_lop )
                    {
                        if (SV["NameSV"].ToString() == name)
                            listsv.Add(GetSV(SV));
                    }
                    else
                    {
                        if (ID_lop == Convert.ToInt32(SV["LopSH"]))
                            listsv.Add(GetSV(SV));
                    }        
                } 
            }
            return listsv;
        }
        public void  addsv( SV sv)// them 1 sv vo mang
        {
            List<SV> listsv = new List<SV>();
            foreach(DataRow row in CSDL.Instance.DTSV.Rows)
            {
                listsv.Add(GetSV(row));
            }
            listsv.Add(sv);
            CSDL.Instance.setSV(listsv);
        }
        public SV findSVwithMSSV(string MSSV) // ham tim sinh vien theo MSSV
        {
            SV s = new SV();
            foreach(SV i in GetAllSV())
            {
                if (i.MSSV == MSSV)
                {
                    s = i;
                }     
            }
            return s;
         }
        public void editsv(SV s) // edit sv thu count thanh sv s
        {
            List<SV> listsv = new List<SV>();
            foreach (DataRow row in CSDL.Instance.DTSV.Rows)
            {
                listsv.Add(GetSV(row));
            }
            int count = 0;
            foreach (var i in listsv)    
            {
                if (listsv[count].MSSV == s.MSSV)
                {
                    listsv[count] = s; // gan gia tri sinh vien thu count thanh sinh vien s sau khi da thay doi
                    break;

                }
                count++;
            }
            CSDL.Instance.setSV(listsv);

        }
        public void deletesv(SV s)
        {
            List<SV> listsv = new List<SV>();
            foreach (DataRow row in CSDL.Instance.DTSV.Rows)
            {
                listsv.Add(GetSV(row));
            }
            //tu dau den day dung de add 1 listsv moi de su dung trong ham delete
            int count = 0;
            foreach (var i in listsv)
            {
                if (listsv[count].MSSV == s.MSSV)
                {
                    listsv.RemoveAt(count); // xoa sinh vien vi tri count trong listsv
                    break;

                }
                count++;
            }
            CSDL.Instance.setSV(listsv); // ham dung de add listsv vao datarow
        }
        public void sortbynamesv()
        {

        }
    }
}
