using Xunit;
using JSSP.CadenaTexto;

namespace JSSP.CadenaTexto.UnitTestAppxUnit;

public class ManipuladorCadenaTests
{
    [Fact]
    public void Invertir_CadenaHola_RetornaAloh()
    {
        // Arrange
        var manipulador = new ManipuladorCadena();

        // Act
        string resultado = manipulador.Invertir("Hola");

        // Assert
        Assert.Equal("aloH", resultado);
    }

    [Theory]
    [InlineData("reconocer", true)]
    [InlineData("anilina", true)]
    [InlineData("csharp", false)]
    public void EsPalindromo_ValidarVariasCadenas_RetornaEsperado(string texto, bool esperado)
    {
        // Arrange
        var manipulador = new ManipuladorCadena();

        // Act
        bool resultado = manipulador.EsPalindromo(texto);

        // Assert
        Assert.Equal(esperado, resultado);
    }
}