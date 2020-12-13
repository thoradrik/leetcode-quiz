using System;

namespace Quiz {
    public class ListNode : IEquatable<ListNode> {
        
        public int val;
        
        public ListNode next;
        
        public ListNode(int val = 0, ListNode next = null) {
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
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ListNode) obj);
        }

        public override int GetHashCode() {
            return HashCode.Combine(val, next);
        }

        public override string ToString() {
            if (next != null) {
                return val + "," + next;
            } else {
                return val.ToString();
            }
        }

    }
}