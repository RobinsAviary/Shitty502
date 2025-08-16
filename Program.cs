using Shitty502;

string name = "Shitty502";
string errorSuffix = "Error: ";
string crossparserError = name + " Cross-Parser " + errorSuffix;
string assemblySourceExt = ".s";
string outputFile = "output" + assemblySourceExt;

if (args.Length > 0)
{
    string filename = args.First();

    if (args.Length > 1) {
        outputFile = args[1];
        if (!outputFile.EndsWith(assemblySourceExt))
        {
            outputFile += assemblySourceExt;
        }
    }

    if (File.Exists(filename))
    {
        if (filename.EndsWith(".s"))
        {
            string output = "";

            var lines = File.ReadLines(filename);
            foreach (string line in lines)
            {
                foreach (var pair in Opcodes.opcodes)
                {
                    if (line.StartsWith(pair.Key))
                    {
                        output += line.Replace(pair.Key, pair.Value) + "\n";

                        break;
                    }
                }
            }

            output = output.TrimEnd('\n');

            File.WriteAllText(outputFile, output);
        }
        else
        {
            Console.WriteLine(crossparserError + $"File specified is not an assembly source file ({assemblySourceExt}).");
        }
    } else
    {
        Console.WriteLine(crossparserError + "File does not exist.");
    }
} else
{
    Console.WriteLine(crossparserError + "No argument/file provided.");
}