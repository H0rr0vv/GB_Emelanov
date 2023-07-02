package Java.Homework_1.Task_1;
import java.util.Scanner;

public class Main {
    /* Вычислить n-ое треугольного число (сумма чисел от 1 до n), n! (произведение чисел от 1 до n) */
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.println("Ввелите число: ");
        int value = in.nextInt();
        int res = 1;
        for (int i = 2; i <= value; i++) {
            res = res + i;
        }
        System.out.printf("Искомое треугольное число равно: %d", res);
    }
}
