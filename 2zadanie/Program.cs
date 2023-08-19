Console.WriteLine("Введите координаты точки A в формате (x, y, z): ");
string str_num_ax = Console.ReadLine();
int num_ax = int.Parse(str_num_ax);
string str_num_ay = Console.ReadLine();
int num_ay = int.Parse(str_num_ay);
string str_num_az = Console.ReadLine();
int num_az = int.Parse(str_num_az);
Console.WriteLine("Введите координаты точки B в формате (x, y, z): ");
string str_num_bx = Console.ReadLine();
int num_bx = int.Parse(str_num_bx);
string str_num_by = Console.ReadLine();
int num_by = int.Parse(str_num_by);
string str_num_bz = Console.ReadLine();
int num_bz = int.Parse(str_num_bz);
double dist(int num_ax, int num_ay, int num_az, int num_bx, int num_by, int num_bz)
{
    int delta_x = num_bx - num_ax;
    int delta_y = num_by - num_ay;
    int delta_z = num_bz - num_az;
    return Math.Sqrt(delta_x*delta_x+delta_y*delta_y+delta_z*delta_z);
}
Console.WriteLine($"Расстояние между A и B {dist(num_ax, num_ay, num_az, num_bx, num_by, num_bz):F2}");