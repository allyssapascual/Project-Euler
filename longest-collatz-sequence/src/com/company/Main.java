package com.company;

public class Main {

    public static void main(String[] args) {
	    int max = 1000000;
        long longest = 0;
        long longestNum = 0;

	    for (int i = 10; i < max; i++) {
	        long count = 0;
	        long temp = i;
            while (temp != 1) {
                if (temp % 2 == 0) {
                    temp = temp / 2;
                } else {
                    temp = (3*temp) + 1;
                }
                count++;
            }
            if (count >= longest) {
                longest = count;
                longestNum = i;
            }
        }
	    System.out.println(longestNum);
    }
}
