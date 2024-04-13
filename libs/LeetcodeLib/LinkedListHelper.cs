using System.Text.Json;
using Quiz;

namespace LeetcodeLib;

public static class LinkedListHelper {
    
    public static ListNode MakeLinkedList(string s) {
        int[] n = JsonSerializer.Deserialize<int[]>(s);

        ListNode list_node = null;
            
        for (int i = n.Length - 1; i >= 0; i--) {
            list_node = new ListNode(n[i], list_node);
        }

        return list_node;
    }
    
    public static ListNode MakeLinkedList(string s, int item, out ListNode item_node) {
        int[] n = JsonSerializer.Deserialize<int[]>(s);

        item_node = null;

        ListNode list_node = null;
            
        for (int i = n.Length - 1; i >= 0; i--) {
            list_node = new ListNode(n[i], list_node);

            if (item == i) {
                item_node = list_node;
            }
        }

        return list_node;
    }
    
}