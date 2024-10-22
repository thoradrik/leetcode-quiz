using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public int GetImportance(IList<Employee> employees, int id) {
            var e_map = new Dictionary<int, Employee>();

            foreach (var employee in employees) {
                e_map[employee.id] = employee;
            }

            var sum = 0;

            var memo = new HashSet<int>();

            void dfs(int employee_id) {
                if (memo.Contains(employee_id)) {
                    return;
                } else {
                    memo.Add(employee_id);
                }

                var employee = e_map[employee_id];

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
