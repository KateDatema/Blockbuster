using System;
using System.Collections.Generic;

namespace Blockbuster
{
    public interface IPlay
    {
        //We care about playing behavior, so we are making a play method stub
        // This method stub keeps the method signuate consistent between children
        // BUT they must fill in their own functionality

        public void Play(List<string> Scenes);

    }
}
