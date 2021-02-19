a = int(input())
for i in range(1, 10):
##    print(a + " * " + i + " = " + a*i)
    print('{0} * {1} = {2}'.format(a, i, a*i))

print("답은" + a)