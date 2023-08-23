def are_anagrams(str1, str2):
    # Remove spaces and convert to lowercase
    str1 = str1.replace(" ", "").lower()
    str2 = str2.replace(" ", "").lower()

    # Check for unequal lengths
    if len(str1) != len(str2): return False

    # Sort and compare
    return sorted(str1) == sorted(str2)

# Usage
result = are_anagrams("listen", "silent")  # True
print("This a Anagrams listen and silent? ");
print(result);
