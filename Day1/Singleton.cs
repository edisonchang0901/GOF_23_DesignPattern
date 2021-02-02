using System;
using System.Collections.Generic;
using System.Text;

namespace GOF_DesignPattern.Day1
{
    // Demo
    /*  Singleton singleton = Singleton.GetInstance("FOO");
        Singleton anotherSingleton = Singleton.GetInstance("BAR");
        Console.WriteLine(singleton.myValue);
        Console.WriteLine(anotherSingleton.myValue);
     */
    class Singleton
    {
        private Singleton() { }
        private static Singleton _instance;
        private static readonly object _lock = new object();
        

        public static Singleton GetInstance(string value) {
            // 這個條件，主要用來避免當物件已經被生成時，其他的執行緒
            // 在外面被lock住，導致在外面等待。
            if (_instance == null)
            {
                // 給一個lock鎖來判斷，當要存取同一個值時藉由此lock來判斷有無存取值的權限
                lock (_lock) 
                {
                    if (_instance == null)
                    {
                        // 實際new出物件
                        _instance = new Singleton();
                        _instance.myValue = value;
                    }
                }
            }
            return _instance;
        }

        public string myValue { get; set; }
    }
}
