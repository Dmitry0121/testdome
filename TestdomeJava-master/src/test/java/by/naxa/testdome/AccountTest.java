//  Created by naXa! on 19/02/2019.
//  Copyright © 2019 naXa!. All rights reserved.
//
/*
 This code is a practice Java interview question from testdome.com
 Problem statement:
    Using JUnit Assert class, write tests for the Account class that cover the following cases:

    * The deposit and withdraw methods will not accept negative numbers.
    * Account cannot overstep its overdraft limit.
    * The deposit and withdraw methods will deposit or withdraw the correct amount, respectively.
    * The withdraw and deposit methods return the correct results.
 */
package by.naxa.testdome;

import org.junit.Assert;
import org.junit.Test;

public class AccountTest {
    private double epsilon = 1e-6;

    @Test
    public void accountCannotHaveNegativeOverdraftLimit() {
        Account account = new Account(-20);

        Assert.assertEquals(0d, account.getOverdraftLimit(), epsilon);
    }

    @Test
    public void depositDoesntAcceptNegativeValue() {
        Account account = new Account(20);
        final boolean result = account.deposit(-10);

        Assert.assertEquals(0d, account.getBalance(), epsilon);
        Assert.assertFalse(result);
    }

    @Test
    public void withdrawDoesntAcceptNegativeValue() {
        Account account = new Account(20);
        final boolean result = account.withdraw(-10);

        Assert.assertEquals(0d, account.getBalance(), epsilon);
        Assert.assertFalse(result);
    }

    @Test
    public void depositPositiveValueOk() {
        Account account = new Account(20);
        final boolean result = account.deposit(10);

        Assert.assertEquals(10d, account.getBalance(), epsilon);
        Assert.assertTrue(result);
    }

    @Test
    public void withdrawPositiveValueOverdraftOk() {
        Account account = new Account(20);
        final boolean result = account.withdraw(10);

        Assert.assertEquals(-10d, account.getBalance(), epsilon);
        Assert.assertTrue(result);
    }

    @Test
    public void withdrawPositiveValueBalanceOk() {
        Account account = new Account(0);
        account.deposit(20);
        final boolean result = account.withdraw(10);

        Assert.assertEquals(10d, account.getBalance(), epsilon);
        Assert.assertTrue(result);
    }

    @Test
    public void accountCannotOverstepOverdraftLimit() {
        Account account = new Account(20);
        final boolean result = account.withdraw(30);

        Assert.assertEquals(0d, account.getBalance(), epsilon);
        Assert.assertFalse(result);
    }

}
