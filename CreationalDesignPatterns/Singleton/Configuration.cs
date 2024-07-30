namespace Singleton
{
    public class Configuration
    {
        public static Configuration _instance { get; set; }
        private static Object obj = new Object();

        public string stringProperty { get; set; }
        public int intProperty { get; set; }

        private Configuration() 
        {
        }

        public static Configuration GetInstance()
        {
            lock (obj)
            {
                if (_instance == null)
                {
                    _instance = new Configuration();
                }
            }

            return _instance;
        }
    }
}
