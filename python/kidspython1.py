import turtle

s = input("enter s")


t = turtle.Pen()
t.speed(10)

for x in range(100):
	t.forward(2*x)
	t.left(90)

