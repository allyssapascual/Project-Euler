package com.company;

import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {
	    // Get triangle number
        // Get divisors of number -> list
        // Check length of divisors list

        int numDiv = 0;
        int triNum = 0;

        for (int count = 1; numDiv <= 500; count++) {
            numDiv = 0;
            //get triangle number
            triNum += count;

            //get divisors
            for (int i = 1; i <= Math.sqrt(triNum); i++) {
                if (triNum % i == 0) {
                    numDiv ++;
                }
            }

            numDiv *= 2;
        }
        System.out.println(triNum);
    }
}
