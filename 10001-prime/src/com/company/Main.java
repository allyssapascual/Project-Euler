package com.company;

import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {
	    int max = 10001;
	    int half = 10001/2;
		boolean flag = true;
		int i = 1;
		ArrayList<Integer> arr = new ArrayList<>();

	    while (arr.size() <= max-1) {
	    	i++;
	        for (int j = 2; j <= half; j++) {
	            if (i % j == 0 && i != j) {
	            	flag = false;
					break;
                }
            }
	        if (flag) {
	        	arr.add(i);
	        }
	        flag = true;
        }
	    System.out.println(arr.get(arr.size()-1));
    }
}
