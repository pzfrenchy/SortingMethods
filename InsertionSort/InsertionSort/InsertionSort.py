list = [3,2,5,8,4]

for i in range(1, len(list)):
    currentValue = list[i]                      #copy current value to temp location
    while i > 0 and list[i-1] > currentValue:   #check if index greater than 0 and preceeding value greater than current
        list[i] = list[i-1]                     #shift higher value right
        i -= 1                                  #decrement index location
    list[i] = currentValue                      #insert current value into correct location

print(list)
