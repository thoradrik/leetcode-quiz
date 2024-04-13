using System.Text.Json;

namespace Quiz;

internal static class LinkedListHelper {

    public static ListNode LinkedList(string s, int cycle, out ListNode[] nodes) {
        int[] n = JsonSerializer.Deserialize<int[]>(s);
        nodes = new ListNode[n.Length];
            
        ListNode node = null;
        ListNode last = null;

        for (int i = n.Length - 1; i >= 0; i--) {
            node = new ListNode(n[i]) {
                next = node
            };

            if (last == null) {
                last = node;
            }

            if (i == cycle) {
                last.next = node;
            }

            nodes[i] = node;
        }

        return node;
    }

}