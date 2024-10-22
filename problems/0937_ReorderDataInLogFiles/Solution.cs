using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        public string[] ReorderLogFiles(string[] logs) {
            var list = new List<(string, string, string, bool, int)>(logs.Length);

            for (var index = 0; index < logs.Length; index++) {
                string log = logs[index];

                int sp_index = log.IndexOf(' ');
                string id = log.Substring(0, sp_index);
                string data = log.Substring(sp_index + 1);
                bool number = Char.IsDigit(data[0]);

                list.Add((log, id, data, number, index));
            }

            list.Sort((x, y) => {
                (string x_log, string x_id, string x_data, bool x_number, int x_index) = x;
                (string y_log, string y_id, string y_data, bool y_number, int y_index) = y;

                if (x_number && y_number) {
                    return x_index.CompareTo(y_index);
                }

                int result = x_number.CompareTo(y_number);
                if (result != 0) {
                    return result;
                }

                result = String.Compare(x_data, y_data, StringComparison.Ordinal);
                if (result != 0) {
                    return result;
                }

                return String.Compare(x_id, y_id, StringComparison.Ordinal);
            });

            for (var index = 0; index < logs.Length; index++) {
                logs[index] = list[index].Item1;
            }

            return logs;
        }

    }
}
