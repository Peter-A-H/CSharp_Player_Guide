int[] a1, a2;

a1 = new int[] { 1, 2, 3 };

a2 = a1;

a2[0] = 100;

Console.WriteLine(a1[0]);

int[] a = new int[] { 1, 2, 3 };
int[] b = new int[] { 1, 2, 3 };

Console.WriteLine(a == b); // reference semantics, same data but different memory locations on the heap