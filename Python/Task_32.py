'''
Определить индексы элементов массива (списка), значения которых принадлежат заданному диапазону (т.е. не меньше заданного минимума и не больше заданного максимума)
'''

import random

giv_list_len = int(input(f'Введите желаемую длину списка: '))
original_list = [random.randint(-10, 10) for i in range(giv_list_len)]
min_desire_num = int(input(f'Введите нижний предел поиска: '))
max_desire_num = int(input(f'Введите верхний предел поиска: '))
index = []

print(original_list)

for i in range(len(original_list)-1):
    if (original_list[i] > min_desire_num and original_list[i] < max_desire_num):
        index.append(i)

print(index)