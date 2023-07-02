package Algorithm;

class dList {
    static Node head;
    static Node tail;

    static class Node {
        int value;
        Node next;
        Node prev;
    }

    public static void pushFront(int value) { // O(1)
        Node node = new Node();
        node.value = value;

        if (head == null) {
            tail = node;
        } else {
            node.next = head;
            head.prev = node;
        }
        head = node;
    }

    public static void print() {
        Node node = head;
        while (node != null) {
            System.out.printf("%d ", node.value);
            node = node.next;
        }
        System.out.println();
    }

    public void reverse() {
        Node node = head;
        while (node != null) {
            Node next = node.next;
            Node prev = node.prev;
            node.next = prev;
            node.prev = next;
            if(prev == null) {
                tail = node;
            }
            if (next == null) {
                head = node;
            }
            node = next;
            
        }
    }
}


public class HM_2 {
    public static void main(String[] args) {
        dList list = new dList();
        for (int i = 1; i <= 10; i++) {
            list.pushFront(i);
        }

        list.print();

        list.reverse();

        list.print();
    }

}
