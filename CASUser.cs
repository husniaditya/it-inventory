using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using KASLibrary;

namespace CAS
{
    public class CASUser
    {
        private SQL sql;
        private string role;
        private string oto;
        private string roleName;
		private string name;
        private string user;
		private DataTable dtMenuPriv;
		
		/// <summary>
		/// The contructor to create CASUser that requires all parameters
		/// </summary>
		/// <param name="name">ACL user name to be manipulated</param>
		/// <param name="userName">MySql user name having privileges to create user and to manipulate database mysql</param>
		/// <param name="password">Password of the MySql user name in the previous parameter</param>
        /// <param name="server">Server name</param>
        /// <param name="database">Database name</param>
		public CASUser(string user, SQL sql)
		{
            //if (server == "" && database == "")
            //    sql = new SQL(userName, password);
            //else
            //    sql = new SQL(userName,password,server,database);
            //sql.KeepAlive = true;
            this.sql = sql;
            this.user = user;
            DataTable temp = sql.Select("select usr.*, usrlevel.name as rolename,usrlevel.otolevel_ as otolevel from usr, usrlevel where usr.role=usrlevel.role and user='" + user + "'");
            if (temp.Rows.Count > 0)
            {
                this.name = temp.Rows[0]["name"].ToString();
                this.role = temp.Rows[0]["role"].ToString();
                this.roleName = temp.Rows[0]["rolename"].ToString();
                this.oto = temp.Rows[0]["otolevel"].ToString();
            }
            else
            {
                this.name = "";
                this.role = "";
                this.roleName = "";
                this.oto = "";
            }
			ConstructDataStructure();
			Refresh();
		}

        ///// <summary>
        ///// The contructor to create CASUser that does not require server and database parameters.
        ///// The server name and database name will be retrieved from application config file.
        ///// </summary>
        ///// <param name="name">ACL user name to be manipulated</param>
        ///// <param name="userName">MySql user name having privileges to create user and to manipulate database mysql</param>
        ///// <param name="password">Password of the MySql user name in the previous parameter</param>
        //public CASUser(string name, string userName, string password)
        //    : this(name, userName, password, "", "")
        //{ 
        //}

        /// <summary>
        /// Return the role of this user.
        /// </summary>
        public string Role
        {
            get { return role; }
        }

        /// <summary>
        /// Return the role name of this user.
        /// </summary>
        public string RoleName
        {
            get { return roleName; }
        }

        /// <summary>
        /// Return the name of this ACL user.
        /// </summary>
        public string User
        {
            get { return user; }
        }

