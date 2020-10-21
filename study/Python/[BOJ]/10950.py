testCases = int(input())
for i in range(0, testCases):
    # input_data = map(int, input().split(','))
    # print(list(input_data[0]) + list(input_data[1]))
    input_data = input().split()
    # a = (int)input_data[0]
    # b print(a + (int)input_data[1])
    a = int(input_data[0])
    b = int(input_data[1])
    print(a + b)