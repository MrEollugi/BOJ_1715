# BOJ_1715 Card Sorting
This problem is about minimizing the total cost of combining several decks of cards into one, where combining two decks incurs a cost equal to the sum of their sizes. It's a classic example of a greedy strategy combined with a priority queue (min-heap).
## Problem Statement
Given `N` decks of cards, each with a certain number of cards, you can combine any two decks at a time. The cost of combining two decks is the **sum of their sizes**. The goal is to **combine all decks into one with the minimum total cost**.
> Input:  
> - First line: an integer `N` (1 ≤ N ≤ 100,000)  
> - Next `N` lines: each line contains the size of a card deck

> Output:  
> - A single integer: the minimum total cost required to combine all the decks

---

## Approach & Algorithm

This problem is similar to **Huffman Coding**, where combining the two smallest items repeatedly leads to an optimal result.  
We use a **min-heap (priority queue)** to always combine the two smallest decks.

### Steps:
1. Push all deck sizes into a min-heap.
2. While the heap has more than one item:
   - Pop the two smallest decks.
   - Combine them (cost = sum).
   - Push the combined deck back into the heap.
   - Accumulate the cost.
3. Output the total cost.

This greedy strategy guarantees the minimum possible cost.
