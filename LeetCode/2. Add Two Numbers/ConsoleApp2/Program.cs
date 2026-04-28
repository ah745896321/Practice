
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode result = new ListNode(0);
        ListNode temp = result;
        int carry = 0;
        int sum = 0;
        while (l1 != null || l2 != null || carry == 1)
        {
            int x = (l1 != null) ? l1.val : 0;
            int y = (l2 != null) ? l2.val : 0;
            sum = x + y + carry;
            temp.next = new ListNode(sum % 10);
            carry = sum / 10;
            temp = temp.next;
            if (l1 != null)
                l1 = l1.next;
            if (l2 != null)
                l2 = l2.next;

        }
        return result.next;
    }
}
public class  ConsoleApp2
{

    static int Main()
    {
        ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
        ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));
        Solution s = new Solution();
        s.AddTwoNumbers(l1, l2);
        return 0;
    }
}