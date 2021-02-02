using System;
using System.Collections.Generic;

namespace Quiz {
    public class Employee {

        public Employee(int id, int importance, int[] subordinates = null) {
            this.id = id;
            this.importance = importance;
            this.subordinates = subordinates ?? Array.Empty<int>();
        }

        public int id;
        
        public int importance;
        
        public IList<int> subordinates;

    }
}