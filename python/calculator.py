x = input("enter first number: ")
y = input("enter second number: ")
op = input("enter operator: ")

x = int(x)
y = int(y)

if (op=="+"):
	result = x+y
elif(op=="-"):
	result = x-y
elif(op=="*"):
	result = x*y
elif(op=="/"):
	result = x/y
else:
	print("Wrong operator ")


print("Result: ", result);

