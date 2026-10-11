import java.util.Scanner;

public class BubbleSort {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);


        double[] numList = new double[10];
        for(int i = 0; i < 10; i++) {
            System.out.println("Please input number #" + (i+1) + ":");
            numList[i] = scan.nextDouble();
        }
        System.out.println("\nThe minimum number is " + min(numList)+"\n");
        sort(numList);

    }
    public static double min(double[] nums){
        double minimum = nums[0];
        for(int i = 0; i < nums.length; i++) {
            if(minimum > nums[i]){
                minimum = nums[i];
            }
        }
        return minimum;
    }

    public static void sort(double[] nums) {
        double temp = 0;
        for(int i = 0; i < nums.length - 1; i++){
            for(int j = 0; j < nums.length - 1 - i; j++) {
                if(nums[j] > nums[j + 1]) {
                    temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
                }
            }
        }
        for(int i = 0; i < nums.length; i++) {
            System.out.println((i + 1) + "# : " + nums[i]);
        }

    }
}