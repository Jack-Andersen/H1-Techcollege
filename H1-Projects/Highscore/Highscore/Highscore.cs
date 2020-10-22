using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Highscore
{
    class Highscore : IComparer <Highscore>
    {
        public string Name;
        public int Score { get; set; }

        public int Compare(Highscore x, Highscore y)
        {
            return x.Score <= y.Score ? 1 : -1;
        }
    }
}
