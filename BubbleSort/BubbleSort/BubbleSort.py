numbers = [5,4,3,2,1]

print(numbers)

for i in range(0,len(numbers)-1):
    for j in range(0,len(numbers)-1):   #double for loop required to check all combinations
        if numbers[j] > numbers[j+1]:   #compare current index location to next and swap if necessary
            temp = numbers[j]           #swap requires temp variable
            numbers[j] = numbers[j+1]   #carryout swap
            numbers[j+1] = temp

print(numbers)
