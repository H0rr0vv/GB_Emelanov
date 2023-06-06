'''
Петя и Катя – брат и сестра. Петя – студент, а Катя – школьница. 
Петя помогает Кате по математике. Он задумывает два натуральных числа X и Y (X,Y≤1000), а Катя должна их отгадать. 
Для этого Петя делает две подсказки. 
Он называет сумму этих чисел S и их произведение P. Помогите Кате отгадать задуманные Петей числа.
'''

import random

num_x = random.randint(0, 1000)
num_y = random.randint(0, 1000)

sum_of_num = num_x + num_y
prod_of_num = num_x * num_y

find_x = 0
find_y = 0

for find_x in range(sum_of_num):
    for find_y in range(prod_of_num):
        if sum_of_num == find_x + find_y and prod_of_num == find_x * find_y:
            print (f'Может: {find_x}, {find_y}')


print (f'Искомые значения: {num_x}, {num_y}')
