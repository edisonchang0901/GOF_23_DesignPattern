using System;
using System.Collections.Generic;
using System.Text;
using GOF_DesignPattern.Day2;

namespace GOF_DesignPattern.Day2
{
    // 實作Demo
    // 用director將product建立出來，並且將裡面實作方法封裝，Client只要知道呼叫即可取得product
    /*      Director dr = new Director();
            MssqlDbBuilder br = new MssqlDbBuilder();
            dr.constructSportsCar(br);
            Console.WriteLine(br.getConnectString());
    // 建立部分組件時，直接用Builder將product建立出來
            br.setDataSource("ming-stock.database.windows.net_u");
            br.setInitialCatalog("stock_AllPrice_u");
            br.setUserID("adming_u");
            br.setPassword("Sao015207_u");
            Console.WriteLine(br.getConnectString());*/
    class Director
    {
        // 用Director實際去安排該複雜物件要有甚麼部分需要建立
        public void constructSportsCar(MssqlDbBuilder builder)
        {
            builder.reset();
            builder.setDataSource();
            builder.setInitialCatalog();
            builder.setUserID();
            builder.setPassword();
        }

    }
}
