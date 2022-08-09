void Swap (ref int a,ref int b)
{
    int t=a;
    a=b;
    b=t;
}

int x=1, y=2;
Swap(ref x,ref y);