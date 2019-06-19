using System;

namespace Creational
{
    /// <summary>
    /// Insures only one instance is created. This pattern can be used in Shopping cart application where only one instance is required for the user.
    /// </summary>
    public class SingleTon
    {
        private static SingleTon instance;
        private static readonly object lockObj = new object();

        private SingleTon()
        {

        }

        public static SingleTon Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new SingleTon();
                        }
                    }
                }

                return instance;
            }
        }
    }
}
