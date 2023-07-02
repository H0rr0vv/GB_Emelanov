package Java.Homework_1.Task_2;

public class Main {
    /* Вывести все простые числа от 1 до 1000 */
    public static void main(String[] args) {
        System.out.println("Программа выводит все простые числа от 1 до 1000");
        int value = 1000;
        int smaller = 0;
        int nod = 1;
        int accuracy = 2;
        int res = 0;
        float degree = 0;
        for (int i = 2; i <= value; i++) {
            for (int k = 1; k <= accuracy; k++) {
                int temp = (int) (Math.random() * ((100 - 1) - 2 + 1) + 2);
                if (i > temp) {
                    smaller = temp;
                } else {
                    smaller = i;
                }
                nod = 1;
                for (int j = 2; j <= smaller; j++) {
                    if (i % j == 0 && temp % j == 0) {
                        nod = j;
                    }
                }
                degree = (i - 1) / 2;
                res = 1;
                for (int l = 1; l < degree; l++) {
                    res = res * nod;
                }
            }

            if (nod == 1 && res != nod / i) {
                System.out.println(i);
            }
        }
    }
}