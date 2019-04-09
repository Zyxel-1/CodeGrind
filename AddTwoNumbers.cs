/*
    Name: Roberto Sanchez
    Date: 2/9/19

    You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

    You may assume the two numbers do not contain any leading zero, except the number 0 itself.

    Example:

    Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    Output: 7 -> 0 -> 8
    Explanation: 342 + 465 = 807.
 */

/**
 * Definition for singly-linked list.
  public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
 }
*/

public class AddTwoNumberas {
  public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
    // Converting array list into array
    string l1val = "";
    string l2val = "";

    // Converting array list into array for l1
    var currentNode = l1;
    for (int i = 0; currentNode != null; i++)
    {
      l1val += currentNode.val;
      currentNode = currentNode.next;
    }
    Console.WriteLine(l1val);

    // Converting array list to array for l2
    var currentNode2 = l2;
    for (int i = 0; currentNode2 != null; i++)
    {
      l2val += currentNode2.val;
      currentNode2 = currentNode2.next;
    }
    Console.WriteLine(l2val);

    // Reversing array then to string
    l1val = new string(l1val.Reverse().ToArray());
    l2val = new string(l2val.Reverse().ToArray());

    // Adding integers from strings
    BigInteger first = BigInteger.Parse(l1val);
    BigInteger second = BigInteger.Parse(l2val);
    BigInteger sum = first + second;
    Console.WriteLine(sum);
    string sum2 = sum.ToString();
    ListNode[] listArray = new ListNode[sum2.Length];
    // Converting each number to a node and storing it in an array
    for (int i = 0; i < sum2.Length; i++)
    {
     listArray[i] = new ListNode((int) char.GetNumericValue(sum2[i]));
    }
    Array.Reverse(listArray);

    for (int i = 0; i < listArray.Length - 1; i++)
    {
     listArray[i].next = listArray[i + 1];
    }
    return listArray[0];
  }
}
