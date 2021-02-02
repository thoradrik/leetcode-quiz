using System.Collections.Generic;

namespace Quiz {
    public class Solution {
        
        public int GetImportance(IList<Employee> employees, int id) {
            Dictionary<int, Employee> e_map = new Dictionary<int, Employee>();

            foreach (Employee employee in employees) {
                e_map[employee.id] = employee;
            }

            int sum = 0;
            
            HashSet<int> memo = new HashSet<int>();

            void dfs(int employee_id) {
                if (memo.Contains(employee_id)) {
                    return;
                } else {
                    memo.Add(employee_id);
                }

                Employee employee = e_map[employee_id];
                
                sum += employee.importance;
                
                foreach (int subordinate_id in employee.subordinates) {
                    dfs(subordinate_id);
                }
            }

            dfs(id);
            
            return sum;
        }
        
    }
}