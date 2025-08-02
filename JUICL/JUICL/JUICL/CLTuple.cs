using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUICL
{
    public class CLTuple
    {
        public bool _Create()
        {
            bool _result = false;
            var primes = Tuple.Create(2, 3, 5, 7, 11, 13, 17, 19);
            Console.WriteLine("Prime numbers less than 20: " +
                              "{0}, {1}, {2}, {3}, {4}, {5}, {6}, and {7}",
                              primes.Item1, primes.Item2, primes.Item3,
                              primes.Item4, primes.Item5, primes.Item6,
                              primes.Item7, primes.Rest.Item1);
            // The example displays the following output:
            //    Prime numbers less than 20: 2, 3, 5, 7, 11, 13, 17, and 19
            return _result;
        }
    }
}
