# Uloha - postupné vykreslení prasátka

## Pyhton řešení
je potřeba knihovna turtle 

Kód byl spustitelný ná https://trinket.io/turtle

```python
import turtle
t = turtle.Turtle()
t.shape("arrow")
t.speed(5)

t.forward(100)
t.right(90)
t.forward(50)
t.right(90)
t.forward(100)
t.right(30)
t.forward(50)
t.right(120)
t.forward(50)
t.right(120)
t.forward(50)
t.right(45)
t.forward(50)
t.backward(50)
t.left(90)
t.forward(50)
t.backward(50)
t.left(45)

t.forward(100)
t.right(135)
t.forward(50)
t.backward(50)
t.left(90)
t.forward(50)
t.backward(50)
t.left(135)

t.forward(50)
t.right(45)
t.forward(50)

```

## LOGO řešení
kód je spustitelný na https://www.calormen.com/jslogo/

```Logo
home clean hideturtle
forward 90 left 90 wait 10
forward 200 left 90 wait 10
forward 90 right 120 wait 10
forward 90 right 120 wait 10
forward 90 right 120 wait 10
forward 90 left 90 wait 10
forward 200 right 60 wait 10
forward 100 right 180 wait 10
forward 100 left 120 wait 10
forward 100 left 180 wait 10
forward 100 left 120 wait 10

forward 200 right 240 wait 10
forward 100 right 180 wait 10
forward 100 left 120 wait 10
forward 100 left 180 wait 10
forward 100 left 120 wait 10
right 90 forward 90 wait 10
right 90 forward 200 wait 10
left 30  forward 50 wait 10
```