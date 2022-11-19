from pprint import pprint

sentence: str = "This is a common interview question"


char_frequency: dict = {}
for char in sentence:
    if char in char_frequency:
        char_frequency[char] += 1
    else:
        char_frequency[char] = 1

print("results", char_frequency)
#pprint(char_frequency, width=1)
sorted_dict = sorted(char_frequency.items(),
                     key=lambda kv: kv[1], reverse=True)
print("sorted", sorted_dict)
print("the first item:", list(sorted_dict[0])[0])
