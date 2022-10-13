int distance = 10000;
int count = 0;
int time = 0;

Console.WriteLine("Напишите скорость первого друга");
int v1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите скорость второго друга");
int v2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите скорость собаки");
int vDog = Convert.ToInt32(Console.ReadLine());

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