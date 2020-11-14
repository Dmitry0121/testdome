//  Created by naXa! on 19/02/2019.
//  Copyright © 2019 naXa!. All rights reserved.
//
/*
 This code is a practice Java interview question from testdome.com
 Problem statement:
    Implement function countNumbers that accepts a sorted array of unique integers and, efficiently with respect to time used, counts the number of array elements that are less than the parameter lessThan.

    For example, SortedSearch.countNumbers(new int[] { 1, 3, 5, 7 }, 4) should return 2 because there are two array elements less than 4.

 Efficient approach:
    As the whole array is sorted we can use binary search to find result.
*/
package by.naxa.testdome;

public class SortedSearch {

    private static int findMid(int[] sortedArray, int left, int right, int lessThan) {
        int middle = left + (right - left) / 2;
        if (sortedArray[middle] == lessThan) {
            // If duplicates are present it returns the position of the first element
            while (middle - 1 > 0 && sortedArray[middle - 1] == lessThan)
                --middle;
            return middle;
        }
        if (middle <= left) {
            // It happens if lessThan is not present in the array
            while (middle <= right && sortedArray[middle] < lessThan)
                ++middle;
            return middle;
        }
        if (sortedArray[middle] < lessThan) {
            left = middle;  // ignore left half
        } else {
            right = middle;  // ignore right half
        }
        return findMid(sortedArray, left, right, lessThan);
    }

    public static int countNumbers(int[] sortedArray, int lessThan) {
        int left = 0;
        int right = sortedArray.length - 1;
        return findMid(sortedArray, left, right, lessThan);
    }

    public static void main(String[] args) {
        System.out.println(SortedSearch.countNumbers(new int[] { 1, 3, 5, 7 }, 4));
    }
}
