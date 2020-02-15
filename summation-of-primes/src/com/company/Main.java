package com.company;

public class Main {

    public static void main(String[] args) {
//        Sieve of Erathosthenes
        long sum = 0;
        int max = 2000000;

        boolean[] ints = new boolean[max + 1];
        //composite = true
        //prime = false

        ints[0] = true;
        ints[1] = true;
        ints[2] = false;

        for (int i = 4; i <= max; i += 2) {
            ints[i] = true;
        }

        int limit = (int) Math.sqrt(max) + 1;
        for (int j = 3; j < limit; j += 2) {
            if (!ints[j]) {
                for (int x = j * j; x <= max; x += j) {
                    ints[x] = true;
                }
            }
        }

        for (int y = 0; y < ints.length; y++) {
            if (!ints[y]) {
                sum += y;
            }
        }

        System.out.println(sum);
    }
}
