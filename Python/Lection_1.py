#n = 'fd\'fd'

#print(n)

#print(type(n))
"""
n = 'fd\'fd'

print(n)

print(type(n))
"""
'''
a = 5
b = 5.89
c = 'hello'

print(f"{a} - {b} - {c}")
'''
'''
a = 5
b = 5.89
c = 'hello'

print("{} - {} - {}".format(a,b,c))
'''
'''
print('Введите первое число: ')
a = input()
print(a)

b = input('Введите второе число: ')

print(a, ' + ', b, ' = ', a + b)
'''

'''
c= 5.89
print(c)
print(type(c))
c = int(c)
print(c)
print(type(c))
c = float(c)
print(c)
print(type(c))
c = bool(c)
print(c)
print(type(c))
c = str(c)
print(c)
print(type(c))

round(c, 2)

'''

'''
iter = 2 
iter += 2 # iter = iter + 2 
iter -= 2 # iter = iter - 2 
iter *= 2 # iter = iter * 2 
iter /= 2 # iter = iter / 2 
iter //= 2 # iter = iter // 2 
iter %= 2 # iter = iter % 2 
iter **= 2 # iter = iter ** 2 
'''

'''
username = input('Введите имя: ')
if username == 'Маша':
    print('Ура, это же МАША!')
elif username == 'Марина':
    print('Я так ждала Вас, Марина!')
elif username == 'Ильнар':
    print('Ильнар - топ')
else:
    print('Привет, ', username)
'''

'''
n = int(input())
flag = True
i = 2
while flag:
    if n % i == 0:
        flag = False
        print(i)
    elif i > n // 2:
        print(n)
        flag = False
    i += 1
'''

