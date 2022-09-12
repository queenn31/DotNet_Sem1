int num = 2;
for (int i=0; i<50; i++)
{
    Console.WriteLine(num);
    num = (-(~num)); num = (-(~num));
}