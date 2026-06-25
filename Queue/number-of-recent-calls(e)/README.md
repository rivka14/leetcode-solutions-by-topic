# **Explanation: Number of Recent Calls**

## **Problem:** [Number of Recent Calls - LeetCode](https://leetcode.com/problems/number-of-recent-calls/?envType=study-plan-v2&envId=leetcode-75)

### **Difficulty Level:** Easy

---

## **Description**  
You have a class `RecentCounter` that counts the number of recent requests within a time window of **3000 milliseconds**.

Implement the `RecentCounter` class with:
- `RecentCounter()` Initializes the counter with zero recent requests.
- `int Ping(int t)` Adds a new request at time `t` and returns the number of requests that have happened in the inclusive range `[t - 3000, t]`.

---

## **Example**  
```csharp
RecentCounter counter = new RecentCounter();
counter.Ping(1);     // returns 1
counter.Ping(100);   // returns 2
counter.Ping(3001);  // returns 3
counter.Ping(3002);  // returns 3
```

---

## **Approach**

We use a **queue** to efficiently store timestamps of recent pings.

Each time a new `Ping(t)` call is made:

1. Add the timestamp `t` to the queue.  
2. Remove all timestamps from the front of the queue that are older than `t - 3000`.  
3. Return the current size of the queue, which represents the number of recent pings in the time window `[t - 3000, t]`.

This works because the queue is always sorted by time (due to FIFO nature), and we only keep relevant recent calls.

---

## **Time Complexity**
- **O(1)** amortized per `Ping` operation — each request is enqueued and dequeued at most once.

## **Space Complexity**
- **O(n)** where `n` is the number of pings made so far (in the worst case, all within 3000 ms).

---

## **Code**

```csharp
public class RecentCounter {
    private Queue<int> requests;

    public RecentCounter() {
        requests = new Queue<int>();
    }

    public int Ping(int t) {
        requests.Enqueue(t);

        while (requests.Peek() < t - 3000) {
            requests.Dequeue();
        }

        return requests.Count;
    }
}
```
