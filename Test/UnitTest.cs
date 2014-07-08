using System;
using GreeklishSoundComparer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestGreeks()
        {
            Assert.IsTrue(SoundComparer.AreSame("Αθήνα","athina"));
            Assert.IsTrue(SoundComparer.AreSame("Αθήνα", "athina"));
            Assert.IsTrue(SoundComparer.AreSame("τζιτσαγκά", "jitsaga"));
            Assert.IsTrue(SoundComparer.AreSame("Αθήνα", "Athena"));
            Assert.IsTrue(SoundComparer.AreSame("Gilgames G", "Γκιλγγαμες Γ"));

            Assert.IsTrue(SoundComparer.AreSame("", ""));
            Assert.IsTrue(SoundComparer.AreSame("  ", "  "));
            Assert.IsFalse(SoundComparer.AreSame("Αθήνα", ""));
            Assert.IsFalse(SoundComparer.AreSame("", "AAAAA"));

            Assert.IsTrue(SoundComparer.AreSame("Yiannis", "Giannis"));
            Assert.IsTrue(SoundComparer.AreSame("ΕΛΕΟΣ", "ELEOC"));
            Assert.IsTrue(SoundComparer.AreSame("ΕΛΕΟΣ", "eLe0C"));
            Assert.IsTrue(SoundComparer.AreSame("apistefto", "απίστευτο"));
            Assert.IsTrue(SoundComparer.AreSame("sistima", "σύστημα"));
            Assert.IsTrue(SoundComparer.AreSame("einai", "είναι"));
            Assert.IsTrue(SoundComparer.AreSame("pragmatikotita", "πραγματικότητα"));

            Assert.IsTrue(SoundComparer.AreSame("ThaBo", "θάμπό"));
            Assert.IsTrue(SoundComparer.AreSame("Eytih0s", "Ευτηχώς"));
            Assert.IsTrue(SoundComparer.AreSame("Tha Pho Anthrwpoi PSOMY", "ΘΑ ΦΩ ΑΝΘΡΩΠΟΙ ΨΩΜΙ"));

            Assert.IsTrue(SoundComparer.AreSame("Ayto", "Άυτό"));
            Assert.IsTrue(SoundComparer.AreSame("Auto", "Αυτό"));
            Assert.IsTrue(SoundComparer.AreSame("Afto", "Αυτό"));
            Assert.IsTrue(SoundComparer.AreSame("Ayti", "Αφτί"));
            Assert.IsTrue(SoundComparer.AreSame("KSIFIAS", "XIPHIAS"));

            Assert.IsTrue(SoundComparer.AreSame("έχω", "exw"));
            Assert.IsTrue(SoundComparer.AreSame("έξω", "exw"));
            Assert.IsTrue(SoundComparer.AreSame("έχω", "exw"));
            Assert.IsTrue(SoundComparer.AreSame("έχω", "ehw"));
            Assert.IsTrue(SoundComparer.AreSame("έχω", "eho"));
            Assert.IsTrue(SoundComparer.AreSame("έχω", "exo"));
            Assert.IsTrue(SoundComparer.AreSame("exo", "eHo"));
            Assert.IsTrue(SoundComparer.AreSame("Έχω", "Εxo"));
            Assert.IsTrue(SoundComparer.AreSame("έχο", "eh0"));

            Assert.IsTrue(SoundComparer.AreSame("Αθήνα", "a8ina"));
            Assert.IsTrue(SoundComparer.AreSame("Αθήνα", "a9ina"));
            Assert.IsTrue(SoundComparer.AreSame("Αthήνα", "a9ina"));
            Assert.IsTrue(SoundComparer.AreSame("Γιώργος", "Giorgos"));
            Assert.IsTrue(SoundComparer.AreSame("Γιώργος", "giorgος"));
            Assert.IsTrue(SoundComparer.AreSame("Γιώργος", "Giwrgos"));
            Assert.IsTrue(SoundComparer.AreSame("Αλέξανδρος", "Aleksandros"));
            Assert.IsTrue(SoundComparer.AreSame("Αλέξανδρος", "Alexandros"));
            Assert.IsTrue(SoundComparer.AreSame("Αγγέλα", "Aggela"));
            Assert.IsTrue(SoundComparer.AreSame("Αγγέλα", "Agela"));
            Assert.IsTrue(SoundComparer.AreSame("Babis", "Μπάμπης"));
            Assert.IsTrue(SoundComparer.AreSame("Mpampis", "Μπάμπης"));
                
            Assert.IsTrue(SoundComparer.AreSame("athina", "Αθήνα"));
            Assert.IsTrue(SoundComparer.AreSame("Athina", "Αθήνα"));
            Assert.IsTrue(SoundComparer.AreSame("a8ina", "Αθήνα"));
            Assert.IsTrue(SoundComparer.AreSame("Αθήνα", "Αθηνα"));
            Assert.IsTrue(SoundComparer.AreSame("πτεροδάκτυλος", "pterodaktilos"));
            Assert.IsTrue(SoundComparer.AreSame("ΣΚΟΥΛΙΚΟΜΙΡΜΙΓΚΟΤΡΥΠΑΩ", "skoylikomirmiggotripaw"));
            Assert.IsTrue(SoundComparer.AreSame("ΣΚΟΥΛΙΚΟΜΙΡΜΙΓΚΟΤΡΥΠΑΩ", "skoylikomirmigotripaw"));


            Assert.IsFalse(SoundComparer.AreSame("έξω", "έχω"));
            Assert.IsFalse(SoundComparer.AreSame("Υτα", "FTA"));
            Assert.IsFalse(SoundComparer.AreSame("Αθήνα", "patra"));
            Assert.IsFalse(SoundComparer.AreSame("Αθήν", "athina"));
            Assert.IsFalse(SoundComparer.AreSame("Αθήνα", "athin"));
            Assert.IsFalse(SoundComparer.AreSame("Αθή", "athina"));
            Assert.IsFalse(SoundComparer.AreSame("Αθή", "ath"));
            Assert.IsFalse(SoundComparer.AreSame("Αθή", "ath"));
            Assert.IsFalse(SoundComparer.AreSame("Αθή", "ath"));
            Assert.IsFalse(SoundComparer.AreSame("Αθή", "ath"));
            Assert.IsFalse(SoundComparer.AreSame("Αθήα", "athie"));
            Assert.IsFalse(SoundComparer.AreSame("KSIFIA", "XIPHI"));

        }

        [TestMethod]
        public void TestStartsWith()
        {
            Assert.IsFalse(SoundComparer.StartsWith("Αθήνα", "patra"));
            Assert.IsFalse(SoundComparer.StartsWith("Αθήναx", "Αθήναs"));
            Assert.IsFalse(SoundComparer.StartsWith("Αθήνεο", "Αθήνει"));
            Assert.IsFalse(SoundComparer.StartsWith("Αθήνα", "ak"));

            Assert.IsTrue(SoundComparer.StartsWith("Apopse", "Αποψ"));
            Assert.IsTrue(SoundComparer.StartsWith("Αποψε", "Apop"));
            Assert.IsFalse(SoundComparer.StartsWith("Αποψ", "Apopse"));
            Assert.IsFalse(SoundComparer.StartsWith("Αποψε", "Apope"));

            Assert.IsTrue(SoundComparer.StartsWith("Babis", "Μπάμπ"));
            Assert.IsTrue(SoundComparer.StartsWith("Babis", "Μπάμ"));
            Assert.IsTrue(SoundComparer.StartsWith("Babis", "Μ"));
            Assert.IsTrue(SoundComparer.StartsWith("Αθήνα", "athin"));
            Assert.IsTrue(SoundComparer.StartsWith("Αθήνα", "ath"));
            Assert.IsTrue(SoundComparer.StartsWith("Αθήνα", "at"));

            Assert.IsTrue(SoundComparer.StartsWith("Athena", "Αθήνα"));
            Assert.IsTrue(SoundComparer.StartsWith("Athena", "Αθήν"));
            Assert.IsTrue(SoundComparer.StartsWith("Athena", "Αθή"));
            Assert.IsTrue(SoundComparer.StartsWith("Athena", "Αθ"));
            Assert.IsTrue(SoundComparer.StartsWith("Athena", "Α"));

            Assert.IsTrue(SoundComparer.StartsWith("Anthropoi", "Άνθρωποι"));
            Assert.IsTrue(SoundComparer.StartsWith("Anthropoi", "Άνθρωπο"));
            Assert.IsTrue(SoundComparer.StartsWith("Anthropoi", "Άνθρωπ"));
            Assert.IsTrue(SoundComparer.StartsWith("Anthropoi", "Άνθρω"));

            Assert.IsFalse(SoundComparer.StartsWith("Μπά", "Babis"));

            Assert.IsTrue(SoundComparer.StartsWith("ΚΣ", "Κ"));
            Assert.IsTrue(SoundComparer.StartsWith("ΟΞιφίας", "OK"));
            Assert.IsTrue(SoundComparer.StartsWith("ΟΞιφίας", "ΟKSIP"));
            Assert.IsTrue(SoundComparer.StartsWith("ΟΞιφίας", "ΟKSIPH"));
            Assert.IsTrue(SoundComparer.StartsWith("ΟΞιφίας", "ΟKSIPHIAS"));            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExceptionTest()
        {
            SoundComparer.AreSame(null, "ath");
        }
    }
}
