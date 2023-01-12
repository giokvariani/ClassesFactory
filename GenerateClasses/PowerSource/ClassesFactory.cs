using GenerateClasses.ValueObjects;
using System.Text;

namespace GenerateClasses.PowerSource
{
    public static class ClassesFactory
    {
        const string Target = nameof(Target);
        const string cs = nameof(cs);
        const string GeneratedObjects = nameof(GeneratedObjects);
        const string Engine = nameof(Engine);
        const string X = nameof(X);
        public static void Create(IEnumerable<string> words)
        {
            var thisProjectPath = @"C:\Users\gio\source\repos\GenerateClasses\GenerateClasses";

            foreach (var word in words)
            {
                var path = @$"{thisProjectPath}{Symbol.BackSlash}{GeneratedObjects}{Symbol.BackSlash}{word}{Symbol.Dot}{cs}";
                var file = File.Create(path);
                file.Dispose();
            }
            var pathTargetClass = @$"{thisProjectPath}\{Engine}\{Target}{Symbol.Dot}{cs}";
            foreach (var word in words)
            {
                var originalText = File.ReadAllText(pathTargetClass);
                var modifiedText = originalText.Replace(Target, word);
                var targetBytes = Encoding.ASCII.GetBytes(modifiedText);
                File.WriteAllBytes(@$"{thisProjectPath}{Symbol.BackSlash}{GeneratedObjects}{Symbol.BackSlash}{word}{Symbol.Dot}{cs}", targetBytes);
            }
        }
    }
}
