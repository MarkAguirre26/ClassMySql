# ClassSql
Better way to perform Create Read Update Delete(CRUD)

INSTALLATION

1. Install ado.net connector v 6.9.9
   (via nuget)
     PM> Install-Package MySql.Data -Version 6.9.9
   (Via package)
     https://dev.mysql.com/downloads/connector/net/6.9.html


2. Add reference ClassMysql to your project


HOW TO USE?

1. Put this line to your form load

    ClassMysql.ClassMysql.Constring = "Connection string here";

2.  Insert/Update/Delete query
    
        private void cmd_Command_Click(object sender, EventArgs e)
        {
            ClassMysql.ClassMysql a = new ClassMysql.ClassMysql();
            a.ExecuteQuery("Query here");
        }

3.  Read/Get Data

	private void cmd_get_Click(object sender, EventArgs e)
        {
            ClassMysql.ClassMysql a = new ClassMysql.ClassMysql(); DataTable dt;
            dt = a.Table("Query here");
           dataGridView1.Rows.Clear();
           foreach (DataRow dr in dt.Rows)
           {
               dataGridView1.Rows.Add(dr["column1"].ToString(), dr["column1"].ToString(), dr["column1"].ToString());
           }
         }
	
