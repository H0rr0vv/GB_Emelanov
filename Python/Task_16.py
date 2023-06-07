'''
Требуется вычислить, сколько раз встречается некоторое число X в массиве A[1..N]. 
Пользователь в первой строке вводит натуральное число N – количество элементов в массиве. 
В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X

*Пример:*

5
    1 2 3 4 5
    3
    -> 1
'''

import random

giv_list_len = int(input(f'Введите желаемую длину списка: '))
original_list = [random.randint(-10, 10) for i in range(giv_list_len)]
desire_num = int(input(f'Введите какое число вы хотите найти: '))
count = int(0)
print()
print(f'Длина списка = {giv_list_len}')
print(f'    {original_list}')

print(f'    Искомое число: {desire_num}')

for i in original_list:
    if i == desire_num:
        count += 1

print(f'    -> {count}')