        /// <summary>
        /// Return the oto of this ACL user.
        /// </summary>
        public string Oto
        {
            get { return oto; }
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
                DataTable tblTemp = sql.Select("select status from userlog where logdate=curdate() and user='" + user + "' order by logtime desc");
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
		public DataTable MenuPriv
		{
			get{return dtMenuPriv;}
		}

		/// <summary>
		/// To refresh the content of TablePriv and ColumnPriv from the database.
		/// </summary>
		public void Refresh()
		{ 
			FillMenuPriv();
		}

		/// <summary>
		/// To check whether this user has privilege to insert entries into a table
		/// </summary>
		/// <param name="menuId">the database table name</param>
		/// <returns>true if allowed</returns>
		public bool AllowInsert(string menuId)
		{
			DataRow[] rows = dtMenuPriv.Select("menuId='" + menuId + "'"); 
			if(rows.Length==0)return false;
			return (bool)rows[0]["insert"];
		}

		/// <summary>
		/// To check whether this user has privilege to update entries in a table
		/// </summary>
		/// <param name="menuId">the database table name</param>
		/// <returns>true if allowed</returns>
		public bool AllowUpdate(string menuId)
		{
			DataRow[] rows = dtMenuPriv.Select("menuId='" + menuId + "'"); 
			if(rows.Length==0)return false;
			return (bool)rows[0]["update"];
		}

		/// <summary>
		/// To check whether this user has privilege to delete entries in a table 
		/// </summary>
		/// <param name="menuId">the database table name</param>
		/// <returns>true if allowed</returns>
		public bool AllowDelete(string menuId)
		{
			DataRow[] rows = dtMenuPriv.Select("menuId='" + menuId + "'"); 
			if(rows.Length==0)return false;
			return (bool)rows[0]["delete"];
		}

		/// <summary>
		/// To check whether this user has privilege to select/view entries in a table.
		/// </summary>
		/// <param name="menuId">the database table name</param>
		/// <returns>true if allowed</returns>
		public bool AllowSelect(string menuId)
		{
			DataRow[] rows = dtMenuPriv.Select("menuId='" + menuId + "'"); 
			if(rows.Length==0)return false;
			return (bool)rows[0]["select"];
		}

        /// <summary>
        /// To check whether this user has privilege to print in a certain menu.
        /// </summary>
        /// <param name="menuId">the database table name</param>
        /// <returns>true if allowed</returns>
        public bool AllowPrint(string menuId)
        {
            DataRow[] rows = dtMenuPriv.Select("menuId='" + menuId + "'");
            if (rows.Length == 0) return false;
            return (bool)rows[0]["print"];
        }

        /// <summary>
        /// To check whether this user has privilege to approve a transaction.
        /// </summary>
        /// <param name="menuId">the database table name</param>
        /// <returns>true if allowed</returns>
        public bool AllowApprove(string menuId)
        {
            DataRow[] rows = dtMenuPriv.Select("menuId='" + menuId + "'");
            if (rows.Length == 0) return false;
            return (bool)rows[0]["approve"];
        }

        /// <summary>
        /// To check whether this user has privilege to display transaction journal entry.
        /// </summary>
        /// <param name="menuId">the database table name</param>
        /// <returns>true if allowed</returns>
        public bool AllowJurnal(string menuId)
        {
            DataRow[] rows = dtMenuPriv.Select("menuId='" + menuId + "'");
            if (rows.Length == 0) return false;
            return (bool)rows[0]["jurnal"];
        }

		/// <summary>
		/// Copying privileges from a user to other user.
		/// If a user has the same role with another user then you can just copy the privileges.
		/// </summary>
		/// <param name="user"></param>
		public void CopyPrivilegesFrom(CASUser user)
		{
			this.dtMenuPriv = user.MenuPriv;
			Update();
		}

        /// <summary>
        /// Sets select,insert,update, and delete to false for all tables.
        /// Excepts for default values.
        /// This will create the Most Limited Privileges.
        /// </summary>
        public void ClearPrivileges()
        {
            foreach (DataRow r in MenuPriv.Rows)
            {
                r["select"] = false;
                r["insert"] = false;
                r["update"] = false;
                r["delete"] = false;
                r["print"] = false;
                r["approve"] = false;
                r["jurnal"] = false;
            }
        }

        /// <summary>
        /// Sets select, insert, update, and delete to true for all tables.
        /// This will create the Unlimited Privileges.
        /// </summary>
        public void SetAllPrivileges()
        {
            foreach (DataRow r in MenuPriv.Rows)
            {
                r["select"] = true;
                r["insert"] = true;
                r["update"] = true;
                r["delete"] = true;
                r["print"] = true;
                r["approve"] = true;
                r["jurnal"] = true;
            }
        }

        /// <summary>
        /// Updating TablePriv and ColumnPriv back to the database.
        /// The effect of the changed privileges is immediately apparent.
        /// </summary>
        public void Update()
        {
            string updateQuery = "";
            foreach (DataRow row in dtMenuPriv.Rows)
            {
                updateQuery += "replace into perms values("
                    + "'" + Role + "'" + ","
                    + "'" + row["menuId"] + "'" + ","
                    + Convert.ToInt16(row["insert"]) + ","
                    + Convert.ToInt16(row["update"]) + ","
                    + Convert.ToInt16(row["delete"]) + ","
                    + Convert.ToInt16(row["print"]) + ","
                    + Convert.ToInt16(row["select"]) + ","
                    + Convert.ToInt16(row["approve"]) + ","
                    + Convert.ToInt16(row["jurnal"]) + ");";
            }
            bool templog = sql.LogData;
            sql.LogData = false;
            sql.Execute(updateQuery);
            sql.LogData = templog;
        }

        /// <summary>
        /// Logout this user
        /// </summary>
        public void Logout()
        {
            try
            {
                bool log = sql.LogData;
                sql.LogData = false;
                sql.Execute("insert into userlog values(curdate(),curtime(),'" + user + "','Logged Out','" + Utility.GetIPAddress() + "')");
                sql.LogData = log;
            }
            catch { }
        }

        /// <summary>
        /// Change password
        /// </summary>
        /// <param name="password">the new password</param>
        public void ChangePassword(string password)
        {
            sql.Execute("update mysql.user set password=password('" + password + "') where user='" + user + "'");
            sql.Execute("FLUSH PRIVILEGES");
        }

        /// <summary>
        /// Change role
        /// </summary>
        /// <param name="role">the new role</param>
        public void ChangeRole(string role)
        {
            sql.Execute("update usr set role='" + role + "' where user='" + name + "'");
        }

		/// <summary>
		/// Preparing the structure of TablePriv and ColumnPriv
		/// </summary>
		private void ConstructDataStructure()
		{
			dtMenuPriv = new DataTable("menupriv");
			dtMenuPriv.Columns.Add("menuId",typeof(string));
            dtMenuPriv.Columns.Add("select", typeof(bool));
			dtMenuPriv.Columns.Add("insert",typeof(bool));
			dtMenuPriv.Columns.Add("update",typeof(bool));
			dtMenuPriv.Columns.Add("delete",typeof(bool));
            dtMenuPriv.Columns.Add("print", typeof(bool));
            dtMenuPriv.Columns.Add("approve", typeof(bool));
            dtMenuPriv.Columns.Add("jurnal", typeof(bool));
            dtMenuPriv.PrimaryKey = new DataColumn[] { dtMenuPriv.Columns["menuId"] };
		}

		/// <summary>
		/// Fill MenuPriv from database
		/// </summary>
		private void FillMenuPriv()
		{
            dtMenuPriv.Clear();

            //Check whether this user has any table privileges
            DataTable dtPriv = sql.Select("select * from perms where role='" + Role + "'");
            //if (dtPriv.Rows.Count == 0) return;

			DataTable tblTable = sql.Select("select * from menuid");
			foreach(DataRow row in tblTable.Rows)
			{
				DataRow newRow = dtMenuPriv.NewRow();
				string menuId = row[0].ToString(); 
				newRow["menuId"] = menuId;
                newRow["select"] = false;
				newRow["insert"] = false;
				newRow["update"] = false;
				newRow["delete"] = false;
                newRow["approve"] = false;
                newRow["jurnal"] = false;

				//Check whether this user has table privileges
                DataRow[] drPriv = dtPriv.Select("menuid='" + menuId + "'");
				if(drPriv.Length > 0)
				{
                    newRow["select"] = drPriv[0]["select"];
                    newRow["insert"] = drPriv[0]["insert"];
                    newRow["update"] = drPriv[0]["update"];
                    newRow["delete"] = drPriv[0]["delete"];
                    newRow["print"] = drPriv[0]["print"];
                    newRow["approve"] = drPriv[0]["approve"];
                    newRow["jurnal"] = drPriv[0]["jurnal"];
				}
				dtMenuPriv.Rows.Add(newRow);
			}
		}
    }

