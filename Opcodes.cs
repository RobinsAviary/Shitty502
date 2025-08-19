namespace Shitty502
{
    internal class Opcodes
    {
        public Dictionary<string, string> list = [];

        public void LoadFile(string filename)
        {
            string[] opcodeText = File.ReadAllLines(filename);
            bool key = true;
            string lastKey = "";

            foreach (string line in opcodeText)
            {
                if (key)
                {
                    lastKey = line;
                }
                else
                {
                    string altCode = line.Split(" ").First();

                    list[lastKey] = altCode;
                }

                key = !key;
            }

            /*foreach (KeyValuePair<string, string> entry in opcodes)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }*/
        }

        public Opcodes()
        {
            LoadFile("opcodes.txt");
        }
    }
}
