using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassMysql;


namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            ClassMysql.ClassMysql.Constring = "Server=localhost;Database=etop;Uid=root;Pwd=;";
           
        }
        private void cmd_Command_Click(object sender, EventArgs e)
        {
            ClassMysql.ClassMysql a = new ClassMysql.ClassMysql();
            a.ExecuteQuery("INSERT INTO `tbl_user` (`FullName`, `Username`, `Password`, `UserLevel`) VALUES ('k', 'k', 'k', '0')");
        }

        private void cmd_get_Click(object sender, EventArgs e)
        {
            ClassMysql.ClassMysql a = new ClassMysql.ClassMysql(); DataTable dt;
            dt = a.Table("Select * from tbl_user");
           dataGridView1.Rows.Clear();
           foreach (DataRow dr in dt.Rows)
           {
               dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
           }
        }
    }
}
