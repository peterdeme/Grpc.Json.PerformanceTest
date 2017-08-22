using System.Collections.Generic;

namespace Shared
{
    public class HugeResponse
    {
        public List<string> StringList { get; set; }
        public List<int> IntList { get; set; }

        public static HugeResponse Create()
        {
            var stringList = new List<string>();
            for (int i = 0; i < 150; i++)
                stringList.Add(new string('a', 25));

            var intList = new List<int>();
            for (int i = 0; i < 150; i++)
                intList.Add(123);

            return new HugeResponse
            {
                StringList = stringList,
                IntList = intList
            };
        }
    }
}
