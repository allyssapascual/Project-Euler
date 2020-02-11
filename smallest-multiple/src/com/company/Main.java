package com.company;

import java.util.List;

public class Main {

    public static void main(String[] args) {
        boolean found = false;
        int i = 0;
        int checkList[] = {11, 13, 14, 16, 17, 18, 19, 20};

	    while (!found) {
            i++;
            for (int x = 0; x < checkList.length; x++) {
                if (!(i % checkList[x] == 0)) {
                    break;
                } else if (x == checkList.length - 1){
                    found = true;
                }
            }
        }

	    System.out.println(i);
    }
}