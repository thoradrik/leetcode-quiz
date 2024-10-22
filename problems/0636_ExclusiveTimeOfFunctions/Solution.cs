using System;
using System.Collections.Generic;

namespace Quiz {
    public class Solution {

        private class Frame {

            public Frame(int function, int time_stamp) {
                Function = function;
                Start = time_stamp;
            }

            public readonly int Function;

            public int Length;

            public readonly int Start;

        }

        public int[] ExclusiveTime(int n, IList<string> logs) {
            var times = new int[n];

            var stack = new Stack<Frame>();

            foreach (string s in logs) {
                string[] ss = s.Split(':');
                int function = Int32.Parse(ss[0]);
                int time_stamp = Int32.Parse(ss[2]);

                if (ss[1][0] == 's') {
                    stack.Push(new Frame(function, time_stamp));
                } else {
                    var frame = stack.Pop();

                    int frame_length = time_stamp - frame.Start + 1;
                    if (stack.TryPeek(out var prev)) {
                        prev.Length -= frame_length;
                    }

                    frame.Length += frame_length;

                    times[frame.Function] += frame.Length;
                }
            }

            return times;
        }

    }
}
