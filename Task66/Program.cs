int f(int m, int n)
 


{
    
    
    if (n==m)
         return n;
    
    return f(m,n-1) + n;
}


int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());


if (m > n)
     Console.WriteLine(f(n, m));
 else
     Console.WriteLine(f(m, n));
