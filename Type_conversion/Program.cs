﻿//inplicit casting - rzutowanie niejawne
//sbyte
sbyte a = 10;

//int 
int b;

//not working, because higher value
//uint b;

//copy the value from "a" to "b"
b = a;

Console.WriteLine(a); //10
Console.WriteLine(b); //10

//-------------------------------------
//explicit casting - rzutowanie jawne
int x = 100;

float y;

y = (float)x;


int c = 500;

byte d;

d = (byte)c;