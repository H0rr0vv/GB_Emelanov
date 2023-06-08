'''
Напишите рекурсивную функцию sum(a, b), возвращающую сумму двух целых неотрицательных чисел. Из всех арифметических операций допускаются только +1 и -1. Также нельзя использовать циклы.

*Пример:*

2 2
    4 
'''

def rec_summ(a, b):
    if a == 0 and b == 0:
        return 0
    elif a != 0:
        return rec_summ (a - 1, b) + 1
    else:
        return rec_summ (a, b - 1) + 1
    


first_num = int(input('Введите первое число: '))
second_num = int(input('Введите второе число: '))
print(rec_summ(first_num, second_num))