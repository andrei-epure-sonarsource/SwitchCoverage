using System;

namespace SwitchCoverage
{
    public class Foo
    {
        public int Bar(string input) =>
            input switch
            {
                "one" => 1,
                "two" => 2,
                "three" => 3,
                _ => 0
            };
    }
}
