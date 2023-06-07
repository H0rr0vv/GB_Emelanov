'''
Дан список чисел. Определите, сколько в нем 
встречается различных чисел.
Input: [1, 1, 2, 0, -1, 3, 4, 4]
Output: 6
'''

import random
original_list = [random.randint(-10, 10) for i in range(8) ]

print('Дан список:', end = ' ')
for i in original_list:
    print(i, end = ' ')

unique_set = {original_list[1]}

for i in original_list:
    unique_set.add(i)

print()
print (f'Количество уникальных элементов списка = {len(unique_set)}')