// See https://aka.ms/new-console-template for more information

using System.Globalization;
using ShapeProject;

List<Shape> shapes = new List<Shape>();

System.Console.Write("Enter the number pf shapes: ");
int numberOfShapes = Convert.ToInt32(Console.ReadLine());


for (int i = 1; i <= numberOfShapes; i++)
{
  System.Console.WriteLine($"Shape #{numberOfShapes} data:");
  System.Console.Write("Rectangle or Circle (r/c)? ");
  char circleOrRetangleOption;
  bool isAValidChar = char.TryParse(Console.ReadLine(), out circleOrRetangleOption);

  if (isAValidChar)
  {
    System.Console.Write("Color: ");
    bool isValidColor = Enum.TryParse<Color>(Console.ReadLine()?.ToUpper(), out Color color);

    if (circleOrRetangleOption == 'r')
    {
      System.Console.Write("Width: ");
      double width = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
      System.Console.Write("Height: ");
      double height = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

      shapes.Add(new Rectangle(color, width, height));


    }
    if (circleOrRetangleOption == 'c')
    {
      System.Console.Write("Radius: ");
      double radius = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

      shapes.Add(new Circle(color, radius));

    }

  }

}


foreach (var shape in shapes)
{
  System.Console.WriteLine("ShapeAreas:");
  System.Console.WriteLine($"Area to {shape.GetType().Name} is {shape.Area()}");

}

