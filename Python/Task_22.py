'''
Даны два неупорядоченных набора целых чисел (может быть, с повторениями). 
Выдать без повторений в порядке возрастания все те числа, которые встречаются в обоих наборах.
Пользователь вводит 2 числа. n — кол-во элементов первого множества. m — кол-во элементов второго множества. 
Затем пользователь вводит сами элементы множеств.
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
