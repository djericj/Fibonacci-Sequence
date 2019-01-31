// Fibonacci Sequence in C#
// Eric Rydberg (djericj@hotmail.com)

int[] a = new int[3] {1, 0, 0}; // 0 = current, 1 = previous, 2 = 2 previous
do {
a[1] = a[0];
a[0] = a[1] + a[2];
a[2] = a[1];
Console.WriteLine(a[0]);
} while (a[0] < 10000); // max length
