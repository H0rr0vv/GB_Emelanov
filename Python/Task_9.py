'''
По данному целому неотрицательному n вычислите значение n!. n! = 1 * 2 * 3 * ... * n 
'''

num = int(input('Введите число: '))
i = int(1)
fac_of_num = 1

while i <= num:
    fac_of_num *= i
    i += 1

print(f'Факториал числа {num} = {fac_of_num}')
