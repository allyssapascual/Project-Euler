package com.company;

public class Main {

    public static void main(String[] args) {
        int max = 4000000;
        int sum = 0;
        int prev = 1;
        int curr = 1;
        int temp;

        while (curr <= 4000000) {
            temp = curr;
            curr += prev;
            prev = temp;

            if (curr % 2 == 0) {
                sum += curr;
            }
        }

        System.out.println(sum);
    }
}
