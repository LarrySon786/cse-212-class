using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: This test ensures that items are properly enqueued and dequeued.
        // It also ensures that the correct ordering is dequeued when taking priority
        // into account. The highest proprity item is dequeued first. IF THERE ARE
        // Multiple of same priority, then the first in the queue is dequeued.
        // Also tests that items are properly enqueued.
    // Expected Result: "Laundry", "Cleaning", "Dishes"
    // Defect(s) Found: 3
        // 1. the Dequeue function did not actually remove from queue.
        // 2. The index started at 1 and not 0 in the dequque function's for loop. This prevented
        // The program from reading the first index value.
        // 3. Also removed the '=' sign from the for loop where the priorities are compared between items
        // This = sign was preventing the program from doing the FIRST item in the queue.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Dishes", 1);
        priorityQueue.Enqueue("Laundry", 3);
        priorityQueue.Enqueue("Cleaning", 3);

        var task1 = priorityQueue.Dequeue();
        var task2 = priorityQueue.Dequeue();
        var task3 = priorityQueue.Dequeue();

        String[] expectedResult1 = ["Laundry", "Cleaning", "Dishes"];

        Assert.AreEqual(task1, expectedResult1[0]);
        Assert.AreEqual(task2, expectedResult1[1]);
        Assert.AreEqual(task3, expectedResult1[2]);
    }

    [TestMethod]
    // Scenario: Tests that an empty PriorityQueue() will display an error message
    // Expected Result: "The queue is empty."
    // Defect(s) Found: 0
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }



    }

    // Add more test cases as needed below.
}