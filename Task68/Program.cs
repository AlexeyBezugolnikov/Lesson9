
int f(int m, int n)



{
    if (m==0)
    return (n+1);
    if (m>0 && n == 0)
    return f(m-1,1);
    if (m>0 && n > 0)
    return f(m-1,f(m,n-1));
    return 0;
}



int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

if (m<0)
m=Math.Abs(m);
if (n<0)
n=Math.Abs(m);

Console.WriteLine(f(m,n));
