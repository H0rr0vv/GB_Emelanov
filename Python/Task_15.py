'''
Иван Васильевич пришел на рынок и решил 
купить два арбуза: один для себя, а другой для тещи. 
Понятно, что для себя нужно выбрать арбуз 
потяжелей, а для тещи полегче. Но вот незадача: 
арбузов слишком много и он не знает как же выбрать 
самый легкий и самый тяжелый арбуз? Помогите ему!
Пользователь вводит одно число N – количество
арбузов. Вторая строка содержит N чисел,
записанных на новой строчке каждое. Здесь каждое
число – это масса соответствующего арбуза
Input: 5 -> 5 1 6 5 9
Output: 1 9
'''
import random

num_of_melon = int(input('Количество арбузов: '))
max_weight = 0
min_weight = 10
weight_of_melon = 0
i = int(0)

while i < num_of_melon:
    weight_of_melon = random.randint(0, 10)
    if max_weight < weight_of_melon:
        max_weight = weight_of_melon
    if min_weight > weight_of_melon:
        min_weight = weight_of_melon
    i += 1

print(f'{min_weight} {max_weight}')
