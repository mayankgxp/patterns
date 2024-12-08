using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns
{
    public sealed class Singleton
    {
        // Private static instance variable
        private static Singleton _instance = null;

        // Object for locking during thread-safe initialization
        private static readonly object _lock = new object();

        // Private constructor to prevent instance creation from outside
        private Singleton()
        {
            // Initialization code
        }

        // Public property to get the Singleton instance
        public static Singleton Instance
        {
            get
            {
                // Double-check locking to ensure thread safety
                // It first checks if the instance is null outside the lock to avoid locking every time the Instance is accessed.
                if (_instance == null)
                {
                    // Lock to ensure only one thread initializes the instance
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }
    }

}
