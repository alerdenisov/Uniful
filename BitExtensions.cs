using System;

namespace Uniful
{
    public static class BitExtensions
    {
        /// <summary>
        /// Sets the bit in byte mask.
        /// </summary>
        /// <returns>The byte value with setted bit.</returns>
        /// <param name="current">Current byte mask.</param>
        /// <param name="position">Position to set bit.</param>
		/// <param name="one">ONE if true; otherwise is ZERO.</param>
        public static byte SetBit(this byte current, byte position, bool one)
        {
            if (one) //set value
                current = (byte)(current | position);
            else //clear value
                current = (byte)(current & (~position));

            return current;
        }

        /// <summary>
        /// Determines if has bits the specified b field.
        /// </summary>
        /// <returns><c>true</c> if has bits the specified b field; otherwise, <c>false</c>.</returns>
        /// <param name="b">The blue component.</param>
        /// <param name="field">Field.</param>
        public static bool HasBits(this byte b, byte field)
        {
            return (b & field) > 0;
        }


		/// <summary>
		/// Dump to bit string the specified byte.
		/// </summary>
		/// <param name="b">The byte value.</param>
		public static string Dump(this byte b) {
			return Convert.ToString(b, 2);
		}

		/// <summary>
		/// Dump to bit string the specified short integer.
		/// </summary>
		/// <param name="s">The short integer value.</param>
		public static string Dump(this short s) {
			return Convert.ToString(s, 2);
		}

		/// <summary>
		/// Dump to bit string the specified integer.
		/// </summary>
		/// <param name="i">The integer value.</param>
		public static string Dump(this int i) {
			return Convert.ToString(i, 2);
		}

        /// <summary>
        /// Pops the count.
        /// </summary>
        /// <returns>The count.</returns>
        /// <param name="b">The blue component.</param>
        public static int PopCount(this byte b)
        {
            int i = b;
            i = i - ((i >> 1) & 0x55555555);
            i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
            return (((i + (i >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24;
        }
    }
}