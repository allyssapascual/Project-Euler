package com.company;

public class Main {

    public static void main(String[] args) {
	    int r = 0;

	    for (int p = 990; p > 99; p-=11) {
	        for (int q = 999; q > 99; q--) {
	            int t = p * q;
	            if (r < t && isPalindrome(t)) {
	                r = t;
	                break;
                } else if (t < r) {
	                break;
                }
            }
        }
	    System.out.println(r);
    }

    public static Boolean isPalindrome(int i) {
        int n = 0;
        int m = i;

        while (i > 0) {
            n = n * 10 + i % 10;
            i = i / 10;
        }
        return n == m;
    }
}
