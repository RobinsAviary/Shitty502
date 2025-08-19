namespace Shitty502
{
    internal class TextfileReader
    {
        public string ReadTextfile(string filename)
        {
            using StreamReader reader = new(filename);

            string text = reader.ReadToEnd();

            return text;
        }
    }
}
