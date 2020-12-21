using System;
using System.Threading;

namespace Quiz {
    public class Foo {

        public Foo() {
        
        }

        private ManualResetEvent EVT_FIRST = new ManualResetEvent(false);
        
        public void First(Action printFirst) {
        
            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();

            EVT_FIRST.Set();
        }

        private ManualResetEvent EVT_SECOND = new ManualResetEvent(false);

        public void Second(Action printSecond) {
            WaitHandle.WaitAll(new WaitHandle[] { EVT_FIRST });
        
            // printSecond() outputs "second". Do not change or remove this line.
            printSecond();

            EVT_SECOND.Set();
        }

        private ManualResetEvent EVT_THIRD = new ManualResetEvent(false);

        public void Third(Action printThird) {
            WaitHandle.WaitAll(new WaitHandle[] { EVT_FIRST, EVT_SECOND });
            
            // printThird() outputs "third". Do not change or remove this line.
            printThird();

            EVT_THIRD.Set();
        }
    }
}