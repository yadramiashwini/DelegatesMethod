using System.Security.Cryptography.X509Certificates;

namespace DelegatesMethod { 
     public delegate void AddDelegate(int a, int b);

      public delegate string SayDelegate(string name);

    public class Program
    { 
        public void Add(int a,int b) 
        {
            Console.WriteLine(a+b);
        }
        public static string SayHello(string name)
        {
            return "hello " + name;
        }
        static void Main(string[] args)
        {
           Program p = new Program();
            AddDelegate ad = new AddDelegate(p.Add);
            ad.Invoke(10,100);
            SayDelegate say1 = new SayDelegate(SayHello);
            string str = say1.Invoke("Ashwini");
            Console.WriteLine(str);
        }
    }
}
