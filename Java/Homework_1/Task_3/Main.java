package Java.Homework_1.Task_3;

import java.util.Scanner;

public class Main {
    /* Реализовать простой калькулятор */
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int value_1 = 0;
        int value_2 = 0;
        int res = 0;
        System.out.println("Введите первое число: ");
        value_1 = in.nextInt();
        System.out.println("Введите действие: ");
        String sight = in.next();
        System.out.println("Введите второе число: ");
        value_2 = in.nextInt();
        if (sight == "+") {
            res = value_1 + value_2;
            System.out.println(res);
        } else if (sight == "-") {
            res = value_1 - value_2;
            System.out.println(res);
        } else if (sight == "*") {
            res = value_1 * value_2;
            System.out.println(res);
        } else if (sight == "/") {
            res = value_1 / value_2;
            System.out.println(res);
        } else {
            System.out.println("Ошибка");
        }
    }
}
