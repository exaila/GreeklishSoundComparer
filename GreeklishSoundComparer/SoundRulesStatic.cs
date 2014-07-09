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

        private const char ALPHA = 'Α';
        private const char SIGMA = 'Σ';
        private const char DELTA = 'Δ';
        private const char DI = 'D';
        private const char FI = 'Φ';
        private const char GAMMA = 'Γ';
        private const char GKOU = 'G';
        private const char HI = 'Χ';
        private const char JI = 'J';
        private const char KAPPA = 'Κ';
        private const char LAMBDA = 'Λ';
        private const char ZITA = 'Ζ';
        private const char XI = 'Ξ';
        private const char PSI = 'Ψ';
        private const char BETA = 'Β';
        private const char NI = 'Ν';
        private const char MI = 'Μ';
        private const char PI = 'Π';
        private const char OMIKRON = 'Ο';
        private const char IOTA = 'Ι';
        private const char THITA = 'Θ';
        private const char RO = 'Ρ';
        private const char EPSILON = 'Ε';
        private const char TAU = 'Τ';
        private const char BI = '~';
        private const char OY = '!';
        private const char EPSILON_YPSILON = '$';
        private const char ALPHA_YPSILONOY = '#';

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

			/// Spelling ignoring rules
			doubleSounds["NN"] = NI;
            doubleSounds["SS"] = SIGMA;
			doubleSounds["LL"] = LAMBDA;
            doubleSounds["RR"] = RO;
			
			doubleSounds["ΝΝ"] = NI;
            doubleSounds["ΣΣ"] = SIGMA;
			doubleSounds["ΛΛ"] = LAMBDA;
            doubleSounds["ΡΡ"] = RO;
			
			
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
			singleSounds['3'] = XI;
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
			accentCapitals['ΐ'] = IOTA;
			accentCapitals['Ϊ'] = IOTA;
            accentCapitals['Ό'] = OMIKRON;
            accentCapitals['Ύ'] = IOTA;
			accentCapitals['Ϋ'] = IOTA;
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
