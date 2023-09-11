namespace Ucu.Poo.TestDateFormat
{
/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
 public static string ChangeFormat(string date)
{
    // Verificar si la longitud de la cadena es igual a 10
    if (date.Length != 10)
    {
        return " "; // Devolver un espacio en blanco si la longitud no es válida
    }
    else
    {
        List<char> numeros = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        bool flag = false;
        string fecha = "";

        foreach (char digito in numeros)
        {
            if (flag == true) 
            {
                break;
            }
            if (date[4] != digito)
            {
                fecha = date.Substring(0, 4) + "-" + date.Substring(5, 2) + "-" + date.Substring(8, 2);
            }
            if (date[4] == digito)
            {
                fecha = date.Substring(6, 4) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
                flag = true; 
            }
        }
        return fecha;
    }
}

}
}
