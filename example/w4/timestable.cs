
// for문으로 구구단 출력하기

for (int i = 2; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        int num = i;
        int time = j +1;

        Console.WriteLine($"{num} + {time} = { num* time}");
    }
}



