set1 = {1,2,3,4,5}
set2 = {4,5,6,7,8}
print('Set 1 : ',set1)
print('Set 2 : ',set2)

print('Union of both set : ',set1.union(set2))
print('All values which are in set1 but not in set2 : ',set1.difference(set2))
print('All values which are in set12 but not in set1 : ',set2.difference(set1))
print('All values which are common in both : ',set1.intersection(set2))

print('Pop : ', set1.pop(),' : from set 1')
print('Set 1 : ',set1)

print('Remove 3 from set 1')
print(set1.remove(3))  # doesn't return anything
print('Set 1 : ',set1)

print('Discard 4 from set1')
print(set1.discard(4))  # doesn't return anything
print('Set 1 : ',set1)

print('Clear set 1')
set1.clear()   # clear all elements of set1 but the set1 variable/container exists
print('Set 1 : ',set1)

print('Delete set 1')
#del set1  # delete all elements of set1 along with set1 variable/container
print('Set 1 : ',set1)