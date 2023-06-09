'''
Заполните массив элементами арифметической прогрессии. 
Её первый элемент, разность и количество элементов нужно ввести с клавиатуры. 
Формула для получения n-го члена прогрессии: an = a1 + (n-1) * d.
Каждое число вводится с новой строки.
'''


first_elem = int(input(f'Введите первый элемент списка: '))
elem_diff = int(input(f'Введите разность элементов списка: '))
list_len = int(input(f'Введите желаемую длину списка: '))


original_list = []
count = 0

while count < list_len:
    original_list.append(first_elem)
    print(original_list[count])
    first_elem += elem_diff
    count += 1
    
