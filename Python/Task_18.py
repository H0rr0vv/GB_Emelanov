'''
Требуется найти в массиве A[1..N] самый близкий по величине элемент к заданному числу X. 
Пользователь в первой строке вводит натуральное число N – количество элементов в массиве. 
В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X

*Пример:*

5
    1 2 3 4 5
    6
    -> 5
'''

import random

giv_list_len = int(input(f'Введите желаемую длину списка: '))
original_list = [random.randint(-10, 10) for i in range(giv_list_len)]
desire_num = int(input(f'Введите какое число вы хотите найти: '))
nearest_num = original_list[0]
print()
print(f'Длина списка = {giv_list_len}')
print(f'    {original_list}')

print(f'    Искомое число: {desire_num}')

for i in range(len(original_list)-1) :
    if (nearest_num - original_list[i] > 0 
        and nearest_num - original_list[i] < nearest_num - original_list[i - 1]) or (original_list[i] - nearest_num > 0 
                                                                                     and original_list[i] - nearest_num < original_list[i - 1] - nearest_num):
        nearest_num = original_list[i]

print(f'    Ближайшее значение: {nearest_num}')