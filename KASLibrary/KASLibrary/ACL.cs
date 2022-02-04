using System;
using System.Configuration; 
using System.Data; 
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Net.NetworkInformation;
//using System.Data.SqlClient;

namespace KASLibrary
{
	/// <summary>
	/// This class is a helper class in executing sql statements to MySql server.
	/// </summary> 
    public class SQL
	{
		private string serverName;
     //   private string serverName2;
		private string databaseName;
     //   private string databaseName2;
		private string userName;
		private string password;
		private MySqlConnection connection;
    //    private SqlConnection conn;
        private bool handleException;
        private bool keepAlive;
        private bool logData;
        private int threadID;
        private MySqlTransaction transaction;


        /// <summary>
        /// The constructor that requires all parameters to connect to MySql
        /// </summary>
        /// <param name="userName">MySQL username</param>
        /// <param name="password">MySQL password</param>
        /// <param name="server">MySQL server</param>
        /// <param name="database">MySQL database</param>
       // public SQL(string userName, string password, string server, string database, string server2, string database2)
        //public SQL(string userName, string password, string server, string database)
        //{
        //    this.serverName = server;
        // //   this.serverName2 = server2;
        //    this.databaseName = database;
        ////    this.databaseName2 = database2;
        //    this.userName = userName;
        //    this.password = password;
        //    this.handleException = false;
        //    this.keepAlive = true;
        //    this.logData = true;

        //    connection = new MySqlConnection("server=" + serverName + ";database=" +
        //        databaseName + ";userid=" + userName + ";pwd=" + password);
        //    connection.Open();
        //    this.threadID = connection.ServerThread;

        //    //try
        //    //{
        //    //    Select("select * from datalog where 0");
        //    //}
        //    //catch
        //    //{
        //    //    string query = "create table datalog(logdate date not null,logtime time not null," +
        //    //        "user varchar(16) not null,query varchar(255) not null)";
        //    //    MySqlCommand command = new MySqlCommand(query, connection);
        //    //    command.ExecuteNonQuery();
        //    //}
        //}

        public SQL(string userName, string password, string server, string database)
        {
            this.serverName = server;
            this.databaseName = database;
            this.userName = userName;
            this.password = password;
            this.handleException = false;
            this.keepAlive = true;
            this.logData = true;

            connection = new MySqlConnection("server=" + serverName + ";database=" +
                databaseName + ";userid=" + userName + ";pwd=" + password);
            connection.Open();
            this.threadID = connection.ServerThread;

            //try
            //{
            //    Select("select * from datalog where 0");
            //}
            //catch
            //{
            //    string query = "create table datalog(logdate date not null,logtime time not null," +
            //        "user varchar(16) not null,query varchar(255) not null)";
            //    MySqlCommand command = new MySqlCommand(query, connection);
            //    command.ExecuteNonQuery();
            //}
        }

		/// <summary>
		/// The constructor that requires only user name and password to connect to MySql,
		/// the server name and database name are located in application config file.
		/// </summary>
		/// <param name="userName">MySql user name</param>
		/// <param name="password">MySql password</param>
        public SQL(string userName, string password)
            : this(userName, password, Utility.GetConfig("server"), Utility.GetConfig("database"))
        {

        }

        /// <summary>
		/// Return server name.
		/// </summary>
		public string ServerName
		{
			get{return serverName;}
		}

		/// <summary>
		/// Return database name
		/// </summary>
		public string DatabaseName
		{
			get{return databaseName;}
		}

		/// <summary>
		/// Return MySql user name
		/// </summary>
		public string UserName
		{
			get{return userName;}
		}

		/// <summary>
		/// Return MySql password
		/// </summary>
		public string Password
		{
			get{return password;}
		}

        public MySqlConnection Connection
        {
            get { return connection; }
        }

        /// <summary>
        /// Whether SQL class will handle the exception or throw. Default is false.
        /// </summary>
        public bool HandleException
        {
            get { return handleException; }
            set { handleException = value; }
        }

        /// <summary>
        /// Indicating to keep alive the connection or not. The default value is true.
        /// </summary>
        public bool KeepAlive
        {
            get { return keepAlive; }
            set 
            {
                keepAlive = value;
                if (keepAlive && connection.State == ConnectionState.Closed)
                {
                    connection = new MySqlConnection("server=" + serverName + ";database=" +
                        databaseName + ";userid=" + userName + ";pwd=" + password);
                    connection.Open();
                }
                if (!keepAlive && connection.State == ConnectionState.Open)
                    CloseConnection(); 
            }
        }

