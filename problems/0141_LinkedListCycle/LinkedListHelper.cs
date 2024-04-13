using System.Text.Json;

namespace Quiz;

internal static class LinkedListHelper {

    public static ListNode LinkedList(string s, int cycle) {
        var n = JsonSerializer.Deserialize<int[]>(s);

        ListNode node = null;
        ListNode last = null;

        for (var i = n.Length - 1; i >= 0; i--) {
            node = new ListNode(n[i]) {
                next = node
            };

            if (last == null) last = node;

            if (i == cycle) last.next = node;
        }

        return node;
    }

}