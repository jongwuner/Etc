input_data = input().split(' ')
h = int(input_data[0])
m = int(input_data[1])

if m - 45 < 0:
	if h - 1 < 0:
		h = 23
	else :
		h = h - 1
	m = 60 - 45 + m
	print(str(h) + ' ' + str(m))
else:
	m -= 45
	print(str(h) + ' ' + str(m))