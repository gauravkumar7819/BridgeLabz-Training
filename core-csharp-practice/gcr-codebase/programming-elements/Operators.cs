using System;
using System.Numerics;
class Operators{
static void Main(String []args){
// Arithmetic Operators
int a= Convert.ToInt32(Console.ReadLine());

int b= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("a + b = " + (a + b)); // Addition

Console.WriteLine("a - b = " + (a - b)); // Subtraction	
//logical operators
Console.WriteLine("a > b = " + (a > b)); // Greater than
Console.WriteLine("a < b = " + (a < b)); // Less than   
Console.WriteLine("a >= b = " + (a >= b)); // Greater than or equal to
Console.WriteLine("a <= b = " + (a <= b)); // Less than or equal to
Console.WriteLine("a == b = " + (a == b)); // Equal to  
Console.WriteLine("a != b = " + (a != b)); // Not equal to
//asignment Operators
Console.WriteLine("a += b: " + (a += b)); // a = a + b
Console.WriteLine("a -= b: " + (a -= b)); // a = a - b
Console.WriteLine("a *= b: " + (a *= b)); // a = a * b
Console.WriteLine("a /= b: " + (a /= b)); // a = a / b
Console.WriteLine("a %= b: " + (a %= b)); // a = a % b
Console.WriteLine("a &= b: " + (a &= b)); // a = a & b

// Unary Operators
Console.WriteLine("++a: " + (++a)); // Pre-increment
Console.WriteLine("a++: " + (a++)); // Post-increment
Console.WriteLine("--a: " + (--a)); // Pre-decrement
Console.WriteLine("a--: " + (a--)); // Post-decrement
// Ternary Operator
int max = (a > b) ? a : b;
Console.WriteLine("Max value: " + max);
// Bitwise Operators
Console.WriteLine("a & b = " + (a & b)); // Bitwise AND
Console.WriteLine("a | b = " + (a | b)); // Bitwise OR
Console.WriteLine("a ^ b = " + (a ^ b)); // Bitwise XOR
Console.WriteLine("~a = " + (~a)); // Bitwise NOT
Console.WriteLine("a << 1 = " + (a << 1)); // Left
Console.WriteLine("a >> 1 = " + (a >> 1)); // Right

}}