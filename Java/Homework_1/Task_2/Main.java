package Java.Homework_1.Task_2;

public class Main {
    /* Вывести все простые числа от 1 до 1000 */
    public static void main(String[] args) {
        System.out.println("Программа выводит все простые числа от 1 до 1000");
        int value = 1000;
        int smaller = 0;
        int nod = 1;
        int accuracy = 2;
        for (int i = 2; i <= value; i++) {
            for (int k = 1; k <= accuracy; k++) {
                int temp = (int) (Math.random() * ((i - 1) - 2 + 1) + 2);
                if (i > temp) {
                    smaller = temp;
                } else {
                    smaller = i;
                }
                for (int j = 2; j <= smaller; j++) {
                    if (i % j == 0 && temp % j == 0) {
                        nod = j;
                    }
                }
                if (nod == 1 && Math.pow(nod, (i - 1) / 2) != nod / i) {
                    System.out.println("i");                   
                }
                Math.pow(i, 2)
                System.out.println(i);
            }
        }
    }
}