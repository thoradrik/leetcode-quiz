using System.Collections.Generic;

namespace Quiz {
    public class Program : ProgramBase {
        
        public static void Main() {
            Solution solution = new Solution();

            IList<NestedInteger> list;
            
            list = new NestedInteger[] { };

            Test.Check(solution.DepthSum, list, 0);
            
            list = new[] {
                new NestedInteger(1)
            };

            Test.Check(solution.DepthSum, list, 1);
            
            list = new[] {
                new NestedInteger(10),
                new NestedInteger(new NestedInteger[] {
                    
                })
            };

            Test.Check(solution.DepthSum, list, 10);
            
            list = new[] {
                new NestedInteger(15),
                new NestedInteger(new[] {
                    new NestedInteger(new NestedInteger[] {
                        
                    })
                })
            };

            Test.Check(solution.DepthSum, list, 15);
            
            list = new[] {
                new NestedInteger(15),
                new NestedInteger(new[] {
                    new NestedInteger(new[] {
                        new NestedInteger(1),
                        new NestedInteger(2),
                        new NestedInteger(new NestedInteger[] {
                        
                        })
                    })
                })
            };

            Test.Check(solution.DepthSum, list, 24);
            
            list = new[] {
                new NestedInteger(new[] {
                    new NestedInteger(1),
                    new NestedInteger(1)
                }),
                new NestedInteger(2),
                new NestedInteger(new[] {
                    new NestedInteger(1),
                    new NestedInteger(1)
                })
            };

            Test.Check(solution.DepthSum, list, 10);
            
            list = new[] {
                new NestedInteger(1),
                new NestedInteger(new[] {
                    new NestedInteger(4),
                    new NestedInteger(new[] {
                        new NestedInteger(6)
                    })
                })
            };

            Test.Check(solution.DepthSum, list, 27);
        }

    }
}