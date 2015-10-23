using System;

namespace BlinkByte.Graphics
{
    //Copied from https://github.com/SFML/SFML.Net/blob/master/src/Graphics/Color.cs , will look at making it more my own later
    public struct Colour: IEquatable<Colour>
    {
        ////////////////////////////////////////////////////////////
        /// <summary>
        /// Utility class for manipulating 32-bits RGBA Colours
        /// </summary>
        ////////////////////////////////////////////////////////////
        

            ////////////////////////////////////////////////////////////
            /// <summary>
            /// Construct the Colour from its red, green and blue components
            /// </summary>
            /// <param name="red">Red component</param>
            /// <param name="green">Green component</param>
            /// <param name="blue">Blue component</param>
            ////////////////////////////////////////////////////////////
            public Colour(byte red, byte green, byte blue) :
                this(red, green, blue, 255)
            {
            }

            ////////////////////////////////////////////////////////////
            /// <summary>
            /// Construct the Colour from its red, green, blue and alpha components
            /// </summary>
            /// <param name="red">Red component</param>
            /// <param name="green">Green component</param>
            /// <param name="blue">Blue component</param>
            /// <param name="alpha">Alpha (transparency) component</param>
            ////////////////////////////////////////////////////////////
            public Colour(byte red, byte green, byte blue, byte alpha)
            {
                R = red;
                G = green;
                B = blue;
                A = alpha;
            }

            ////////////////////////////////////////////////////////////
            /// <summary>
            /// Construct the Colour from 32-bit unsigned integer
            /// </summary>
            /// <param name="Colour">Number containing the RGBA components (in that order)</param>
            ////////////////////////////////////////////////////////////
            public Colour(uint Colour)
            {
                unchecked
                {
                    R = (byte)(Colour >> 24);
                    G = (byte)(Colour >> 16);
                    B = (byte)(Colour >> 8);
                    A = (byte)Colour;
                }
            }

            ////////////////////////////////////////////////////////////
            /// <summary>
            /// Construct the Colour from another
            /// </summary>
            /// <param name="Colour">Colour to copy</param>
            ////////////////////////////////////////////////////////////
            public Colour(Colour Colour) :
                this(Colour.R, Colour.G, Colour.B, Colour.A)
            {
            }

            ////////////////////////////////////////////////////////////
            /// <summary>
            /// Convert a Colour to a 32-bit unsigned integer
            /// </summary>
            /// <returns>Colour represented as a 32-bit unsigned integer</returns>
            ////////////////////////////////////////////////////////////
            public uint ToInteger()
            {
                return (uint)((R << 24) | (G << 16) | (B << 8) | A);
            }

            ////////////////////////////////////////////////////////////
            /// <summary>
            /// Provide a string describing the object
            /// </summary>
            /// <returns>String description of the object</returns>
            ////////////////////////////////////////////////////////////
            public override string ToString()
            {
                return "[Colour]" +
                       " R(" + R + ")" +
                       " G(" + G + ")" +
                       " B(" + B + ")" +
                       " A(" + A + ")";
            }

            ////////////////////////////////////////////////////////////
            /// <summary>
            /// Compare Colour and object and checks if they are equal
            /// </summary>
            /// <param name="obj">Object to check</param>
            /// <returns>Object and Colour are equal</returns>
            ////////////////////////////////////////////////////////////
            public override bool Equals(object obj)
            {
                return (obj is Colour) && Equals((Colour)obj);
            }

            ///////////////////////////////////////////////////////////
            /// <summary>
            /// Compare two Colours and checks if they are equal
            /// </summary>
            /// <param name="other">Colour to check</param>
            /// <returns>Colours are equal</returns>
            ////////////////////////////////////////////////////////////
            public bool Equals(Colour other)
            {
                return (R == other.R) &&
                       (G == other.G) &&
                       (B == other.B) &&
                       (A == other.A);
            }

            ////////////////////////////////////////////////////////////
            /// <summary>
            /// Provide a integer describing the object
            /// </summary>
            /// <returns>Integer description of the object</returns>
            ////////////////////////////////////////////////////////////
            public override int GetHashCode()
            {
                return (R << 24) | (G << 16) | (B << 8) | A;
            }

