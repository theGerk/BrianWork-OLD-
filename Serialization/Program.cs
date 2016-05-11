using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//May 10th 2016 - Assignment 1
//Serialize(convert into binary) --these kinds of objects
//Arrays
//Objects
//Integers
//Doubles
//Strings
//
//Deserialize(convert from binary), the same types listed above

class Program
{
	static void Main(string[] args)
	{
		var obj = new int[5];
		foreach (var item in Serialization.Serializer.serialize(obj))
		{
			Console.WriteLine(item);
		}
	}
}