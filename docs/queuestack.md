### How It Works

1. **Enqueue (Insertion)**: Whenever we want to insert an element into the queue, we push it onto the first stack (`stackNewestOnTop`).
   
2. **Dequeue (Removal)**: This operation is a bit trickier. When we want to remove an element (which is the oldest element as per queue's behavior), we:
   - If the second stack (`stackOldestOnTop`) is empty, pop all the elements from the first stack (`stackNewestOnTop`) and push them onto the second stack (`stackOldestOnTop`).
   - Pop the top element from `stackOldestOnTop`.
   
3. **Peek (Checking the front element)**: The process is similar to Dequeue, but instead of popping from `stackOldestOnTop`, we just peek at its top.

### Explanation

Let's visualize this with a step-by-step diagram:

1. **Initial State**: Both stacks are empty.

   ```
   stackNewestOnTop: []

   stackOldestOnTop: []
   ```

2. **Enqueue 1, 2, 3**: Push each number onto `stackNewestOnTop`.

   ```
   stackNewestOnTop: [3, 2, 1]

   stackOldestOnTop: []
   ```

3. **Dequeue**: We need to get `1` (the oldest element). Since `stackOldestOnTop` is empty, transfer all elements from `stackNewestOnTop`.

   ```
   Before Transfer:

   stackNewestOnTop: [3, 2, 1]
   stackOldestOnTop: []

   After Transfer:

   stackNewestOnTop: []
   stackOldestOnTop: [1, 2, 3]
   ```

   Now, pop the top of `stackOldestOnTop` (which is `1`).

4. **Enqueue 4**: 

   ```
   stackNewestOnTop: [4]
   stackOldestOnTop: [2, 3]
   ```

5. **Dequeue**: This time, since `stackOldestOnTop` isn't empty, just pop its top, which is `2`.

6. **Peek**: Without any modifications, just look at the top of `stackOldestOnTop`, which is `3`.

### Code Breakdown

1. **Variables**:
   - `stackNewestOnTop`: Holds the newest elements at its top.
   - `stackOldestOnTop`: Holds the oldest elements at its top after a transfer.

2. **Enqueue**:
   Simply push the element onto `stackNewestOnTop`.

3. **ShiftStacks**:
   An internal method to handle the logic of transferring elements from `stackNewestOnTop` to `stackOldestOnTop` if the latter is empty. This ensures that the oldest element is always on top of `stackOldestOnTop`.

4. **Dequeue**:
   - Call `ShiftStacks` to ensure the oldest element is at the top of `stackOldestOnTop`.
   - Pop the top of `stackOldestOnTop`.

5. **Peek**:
   - Similar to `Dequeue`, but instead of popping, we just peek at the top of `stackOldestOnTop`.

6. **Reset**:
   For testing purposes, this method clears both stacks to ensure a fresh start.

By using two stacks in this manner, we effectively create a queue with all its standard operations. The use of two stacks might seem like an overhead, but it allows us to keep the time complexity of the `Enqueue` operation to O(1). The `Dequeue` and `Peek` operations are amortized O(1) since the transfer of elements from one stack to another doesn't happen with every call.