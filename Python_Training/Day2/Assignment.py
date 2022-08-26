'''
1. Develop Dictionary with number as key and square of number as value, for number 5 to 10
'''
dict1 = {}
for i in range(5,11):
    dict1[i] = i*i
print('Dict 1 : ',dict1)

'''2. From above dictionary create two list such that 1 list will have all keys and other will have all values'''
keyList = [key for key in dict1.keys()]
valueList = [value for value in dict1.values()]
print('Key List : ',keyList)
print('Value List : ',valueList)

'''3. Write a python code to combine/mapping 2 lists into single dictionary such that items of list1 will be key of 
dict2 and items of list2 will be value of dict2'''
dict2 = dict(zip(keyList,valueList))
print('Dict 2 : ',dict2)

'''4. Print pyramid of "*" with 10 lines '''
k=0
for i in range(10):
    for j in range(10,i,-1):
        print(end=" ")
    for k in range(i+1):
        print(end="* ")
    print()


'''5. Print all number between 1 to 100. When nuber 7 or multiple of 7 or number with 7 (47,73, etc) comes,
 print "I a perfect" '''
print('\n')
for i in range(1,101):
    if(i == 7):
        print('I am Perfect  ',i)
    elif(i%7 == 0):
        print('I am Perfect  ',i)
    elif(str(i).__contains__('7')):
        print('I am Perfect  ',i)


''' 6. find greatest of 5 different numbers '''
a,b,c,d,e = 1,8,9,3,5
max1 = a
for i in a,b,c,d,e:
    if(max1 < i):
        max1 = i
print(max1)

''' 7. Create a list of random items. Create dict with those random item as key and their type as its value'''
list1=[1.4,2,'Anna',True,'R']
dict1={}
for key in list1:
    dict1[key]=type(key)
print('Dict 1 : ',dict1)

''' 8. Consider the following dictionary 
       stock = {'apple':20,'orange':10,'pear':5}
       rates = {'apple':78,'orange':40.5,'pear':55,'banana':10}
       order = {'apple':3,'pear':6,'orange':7,'pineapple':2}
       person orders according to order dict, print cost dict with fruitname as key and toatl cost as value
       '''
stock = {'apple':20,'orange':10,'pear':5}
rates = {'apple':78,'orange':40.5,'pear':55,'banana':10}
order = {'apple':3,'pear':6,'orange':7,'pineapple':2}
cost = {}
for fruitname, orderAmount in order.items():
    if(fruitname in stock.keys()):
        if(stock[fruitname]>orderAmount):
            stock[fruitname] = stock[fruitname] - orderAmount
            cost[fruitname] = orderAmount * rates[fruitname]
        else:
            cost[fruitname] = stock[fruitname] * rates[fruitname]
            stock[fruitname] = 0
    else:
        cost[fruitname] = 0

print('Cost Dict : ',cost)
print('Stock Dict : ',stock)

