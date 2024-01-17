Console.WriteLine(Add(1, 2));
Console.WriteLine(Add(1.5, 2.5));
Console.WriteLine(Add("Hello", "World"));

static dynamic Add(dynamic a, dynamic b) => a + b;
