'''
Дано натуральное число A > 1. 
Определите, каким по счету числом Фибоначчи оно является, то есть 
выведите такое число n, что φ(n)=A. 
Если А не является числом Фибоначчи, выведите число -1
'''

num = int(input('Введите число: '))
febonachi = 2
prev_febonachi = 1
i = 4

if num == 0:
    print (f'{num} стоит 1 в последовательности Фебоначчи')
elif num == 1:
    print (f'{num} стоит 2 или 3 в последовательности Фебоначчи')
else:
    while num >= febonachi:
        if num == febonachi:
            print (f'{num} стоит {i} в последовательности Фебоначчи')
        febonachi = febonachi + prev_febonachi
        prev_febonachi = febonachi - prev_febonachi
        i += 1
        
if num != febonachi - (febonachi - prev_febonachi):
    print (-1)