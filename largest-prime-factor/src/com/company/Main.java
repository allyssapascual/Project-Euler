package com.company;

import java.util.ArrayList;
import java.util.Collections;

public class Main {

    public static void main(String[] args) {
        long val = 600851475143L;
        ArrayList<Integer> factor = new ArrayList<Integer>();

        for (int i = 2; i <= val; i++) {
            while (val % i == 0) {
                factor.add(i);
                val /= i;
            }
        }

        Collections.sort(factor, Collections.reverseOrder());

        System.out.println(factor.get(0));
    }
}
