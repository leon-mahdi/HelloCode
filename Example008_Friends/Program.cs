int distance = 10000;
int count = 0;
int time = 0, v1 = 2, v2 = 3, vDog = 7;
bool friend2 = true;

while(distance>10)
{
    if (friend2 = false)
    {
        time = distance / (v1 + vDog);
        friend2 = true;
    }
    else
    {
        time = distance / (v2 + vDog);
        friend2 = false;
    }
    distance = distance - (v1 + v2) * time;
    count++;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");