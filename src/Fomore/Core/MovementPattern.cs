﻿namespace Core
{
    public class MovementPattern : ICloneable<MovementPattern>
    {
        public MovementPattern Clone()
        {
            return new MovementPattern();
            // TODO actually implement this once the class has functionality
        }
    }
}