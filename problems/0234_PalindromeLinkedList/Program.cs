using static LeetcodeLib.LinkedListHelper;

namespace Quiz;

public class Program : ProgramBase {
    
    public static void Main() {
        var solution = new Solution();

        Test.Check(solution.IsPalindrome, MakeLinkedList("[]"), true);
        Test.Check(solution.IsPalindrome, MakeLinkedList("[0]"), true);
        Test.Check(solution.IsPalindrome, MakeLinkedList("[1]"), true);
        Test.Check(solution.IsPalindrome, MakeLinkedList("[0,1]"), false);
        Test.Check(solution.IsPalindrome, MakeLinkedList("[0,1,2]"), false);
        Test.Check(solution.IsPalindrome, MakeLinkedList("[1,2,1]"), true);
        Test.Check(solution.IsPalindrome, MakeLinkedList("[1,2,2,1]"), true);
        Test.Check(solution.IsPalindrome, MakeLinkedList("[1,2,4,2,1]"), true);
        Test.Check(solution.IsPalindrome, MakeLinkedList("[1,2,3,4,2,1]"), false);
        Test.Check(solution.IsPalindrome, MakeLinkedList("[1,2,3,17,4,2,1]"), false);
        Test.Check(solution.IsPalindrome, MakeLinkedList("[1,2,3,17,3,4,2,1]"), false);
        Test.Check(solution.IsPalindrome, MakeLinkedList("[1,2,3,4,17,3,4,2,1]"), false);
        Test.Check(solution.IsPalindrome, MakeLinkedList("[1,2,4,3,17,3,4,2,1]"), true);
        Test.Check(solution.IsPalindrome, MakeLinkedList("[1,2,4,3,17,17,3,4,2,1]"), true);
        Test.Check(solution.IsPalindrome, MakeLinkedList("[1,2,4,3,17,17,4,3,2,1]"), false);
    }
    
}