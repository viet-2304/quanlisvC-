using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT02_102190248_PhamSiViet
{
    public partial class Form2 : Form
    {
        public delegate void MyDel( string mssv); // em cu sua cai delegat nay tu nhien ^^
      //  public MyDel d {get; set;}                           // nho comment lai cho a la oke
        public MyDel mydel;
        private int ID_Lop = 0;
        
        private string MSSV = "";
        public void getdata( string mssv)
        {
            
            MSSV = mssv;
        }
        public Form2()
        {
           mydel = new MyDel(getdata);// tham chieu den ham getdata

          InitializeComponent();
          setCBB();
          male.Checked = true;
            

        }
        private void setCBB()
        {
            LopSH.Items.Add(new CBBItiem { value=0 ,Text=""} );
            foreach (LopSH i in CSDL_OOP.Instance.GetAllLopSH())
            {
                LopSH.Items.Add(new CBBItiem
                {
                    value = i.ID_lop,
                    Text = i.namelop
                });

            }
           
        }
        private void button2_Click(object sender, EventArgs e) // button cancel
        {
            this.Close();
        }

        
        private void button1_Click(object sender, EventArgs e) // button oke
        {
            CSDL_OOP.Instance.editsv(getSV());
            MessageBox.Show("them thanh cong nhan, show de xem ket qua");
            this.Dispose();
        }
        private SV getSV() // lay du lieu cua sv tu form 2
        {
            SV s = new SV();
            s.MSSV = MSSVBox.Text;
            s.NameSV = NameBox.Text;
            s.ID_Lop = ((CBBItiem)LopSH.SelectedItem).value;
            s.NS = dateTimePicker1.Value;

            if (male.Checked == false)
                s.Gender = Convert.ToBoolean(male.Checked);
            else
                s.Gender = Convert.ToBoolean(male.Checked);
            return s;
        }

       private void Form2_Load(object sender, EventArgs e)
        {
            if (MSSV != "")
            {
                editstudent();
                MessageBox.Show("sua thanh cong nhan, show de xem ket qua");
            }
            
        }
        public void editstudent() // load du lieu duoc nhap vao form2  cho sv
        {
            SV s ;
            s = CSDL_OOP.Instance.findSVwithMSSV(MSSV);
            MSSVBox.Text = s.MSSV;
            MSSVBox.Enabled = false;
            NameBox.Text = s.NameSV;
          
            LopSH.SelectedIndex = s.ID_Lop;          
           //dateTimePicker1.Value = s.NS;
            male.Checked = s.Gender;
        }
 
    }
}
