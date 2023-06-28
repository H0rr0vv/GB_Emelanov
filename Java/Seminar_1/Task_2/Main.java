package Java.Seminar_1.Task_2;
import java.util.Arrays;


public class Main {
    /* Дан массив двоичных чисел, например [1,1,0,1,1,1],
    вывести максимальное количество подряд идущих 1. */
    public static void main(String[] args) {        
        int[] my_array = createRandomArray(0, 1);
        System.out.println(Arrays.toString(my_array));
        System.out.println(countOne(my_array));
        
    }

    static int[] createRandomArray(int  min, int max) {
        int size = 10;
        int[] arr = new int[size];
        for (int i = 0; i < arr.length; i++) {
            arr[i] = (int) (Math.random() * (max - min + 1) + min);
        }
        return arr;
    }

    static int countOne(int[] arr) {
        int max_count = 0;
        int count = 0;
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] == 1) {
                count++;
                if (max_count < count) {
                    max_count = count;
                }
            } else {
                count = 0;
            }
        }
        return max_count;
    }
}
