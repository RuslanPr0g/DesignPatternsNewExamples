using System;

namespace Singletone
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.GetInstance();
            singleton.IncreaseCount();
            singleton.IncreaseCount();
            singleton.IncreaseCount();
            singleton.IncreaseCount();
            singleton.IncreaseCount();
            singleton = Singleton.GetInstance();
            singleton.ShowCount();
            singleton.DecreaseCount();
            singleton.DecreaseCount();
            singleton.DecreaseCount();
            singleton.DecreaseCount();
            singleton.DecreaseCount();
            singleton.DecreaseCount();
            singleton.DecreaseCount();
            singleton.DecreaseCount();
            singleton = Singleton.GetInstance();
            singleton.ShowCount();
            singleton.IncreaseCount();
            singleton.IncreaseCount();
            singleton.IncreaseCount();
            singleton.IncreaseCount();
            singleton.ShowCount();
        }
    }
}