    /// <summary>
    /// This class is the main entry for accessing Access Control List (ACL).
    /// With this class you can create user, delete user, and get specific user as well.
    /// </summary>
    public class ACL
    {
        public SQL sql;

        /// <summary>
        /// The contructor for ACL class that requires all connection parameters.
        /// </summary>
        /// <param name="userName">MySql user name that has privilege to create user (ex: root)</param>
        /// <param name="password">MySql password for the user name given in the previous parameter</param>
        /// <param name="server">MySql server location, e.g: localhost, 192.168.12.7</param>
        /// <param name="database">MySql database to use</param>
        public ACL(string userName, string password, string server, string database)
        {
            if (server == "" && database == "")
                sql = new SQL(userName, password);
            else
                sql = new SQL(userName, password, server, database);
            sql.KeepAlive = true;

            //try
            //{
            //    sql.Select("select * from userlog where 0");
            //}
            //catch
            //{
            //    string query = "create table userlog(logdate date not null,logtime time not null," +
            //        "user varchar(16) not null,status varchar(25) not null,ip varchar(15) not null)";
            //    sql.Execute(query);
            //}
        }

        /// <summary>
        /// The constructor that requires only user name and password,
        /// the server name and database name will be retrieved from application config file. 
        /// </summary>
        /// <param name="userName">MySQL username</param>
        /// <param name="password">MySQL password</param>
        public ACL(string userName, string password)
            : this(userName, password, "", "")
        {
        }

        /// <summary>
        /// Get all posible roles.
        /// </summary>
        /// <returns>Array of string contains roles</returns>
        public string[] GetRoles()
        {
            DataTable table = sql.Select("select distinct role from usrlevel order by role");
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
        public CASUser[] GetUsers()
        {
            DataTable table = sql.Select("select user from mysql.user where user<>'" + sql.UserName + "' order by user");
            CASUser[] users = new CASUser[table.Rows.Count];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                users[i] = new CASUser(table.Rows[i]["user"].ToString(), sql);
            }
            return users;
        }

