using System;

namespace Coding.Exercise
{
    using System.Collections.Generic;

    public class EvenNumberGenerator
    {
        public IEnumerable<int> GenerateEvenNumbers()
        {
            int current = 0;
            while (true)
            {
                // Kod w środku pętli
                yield return current;
                current += 2;
                
            }


        }
    }

}
