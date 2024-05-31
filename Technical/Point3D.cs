namespace Technical;

public class Point3D
{
    //Define each axis and an optional identifier
    public string Id { get; set; } = string.Empty;
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }


    //Constructors with/without identifier
    public Point3D(int x, int y, int z, string id){
        X = x;
        Y = y;
        Z = z;
        Id = id;
    }

    public Point3D(int x, int y, int z){
        X = x;
        Y = y;
        Z = z;
    }

    public override string ToString()
    {
        return $"{Id}(X:{X}, Y:{Y}, Z:{Z})";
    }

    //3D euclidean distance
    public float DistanceToAsFloat(Point3D target)
    {
        return (float) Math.Sqrt(Math.Pow(X - target.X, 2) + Math.Pow(Y - target.Y, 2) + Math.Pow(Z - target.Z, 2));
    }

    //Just in case you wanted the coordinate distance for each axis. 
    // public Point3D DistanceToAsCoordinates(Point3D target)
    // {
    //     return new Point3D(X-target.X, Y-target.Y, Z-target.Z);
    // }

    //Move to the specified coordinates without reinstanciating the object
    public void MoveTo(int x, int y, int z)
    {
        X = x; 
        Y = y; 
        Z = z; 
    }

    //Just another way I thought useful to "move" relative to its position and not bound by mandatory arguments
    public void DisplaceOn(int x = 0, int y = 0, int z = 0)
    {
        X += x;
        Y += y;
        Z += z;
    }
}
