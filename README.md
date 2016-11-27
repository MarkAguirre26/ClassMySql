# ClassMySql
Better way to perform Create Read Update Delete(CRUD)

INSTALLATION

1. Download ProjectClasMysql.rar.
    https://www.dropbox.com/s/bhu9wvagygzhx9x/ProjectClasMysql.zip?dl=1
    
FILES

ClassMysql.dll  and Demo project
    
2. Install ado.net connector v 6.9.9.

   (via nuget)
     PM> Install-Package MySql.Data -Version 6.9.9
   (Via package)
     https://dev.mysql.com/downloads/connector/net/6.9.html
     
3. Add reference ClassMySql.dll class to your project.

HOW TO USE?

1. Connect your proJect to your database.

   		 private void Form1_Load(object sender, EventArgs e)  {
          	 	 ClassMysql.ClassMysql.Constring = "Server=localhost;Database=youdb;Uid=root;Pwd=yourPWD;";           
       		 }

2.  Insert/Update/Delete query.
    
      	  	private void cmd_Command_Click(object sender, EventArgs e)    {
            		ClassMysql.ClassMysql a = new ClassMysql.ClassMysql();
           	 	a.ExecuteQuery("Query here");
        	}

3.  Read/Get Data.

		private void cmd_get_Click(object sender, EventArgs e)     {
          	  	ClassMysql.ClassMysql a = new ClassMysql.ClassMysql(); DataTable dt;
          	  	dt = a.Table("Query here");
          		 dataGridView1.Rows.Clear();
          		 foreach (DataRow dr in dt.Rows)    	{
              			 dataGridView1.Rows.Add(dr["column1"].ToString(), dr["column1"].ToString(), dr["column1"].ToString());
     	    		  }
        	 }
	 
//The Developer
MARK SOMERSON R. AGUIRRE
.net/mobile developer
gmail: markaguirre26@gmail.com
skype: markaguirre26@gmail.com
Facebook: https://www.facebook.com/mark.aguirre.50
