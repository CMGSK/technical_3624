namespace Technical;

public class Program
{
    public static void Main(string[] args)
    {
        List<Point3D> coordinates = File.ReadAllLines("./Input3DPoints.txt") //Read the file as array of lines
            .Select(line => $"{line.Split('=')[0]}," + line.Split('=')[1].Trim("( )".ToCharArray())) //Format each one to name,x,y,z
            .Select(coords => coords.Split(',').ToArray()) //Split it into an array using the comma
            .Select(nxyz => new Point3D(int.Parse(nxyz[1]), int.Parse(nxyz[2]), int.Parse(nxyz[3]), nxyz[0])) //Build the object parsing xyz into int
            .ToList(); //return it as a list to match coordinates variable

        Console.WriteLine("\n\tThe points are:");
        foreach (Point3D p in coordinates) 
            Console.WriteLine(p);

        Console.WriteLine("\n\tPoint 1 is:");
        foreach (Point3D p in coordinates.Skip(1)) //Skip the index 0 since is the one we are comparing
            Console.WriteLine($"At {coordinates[0].DistanceToAsFloat(p):00.000} units from {p}");

        Console.WriteLine($"\nMoving {coordinates[0]}...");
        coordinates[0].MoveTo(7,3,9);
        Console.WriteLine($"\tNow {coordinates[0]}");

        Console.WriteLine($"\nDisplacing {coordinates[0]} +5 on Y axis...");
        coordinates[0].DisplaceOn(y: 5);
        Console.WriteLine($"\tNow {coordinates[0]}");


    }

}
