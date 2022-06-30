int a1 = 1500;
int a2 = 42;
int a3 = 13;
int b1 = 25;
int b2 = 32;
int b3 = 23;
int c1 = 3737;
int c2 = 412;
int c3 = 33;

int max = a1;

if (b1 > max) max = b1;
if (b2 > max) max = b2;
if (b3 > max) max = b3;

if (c1 > max) max = c1;
if (c2 > max) max = c2;
if (c3 > max) max = c3;

if (a2 > max) max = a2;
if (a3 > max) max = a3;

Console.WriteLine("Максимальное число среди всех = " + max);
