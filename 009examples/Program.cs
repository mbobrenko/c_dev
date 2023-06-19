// Найти максимальное из 9


int Max(int arg1, int arg2, int arg3);

{
int result =arg1;
 if (arg2 > result) result = arg2;
 if (arg3> result) result = arg3;
    return result;
}

int a1 = 23;
int b1 = 43;
int c1 = 36;
int a2 = 39;
int b2 = 33;
int c2 = 623;
int a3 = 13;
int b3 = 253;
int c3 = 33;

//int max1= Max(a1,b1,c1);
//int max2= Max(a2,b2,c2);
//int max3= Max(a3,b3,c3);
//int max= Max(max1, max2, max3);

int max=Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));

Console.WriteLine(max);
