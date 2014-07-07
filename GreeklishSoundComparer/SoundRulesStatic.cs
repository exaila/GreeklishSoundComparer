using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreeklishSoundComparer
{
    /// <summary>
    /// The initialization of the SoundRules Class.
    /// </summary>
    internal partial class SoundRules
    {
        /// <summary>
        /// Define all possible sound symbols which can be found in the Greek language.
        /// </summary>
        #region MyRegion

        private char ALPHA = 'Α';
        private char SIGMA = 'Σ';
        private char DELTA = 'Δ';
        private char DI = 'D';
        private char FI = 'Φ';
        private char GAMMA = 'Γ';
        private char GKOU = 'G';
        private char HI = 'Χ';
        private char JI = 'J';
        private char KAPPA = 'Κ';
        private char LAMBDA = 'Λ';
        private char ZITA = 'Ζ';
        private char XI = 'Ξ';
        private char PSI = 'Ψ';
        private char BETA = 'Β';
        private char NI = 'Ν';
        private char MI = 'Μ';
        private char PI = 'Π';
        private char OMIKRON = 'Ο';
        private char IOTA = 'Ι';
        private char THITA = 'Θ';
        private char RO = 'Ρ';
        private char EPSILON = 'Ε';
        private char TAU = 'Τ';
        private char BI = '~';
        private char OY = '!';
        private char EPSILON_YPSILON = '$';
        private char ALPHA_YPSILONOY = '#';

        #endregion

        private void Initialize()
        {
            /// chars and CSV are implicitly converted to Sounds
            /// Associate all letters to their sound

            /// English double sounds
            doubleSounds["TH"] = THITA;
            doubleSounds["PS"] = PSI;
            doubleSounds["PH"] = FI;
            doubleSounds["KS"] = XI;
			doubleSounds["CH"] = HI;
            doubleSounds["GG"] = GKOU;
            doubleSounds["OY"] = OY;
            doubleSounds["OU"] = OY;
            doubleSounds["TZ"] = JI;
            doubleSounds["MP"] = BI;
            doubleSounds["AI"] = EPSILON;
            doubleSounds["EY"] = EPSILON_YPSILON;
            doubleSounds["EF"] = EPSILON_YPSILON;
            doubleSounds["AF"] = ALPHA_YPSILONOY;
            doubleSounds["AY"] = ALPHA_YPSILONOY;
            doubleSounds["AU"] = ALPHA_YPSILONOY;
            doubleSounds["EI"] = IOTA;
            doubleSounds["OI"] = IOTA;

            /// Greek double sounds
            doubleSounds["ΓΓ"] = GKOU;
            doubleSounds["ΑΙ"] = EPSILON;
            doubleSounds["ΓΚ"] = GKOU;
            doubleSounds["ΤΖ"] = JI;
            doubleSounds["ΟΥ"] = OY;
            doubleSounds["ΜΠ"] = BI;
            doubleSounds["ΕΥ"] = EPSILON_YPSILON;
            doubleSounds["ΕΦ"] = EPSILON_YPSILON;
            doubleSounds["ΑΦ"] = ALPHA_YPSILONOY;
            doubleSounds["ΑΥ"] = ALPHA_YPSILONOY;
            doubleSounds["ΟΙ"] = IOTA;
            doubleSounds["ΕΙ"] = IOTA;
            doubleSounds["ΚΣ"] = XI;
            doubleSounds["ΠΣ"] = PSI;

            /// English Sounds
            singleSounds['Q'] = KAPPA;
            singleSounds['8'] = THITA;
            singleSounds['9'] = THITA;
            singleSounds['0'] = OMIKRON;
            singleSounds['W'] = OMIKRON;
            singleSounds['O'] = OMIKRON;
            singleSounds['E'] = string.Concat(EPSILON,',',IOTA);
            singleSounds['R'] = RO;
            singleSounds['T'] = TAU;
            singleSounds['Y'] = string.Concat(IOTA,',',GAMMA);
            singleSounds['U'] = string.Concat(IOTA,',',OY);
            singleSounds['I'] = IOTA;            
            singleSounds['P'] = PI;
            singleSounds['A'] = ALPHA;
            singleSounds['S'] = SIGMA;
            singleSounds['D'] = string.Concat(DELTA,',',DI);
            singleSounds['F'] = FI;
            singleSounds['G'] = string.Concat(GKOU,',',GAMMA);
            singleSounds['H'] = string.Concat(IOTA,',',HI);
            singleSounds['J'] = JI;
            singleSounds['K'] = KAPPA;
            singleSounds['L'] = LAMBDA;
            singleSounds['Z'] = ZITA;
            singleSounds['X'] = string.Concat(HI,',',XI);
            singleSounds['C'] = string.Concat(KAPPA,',',SIGMA);
            singleSounds['V'] = BETA;
            singleSounds['B'] = string.Concat(BETA,',',BI);
            singleSounds['N'] = NI;
            singleSounds['M'] = MI;

            /// Greek letters
            singleSounds['Γ'] = GAMMA;
            singleSounds['Ω'] = OMIKRON;
            singleSounds['Η'] = IOTA;
            singleSounds['Ι'] = IOTA;
            singleSounds['Υ'] = IOTA;
            singleSounds['Η'] = IOTA;
            singleSounds['ς'] = SIGMA;
            singleSounds['Ξ'] = XI;

            accentCapitals['Ά'] = ALPHA;
            accentCapitals['Ί'] = IOTA;
            accentCapitals['Ό'] = OMIKRON;
            accentCapitals['Ύ'] = IOTA;
            accentCapitals['Ή'] = IOTA;
            accentCapitals['Έ'] = EPSILON;
            accentCapitals['Ώ'] = OMIKRON;

            /// Find all characters which may start a double symbol sound
            foreach (var key in doubleSounds.Keys)
            {
                if (!startOfDouble.Contains(key[0].ToString()))
                {
                    startOfDouble += key[0];
                }
            }
        }

    }
}
