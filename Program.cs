using Shitty502;

string name = "Shitty502";
string errorSuffix = "Error: ";
string crossparserError = name + " Cross-Parser " + errorSuffix;
string assemblySourceExt = ".s";
string outputFile = "output" + assemblySourceExt;
char flagPrefix = '-';

Opcodes opcodes = new();

if (args.Length > 0)
{
    string filename = args.First();

    uint i = 1;
    while (i < args.Length)
    {
        string arg = args[i];

        if (!arg.StartsWith(flagPrefix) && arg.EndsWith(assemblySourceExt))
        {
            outputFile = args[i];
            if (!outputFile.EndsWith(assemblySourceExt))
            {
                outputFile += assemblySourceExt;
            }
        }
        else if (arg.StartsWith(flagPrefix) && arg.EndsWith("reverse"))
        {
            Console.WriteLine("Reverse!");
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
                bool startsWithOpcode = false;
                // TODO: Call a function or index instead of iterating
                foreach (var pair in opcodes.opcodes)
                {
                    if (line.StartsWith(pair.Key))
                    {
                        output += line.Replace(pair.Key, pair.Value) + "\n";

                        startsWithOpcode = true;
                        break;
                    }
                }

                if (!startsWithOpcode)
                {
                    output += line + "\n";
                }
            }

            output = output.TrimEnd('\n');
            output = output.Replace("//", ";");

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