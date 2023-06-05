using System;
using System.Linq;
using System.Collections.Generic;

public class Program {
	public static int[] ArrayOfMultiples(int num, int length)
        => Enumerable.Range(1, length).Select(x => x * num).ToArray();

}
