// ReSharper disable MemberCanBePrivate.Global
namespace Blueprint
{
    public class Color
    {
        /// <summary>
        /// Red, number from 0 to 1. 
        /// </summary>
        public float R;

        /// <summary>
        /// Red, number from 0 to 1. 
        /// </summary>
        public float G;

        /// <summary>
        /// Blue, number from 0 to 1. 
        /// </summary>
        public float B;

        /// <summary>
        /// Transparency, number from 0 to 1.
        /// </summary>
        public float A;

        public Color(float r = 1.0f, float g = 1.0f, float b = 1.0f, float a = 0.0f)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }
    }
}