package com.company;

public class Main {

    public static void main(String[] args) {
        double ans = 1000;

        for (int a = 0; a < ans/2; a++) {
            for (int b = 0; b < ans/3; b++) {
                int c = 1000 - a - b;

                if ((Math.pow(a, 2) + Math.pow(b,2) == Math.pow(c,2))) {
                    System.out.println(a + " and " + b + " and " + c + " = " + ans);
                    System.out.println(a*b*c);
                    break;
                }
            }
        }
    }
}
