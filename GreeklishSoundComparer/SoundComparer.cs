using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreeklishSoundComparer
{
    public class SoundComparer
    {
        /// <summary>
        /// The rules based on which the comparison is done.
        /// </summary>
        private static SoundRules rules = new SoundRules();

        /// <summary>
        /// Check if first and second sound he same.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static bool AreSame(string first,string second)
        {
            if (first == null)
            {
                throw new ArgumentNullException("first");
            }

            if (second == null)
            {
                throw new ArgumentNullException("second");
            }

            return rules.Compare(first, second,false);
        }

        /// <summary>
        /// Check if first starts with second.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static bool StartsWith(string first, string second)
        {
            if (first == null)
            {
                throw new ArgumentNullException("first");
            }

            if (second == null)
            {
                throw new ArgumentNullException("second");
            }

            return rules.Compare(first, second, true);
        }
    }
}
