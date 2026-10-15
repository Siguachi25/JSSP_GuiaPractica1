using Microsoft.VisualStudio.TestTools.UnitTesting;
using JSSP.Temperatura;

namespace JSSP.Temperatura.UnitTestMSTest;

[TestClass]
public class ConvertidorTemperaturaTests
{
    [TestMethod]
    public void CelsiusAFahrenheit_ValorCero_Retorna32()
    {
        // Arrange
        var convertidor = new ConvertidorTemperatura();

        // Act
        double resultado = convertidor.CelsiusAFahrenheit(0);

        // Assert
        Assert.AreEqual(32, resultado);
    }

    [TestMethod]
    public void FahrenheitACelsius_Valor212_Retorna100()
    {
        // Arrange
        var convertidor = new ConvertidorTemperatura();

        // Act
        double resultado = convertidor.FahrenheitACelsius(212);

        // Assert
        Assert.AreEqual(100, resultado);
    }
}