using System;

namespace Singletone
{
    public class Singleton
    {
        private static Singleton _singleton;
        public int Count { get; set; }

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (_singleton is null)
            {
                _singleton = new Singleton();
            }

            return _singleton;
        }

        public void IncreaseCount()
        {
            Console.WriteLine(_singleton.Count++);
        }

        public void DecreaseCount()
        {
            Console.WriteLine(_singleton.Count--);
        }

        public void ShowCount()
        {
            Console.WriteLine(_singleton.Count);
        }
    }
}
