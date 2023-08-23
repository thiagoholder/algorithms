def reverse(nums, start, end):
    while start < end:
        nums[start], nums[end] = nums[end], nums[start]
        start += 1
        end -= 1

def rotate(nums, k):
    n = len(nums)
    k %= n # Handle the case when k is greater than n

    # Reverse the entire list
    reverse(nums, 0, n-1)

    # Reverse the first k numbers
    reverse(nums, 0, k-1)

    reverse(nums, k, n-1)
    return nums

nums = [1,2,3,4,5]
k = 2
print(rotate(nums,k))