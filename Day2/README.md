## Day1 GOF_23_DesignPattern-Builder
------------
####介紹
<br />
SingleTon Pattern 是一種Creational Patterns（創建型模式），它可以讓你用一步一步的流程去建立一個複雜的物件，並藉由Director去操作Builder介面來建構物件並且將Builder建構物件的建立流程封裝起來，User只要直接呼叫便可取得建立好的物件；也可不用Director操作，直接用Builder裡的方法將物件建出來並取得。


####範例
<br />
這邊先宣告要建立的product，這邊想到之前寫連接DB時的連線資訊，就是用Builder這個pattern來建立你所想要連接的DB資訊，所以這邊我宣告了Database這個class當作我要建的production
**Database.cs**
```
  class Database
    {
        public string DataSource;
        public string UserID;
        public string Password;
        public string InitialCatalog;
    }
```
先將Builder的interface下的方法定義出來，來讓其他不同的Builder去實作時，可以根據不同內容去實作底下的方法，因為每個DB的連線資訊不盡相同，所以下面先將設定資料連線屬性的方法定義出來。
**Builder.cs**
```
 interface Builder
    {
        public void reset();
        public void setDataSource(string s);
        public void setUserID(string s);
        public void setPassword(string s);
        public void setInitialCatalog(string s);
    }
```
在依據不同的DB去實作實體Builder，並去實現MssqlDbBuilder連線資訊的各式設定
**MssqlDbBuilder Implements Builder**
```
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
```
 建立Director讓它呼叫MssqlDbBuilder來實際去安排該複雜物件要有甚麼部分需要建立
**Director**
```
class Director
    {
        public void constructSportsCar(MssqlDbBuilder builder)
        {
            builder.reset();
            builder.setDataSource();
            builder.setInitialCatalog();
            builder.setUserID();
            builder.setPassword();
        }

    }
```





