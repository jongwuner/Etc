# input_data = input().split(' ')
# N = int(input_data[0])
# num = int(input_data[1])
# for _ in range(N):
#    tmp = input()
#    if(tmp < num) print(tmp + ' ', end='')

input_data = input().split(' ')
n = int(input_data[0])
x = int(input_data[1])

a = list(map(int, input().split(' ')))

for i in a:
    if x > i:
        print(i)