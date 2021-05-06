Area Calculations
===
[Link](https://www.codewars.com/kata/5702e2f380b8c86df3000003)
Implement a calculator for shapes, like Square, Rectangle, Circle and Triangle.
The calculator have 2 interfaces ```decimal GetTotalArea(...shapes)```

![UML](http://www.plantuml.com/plantuml/png/ZP0n3i8m34Ltdo8ZB3a1GaKCY9LsGmmcDL39RS5n9k3kG34I5KF84kddENa_HLGKJIr3O8pHBP53OjHUt1NSSzLzsZEv5MdLA_9222VhyeHdskvSVErn2dU0fbEI0mPoxzEVyM5oGEsbHWBdiGq5nUxu1rbU4aeUgwJ9tVVr2TxFhH205PlTl3VxKMIcuzIiHj77000AwkhKyWC0)
```plantuml
@startuml
class Calculator {
    double GetTotalArea(IShape[] shapes)
}

interface IShape {
    double GetArea()
}

class Circle {
    double GetArea()
}

class Rectangle {
    double GetArea()
}

class Square {
    double GetArea()
}

class Triangle {
    double GetArea()
}

Calculator ..> IShape

IShape <|.. Circle
IShape <|.. Rectangle
IShape <|.. Square
IShape <|.. Triangle
@enduml
```