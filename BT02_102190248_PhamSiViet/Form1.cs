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
    
    public partial class Form1 : Form
    {
        
       
        public Form1()
        {
            InitializeComponent();
            SetCBB();
            SetSortText();
           
        }

        public void SetCBB() // cai dat lopsh
        {
            lopSH.Items.Add(new CBBItiem { value = 0, Text = "All" });
            foreach (LopSH i in CSDL_OOP.Instance.GetAllLopSH())
            {
                lopSH.Items.Add(new CBBItiem
                {
                    value = i.ID_lop,
                    Text = i.namelop
                });

            }
            lopSH.Text = "All";
        }


        private void Searchbutton_Click(object sender, EventArgs e)
        {
            findSV();
        } // ham search

        private void Showbutton_Click(object sender, EventArgs e)
        {
            findSV();
        } // ham show

        private void findSV() // findSV theo lopsh and  name
        {
            int idlop = ((CBBItiem)lopSH.SelectedItem).value;

            string nameSV = textSearch.Text;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = CSDL_OOP.Instance.GetListSV(idlop, nameSV);

        }

        private void Deletebutton_Click(object sender, EventArgs e) // ham xoa
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count > 0)
            {
                string mssv = "";
                if (r.Count > 0)
                {
                    foreach (DataGridViewRow i in r)
                    {
                        mssv = i.Cells["MSSV"].Value.ToString(); // kiem tra mssv co khong                                                              
                    }
                }
                foreach (DataRow sv in CSDL.Instance.DTSV.Rows)
                {
                    if (sv["MSSV"].ToString() == mssv)
                    {
                        CSDL_OOP.Instance.deletesv(CSDL_OOP.Instance.findSVwithMSSV(mssv));
                        // ham o trong dung de tim kiem sinh vien theo mssv sau do tra ve kieu sv
                        //ham deletesv dung de xoa sinh vien duoc truyen vao trong database
                        break;
                    }
                }


                MessageBox.Show("xoa thanh cong nhan show de xem ket qua");
            }
        }
        private void Addbutton_Click(object sender, EventArgs e) // ham add
        {

            Form2 form2 = new Form2();
            form2.Show();

        }

        private void Editbutton_Click(object sender, EventArgs e)  // ham edit
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            string mssv = "";
            if (r.Count > 0)
            {
                foreach (DataGridViewRow i in r)
                {
                    mssv = i.Cells["MSSV"].Value.ToString(); // kiem tra mssv co khong
                }
                foreach (DataRow sv in CSDL.Instance.DTSV.Rows)
                {   
                    if (sv["MSSV"].ToString() == mssv)
                    {
                        CSDL_OOP.Instance.findSVwithMSSV(mssv);  // tim kiem sv theo mssv  trong csdl
                    }
                } 
                Form2 form2 = new Form2();
                form2.mydel(mssv); //truyen du lieu mssv tu form1 sang form2
                form2.Show();
            }
        }

        private void Sortbutton_Click(object sender, EventArgs e)
        {
            int test= ((CBBItiem)sorttext.SelectedItem).value;
            /*switch (test)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                default:
            }*/
        }
        private void SetSortText()
        {
            sorttext.Items.Add(new CBBItiem { value = 0, Text = "NameSV" });
            sorttext.Items.Add(new CBBItiem { value = 1, Text = "MSSV" });
            sorttext.Items.Add(new CBBItiem { value = 2, Text = "Gender" });
            sorttext.Items.Add(new CBBItiem { value = 3, Text = "NS" });
            sorttext.Items.Add(new CBBItiem { value = 4, Text = "ID_Lop" });
        }
    }
}