            ////////////////////////////////////////////////////////////
            /// <summary>
            /// Compare two Colours and checks if they are equal
            /// </summary>
            /// <returns>Colours are equal</returns>
            ////////////////////////////////////////////////////////////
            public static bool operator ==(Colour left, Colour right)
            {
                return left.Equals(right);
            }

            ////////////////////////////////////////////////////////////
            /// <summary>
            /// Compare two Colours and checks if they are not equal
            /// </summary>
            /// <returns>Colours are not equal</returns>
            ////////////////////////////////////////////////////////////
            public static bool operator !=(Colour left, Colour right)
            {
                return !left.Equals(right);
            }

            ////////////////////////////////////////////////////////////
            /// <summary>
            /// This operator returns the component-wise sum of two Colours.
            /// Components that exceed 255 are clamped to 255.
            /// </summary>
            /// <returns>Result of left + right</returns>
            ////////////////////////////////////////////////////////////
            public static Colour operator +(Colour left, Colour right)
            {
                return new Colour((byte)Math.Min(left.R + right.R, 255),
                                 (byte)Math.Min(left.G + right.G, 255),
                                 (byte)Math.Min(left.B + right.B, 255),
                                 (byte)Math.Min(left.A + right.A, 255));
            }

            ////////////////////////////////////////////////////////////
            /// <summary>
            /// This operator returns the component-wise subtraction of two Colours.
            /// Components below 0 are clamped to 0.
            /// </summary>
            /// <returns>Result of left - right</returns>
            ////////////////////////////////////////////////////////////
            public static Colour operator -(Colour left, Colour right)
            {
                return new Colour((byte)Math.Max(left.R - right.R, 0),
                                 (byte)Math.Max(left.G - right.G, 0),
                                 (byte)Math.Max(left.B - right.B, 0),
                                 (byte)Math.Max(left.A - right.A, 0));
            }

            ////////////////////////////////////////////////////////////
            /// <summary>
            /// This operator returns the component-wise multiplication of two Colours.
            /// Components above 255 are clamped to 255.
            /// </summary>
            /// <returns>Result of left * right</returns>
            ////////////////////////////////////////////////////////////
            public static Colour operator *(Colour left, Colour right)
            {
                return new Colour((byte)Math.Min(left.R * right.R, 255),
                                 (byte)Math.Min(left.G * right.G, 255),
                                 (byte)Math.Min(left.B * right.B, 255),
                                 (byte)Math.Min(left.A * right.A, 255));
            }

            /// <summary>Red component of the Colour</summary>
            public byte R;

            /// <summary>Green component of the Colour</summary>
            public byte G;

            /// <summary>Blue component of the Colour</summary>
            public byte B;

            /// <summary>Alpha (transparent) component of the Colour</summary>
            public byte A;


            /// <summary>Predefined black Colour</summary>
            public static readonly Colour Black = new Colour(0, 0, 0);

            /// <summary>Predefined white Colour</summary>
            public static readonly Colour White = new Colour(255, 255, 255);

            /// <summary>Predefined red Colour</summary>
            public static readonly Colour Red = new Colour(255, 0, 0);

            /// <summary>Predefined green Colour</summary>
            public static readonly Colour Green = new Colour(0, 255, 0);

            /// <summary>Predefined blue Colour</summary>
            public static readonly Colour Blue = new Colour(0, 0, 255);

            /// <summary>Predefined yellow Colour</summary>
            public static readonly Colour Yellow = new Colour(255, 255, 0);

            /// <summary>Predefined magenta Colour</summary>
            public static readonly Colour Magenta = new Colour(255, 0, 255);

            /// <summary>Predefined cyan Colour</summary>
            public static readonly Colour Cyan = new Colour(0, 255, 255);

            /// <summary>Predefined (black) transparent Colour</summary>
            public static readonly Colour Transparent = new Colour(0, 0, 0, 0);
        }
    }


