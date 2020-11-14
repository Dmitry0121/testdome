//  Created by naXa! on 19/02/2019.
//  Copyright © 2019 naXa!. All rights reserved.
//
/*
 This code is a practice Java interview question from testdome.com
 Problem statement:
    A TrainComposition is built by attaching and detaching wagons from the left and the right sides, efficiently with respect to time used.

    For example, if we start by attaching wagon 7 from the left followed by attaching wagon 13, again from the left, we get a composition of two wagons (13 and 7 from left to right). Now the first wagon that can be detached from the right is 7 and the first that can be detached from the left is 13.

    Implement a TrainComposition that models this problem.
 */
package by.naxa.testdome.traincomposition;

import java.util.Deque;
import java.util.LinkedList;

public class TrainComposition2 {
    private final Deque<Integer> deque = new LinkedList<>();

    public void attachWagonFromLeft(int wagonId) {
        deque.addFirst(wagonId);
    }

    public void attachWagonFromRight(int wagonId) {
        deque.addLast(wagonId);
    }

    public int detachWagonFromLeft() {
        final Integer wagon = deque.pollFirst();
        return wagon == null? 0 : wagon;
    }

    public int detachWagonFromRight() {
        final Integer wagon = deque.pollLast();
        return wagon == null? 0 : wagon;
    }

    public static void main(String[] args) {
        final TrainComposition tree = new TrainComposition();
        tree.attachWagonFromLeft(7);
        tree.attachWagonFromLeft(13);
        System.out.println(tree.detachWagonFromRight()); // 7
        System.out.println(tree.detachWagonFromLeft()); // 13
    }
}
