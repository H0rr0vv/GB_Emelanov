'''
Дана последовательность из N целых чисел и число 
K. Необходимо сдвинуть всю последовательность 
(сдвиг - циклический) на K элементов вправо, K – 
положительное число.
Input: [1, 2, 3, 4, 5] k = 3
Output: [4, 5, 1, 2, 3]
'''

import random
original_list = [random.randint(0, 10) for i in range(5)]
list_shift = int(input('Введите на сколько сдвинется список '))

print(f'Дан список: {original_list}', end = ' ')


print(f'k = {list_shift}')


new_list = []
count = -1 * list_shift

while count + 1 < list_shift:
    n = original_list[count]
    new_list.append(n)
    count += 1

print()
print(new_list)