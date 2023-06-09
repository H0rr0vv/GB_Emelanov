'''
Даны два массива чисел. Требуется вывести те элементы
первого массива (в том порядке, в каком они идут в первом
массиве), которых нет во втором массиве. Пользователь вводит 
число N - количество элементов в первом массиве, затем N
чисел - элементы массива. Затем число M - количество
элементов во втором массиве. Затем элементы второго массива
Ввод: Вывод:
7 3 3 2 12
3 1 3 4 2 4 12
6
4 15 43 1 15 1 (каждое число вводится с новой строки)
'''

import random

giv_first_list_len = int(input(f'Введите желаемую длину первого списка: '))
first_original_list = [random.randint(-10, 10) for i in range(giv_first_list_len)]
giv_second_list_len = int(input(f'Введите желаемую длину второго списка: '))
second_original_list = [random.randint(-10, 10) for i in range(giv_second_list_len)]

result_list = first_original_list + second_original_list
result_list = list(set(result_list))

list.sort(result_list)

print(result_list)