'''
Хакер Василий получил доступ к классному журналу и
хочет заменить все свои минимальные оценки на
максимальные. Напишите программу, которая
заменяет оценки Василия, но наоборот: все
максимальные – на минимальные.
Input: 5 -> 1 3 3 3 4
Output: 1 3 3 3 1
'''
import random

def fun_miss(n):
    max_mark = max(n)
    min_mark = min(n)
    for i in range(len(n)):
        if n[i] == max_mark:
            n[i] = min_mark
    return n

mark_len = int(input(f'Введите количество оценок: '))
marks = [random.randint(1, 5) for i in range(mark_len)]
print(marks)
print(fun_miss(marks))