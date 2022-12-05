using System;
using System.Collections.Generic;
using System.Text;

namespace Chocolate_Lazy
{
    class Singleton
    {
        private static Singleton _singleton;
        private int _counter;
        private Singleton()
        {
            _counter = 0;
        }

        public static Singleton GetInstance()
        {
            // Lazy instantiation
            if (_singleton==null)
            {
                _singleton = new Singleton();
            }

            return _singleton;
        }

        public int GetNextId()
        {
            return ++_counter;
        }
    }
}
