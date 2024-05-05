using Microsoft.VisualBasic;

public static class TakingTurns {
    public static void Test() {
        // TODO Problem 1 - Run test cases and fix the code to match requirements
        // Test Cases

        // Test 1
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3) and
        // run until the queue is empty
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
        Console.WriteLine("Test 1");
        var players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);
        // Console.WriteLine(players);    // This can be un-commented out for debug help
        
        while (players.Length > 0)
            players.GetNextPerson();

        // Defect(s) Found:
        /*
            It’s starting with the last one that was added and if the 
            times of that element, in this case Sue as first name to be
            printed and 3 times in a row, for only then I came the 
            name Tim 5 times in a row, etc.

            public void Enqueue(Person person) {_queue.Insert(0, person);} This causes confusion in the Order,
            so I used the _queue.Add(person);
        */

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3)
        // After running 5 times, add George with 3 turns.  Run until the queue is empty.
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, George, Sue, Tim, George, Tim, George
        Console.WriteLine("Test 2");
        players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);

        for (int i = 0; i < players.Length; i++) {
            players.GetNextPerson();
            // Console.WriteLine(players);
        }

        players.AddPerson("George", 3);
        // Console.WriteLine(players);
        
        while (players.Length > 0)
            players.GetNextPerson();

        // Defect(s) Found: 
        /*
            It is started by the last element added and as in the first
            case the name of the element is repeated sequentially 
            without the rotation of the names and the first loop of 
            repetition (for) only goes up to 5 positions and the 
            total are 10.
            The queuer only has 3 positions so George can only be 
            added when there is a vacancy, in case when Bob leaves.

            for (int i = 0; i < 5; i++) replace by for (int i = 0; i < players.Length; i++)
        */

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (Forever), Sue (3)
        // Run 10 times.
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
        Console.WriteLine("Test 3");
        players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 0);
        players.AddPerson("Sue", 3);
        // Console.WriteLine(players);

        for (int i = 0; i <= 10; i++) {
            if (i <= 10)
            {
                players.GetNextPerson();
                i++;
            }
            else
                break; // Exit the loop if there are no more people in the queue
        }

        // Defect(s) Found: 
        /*
            Has the behavior of the test 1, however 
            Tim should have an infinite number of times and this 
            does not happen, there is one for ultin 10 times and go on the 
            message the queues is empty.
        */

        Console.WriteLine("---------");

         // Test 4
        // Scenario: Create a queue with the following people and turns: Tim (Forever), Sue (3)
        // Run 10 times.
        // Expected Result: Tim, Sue, Tim, Sue, Tim, Sue, Tim, Tim, Tim, Tim
        Console.WriteLine("Test 4");
        players = new TakingTurnsQueue();
        players.AddPerson("Tim", -3);
        players.AddPerson("Sue", 3);
        // Console.WriteLine(players);

        
        for (int i = -3; i <= 10; i++) {
            if (i <= 10)
            {
                players.GetNextPerson();
                i++;
            }
            else
                break; // Exit the loop if there are no more people in the queue
        }
          
        // Defect(s) Found: 
        /*
            Same behavior of test 1 and test 3 where Tim is only recognized 1 time
            and because there is one up to 10 falls on the message that 
            the queues is empty. 
        */

        Console.WriteLine("---------");

        // Test 5
        // Scenario: Try to get the next person from an empty queue
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 5");
        players = new TakingTurnsQueue();
        players.GetNextPerson();
        // Defect(s) Found:
        /*
        */
    }
}