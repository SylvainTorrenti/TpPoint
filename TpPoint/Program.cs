using TpPoint;

#region Create Point
Point Point1 = new Point();
Point1.Abscissa = 1;
Point1.Ordered = 2;
#endregion
#region Use method
Console.WriteLine($"La norme du point (1,2) est : {Point1.Norme()}");  
#endregion