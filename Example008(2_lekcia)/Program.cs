int Max(int arg1, int arg2, int arg3)
{
int result = arg1;
if (arg2 > result) result = arg2;
if (arg3 > result) result = arg3;
return result;
}
int a1 = 3;
int b1 = 498654346;
int c1 = 8;
int a2 = 9;
int b2 = 30;
int c2 = 44;
int a3 = 33;
int b3 = 99;
int c3 = 83;

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);