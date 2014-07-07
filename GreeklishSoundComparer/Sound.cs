using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace GreeklishSoundComparer
{
    /// <summary>
    /// This class holds all different sounds a single symbol can be associated with.
    /// <example> H can be associated with the sound X and the sound I </example>
    /// </summary>
    public class Sound
    {
        /// <summary>
        /// All different sounds symbols associated with this Sound.
        /// </summary>
        private char[] soundSymbols;

        public Sound(params char[] soundSymbols)
        {
            this.soundSymbols = soundSymbols;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static implicit operator Sound(char c)
        {
            return new Sound(c);
        }

        /// <summary>
        /// Converts implicitly a CSV string into a sound containing an array of all values.
        /// </summary>
        /// <param name="chars"></param>
        /// <returns></returns>
        public static implicit operator Sound(string chars)
        {
            var sounds = chars.Split(',');

            char[] soundSymbols = new char[sounds.Length];

            int i = 0;
            foreach(var sound in sounds)
            {
                soundSymbols[i] = Convert.ToChar(sound);
                i++;
            }

            return new Sound(soundSymbols);
        }

        /// <summary>
        /// Combines two different sounds into a new one
        /// </summary>
        /// <param name="sound1"></param>
        /// <param name="sound2"></param>
        /// <returns></returns>
        public static Sound Append(Sound sound1,Sound sound2)
        {
            int length = sound1.soundSymbols.Length + sound2.soundSymbols.Length;

            char[] soundSymbols = new char[length];

            Array.Copy(sound1.soundSymbols,0, soundSymbols, 0, sound1.soundSymbols.Length);
            Array.Copy(sound2.soundSymbols,0, soundSymbols,sound1.soundSymbols.Length, sound2.soundSymbols.Length);

            return new Sound(soundSymbols);
        }

        /// <summary>
        /// Determines if two different sounds are equal.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var other = obj as Sound;

            if (other == null)
            {
                return false;
            }

            foreach (var s1 in soundSymbols)
            {
                foreach (var s2 in other.soundSymbols)
                {
                    if (s1 == s2)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public override string ToString()
        {
            string output = string.Empty;
            foreach (var c in soundSymbols)
            {
                output += c;
            }

            return output;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
