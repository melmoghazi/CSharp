using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Thinking.Constructors
{
    internal class PrivateConstructor
    {
        Singleton instance = Singleton.Instance;
        //Singleton s=new Singleton(); // inaccessible due to its protection level 
    }
    public class Singleton
    {
        private static Singleton _instance;
        private Singleton()
        {
        }
        public static Singleton Instance => _instance ??= new Singleton();

        //public static Singleton Instance()
        //{
        //    return _instance != null ? _instance : new Singleton();
        //}
    }


}
