using System;
using System.Collections.Generic;

class BOJ_1715_Ver01
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var pq = new PriorityQueue<int, int>();

        for (int i = 0; i < n; i++)
        {
            int card = int.Parse(Console.ReadLine());
            pq.Enqueue(card, card); // 값과 우선순위를 동일하게
        }

        int totalCost = 0;

        while (pq.Count > 1)
        {
            int first = pq.Dequeue();
            int second = pq.Dequeue();
            int sum = first + second;
            totalCost += sum;
            pq.Enqueue(sum, sum); // 합친 결과를 다시 큐에
        }

        Console.WriteLine(totalCost);
    }
}
