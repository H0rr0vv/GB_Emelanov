#Найдите сумму цифр трехзначного числа.

number = int(input('Введите трехзначное число: '))

firstNum = int(number / 100)

secondNum = int(number / 10 % 10)

firdNum = int(number % 10)

result = int(firstNum + secondNum + firdNum)

print(f'{number} -> {result} ({firstNum} + {secondNum} + {firdNum})')
