"""
def printDict(dict1):
    print('Dict 1 : ', dict1)

dict1 = {'name':'Tommy', 'age' : 32, 'dept':'CSE'}
print('Dict 1  :   ',dict1)
print('\n',end='')

print('Traverse all keys in dict1')
for key in dict1:
    print(key,end=' ')
print('\n')

print('Traverse all keys in dict1.keys()')
for key in dict1.keys():
    print(key,end=' ')
print('\n')

print('Traverse all values in dict1.values()')
for value in dict1.values():
    print(value,end=' ')
print('\n')

print('Traverse all keys and values in dict1.items()')
for key,value in dict1.items():
    print(key,' : ',value)

print('\nPrint value for key "name" : ',dict1['name'])

print('\nAdd new key value to dict1')
dict1['University']='VIT'
printDict(dict1)

print('Update age to 21')
dict1['age']=21
printDict(dict1)

x = dict1.values()
print('\nx before dict updation : ', x)
dict1['trying'] = 'x'
print('X after dict updation  : ',x)
# x is getting dynamically updated with updation to dict1.values()
"""


