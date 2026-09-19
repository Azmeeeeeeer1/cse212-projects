using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add several items with different priorities.
    // Expected Result: The item with the highest priority is returned first.
    // Defect(s) Found: The first two weren't being tested.
    
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario: Add multiple items with the same highest priority.
    // Expected Result: The item added first is returned first.
    // Defect(s) Found: The later one from the same index was returned instead of the first one added.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("First", 10);
        priorityQueue.Enqueue("Second", 10);
        priorityQueue.Enqueue("Third", 5);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("First", result);
    }

    // Add more test cases as needed below.
}