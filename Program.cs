
Queue<string> turnQueue = new Queue<string>();

// Add players to the queue
turnQueue.Enqueue("Knight");
turnQueue.Enqueue("Mage");
turnQueue.Enqueue("Archer");

Console.WriteLine("Battle Start!\n");

// Process each player's turn
while (turnQueue.Count > 0)
{
    string player = turnQueue.Dequeue();
    Console.WriteLine($"{player} takes their turn");
}

Console.WriteLine("\nAll turns completed");
