using System;
using System.Collections.Generic;
using System.Text;

namespace Chocolate_Lazy
{
    class SingletonEager
    {
        private static SingletonEager _singletonEager = new SingletonEager();
        private int _counter;
        private SingletonEager()
        {
            _counter = 0;
        }

        public static SingletonEager GetInstance()
        {
            // Eager instantiation
            return _singletonEager;
        }

        public int GetNextId()
        {
            return ++_counter;
        }
    }
}
