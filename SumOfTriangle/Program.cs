using SumOfTriangle;

var inputValue = "";
    
var input = GetInput.GetInputValue(inputValue);

string[] arrayOfRowsByNewlines = input.Split('\n');

var tableHolder = FlattenTheTriangleInto.FlattenTheTriangleIntoTable(arrayOfRowsByNewlines);

var result = ThroughTheNode.Walk(arrayOfRowsByNewlines, tableHolder);

Console.WriteLine($"The Maximum Total Sum Of Non-Prime Numbers From Top To Bottom Is:  {result[0, 0]}");

Console.ReadKey();




