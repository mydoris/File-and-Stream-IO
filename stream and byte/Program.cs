using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace stream_and_byte
{
    class Program
    {
        private const string FILE_NAME = "MyFile.txt";
        
        static void Main(string[] args)
        {
            if (!File.Exists(FILE_NAME))
            {
                Console.WriteLine("{0} does not exist!", FILE_NAME);
                Console.ReadLine();
                return;
            }

            byte[] fileContents = new byte[14];

            var stream = new MemoryStream();
            var writer = new BinaryWriter(stream);
            writer.Write("fileName");
            writer.Write("authorName");
            writer.Write(fileContents.Length);
            writer.Write(fileContents);

            var data = stream.ToArray();  // send this data array to server
            writer.Dispose();
            stream.Dispose();

            var stream2 = new MemoryStream();
            var reader = new BinaryReader(stream2);

            Console.WriteLine(reader.PeekChar());

            var fileName = reader.ReadString();
            var author = reader.ReadString();
            var fileContents2 = reader.ReadBytes(reader.ReadInt32());


            using (BinaryReader br = new BinaryReader(stream2))
            {
                byte input;
                // While not at the end of the file, read lines from the file.
                while (br.PeekChar() > -1)
                {
                    input = br.ReadByte();
                    Console.WriteLine(input);
                }
            }

            reader.Dispose();
            stream.Dispose();



            Console.ReadLine();
        }
    }
}
