## Day1 GOF_23_DesignPattern-Singleton
####介紹
SingleTon Pattern 是一種Creational Patterns（創建型模式），它可以讓你確保要被建立出來的物件是唯一的，並且用一個靜態方法去當作一個取得物件的方法。

------------
####範例
**Singleton.cs**
```
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
            // 給一個lock鎖來判斷
		    // 當要存取同一個值時藉由此lock來判斷有無存取值的權限
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
```

