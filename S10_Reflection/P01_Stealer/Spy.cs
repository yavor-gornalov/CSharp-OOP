using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
        {
            Type classType = Type.GetType(investigatedClass);
            FieldInfo[] classFields = classType.GetFields(
                BindingFlags.Instance |
                BindingFlags.Static |
                BindingFlags.NonPublic |
                BindingFlags.Public);


            object? classInstance = Activator.CreateInstance(classType, Array.Empty<object>());

            var sb = new StringBuilder();
            sb.AppendLine($"Class under investigation: {investigatedClass}");
            foreach (var field in classFields.Where(f => requestedFields.Contains(f.Name)))
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");

            return sb.ToString().Trim();
        }
    }
}
