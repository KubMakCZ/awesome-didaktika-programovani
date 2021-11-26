# Progrmaovací jazyk LOGO
## Zadání ve zkratce

 rekurze -> vykreslit fraktal, kochova vločka, rekurzivní strom

 Veškeré ukázkové programy jsou spustitelné na stránkach
 https://www.calormen.com/jslogo/

## Kódy
### Vytvoření kochovy vločky
```logo
TO SNOWFLAKE.SIDE :LENGTH :DEPTH

  IF :DEPTH = 0 [
    FORWARD :LENGTH
    STOP 
  ]

  SNOWFLAKE.SIDE :LENGTH  / 3 :DEPTH - 1

  LEFT    60
  SNOWFLAKE.SIDE :LENGTH  / 3 :DEPTH - 1
  RIGHT   120
  SNOWFLAKE.SIDE :LENGTH  / 3 :DEPTH - 1
  LEFT    60

  SNOWFLAKE.SIDE :LENGTH  / 3 :DEPTH - 1
END

TO SNOWFLAKE :LENGTH :DEPTH
  REPEAT 3 [
    SNOWFLAKE.SIDE :LENGTH :DEPTH
    RIGHT 120
  ]
END
 
clearscreen window hideturtle 
SNOWFLAKE 200 4
```

### Vytvoření stromu
```
TO PLANT :SIZE :ANGLE
   IF :SIZE < 1 [ STOP ] 

   RIGHT :ANGLE
   FORWARD :SIZE
   REPEAT 4 [
     PLANT :SIZE / 2 DIFFERENCE RANDOM 160 80
   ]
   BACK :SIZE
   LEFT :ANGLE
END
 
PLANT 100 0
```

### Trojúhelníkový fraktal
```
TO TRIANGLE.FRACTAL :LENGTH :DEPTH

  ; base case:
  ; just move forward, no more squares
  IF :DEPTH = 0 [
    FORWARD :LENGTH
    STOP
  ]

  ; recursive case:
  ; draw a triangle such that each side of
  ; the triangle has TRIANGLE.FRACTAL in it.
  REPEAT 3 [
      FORWARD :LENGTH / 3
      TRIANGLE.FRACTAL :LENGTH / 3 :DEPTH - 1
      FORWARD :LENGTH / 3

      RIGHT 120
  ]
END

clearscreen window hideturtle 
TRIANGLE.FRACTAL 200 4
```

### Čtvercový fraktal
```
TO SQUARE.FRACTAL :LENGTH :DEPTH

  ; base case: no more squares
  IF :DEPTH = 0 [ STOP ]

  ; recursive case: draw a square such that each corner
  ; of the square has SQUARE.FRACTAL in it.
  REPEAT 4 [
    FORWARD :LENGTH
    RIGHT   90
    SQUARE.FRACTAL :LENGTH * 0.4 :DEPTH - 1 
  ]

END

clearscreen window hideturtle 
SQUARE.FRACTAL 200 4
```

### Kytičkový fraktál
```
TO CURLY.FRACTAL :SIZE

  IF :SIZE < 0.5 [ STOP ]

  REPEAT 360 [

      IF REPCOUNT = 5 [ 
         LEFT 90
         CURLY.FRACTAL :SIZE / 2
         RIGHT 90
      ]

      IF REPCOUNT = 10 [ 
         LEFT 90
         CURLY.FRACTAL :SIZE / 5
         RIGHT 90
      ]

      IF REPCOUNT = 15 [ 
         LEFT 90
         CURLY.FRACTAL :SIZE / 5
         RIGHT 90
      ]

      IF REPCOUNT = 20 [ 
         LEFT 90
         CURLY.FRACTAL :SIZE / 4
         RIGHT 90
      ]

      IF REPCOUNT = 25 [ 
         LEFT 90
         CURLY.FRACTAL :SIZE / 5
         RIGHT 90
      ]

      IF REPCOUNT = 30 [ 
         LEFT 90
         CURLY.FRACTAL :SIZE / 8
         RIGHT 90
      ]

      FORWARD :SIZE
      RIGHT REPCOUNT 
  ]

  RIGHT 180

END

clearscreen window hideturtle
CURLY.FRACTAL 10
```


## Zdroje

https://fmslogo.sourceforge.io/workshop/fractals.shtml