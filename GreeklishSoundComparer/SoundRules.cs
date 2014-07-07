using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreeklishSoundComparer
{
    /// <summary>
    /// Holds all rules based on which we make the comparisons.
    /// </summary>
    internal partial class SoundRules
    {
        /// <summary>
        /// A dictionary to hold all double character sounds like 'TS' and 'PS'.
        /// </summary>
        private Dictionary<string, Sound> doubleSounds = new Dictionary<string, Sound>();

        /// <summary>
        /// A dictionary to hold all single symbol sounds like 'A' and 'S'
        /// </summary>
        private Dictionary<char, Sound> singleSounds = new Dictionary<char, Sound>();

        /// <summary>
        /// A dictionary to provide an easy way to change Greek accented vowels to 
        /// their non accented form.
        /// </summary>
        private Dictionary<char, char> accentCapitals = new Dictionary<char, char>();

        /// <summary>
        /// A string which contains all chars appearing as the first character of a 
        /// double character sound.
        /// ex. AI, OI , AY, EI => "AOE"
        /// </summary>
        private string startOfDouble = string.Empty;

        public SoundRules()
        {
            Initialize();
        }

        /// <summary>
        /// Compare the two given string and determines if they sound the same.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="startsWith">Indicates if a partial match is considered positive or negative result</param>
        /// <returns></returns>
        internal bool Compare(string first, string second,bool startsWith)
        {
            var enumerator2 = GetNextSound(second, startsWith).GetEnumerator();

            foreach (var sound1 in GetNextSound(first, startsWith))
            {
                if (enumerator2.MoveNext())
                {
                    if (!sound1.Equals(enumerator2.Current))
                    {
                        /// Found a non matching sound thus
                        /// we are sure the two words don't sound the same
                        return false;
                    }
                }
                else
                {
                    /// The first word sounds exactly as second up until now.
                    /// Return true if we check that first starts with second
                    /// Return false if first and second must sound the same.
                    return startsWith;
                }
            }
            
            /// Special case where first is a substring of second
            /// We need to make sure that both string have reached their end.
            if (enumerator2.MoveNext())
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// The core function of the library.
        /// Returns the next sound of the string.
        /// </summary>
        /// <param name="string"></param>
        /// <param name="retrieveAll"></param>
        /// <returns></returns>
        internal IEnumerable<Sound> GetNextSound(string @string,bool retrieveAll)
        {
            /// Used to indicate the beginning of a double char sound
            bool doubleSoundPending = false;

            /// Store the first char of a double symbol sound
            char previousCharacter = '\0';

            @string = @string.ToUpper();
            foreach (var c in @string)
            {
                var character = c;

                /// Remove the acute accent from the character if present
                if (accentCapitals.ContainsKey(character))
                {
                    character = accentCapitals[character];
                }

                /// We have a pending double sound.
                /// Check if the previousCharacter followed up by character is a 
                /// doubleSymbol Sound
                if (doubleSoundPending)
                {
                    doubleSoundPending = false;

                    /// Create the key and check if it exists as a double symbol sounds
                    var key = String.Concat(previousCharacter, character);

                    if (doubleSounds.ContainsKey(key))
                    {
                        yield return doubleSounds[key];                      
                        continue;
                    }
                    else
                    {
                        yield return GetSound(previousCharacter);
                    }
                }

                /// If this character could potentially lead a double symbol
                /// sound we need to check the following character too.
                if (startOfDouble.IndexOf(character) >= 0)
                {
                    doubleSoundPending = true;
                    previousCharacter = character;
                }
                else
                {
                    yield return GetSound(character);
                }
            }

            /// Return any pending sounds
            if (doubleSoundPending)
            {
                if (retrieveAll)
                {
                    yield return GetAllSounds(previousCharacter);
                }
                else
                {
                    yield return GetSound(previousCharacter);
                }                
            }
        }

        /// <summary>
        /// Get the sound of a single character
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        private Sound GetSound(char character)
        {            
            if (singleSounds.ContainsKey(character))
            {
                return singleSounds[character];
            }
            else
            {
                return character;
            }
        }

        /// <summary>
        /// Returns all sounds which are possible starting with the given character.        
        /// </summary>
        /// <example>
        /// p => P, PS, PH
        /// </example>
        /// <param name="character"></param>
        /// <returns></returns>
        private Sound GetAllSounds(char character)
        {
            Sound sound = GetSound(character);

            if (startOfDouble.IndexOf(character) >= 0)
            {
                foreach (var doubleSound in doubleSounds.Where(p => p.Key[0] == character))
                {
                    if (sound != null)
                    {
                        sound = Sound.Append(sound, doubleSound.Value);
                    }
                }
            }

            return sound;
        }
    }
}
