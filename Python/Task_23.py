'''
Дан массив, состоящий из целых чисел. Напишите 
программу, которая подсчитает количество 
элементов массива, больших предыдущего (элемента с предыдущим номером) 
Input: [0, -1, 5, 2, 3]
Output: 2 (-1 < 5, 2 < 3)
Примечание: Пользователь может вводить значения 
списка или список задан изначально.
'''

import random
my_list = [random.randint(-10, 10) for i in range(8)]
print(f'Дан список: {my_list}')

count = int(0)
new_list = []


for i in range(len(my_list)-2):
    if my_list[i] < my_list[i + 1]:
        count += 1

print(f'{count} ', end = '')

for i in range(len(my_list)-2):
    if my_list[i] < my_list[i + 1]:
        new_list.append(f'{my_list[i]} < {my_list[i + 1]}')

print(new_list)