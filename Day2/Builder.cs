using System;
using System.Collections.Generic;
using System.Text;
using GOF_DesignPattern.Day2;

namespace GOF_DesignPattern.Day2
{
    interface Builder
    {
        public void reset();
        public void setDataSource();
        public void setUserID();
        public void setPassword();
        public void setInitialCatalog();
    }
    
    public class MssqlDbBuilder : Builder
    {
        private Database DB;
        private string DataSource = "ming-stock.database.windows.net";
        private string InitialCatalog = "stock_AllPrice";
        private string UserID = "adming";
        private string Password = "Sao015207";
        public MssqlDbBuilder()
        {
            this.reset();
        }
        public void reset()
        {
            this.DB = new Database();
        }
        public void setDataSource()
        {
            this.DB.DataSource = DataSource;
        }

        public void setUserID()
        {
            this.DB.UserID = UserID;
        }

        public void setPassword()
        {
            this.DB.Password = Password;
        }

        public void setInitialCatalog()
        {
            this.DB.InitialCatalog = InitialCatalog;
        }

        public string getConnectString()
        {

            return "Data Source="+ this.DB.DataSource + ";Initial Catalog="+this.DB.InitialCatalog+";User ID="+ this.DB.UserID + ";Password="+this.DB.Password;
        }

    }
}
