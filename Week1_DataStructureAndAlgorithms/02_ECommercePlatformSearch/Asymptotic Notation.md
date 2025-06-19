## 1. Understand Asymptotic Notation

### a. Big O Notation
Big O notation describes the **upper bound** of an algorithm's time or space complexity as the input size (*n*) grows. It helps analyze and compare algorithm efficiency, especially for large inputs.

**Common Big O Examples:**
- **O(1)** – Constant time
- **O(log n)** – Logarithmic time (e.g., Binary Search)
- **O(n)** – Linear time (e.g., Linear Search)
- **O(n log n)** – Linearithmic time (e.g., Merge Sort)
- **O(n²)** – Quadratic time (e.g., Bubble Sort)

---

### b. Best, Average, and Worst-Case Scenarios

#### 1. Best Case
- Fastest scenario; item is found immediately.
- **Time Complexity:** `O(1)`

#### 2. Average Case
- Typical scenario; item is somewhere in the middle.
- **Time Complexity:** `O(n)`

#### 3. Worst Case
- Slowest scenario; item is last or not found.
- **Time Complexity:** `O(n)`


> Binary Search (on sorted data) has **O(log n)** in all cases except the best case, which can be **O(1)**.