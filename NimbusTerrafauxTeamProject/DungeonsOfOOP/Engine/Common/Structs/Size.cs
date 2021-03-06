﻿namespace Engine.Common.Structures
{
    public struct Size
    {
        public Size(int width, int height) : this()
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width { get; set; }
        public int Height { get; set; }
    }
}
