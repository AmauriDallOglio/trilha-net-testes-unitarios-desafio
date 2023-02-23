using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        //Ao passar um texto escrito a palavra "Matrix", deve retornar o número 6, representando 6 caracteres presentes na palavra

        // Arrange
        var texto = "Matrix";
        var resultadoEsperado = 6;

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        //Ao passar um texto escrito "Esse é um texto qualquer" e procurar pela palavra "qualquer",
        //deve retornar verdadeiro pois a palavra existe no texto

        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";
        bool resultado = _validacoes.ContemCaractere(texto, textoProcurado);
        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";
        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);
        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";
        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);
        // Assert
        Assert.True(resultado);
    }
}