        /// <summary>
        /// Whether SQL class will log insert/update/delete queries. Default is true.
        /// </summary>
        public bool LogData
        {
            get { return logData; }
            set { logData = value; }
        }

		/// <summary>
		/// Executing a select query.
		/// </summary>
		/// <param name="query">sql statement</param>
		/// <returns>DataTable filled with the result set</returns>
		public DataTable Select(string query)
		{
            CheckConnection();
            try
            {
                if (!keepAlive)
                {
                    connection = new MySqlConnection("server=" + serverName + ";database=" +
                        databaseName + ";userid=" + userName + ";pwd=" + password);
                    connection.Open();
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.SelectCommand.CommandTimeout = 120;
                DataTable table = new DataTable();
                adapter.Fill(table); 
                adapter.Dispose(); 
                if (!keepAlive) CloseConnection();
                return table;
            }
            catch (Exception ex)
            {
                if (!keepAlive) CloseConnection();
                if (handleException)
                    Utility.ExceptionHandler(ex, "query", query, "sql", this);
                else
                    throw (ex);
                return null;
            }
		}

        //public DataTable Select2(string query)
        //{
        //    try
        //    {

        //       // conn = new MySqlConnection("server=" + serverName2 + "; database="+databaseName2 + "; userid=root; pwd=database");
        //        conn = new SqlConnection("Data Source = " + serverName2 + "\\SQLEXPRESS; " +
        //        "Initial Catalog = " + databaseName2 + "; " + "User Id =sa; Password =database;");

        //        conn.Open();
             
        //        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //        adapter.SelectCommand.CommandTimeout = 120;
        //        DataTable table = new DataTable();
        //        adapter.Fill(table);
        //        adapter.Dispose();               
        //        conn.Close(); 
        //        return table;
        //    }
        //    catch (Exception ex)
        //    {
        //        conn.Close();
        //        throw (ex);
        //    }
        //}

        /// <summary>
        /// Executing a select query.
        /// </summary>
        /// <param name="query">sql statement</param>
        /// <returns>Data Adapter with Commands set</returns>
        public MySqlDataAdapter SelectAdapter(string query)
        {
            CheckConnection();
            try
            {
                if (!keepAlive) throw new Exception("Can't use SelectAdapter when KeepAlive is false!");  
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.SelectCommand.CommandTimeout = 120;
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
                try
                {
                    adapter.UpdateCommand = builder.GetUpdateCommand();
                    adapter.InsertCommand = builder.GetInsertCommand();
                    adapter.DeleteCommand = builder.GetDeleteCommand();
                }
                catch { /*Not from one table*/}
                return adapter;
            }
            catch (Exception ex)
            {
                if (!keepAlive) CloseConnection();
                if (handleException)
                    Utility.ExceptionHandler(ex, "query", query, "sql", this);
                else
                    throw (ex);
                return null;
            }
        }

		/// <summary>
		/// Executing sql query except for select query.
		/// For select query use Select function.
		/// </summary>
		/// <param name="query">sql statement</param>
		public int Execute(string query)
		{
            CheckConnection();
            int result = -1;
            try
            {
                if (!keepAlive)
                {
                    connection = new MySqlConnection("server=" + serverName + ";database=" +
                        databaseName + ";userid=" + userName + ";pwd=" + password);
                    connection.Open();
                }
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                if (logData)
                {
                    string q = "insert into datalog values(curdate(),curtime(),'" + userName + "','" +
                        query.Replace("'", "\\\'") + "')";
                    command = new MySqlCommand(q, connection);
                    result = command.ExecuteNonQuery();
                    command.Dispose();
                }
                if (!keepAlive)CloseConnection();
            }
            catch (Exception ex)
            {
                if (!keepAlive)CloseConnection();
                if (handleException)
                    Utility.ExceptionHandler(ex, "query", query, "sql", this);
                else
                    throw (ex);
            }
            return result;
           // return 1;
            
		}

        //public int Execute2(string query)
        //{
        //    int result = 1;
        //   try
        //    {
        //        conn = new SqlConnection("Data Source = " + serverName2 + "\\SQLEXPRESS; " +
        //         "Initial Catalog = " + databaseName2 + "; " + "User Id =sa; Password =database");
        //        conn.Open();

        //        SqlCommand command = new SqlCommand(query, conn);
        //        command.ExecuteNonQuery();
        //        command.Dispose();
        //        conn.Close();
                
        //    }
        //    catch (Exception ex)
        //    {
        //       conn.Close();
        //       throw (ex);
        //    }
        //    return result;
        //}

        public void CheckConnection()
        {
            if (!keepAlive) return;
            try
            {
                if (connection.Ping() == false) throw (new Exception());
            }
            catch
            {
                try
                {
                    //Try to create new connection
                    connection = new MySqlConnection("server=" + serverName + ";database=" +
                        databaseName + ";userid=" + userName + ";pwd=" + password);
                    connection.Open();

                    #region Kill The Old Thread using the new connection
                    MySqlCommand command = new MySqlCommand("kill " + threadID.ToString(), connection);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch { }
                    command.Dispose();
                    #endregion

                    threadID = connection.ServerThread;
                }
                catch { }             
            }
        }

        /// <summary>
        /// Begin the transaction. KeepAlive must be set to true (default is true).
        /// </summary>
        public void BeginTransaction()
        {
            try
            {
                transaction = connection.BeginTransaction();
            }
            catch
            {
                connection.Close();
                //connection = new MySqlConnection("server=" + serverName + ";database=" +
                //        databaseName + ";userid=" + userName + ";pwd=" + password);
                connection.Open();
                transaction = connection.BeginTransaction();
            }
            //transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
        }

        /// <summary>
        /// Rollback the transaction. KeepAlive must be set to true (default is true).
        /// </summary>
        public void RollbackTransaction()
        {
            if (transaction != null)
                transaction.Rollback(); 
        }

        /// <summary>
        /// Commit the transaction. KeepAlive must be set to true (default is true).
        /// </summary>
        public void CommitTransaction()
        {
            if (transaction != null)
                transaction.Commit(); 
        }

        /// <summary>
        /// Force close connection via kill id
        /// </summary>
        private void CloseConnection()
        {
            if (connection.State == ConnectionState.Closed)
                return;

            MySqlCommand command = new MySqlCommand("kill " + connection.ServerThread.ToString(),
                connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch {  }
            command.Dispose(); 
            if(connection.State!=ConnectionState.Closed)connection.Close();  
        }

        /// <summary>
        /// Closing connection
        /// </summary>
		~SQL()
		{
            try
            {
                CloseConnection();
            }
            catch { }
		}
	}
	
    /// <summary>
	/// This class is the main entry for accessing Access Control List (ACL).
	/// With this class you can create user, delete user, and get specific user as well.
	/// </summary>
	public class ACL
	{
		private SQL sql;

		/// <summary>
		/// The contructor for ACL class that requires all connection parameters.
		/// </summary>
		/// <param name="userName">MySql user name that has privilege to create user (ex: root)</param>
		/// <param name="password">MySql password for the user name given in the previous parameter</param>
        /// <param name="server">MySql server location, e.g: localhost, 192.168.12.7</param>
        /// <param name="database">MySql database to use</param>
		public ACL(string userName,string password, string server, string database)
		{
            if (server == "" && database == "")
                sql = new SQL(userName, password);
            else
                sql = new SQL(userName, password, server, database);
            sql.KeepAlive = false;

            try
            {
                sql.Select("select * from menu where 0");
            }
            catch
            {
                //menu doesn't exist. Therefore create the table.
                sql.Execute("create table menu(role varchar(16) not null,menu varchar(50) not null,submenu varchar(50))");
                sql.Execute("alter table menu add primary key(role,menu,submenu)");
            }
            try
            {
                sql.Select("select * from role where 0");
            }
            catch
            {
                //role doesn't exist. Therefore create the table.
                sql.Execute("create table role(role varchar(16) not null,user varchar(16) not null)");
                sql.Execute("alter table role add primary key(role,user)");
            }
            try
            {
                sql.Select("select * from userlog where 0");
            }
            catch
            {
                string query = "create table userlog(logdate date not null,logtime time not null," +
                    "user varchar(16) not null,status varchar(25) not null,ip varchar(15) not null)";
                sql.Execute(query);
            }
		}

        /// <summary>
        /// The constructor that requires only user name and password,
        /// the server name and database name will be retrieved from application config file. 
        /// </summary>
        /// <param name="userName">MySQL username</param>
        /// <param name="password">MySQL password</param>
        public ACL(string userName, string password) : this(userName, password, "", "")
        {
        }
        
        /// <summary>
        /// Get all posible roles.
        /// </summary>
        /// <returns>Array of string contains roles</returns>
        public string[] GetRoles()
        {
            DataTable table = sql.Select("select distinct role from role order by role");
            string[] roles = new string[table.Rows.Count];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                roles[i] = table.Rows[i]["role"].ToString();  
            }
            return roles;
        }

        /// <summary>
        /// To get all posible MySql users (alias ACL users) excluding the one you put in the constructor.
        /// </summary>
        /// <returns>ACL users available excluding the one you put in the constructor</returns>
        public ACLUser[] GetUsers()
		{
			DataTable table = sql.Select("select user from mysql.user where user<>'" + sql.UserName + "' order by user"); 
			ACLUser[] users = new ACLUser[table.Rows.Count];
			for(int i=0;i<table.Rows.Count;i++)  
			{
				users[i] = new ACLUser(table.Rows[i]["user"].ToString(),sql.UserName,sql.Password,sql.ServerName,sql.DatabaseName); 
			}
			return users;
		}

        /// <summary>
        /// To get all ACL users that have specific role
        /// </summary>
        /// <param name="role">the role of the ACL users</param>
        /// <returns>ACL users</returns>
        public ACLUser[] GetUsers(string role)
        {
            DataTable table = sql.Select("select user from role where role='" + role + "' order by user");
            ACLUser[] users = new ACLUser[table.Rows.Count];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                users[i] = new ACLUser(table.Rows[i]["user"].ToString(), sql.UserName, sql.Password,sql.ServerName,sql.DatabaseName);
            }
            return users;
        }

