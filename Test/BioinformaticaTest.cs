using Microsoft.VisualStudio.TestTools.UnitTesting;
using Metodi;

namespace Test
{
    [TestClass]
    public class BioinformaticaTest
    {
        [TestMethod]
        public void TestLunghezza()
        {
            int file1 = BioinformaticaMetodi.Lunghezza("sensibile.txt");
            int file2 = BioinformaticaMetodi.Lunghezza("resistente.txt");
            int risposta1 = 3901;
            int risposta2 = 3901;
            Assert.AreEqual(risposta1, file1);
            Assert.AreEqual(risposta2, file2);
        }

        [DataTestMethod]
        [DataRow("sensibile.txt", "resistente.txt", 3901, 3901)]
        public void DataTestLunghezza(string file1, string file2, int risposta1, int risposta2)
        {
            int lunghezza1 = BioinformaticaMetodi.Lunghezza(file1);
            int lunghezza2 = BioinformaticaMetodi.Lunghezza(file2);
            Assert.AreEqual(risposta1, lunghezza1);
            Assert.AreEqual(risposta2, lunghezza2);
        }
    }
}
