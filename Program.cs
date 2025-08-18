using Shitty502;
using System.Text.RegularExpressions;

string name = "Shitty502";
string errorSuffix = "Error: ";
string crossparserError = name + " Cross-Parser " + errorSuffix;
string assemblySourceExt = ".s";
string outputFile = "output" + assemblySourceExt;
char flagPrefix = '-';
bool reverseInterpret = false;

Opcodes opcodes = new();

if (args.Length > 0)
{
    string filename = args.First();

    for (uint i = 1; i < args.Length; i++)
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
            reverseInterpret = true;
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
                string comment = "";
                bool commentFound = false;

                int commentPos = line.IndexOf("//");

                if (commentPos != -1)
                {
                    commentFound = true;
                    comment = line.Substring(commentPos);
                }

                string mainLine = line.Substring(0, line.Length - comment.Length);

                string[] mainSplit = mainLine.TrimStart().Split(" ");
                
                if (mainSplit.Length > 0)
                {
                    string opcode = mainSplit[0];

                    if (opcodes.opcodes.ContainsKey(opcode))
                    {
                        string altCode = opcodes.opcodes[opcode];

                        var regex = new Regex(Regex.Escape(opcode));
                        mainLine = regex.Replace(mainLine, altCode, 1);
                    }
                }

                output += mainLine;
                if (commentFound) output += ";" + comment.Substring(2);
                output += "\n";
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