## Analysis of Search Algorithms

- **Linear Search**
  - **Time Complexity:** O(n)
  - **Best Case:** Target is the first element (O(1))
  - **Worst Case:** Target is at the end or not found (O(n))
  - **Use Case:** Suitable for small or unsorted product lists.

- **Binary Search**
  - **Time Complexity:** O(log n)
  - **Best Case:** Target is at the middle (O(1))
  - **Worst Case:** Target not found after repeated halving (O(log n))
  - **Use Case:** Best for large, sorted datasets.

## Conclusion

- **binary search** is better when product data is sorted and read-heavy.
- **linear search** is better for small datasets or when sorting isn't practical.
