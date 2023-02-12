//Задача 4: Напишите программу, которая принимает на вход три 
//числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22



int a;
int b;
int c;
int max;

a = 2;
b = 3;
c = 7;
max = 0;

if (a > b)
{
   max = a; 
}
else 
{
max = b;
}
if (a > c)
{
    max = a;
}
else 
{
    max = c;
}
if (b > c)
{ 
    max = b;
}

Console.WriteLine(max); 


a = 44;
b = 5;
c = 78;
max = 0;

if (a > b)
{
   max = a; 
}
else 
{
max = b;
}
if (a > c)
{
    max = a;
}
else 
{
    max = c;
}
if (b > c)
{ 
    max = b;
}

Console.WriteLine(max); 

a = 22;
b = 3;
c = 9;
max = 0;

if (a > b)
{
   max = a; 
}
else 
{
max = b;
}
if (a > c)
{
    max = a;
}
else 
{
    max = c;
}
if (b > c)
{ 
    max = b;
}

Console.WriteLine(max); 