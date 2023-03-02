string path1 = "C:\\Users\\Lolopo\\Desktop\\Паук и муха\\input_s1_20.txt";
string path2 ="C:\\Users\\Lolopo\\Desktop\\Паук и муха\\output_s1_20.txt";

string[] list1 = File.ReadAllLines(path1);
string list2 = File.ReadAllText(path2);

string[] size = list1[0].Split(" ");

int x = Convert.ToInt32(size[0]);
int y = Convert.ToInt32(size[1]);
int z = Convert.ToInt32(size[2]);

string[] k1 = list1[1].Split(" ");

int x1 = Convert.ToInt32(k1[0]);
int y1 = Convert.ToInt32(k1[1]);
int z1 = Convert.ToInt32(k1[2]);

string[] k2 = list1[2].Split(" ");

int x2 = Convert.ToInt32(k2[0]);
int y2 = Convert.ToInt32(k2[1]);
int z2 = Convert.ToInt32(k2[2]);

Console.WriteLine($"{x} {y} {z}");
Console.WriteLine($"{x1} {y1} {z1}, {x2} {y2} {z2}");

double S = 0;
double[] h = new double[4];
double[] g = new double[6];
int[] v = { x2-x1, y2-y1 , z2-z1 };
Console.WriteLine(String.Join(" ", v));
if (x1 == x2 && (x1 == 0 || x1 == x))
{
    S = Math.Sqrt(v[1] * v[1] + v[2] * v[2]);
}
else if (y1 == y2 && (y1 == 0 || y1 == y))
{
    S = Math.Sqrt(v[0] * v[0] + v[2] * v[2]);
}
else if (z1 == z2 && (z1 == 0 || z1 == z))
{
    S = Math.Sqrt(v[1] * v[1] + v[0] * v[0]);
}
else if (Math.Abs(v[1]) == y)
{
    h[0] = Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (z1 + y + z2) * (z1 + y + z2)), 3);
    h[1] = Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (z - z2 + y + z - z1) * (z - z2 + y + z - z1)), 3);
    h[2] = Math.Round(Math.Sqrt((z1 - z2) * (z1 - z2) + (x1 + y + x2) * (x1 + y + x2)), 3);
    h[3] = Math.Round(Math.Sqrt((z1 - z2) * (z1 - z2) + (x - x2 + y + x - x1) * (x - x2 + y + x - x1)), 3);
    S = h.Min();
}
else if (Math.Abs(v[0]) == x)
{
    h[0] = Math.Round(Math.Sqrt((y1 - y2) * (y1 - y2) + (z1 + x + z2) * (z1 + x + z2)), 3);
    h[1] = Math.Round(Math.Sqrt((y1 - y2) * (y1 - y2) + (z - z2 + x + z - z1) * (z - z2 + x + z - z1)), 3);
    h[2] = Math.Round(Math.Sqrt((z1 - z2) * (z1 - z2) + (y1 + x + y2) * (y1 + x + y2)), 3);
    h[3] = Math.Round(Math.Sqrt((z1 - z2) * (z1 - z2) + (y - y2 + x + y - y1) * (y - y2 + x + y - y1)), 3);
    S = h.Min();
}
else if (Math.Abs(v[2]) == z)
{
    h[0] = Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 + z + y2) * (y1 + z + y2)), 3);
    h[1] = Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (y - y2 + z + y - y1) * (y - y2 + z + y - y1)), 3);
    h[2] = Math.Round(Math.Sqrt((y1 - y2) * (y1 - y2) + (x1 + z + x2) * (x1 + z + x2)), 3);
    h[3] = Math.Round(Math.Sqrt((y1 - y2) * (y1 - y2) + (x - x2 + z + x - x1) * (x - x2 + z + x - x1)), 3);
    S = h.Min();
}
else if (x1 == 0) 
{
    if (y2 == 0)
    {
        S = Math.Round(Math.Sqrt((z1 - z2) * (z1 - z2) + (y1 + x2) * (y1 + x2)), 3);
    }
    if (y2 == y)
    {
        S = Math.Round(Math.Sqrt((z1 - z2) * (z1 - z2) + (x2 + y - y1) * (x2 + y - y1)), 3);
    }
    if (z2 == 0)
    {
        S = Math.Round(Math.Sqrt((y1 - y2) * (y1 - y2) + (z1 + x2) * (z1 + x2)), 3);
    }
    if (z2 == z)
    {
        S = Math.Round(Math.Sqrt((y1 - y2) * (y1 - y2) + (x2 + z - z1) * (x2 + z - z1)), 3);
    }
}
else if (x1 == x)
{
    if (y2 == 0)
    {
        S = Math.Round(Math.Sqrt((z1 - z2) * (z1 - z2) + (y1 + x - x2) * (y1 + x - x2)), 3);
    }
    if (y2 == y)
    {
        S = Math.Round(Math.Sqrt((z1 - z2) * (z1 - z2) + (x - x2 + y - y1) * (x - x2 + y - y1)), 3);
    }
    if (z2 == 0)
    {
        S = Math.Round(Math.Sqrt((y1 - y2) * (y1 - y2) + (z1 + x - x2) * (z1 + x - x2)), 3);
    }
    if (z2 == z)
    {
        S = Math.Round(Math.Sqrt((y1 - y2) * (y1 - y2) + (x - x2 + z - z1) * (x - x2 + z - z1)), 3);
    }
}
else if (y1 == 0)
{
    if (x2 == 0)
    {
        S = Math.Round(Math.Sqrt((z1 - z2) * (z1 - z2) + (y2 + x1) * (y2 + x1)), 3);
    }
    if (x2 == x)
    {
        S = Math.Round(Math.Sqrt((z1 - z2) * (z1 - z2) + (y2 + x - x1) * (y2 + x - x1)), 3);
    }
    if (z2 == 0)
    {
        S = Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (z1 + y2) * (z1 + y2)), 3);
    }
    if (z2 == z)
    {
        S = Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (y2 + z - z1) * (y2 + z - z1)), 3);
    }
}
else if (y1 == y)
{
    if (x2 == 0)
    {
        S = Math.Round(Math.Sqrt((z1 - z2) * (z1 - z2) + (y - y2 + x1) * (y - y2 + x1)), 3);
    }
    if (x2 == x)
    {
        S = Math.Round(Math.Sqrt((z1 - z2) * (z1 - z2) + (y - y2 + x - x1) * (y - y2 + x - x1)), 3);
    }
    if (z2 == 0)
    {
        S = Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (z1 + y - y2) * (z1 +y - y2)), 3);
    }
    if (z2 == z)
    {
        S = Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (y - y2 + z - z1) * (y - y2 + z - z1)), 3);
    }
}
else if (z1 == 0)
{
    if (x2 == 0)
    {
        S = Math.Round(Math.Sqrt((y1 - y2) * (y1 - y2) + (x1 + z2) * (x1 + z2)), 3);
    }
    if (x2 == x)
    {
        S = Math.Round(Math.Sqrt((y1 - y2) * (y1 - y2) + (y2 + x - x1) * (y2 + x - x1)), 3);
    }
    if (y2 == 0)
    {
        S = Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 + z2) * (y1 + z2)), 3);
    }
    if (y2 == y)
    {
        S = Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (z2 + y - y1) * (z2 + y - y1)), 3);
    }
}
else if (z1 == z)
{
    if (x2 == 0)
    {
        S = Math.Round(Math.Sqrt((y1 - y2) * (y1 - y2) + (z - z2 + x1) * (z - z2 + x1)), 3);
    }
    if (x2 == x)
    {
        S = Math.Round(Math.Sqrt((y1 - y2) * (y1 - y2) + (z - z2 + x - x1) * (z - z2 + x - x1)), 3);
    }
    if (y2 == 0)
    {
        S = Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (z1 + y - y2) * (z1 + y - y2)), 3);
    }
    if (y2 == y)
    {
        S = Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (z - z2 + y - y1) * (z - z2 + y - y1)), 3);
    }
}
Console.WriteLine(Math.Round(S, 3));
Console.WriteLine(list2);
