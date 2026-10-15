namespace JSSP.CadenaTexto;

public class ManipuladorCadena
{
    public string Invertir(string texto)
    {
        if (string.IsNullOrEmpty(texto)) return texto;
        char[] array = texto.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }

    public bool EsPalindromo(string texto)
    {
        if (string.IsNullOrWhiteSpace(texto)) return false;
        string limpia = texto.Replace(" ", "").ToLower();
        string invertida = Invertir(limpia);
        return limpia == invertida;
    }
}
