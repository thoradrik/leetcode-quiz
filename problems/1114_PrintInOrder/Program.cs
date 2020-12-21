using System;
using System.Threading;

namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Foo solution = new Foo();
            
            Thread first = new Thread(() => solution.First(() => Console.WriteLine("First")));

            Thread second = new Thread(() => solution.Second(() => Console.WriteLine("Second")));

            Thread third = new Thread(() => solution.Third(() => Console.WriteLine("Third")));
            
            first.Start();
            third.Start();
            second.Start();
        }
        
    }
}