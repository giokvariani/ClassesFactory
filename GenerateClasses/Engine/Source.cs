using System.Reflection;

namespace GenerateClasses.Engine
{
    public abstract class Source
    {
        public static IReadOnlyCollection<Type>? GetAllChild()
        {
            return Assembly.GetAssembly(typeof(Source))?
                .GetTypes()
                .Where(theType => theType.IsClass && !theType.IsAbstract && theType
                .IsSubclassOf(typeof(Source))).ToList();
        }
    }
}
