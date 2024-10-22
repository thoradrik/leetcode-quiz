using System;
using System.Threading;

namespace Quiz {
    public class Program : ProgramBase {

        public static void Main() {
            var solution = new Foo();

            var first = new Thread(() => solution.First(() => Console.WriteLine("First")));

            var second = new Thread(() => solution.Second(() => Console.WriteLine("Second")));

            var third = new Thread(() => solution.Third(() => Console.WriteLine("Third")));

            first.Start();
            third.Start();
            second.Start();
        }

    }
}
