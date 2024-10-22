using System.Text.Json;

namespace Quiz;

internal static class LinkedListHelper {

    public static ListNode Array(string s) {
        int[] n = JsonSerializer.Deserialize<int[]>(s);

        ListNode list_node = null;

        for (var i = n.Length - 1; i >= 0; i--) list_node = new ListNode(n[i], list_node);

        return list_node;
    }

    public static ListNode[] ArrayK(string s) {
        int[][] nn = JsonSerializer.Deserialize<int[][]>(s);

        var list_nodes = new ListNode[nn.Length];

        for (var j = 0; j < nn.Length; j++) {
            ListNode list_node = null;

            for (var i = nn[j].Length - 1; i >= 0; i--) list_node = new ListNode(nn[j][i], list_node);

            list_nodes[j] = list_node;
        }

        return list_nodes;
    }

}
