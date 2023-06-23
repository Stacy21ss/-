int [] array = {2,3,5,22,65,78,24,7,9,0};
int n = array.Length;
int find = 5;
int index = 0;
while (index < n)
{
    if (array [index] == find)
    {
       Console.WriteLine(index); 
    }
    index++;
}

