package com.company;

public class Main {

    public static void main(String[] args) {
	    long squareSum = 0;
	    long sumSquare = 0;

	    double sum = 0;
        for (int i = 1; i <= 100; i++) {
            sum += i;
            sumSquare += Math.pow(i, 2);
        }

        squareSum = (long) Math.pow(sum, 2);

        System.out.println(sumSquare + " " + squareSum);
	    System.out.println(squareSum - sumSquare);
    }

}
