using System.Threading.Tasks;

namespace ClassLib
{
    public class Class1
    {
        public static async Task<string> GetValueAsync()
        {
            return await GetValueWithValueTask();
        }

        private static ValueTask<string> GetValueWithValueTask()
        {
            return new ValueTask<string>("foo");
        }
    }
}
