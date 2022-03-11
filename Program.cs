int a;
for (int i = 0; i <4;i++)
{
    System.Console.WriteLine("hogog bede");
    a=Convert.ToInt32(Console.ReadLine());
    if (a>2000000 && a<3000000)
    {
        System.Console.WriteLine("maliat"+(a*0.05));

    }
    else if(a>3000000)
    {
        System.Console.WriteLine("maliat"+(a*0.07));

    } else
    {
        System.Console.WriteLine("maliat 0");
    }
    

}