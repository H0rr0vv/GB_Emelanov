'''
Задача 8: Требуется определить, можно ли от шоколадки размером n × m долек отломить k долек, 
если разрешается сделать один разлом по прямой между дольками (то есть разломить шоколадку на два прямоугольника).

*Пример:*

3 2 4 -> yes
3 2 1 -> no
'''

chocoLenght = int(input('Длина шоколадки: '))
chocoWidth = int(input('Ширина шоколадки: '))

chocoSlice = int(input('Вы хотите получить столько долек: '))

changeLine = 1

flag = True

if chocoLenght < 1 or chocoWidth < 1:
    print('Таких шоколадок не существует')
    
while flag:
    if changeLine * chocoLenght == chocoSlice or changeLine * chocoWidth == chocoSlice:
        flag = False
        print(f'{chocoLenght} {chocoWidth} {chocoSlice} -> yes')
    elif changeLine * chocoLenght < chocoSlice or changeLine * chocoWidth < chocoSlice:
        changeLine += 1
    else:
        flag = False
        print(f'{chocoLenght} {chocoWidth} {chocoSlice} -> no')