import sys

test = int(input())
for _ in range(test):
    input_data = sys.stdin.readline().rstrip().split(' ')
    A = int(input_data[0])
    B = int(input_data[1])
    print(A + B)