using System.Collections.Generic;

namespace Shared
{
    public class HugeRequest
    {
        public List<string> StringList { get; set; }
        public List<int> IntList { get; set; }

        public static HugeRequest Create()
        {
            var stringList = new List<string>();
            for (int i = 0; i < 150; i++)
                stringList.Add(new string('a', 25));

            var intList = new List<int>();
            for (int i = 0; i < 150; i++)
                intList.Add(123);

            return new HugeRequest
            {
                StringList = stringList,
                IntList = intList
            };
        }
    }
}
