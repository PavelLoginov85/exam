# Задача 22: Даны два неупорядоченных набора целых чисел (может быть, с повторениями).
# Выдать без повторений в порядке возрастания все те числа, которые встречаются в обоих наборах.
# Пользователь вводит 2 числа. n — кол-во элементов первого множества. 
# m — кол-во элементов второго множества.
# Затем пользователь вводит сами элементы множеств.

n = int(input("Введите кол-во эл-ов списка 1  "))
print()
m = int(input("Введите кол-во эл-ов списка 2  "))

list_n = []
list_m = []

for i in range(n):
    number_n = int(input("Число для списка 1  "))
    list_n.append(number_n )
for i in range(m):
    number_m = int(input("Число для списка 2  "))
    list_m.append(number_m)
print()
print(f"Первый список {list_n}")
print(f"Второй список {list_m}")

def intersectionss(list1, list2):
    list3 = [value for value in list1 if value in list2]
    return list3

total = (intersectionss(list_m, list_n))
def sort (array):
    if len(array) < 2:
        return array
    else:
        minn = array[0]
        less = [i for i in array[1:] if i <= minn]
        big = [i for i in array[1:] if i > minn]
        return sort (less) + [minn] + sort (big)

a = set(sort(total)) 
print(f"В итоги получаем такой список {a}")




# Задача 6: -- домашка
# num = int(input("Введите шестизначное число: "))
# sum1 = 0
# sum2 = 0
# c = num
# t = 0
# while num > 0: 
#     if num > 99999 and num < 1000000:
#         while num > 0:
#                 if t < 3:
#                     sum1 += num%10
#                     num = num//10
#                     t= t+1
#                 elif t >=3:
#                     sum2 += num%10
#                     num = num//10
#                     t= t+1              

#         if sum1 == sum2:
#             print(f"{c} yes")
#         else:
#             print(f"{c} no")

     

# Задача 2: Найдите сумму цифр трехзначного числа. -- домашка

# *Пример:*

# 123 -> 6 (1 + 2 + 3)
# 100 -> 1 (1 + 0 + 0) |

# a = int(input("Введите трехзначное число: "))
# sum = 0
# t = 0
# if (a > 99 and a < 1000):
#     while t < 4:
#         sum += a%10
#         a = a//10
#         t = t + 1
#     print(f"Сумма цифр равна {sum}")

# else:
#     print(f"Число {a} не трехзначное или отрицательное")


# Задача 4: Петя, Катя и Сережа делают из бумаги журавликов. 
# Вместе они сделали S журавликов. Сколько журавликов сделал 
# каждый ребенок, если известно, что Петя и Сережа
# сделали одинаковое количество журавликов, 
# а Катя сделала в два раза больше журавликов, чем Петя и Сережа вместе?

# a = int(input("Введите кол-во журавликов: "))

# p = (a / 3)/2
# s = (a / 3)/2
# k = (s + p) * 2
# print (f"Петя сделал {p} ,журавликов  Серёжа {s} , Катя сделала {k}")


# Задача 8: Требуется определить, можно ли от шоколадки размером
# n × m долек отломить k долек, если разрешается сделать один 
# разлом по прямой между дольками (то есть разломить шоколадку на два прямоугольника)

# n = int(input("Введите первый размер шоколадки: "))
# m = int(input("Введите второй размер шоколадки: "))
# k = int(input("Какое кол-во долек ломаем? "))

# if (k%m == 0 and (m*n) > k) or (k%n == 0 and (m*n) > k):
#     print("yes")
# else:
#      print("no")

