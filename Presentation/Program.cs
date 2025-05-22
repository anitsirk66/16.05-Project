
List<string> input = new List<string>();

using (StreamReader reader = new StreamReader("query.txt", System.Text.Encoding.UTF8))
{
    string line;
    while((line = reader.ReadLine()) != null)
    {
        input = line.Split(' ').ToList();
        string name = input[0];
        int rating = int.Parse(input[1]);
        
    }
}
