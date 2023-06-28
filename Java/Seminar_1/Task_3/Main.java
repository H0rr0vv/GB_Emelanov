package Java.Seminar_1.Task_3;

public class Main {
    public static void main(String[] args) {
    /*Во фразе "Добро пожаловать на курс по Java" переставить слова в обратном порядке*/    
        String line = "Добро пожаловать на курс по Java";
        System.out.println(reverse(line));

    }

    static String reverse(String line) {
        String[] temp = line.split(" ");
        String res = "";
        for (int i = temp.length - 1; i >= 0; i--) {
            res += temp[i] + " ";
        }
        return res;
    }
}
