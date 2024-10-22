using System.Text;

namespace Quiz;

public class ListNode : IEquatable<ListNode> {

    // ReSharper disable InconsistentNaming
    public int val;

    public ListNode next;
    // ReSharper restore InconsistentNaming

    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }

    public bool Equals(ListNode other) {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return val == other.val && Equals(next, other.next);
    }

    public override bool Equals(object obj) {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((ListNode) obj);
    }

    public override int GetHashCode() {
        return HashCode.Combine(val, next);
    }

    public override string ToString() {
        var sb = new StringBuilder();
        sb.Append("{");

        sb.Append(val);

        var current = next;
        while (current != null) {
            sb.Append(",");
            sb.Append(current.val);

            current = current.next;
        }

        sb.Append("}");

        return sb.ToString();
    }

}
