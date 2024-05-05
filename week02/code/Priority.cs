public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: The queue is organized according to the priority number, the highest priority
        // number must be the first in the queue.
        // Expected Result: D, C, A, E, B
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("A", 13);
        priorityQueue.Enqueue("B", 8);
        priorityQueue.Enqueue("C", 19);
        priorityQueue.Enqueue("D", 39);
        priorityQueue.Enqueue("E", 9);
        Console.WriteLine("After enqueu: " + priorityQueue);

        while(true)
        {
            var dequeuedItem = priorityQueue.Dequeue();
            if (dequeuedItem == null)
            {
                break;
            }
            
            Console.WriteLine("Dequeued: " + dequeuedItem);
        }

        // Defect(s) Found: 
        /*
            Only the first priority is shown repeatedly, 
            this way is not made a queue in order of priority.
        */

        Console.WriteLine("---------");

        // Test 2
        // Scenario: In the priority queue the largest number must be in front, 
        // however having elements with equal priorities what was added first should 
        // be in front.
        // Expected Result: C, D, B, E, A
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("A", 3);
        priorityQueue.Enqueue("B", 9);
        priorityQueue.Enqueue("C", 19);
        priorityQueue.Enqueue("D", 19);
        priorityQueue.Enqueue("E", 9);
        Console.WriteLine("After enqueuing: " + priorityQueue);
        Console.WriteLine("Dequeue: " + priorityQueue.Dequeue());

        while(true)
        {
            var dequeuedItem = priorityQueue.Dequeue();
            if (dequeuedItem == null)
            break;
            Console.WriteLine("Dequeued: " + dequeuedItem);
        }

        // Defect(s) Found: 
        /*
            Only the first priority is shown repeatedly, this way is not made 
            a queue ordered by the criteria of elements that has the same 
            priority value. 
        */

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}