        /// <summary>
        /// To get all ACL users that have specific role
        /// </summary>
        /// <param name="role">the role of the ACL users</param>
        /// <returns>ACL users</returns>
        public CASUser[] GetUsers(string role)
        {
            DataTable table = sql.Select("select user from usr where role='" + role + "' order by user");
            CASUser[] users = new CASUser[table.Rows.Count];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                users[i] = new CASUser(table.Rows[i]["user"].ToString(), sql);
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
            DataTable table = sql.Select("select user from usr where role='" + role + "' order by user");
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
        /// Getting an CASUser based on specific user name
        /// </summary>
        /// <param name="name">ACL user name or MySql user name</param>
        /// <returns>CASUser requested or null if not available</returns>
        public CASUser GetUser(string name)
        {
            //DataTable table = sql.Select("select user from mysql.user where user='" + name + "'");
            //if (table.Rows.Count == 0)
            //    return null;
            //else
                return new CASUser(name, sql);
        }

        /// <summary>
        /// Create a new ACL user
        /// </summary>
        /// <param name="role">role of the user</param>
        /// <param name="name">user name</param>
        /// <param name="password">password</param>
        /// <returns>CASUser created</returns>
        //public CASUser CreateUser(string username, string password, string name, string role)
        public void CreateUser(string username, string password, string name, string role)
        {
            try
            {
                sql.Execute("create user '" + username + "' identified by '" + password + "'");
            }
            catch { }
            // Grant User to 'cas' database
            sql.Execute("GRANT SELECT, INSERT, UPDATE, DELETE, EXECUTE ON `" + sql.DatabaseName + "`.* TO '" + username + "'@'%'");
            sql.Execute("GRANT SELECT, UPDATE, EXECUTE ON `mysql`.* TO '" + username + "'@'%'");
            sql.Execute("GRANT RELOAD, PROCESS ON *.* TO '" + username + "'@'%'");
            sql.Execute("GRANT INSERT ON `historymdu`.* TO '" + username + "'@'%'");
         
            // Insert into Table usr
            //sql.Execute("insert into usr values('" + username + "',\"" + name + "\",'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "','" + sql.UserName + "','" + role + "')");

            //DataTable temp = sql.Select("select user from usr where role='" + role + "'");
            //CASUser user = new CASUser(username, sql.UserName, sql.Password, sql.ServerName, sql.DatabaseName);
            //if (temp.Rows.Count > 0)
            //{
            //    CASUser template = new CASUser(temp.Rows[0]["user"].ToString(), sql.UserName, sql.Password, sql.ServerName, sql.DatabaseName);
            //    //user.CopyPrivilegesFrom(template);
            //}
            //else
            //{
            //    user.ClearPrivileges();
            //    user.Update();
            //}
            
            //return user;
        }

        /// <summary>
        /// Delete a specific ACL user
        /// </summary>
        /// <param name="name">user name to be deleted</param>
        public void DeleteUser(string name)
        {
            string role = sql.Select("select role from usr where user='" + name + "'").Rows[0]["role"].ToString();
            sql.Execute("drop user '" + name + "'");
            sql.Execute("delete from usr where user='" + name + "'");
        }

        /// <summary>
        /// Perform the login process for user.
        /// </summary>
        /// <param name="name">user name</param>
        /// <param name="password">password of the user</param>
        /// <param name="status">status of the user</param>
        /// <returns>CASUser of logged-in user, null if login process failed</returns>
        /// <remarks>status output: "Logged In", "Invalid", "Blocked"</remarks>
        public CASUser Login(string name, string password, out string status)
        {
            bool log = sql.LogData;
            sql.LogData = false;
            if (IsBlocked(name))
            {
                status = "Blocked";
                return null;
            }
            string ipAddress = Utility.GetIPAddress();
            try
            {
                //SQL test = new SQL(name, password);
                //test.KeepAlive = false;
                sql.Execute("insert into userlog values(curdate(),curtime(),'" + name + "','Logged In','" + ipAddress + "')");
                status = "Logged In";
                sql.LogData = log;
                return GetUser(name);
            }
            catch(Exception ex)
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
                sql.LogData = log;
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
}
