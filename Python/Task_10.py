'''
Задача 10: На столе лежат n монеток. Некоторые из них лежат вверх решкой, а некоторые – гербом.
Определите минимальное число монеток, которые нужно перевернуть, чтобы все монетки были повернуты вверх одной и той же стороной. 
Выведите минимальное количество монет, которые нужно перевернуть
'''

import random
coins_number = int(input('Количество монеток: '))
coin = None
coin_zero = 0
coin_one = 0

for i in range(coins_number):
    coin = random.randint(0, 1)
    print(coin, end=' ')
    if coin == 0:
        coin_zero += 1
    else:
        coin_one += 1
    i += 1

print()
if coin_one > coin_zero:
    print(coins_number - coin_one)
else:
    print(coins_number - coin_zero)