using System;
using System.Collections.Generic;
using System.Text;
using GOF_DesignPattern.Day2;

namespace GOF_DesignPattern.Day2
{
    interface Builder
    {
        public void reset();
        public void setDataSource(string s);
        public void setUserID(string s);
        public void setPassword(string s);
        public void setInitialCatalog(string s);
    }
    
    public class MssqlDbBuilder : Builder
    {
        private MSsql DB;
        public MssqlDbBuilder()
        {
            this.reset();
        }
        public void reset()
        {
            this.DB = new MSsql();
        }
        public void setDataSource(string s)
        {
            this.DB.DataSource = s;
        }

        public void setUserID(string s)
        {
            this.DB.UserID = s;
        }

        public void setPassword(string s)
        {
            this.DB.Password = s;
        }

        public void setInitialCatalog(string s)
        {
            this.DB.InitialCatalog = s;
        }

        public string getConnectString()
        {

            return "Data Source="+ this.DB.DataSource + ";Initial Catalog="+this.DB.InitialCatalog+";User ID="+ this.DB.UserID + ";Password="+this.DB.Password;
        }

    }
}
