## Day1 GOF_23_DesignPattern-Builder
------------
####����
<br />
SingleTon Pattern �O�@��Creational Patterns�]�Ыث��Ҧ��^�A���i�H���A�Τ@�B�@�B���y�{�h�إߤ@�ӽ���������A���ǥ�Director�h�ާ@Builder�����ӫغc����åB�NBuilder�غc���󪺫إ߬y�{�ʸ˰_�ӡAUser�u�n�����I�s�K�i���o�إߦn������F�]�i����Director�ާ@�A������Builder�̪���k�N����إX�Өè��o�C


####�d��
<br />
�o����ŧi�n�إߪ�product�A�o��Q�줧�e�g�s��DB�ɪ��s�u��T�A�N�O��Builder�o��pattern�ӫإߧA�ҷQ�n�s����DB��T�A�ҥH�o��ګŧi�FDatabase�o��class��@�ڭn�ت�production
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
���NBuilder��interface�U����k�w�q�X�ӡA������L���P��Builder�h��@�ɡA�i�H�ھڤ��P���e�h��@���U����k�A�]���C��DB���s�u��T���ɬۦP�A�ҥH�U�����N�]�w��Ƴs�u�ݩʪ���k�w�q�X�ӡC
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
�b�̾ڤ��P��DB�h��@����Builder�A�åh��{MssqlDbBuilder�s�u��T���U���]�w
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
 �إ�Director�����I�sMssqlDbBuilder�ӹ�ڥh�w�Ƹӽ�������n���ƻ򳡤��ݭn�إ�
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





