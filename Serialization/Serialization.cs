using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


//May 10th 2016 - Assignment 1
//Serialize(convert into binary) --these kinds of objects
//Arrays
//Objects
//Integers
//Doubles
//Strings

namespace Serialization
{
	class Serializer
	{
		private enum OPCodes : byte
		{
			Object,
			Integer,
			Double,
			String,
			Array,
			Character,
		}

		static public byte[] serialize(char input)
		{
			BinaryWriter writer = new BinaryWriter(new MemoryStream());
			writeOp(input, writer);
			serialize(input, writer);
			return ((MemoryStream)writer.BaseStream).ToArray();
		}

		static private void writeOp(char input, BinaryWriter writer)
		{
			writer.Write((byte)OPCodes.Character);
		}

		static private void serialize(char input, BinaryWriter writer)
		{
			writer.Write(input);
		}

		static public byte[] serialize(int input)
		{
			BinaryWriter writer = new BinaryWriter(new MemoryStream());
			writeOp(input, writer);
			serialize(input, writer);
			return ((MemoryStream)writer.BaseStream).ToArray();
		}

		static private void writeOp(int input, BinaryWriter writer)
		{
			writer.Write((byte)OPCodes.Integer);
		}

		static private void serialize(int input, BinaryWriter writer)
		{
			writer.Write(input);
		}

		static public byte[] serialize(double input)
		{
			BinaryWriter writer = new BinaryWriter(new MemoryStream());
			writeOp(input, writer);
			serialize(input, writer);
			return ((MemoryStream)writer.BaseStream).ToArray();
		}

		static private void writeOp(double input, BinaryWriter writer)
		{
			writer.Write((byte)OPCodes.Double);
		}

		static private void serialize(double input, BinaryWriter writer)
		{
			writer.Write(input);
		}

		static public byte[] serialize(string input)
		{
			BinaryWriter writer = new BinaryWriter(new MemoryStream());
			writeOp(input, writer);
			serialize(input, writer);
			return ((MemoryStream)writer.BaseStream).ToArray();
		}

		static private void writeOp(string input, BinaryWriter writer)
		{
			writer.Write((byte)OPCodes.String);
		}

		static private void serialize(string input, BinaryWriter writer)
		{
			writer.Write(input);
		}

		static public byte[] serialize(object input)
		{
			BinaryWriter writer = new BinaryWriter(new MemoryStream());
			writeOp(input, writer);
			serialize(input, writer);
			return ((MemoryStream)writer.BaseStream).ToArray();
		}

		static private void writeOp(object input, BinaryWriter writer)
		{
			writer.Write((byte)OPCodes.Object);
		}

		static private void serialize(object input, BinaryWriter writer)
		{
			//probably should do something here?
		}

		static public byte[] serialize<T>(T[] input)
		{
			BinaryWriter writer = new BinaryWriter(new MemoryStream());
			writeOp(input, writer);
			serialize(input, writer);
			return ((MemoryStream)writer.BaseStream).ToArray();
		}

		static private void writeOp<T>(T[] input, BinaryWriter writer)
		{
			writer.Write((byte)OPCodes.Array);
			writeOp(default(T), writer);
		}

		static private void serialize<T>(T[] input, BinaryWriter writer)
		{
			writer.Write(input.Length);
			foreach (T i in input)
			{
				serialize(i, writer);
			}
		}
	}
}
