package Seminar_1;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        /* В консоли запросить имя пользователя. В зависимости от текущего времени, вывести приветствие вида
        "Доброе утро, <Имя>!", если время от 05:00 до 11:59
        "Добрый день, <Имя>!", если время от 12:00 до 17:59
        "Добрый вечер, <Имя>!", если время от 18:00 до 22:59
        "Доброй ночи, <Имя>!", если время от 23:00 до 4:59 */
        Scanner scanner = new Scanner (System.in);
        LocalTime time = LicalTime.now();
        System.out.println("Как вас зовут?");
        String name = scanner.nextLine();
        if (time == )
    }
}