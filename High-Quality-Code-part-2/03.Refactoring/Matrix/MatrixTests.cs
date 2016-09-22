namespace MatrixGame
{
    using Matrix;
    using NUnit.Framework;

    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void IsValidValueAddToMatrix_ValidValues_ReturnTrue()
        {
            int row = 8;
            int col = 8;
            Assert.That(() => GenerateMatrix.ChangeMatrix(ref row, ref col), Throws.Nothing);
        }

        [Test]
        public void IsCheckedMatrixValidation_CheckedValidation_ReturnsTrue()
        {
            int[,] arr = new int[1, 1];
            int x = 0;
            int y = 0;
            bool result = GenerateMatrix.CheckMatrixValidation(arr, x, y);
            Assert.True(result);
        }

        [Test]
        public void IsFindCell_FindedCell_ReturnsTrue()
        {
            int[,] arr = new int[1, 1];
            int x = 0;
            int y = 0;
            Assert.That(() => GenerateMatrix.FindCell(arr, out x, out y), Throws.Nothing);
        }
    }
}