        /// <summary>
        /// To get all user names that have specific role
        /// </summary>
        /// <param name="role">the role of the ACL users</param>
        /// <returns>ACL user names</returns>
        public string[] GetUserNames(string role)
        {
            DataTable table = sql.Select("select user from role where role='" + role + "' order by user");
            string[] users = new string[table.Rows.Count];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                users[i] = table.Rows[i]["user"].ToString();
            }
            return users;
        }

        /// <summary>
        /// To get all blocked user names
        /// </summary>
        /// <returns>ACL user names</returns>
        public string[] GetBlockedUserNames()
        {
            DataTable table = sql.Select("select user from userlog where status='Blocked' order by user");
            string[] users = new string[table.Rows.Count];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                users[i] = table.Rows[i]["user"].ToString();
            }
            return users;
        }

		/// <summary>
		/// Getting an ACLUser based on specific user name
		/// </summary>
		/// <param name="name">ACL user name or MySql user name</param>
		/// <returns>ACLUser requested or null if not available</returns>
		public ACLUser GetUser(string name)
		{
			DataTable table = sql.Select("select user from mysql.user where user='" + name + "'");
            if (table.Rows.Count == 0)
                return null;
            else
               return new ACLUser(name,sql.UserName,sql.Password,sql.ServerName,sql.DatabaseName); 
		}

		/// <summary>
		/// Create a new ACL user
		/// </summary>
        /// <param name="role">role of the user</param>
		/// <param name="name">user name</param>
		/// <param name="password">password</param>
		/// <returns>ACLUser created</returns>
		public ACLUser CreateUser(string role,string name,string password)
		{
			sql.Execute("create user '" + name + "' identified by '" + password + "'");
            DataTable temp = sql.Select("select user from role where role='" + role + "'");
            ACLUser user = new ACLUser(name, sql.UserName, sql.Password,sql.ServerName,sql.DatabaseName);
            if (temp.Rows.Count > 0)
            {
                ACLUser template = new ACLUser(temp.Rows[0]["user"].ToString(), sql.UserName, sql.Password, sql.ServerName, sql.DatabaseName);
                user.CopyPrivilegesFrom(template);
            }
            else
            {
                user.ClearPrivileges();
                user.Update();
            }
            sql.Execute("insert into role values('" + role + "','" + name + "')");
            return user;
		}

		/// <summary>
		/// Delete a specific ACL user
		/// </summary>
		/// <param name="name">user name to be deleted</param>
		public void DeleteUser(string name)
		{
            string role = sql.Select("select role from role where user='" + name + "'").Rows[0]["role"].ToString();  
            sql.Execute("drop user '" + name + "'");
            sql.Execute("delete from role where user='" + name + "'");
            sql.Execute("delete from mysql.tables_priv where user='" + name + "'");
            sql.Execute("delete from mysql.columns_priv where user='" + name + "'");
            if (sql.Select("select * from role where role='" + role + "'").Rows.Count == 0)
            {
                //Remove also this role
                sql.Execute("delete from menu where role='" + role + "'"); 
            }
		}

        /// <summary>
        /// Perform the login process for user.
        /// </summary>
        /// <param name="name">user name</param>
        /// <param name="password">password of the user</param>
        /// <param name="status">status of the user</param>
        /// <returns>ACLUser of logged-in user, null if login process failed</returns>
        /// <remarks>status output: "Logged In", "Invalid", "Blocked"</remarks>
        public ACLUser Login(string name, string password,out string status)
        {
            if (IsBlocked(name))
            {
                status = "Blocked";
                return null;
            }
            string ipAddress = Utility.GetIPAddress(); 
            try
            {
                SQL test = new SQL(name, password);
                test.KeepAlive = false;
                sql.Execute("insert into userlog values(curdate(),curtime(),'" + name + "','Logged In','" + ipAddress + "')");
                status = "Logged In";
                return GetUser(name);
            }
            catch 
            {
                DataTable tblTemp = sql.Select("select count(*) from userlog where logdate=curdate() and status='Invalid' and user='" + name + "'");
                if (int.Parse(tblTemp.Rows[0][0].ToString()) < 3)
                {
                    sql.Execute("insert into userlog values(curdate(),curtime(),'" + name + "','Invalid','" + ipAddress + "')");
                    status = "Invalid";
                }
                else
                {
                    sql.Execute("insert into userlog values(curdate(),curtime(),'" + name + "','Blocked','" + ipAddress + "')");
                    status = "Blocked";
                }
                return null;
            }
        }

        /// <summary>
        /// Get whether a user is blocked or not.
        /// </summary>
        /// <param name="name">user name</param>
        /// <returns></returns>
        public bool IsBlocked(string name)
        {
            DataTable tblTemp = sql.Select("select * from userlog where status='Blocked' and user='" + name + "'");
            if (tblTemp.Rows.Count > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Block a user.
        /// </summary>
        /// <param name="name">user name</param>
        public void Block(string name)
        {
            string ipAddress = Utility.GetIPAddress(); 
            sql.Execute("insert into userlog values(curdate(),curtime(),'" + name + 
                "','Blocked','" + ipAddress + "')");
        }

        /// <summary>
        /// Unblock user who is blocked.
        /// </summary>
        /// <param name="name">user name</param>
        public void UnBlock(string name)
        {
            DataTable tblTemp = sql.Select("select * from userlog where status='Blocked' and user='" + name + "'");
            if (tblTemp.Rows.Count > 0)
            {
                sql.Execute("update userlog set status='Unblocked' where status='Blocked' and user='" + name + "'"); 
            }
        }
	}

	/// <summary>
	/// Class to manipulate an ACL user
	/// </summary>
	public class ACLUser
	{
		private SQL sql;
        private string role;
		private string name;
		private DataTable tblTablePriv;
		
		/// <summary>
		/// The contructor to create ACLUser that requires all parameters
		/// </summary>
		/// <param name="name">ACL user name to be manipulated</param>
		/// <param name="userName">MySql user name having privileges to create user and to manipulate database mysql</param>
		/// <param name="password">Password of the MySql user name in the previous parameter</param>
        /// <param name="server">Server name</param>
        /// <param name="database">Database name</param>
		public ACLUser(string name,string userName,string password,string server,string database)
		{
            if (server == "" && database == "")
                sql = new SQL(userName, password);
            else
			    sql = new SQL(userName,password,server,database);
            sql.KeepAlive = false;
			this.name = name;
            DataTable temp = sql.Select("select role from role where user='" + name + "'");
            if (temp.Rows.Count > 0)
                this.role = temp.Rows[0]["role"].ToString();
            else
                this.role = "";
			ConstructDataStructure();
			Refresh();
		}

        /// <summary>
        /// The contructor to create ACLUser that does not require server and database parameters.
        /// The server name and database name will be retrieved from application config file.
        /// </summary>
        /// <param name="name">ACL user name to be manipulated</param>
        /// <param name="userName">MySql user name having privileges to create user and to manipulate database mysql</param>
        /// <param name="password">Password of the MySql user name in the previous parameter</param>
        public ACLUser(string name, string userName, string password)
            : this(name, userName, password, "", "")
        { 
        }

        /// <summary>
        /// Return the role of this user.
        /// </summary>
        public string Role
        {
            get { return role; }
        }

		/// <summary>
		/// Return the name of this ACL user.
		/// </summary>
		public string Name
		{
			get{return name;}
		}

        /// <summary>
        /// Return the status of this ACL user. If user do nothing today then status is empty string.
        /// </summary>
        public string Status
        {
            get 
            {
                DataTable tblTemp = sql.Select("select status from userlog where logdate=curdate() and user='" + name + "' order by logtime desc");
                if (tblTemp.Rows.Count > 0)
                    return tblTemp.Rows[0]["status"].ToString();
                else
                    return "";
            }
        }

		/// <summary>
		/// Return a DataTable containing the table privileges for this user.
		/// Columns: table, insert, update, delete.
		/// For select privileges use the ColumnPriv property.
		/// This DataTable is related with ColumnPriv as a parent.
		/// </summary>
		public DataTable TablePriv
		{
			get{return tblTablePriv;}
		}

		/// <summary>
		/// To refresh the content of TablePriv and ColumnPriv from the database.
		/// </summary>
		public void Refresh()
		{ 
			FillTablePriv();
		}

		/// <summary>
		/// To check whether this user has privilege to insert entries into a table
		/// </summary>
		/// <param name="tableName">the database table name</param>
		/// <returns>true if allowed</returns>
		public bool AllowInsert(string tableName)
		{
			DataRow[] rows = tblTablePriv.Select("table='" + tableName + "'"); 
			if(rows.Length==0)return false;
			return (bool)rows[0]["insert"];
		}

		/// <summary>
		/// To check whether this user has privilege to update entries in a table
		/// </summary>
		/// <param name="tableName">the database table name</param>
		/// <returns>true if allowed</returns>
		public bool AllowUpdate(string tableName)
		{
			DataRow[] rows = tblTablePriv.Select("table='" + tableName + "'"); 
			if(rows.Length==0)return false;
			return (bool)rows[0]["update"];
		}

		/// <summary>
		/// To check whether this user has privilege to delete entries in a table 
		/// </summary>
		/// <param name="tableName">the database table name</param>
		/// <returns>true if allowed</returns>
		public bool AllowDelete(string tableName)
		{
			DataRow[] rows = tblTablePriv.Select("table='" + tableName + "'"); 
			if(rows.Length==0)return false;
			return (bool)rows[0]["delete"];
		}

		/// <summary>
		/// To check whether this user has privilege to select certain column in a certain table.
		/// </summary>
		/// <param name="tableName">the database table name</param>
		/// <returns>true if allowed</returns>
		public bool AllowSelect(string tableName)
		{
			DataRow[] rows = tblTablePriv.Select("table='" + tableName + "'"); 
			if(rows.Length==0)return false;
			return (bool)rows[0]["select"];
		}

		/// <summary>
		/// Copying privileges from a user to other user.
		/// If a user has the same role with another user then you can just copy the privileges.
		/// </summary>
		/// <param name="user"></param>
		public void CopyPrivilegesFrom(ACLUser user)
		{
			this.tblTablePriv = user.TablePriv;
			Update();
		}

        /// <summary>
        /// Sets select,insert,update, and delete to false for all tables.
        /// Excepts for default values.
        /// This will create the Most Limited Privileges.
        /// </summary>
        public void ClearPrivileges()
        {
            foreach (DataRow r in TablePriv.Rows)
            {
                r["select"] = false;
                r["insert"] = false;
                r["update"] = false;
                r["delete"] = false;
            }
            DataRow row;
            row = TablePriv.Rows.Find("userlog");
            row["select"] = true;
            row["insert"] = true;
            row = TablePriv.Rows.Find("datalog");
            row["select"] = true;
            row["insert"] = true;
            row = TablePriv.Rows.Find("role");
            row["select"] = true;
            row = TablePriv.Rows.Find("menu");
            row["select"] = true;
        }

        /// <summary>
        /// Sets select, insert, update, and delete to true for all tables.
        /// This will create the Unlimited Privileges.
        /// </summary>
        public void SetAllPrivileges()
        {
            foreach (DataRow r in TablePriv.Rows)
            {
                r["select"] = true;
                r["insert"] = true;
                r["update"] = true;
                r["delete"] = true;
            }
        }

        /// <summary>
        /// Updating TablePriv and ColumnPriv back to the database.
        /// The effect of the changed privileges is immediately apparent.
        /// </summary>
        public void Update()
        {
            sql.KeepAlive = true;
            sql.Execute("delete from mysql.tables_priv where db='" + sql.DatabaseName +
                "' and user='" + name + "'");
            foreach (DataRow row in tblTablePriv.Rows)
            {
                string tablePriv = "";
                if ((bool)row["select"])
                {
                    if (tablePriv != "") tablePriv += ",";
                    tablePriv += "select";
                }
                if ((bool)row["insert"])
                {
                    if (tablePriv != "") tablePriv += ",";
                    tablePriv += "insert";
                }
                if ((bool)row["update"])
                {
                    if (tablePriv != "") tablePriv += ",";
                    tablePriv += "update";
                }
                if ((bool)row["delete"])
                {
                    if (tablePriv != "") tablePriv += ",";
                    tablePriv += "delete";
                }
                sql.Execute("insert into mysql.tables_priv values('%','" + sql.DatabaseName +
                    "','" + name + "','" + row["table"].ToString() + "','',null,'" + tablePriv +
                    "','')");
            }
            sql.KeepAlive = false;
            sql.Execute("FLUSH PRIVILEGES");
        }

        /// <summary>
        /// Logout this user
        /// </summary>
        public void Logout()
        {
            sql.Execute("insert into userlog values(curdate(),curtime(),'" + name + "','Logged Out','" + Utility.GetIPAddress() + "')");
        }

        /// <summary>
        /// Change password
        /// </summary>
        /// <param name="password">the new password</param>
        public void ChangePassword(string password)
        {
            sql.Execute("update mysql.user set password=password('" + password + "') where user='" + name + "'");
            sql.Execute("FLUSH PRIVILEGES");
        }

        /// <summary>
        /// Change role
        /// </summary>
        /// <param name="role">the new role</param>
        public void ChangeRole(string role)
        {
            sql.Execute("update role set role='" + role + "' where user='" + name + "'");
            sql.Execute("FLUSH PRIVILEGES");
        }

		/// <summary>
		/// Preparing the structure of TablePriv and ColumnPriv
		/// </summary>
		private void ConstructDataStructure()
		{
			tblTablePriv = new DataTable("tablepriv");
			tblTablePriv.Columns.Add("table",typeof(string));
            tblTablePriv.Columns.Add("select", typeof(bool));
			tblTablePriv.Columns.Add("insert",typeof(bool));
			tblTablePriv.Columns.Add("update",typeof(bool));
			tblTablePriv.Columns.Add("delete",typeof(bool));
            tblTablePriv.PrimaryKey = new DataColumn[] { tblTablePriv.Columns["table"] };
		}

		/// <summary>
		/// Fill TablePriv from database
		/// </summary>
		private void FillTablePriv()
		{
            tblTablePriv.Clear();

            //Check whether this user has any table privileges
            DataTable dtPriv = sql.Select("select * from mysql.tables_priv where db='" + sql.DatabaseName +
                "' and user='" + name + "'");
            //if (dtPriv.Rows.Count == 0) return;

			DataTable tblTable = sql.Select("show tables");
			foreach(DataRow row in tblTable.Rows)
			{
				DataRow newRow = tblTablePriv.NewRow();
				string tableName = row[0].ToString(); 
				newRow["table"] =tableName;
                newRow["select"]=false;
				newRow["insert"]=false;
				newRow["update"]=false;
				newRow["delete"]=false;

				//Check whether this user has table privileges
                DataRow[] drPriv = dtPriv.Select("table_name='" + tableName + "'");
				if(drPriv.Length > 0)
				{
					string tablePriv = drPriv[0]["table_priv"].ToString().ToLower();
                    if(tablePriv.IndexOf("select")>=0)newRow["select"]=true;
					if(tablePriv.IndexOf("insert")>=0)newRow["insert"]=true;
					if(tablePriv.IndexOf("update")>=0)newRow["update"]=true;
					if(tablePriv.IndexOf("delete")>=0)newRow["delete"]=true;
				}
				tblTablePriv.Rows.Add(newRow);
			}
		}
	}
}
