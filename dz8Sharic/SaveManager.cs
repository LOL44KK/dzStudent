using System.Text.Json;

namespace dzStudent
{
    public class SaveManager
    {
        private static JsonSerializerOptions _options = new JsonSerializerOptions
        {
            WriteIndented = true,
        };

        public static void SaveGroup(Group group, string path)
        {
            File.WriteAllText(path, JsonSerializer.Serialize(group, typeof(Group), _options));
        }

        public static Group? LoadGroup(string path) 
        {
            return JsonSerializer.Deserialize<Group>(File.ReadAllText(path), _options);
        }
    }
}
