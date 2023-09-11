using Ucu.Poo.TestDateFormat;
namespace Library.Tests;

public class DateFormatterTests
{
    [Test]
    public void Test_Mas_Caracteres()
    {
       const string fecha_11_Caracteres="11/11/11111 ";//11 caracteres
       string fecha_11_cahr_pasada_por_la_funcion = DateFormatter.ChangeFormat(fecha_11_Caracteres);
       Assert.AreEqual(" ", fecha_11_cahr_pasada_por_la_funcion);
    }

    [Test]
    public void Test_Espacio_Vacio()
    {
       const string fecha_vacia=" ";
       string fecha_vacia_pasada_por_la_funcion = DateFormatter.ChangeFormat(fecha_vacia );
       Assert.AreEqual(" ", fecha_vacia_pasada_por_la_funcion);
    }

    [Test]
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    
    public void Test_Formato_Correcto()
    {
        const string fecha_correcta ="20/02/2020";
        string fecha_correcta_pasada_por_la_funcion= DateFormatter.ChangeFormat (fecha_correcta);
        Assert.AreEqual ("2020-02-20", fecha_correcta_pasada_por_la_funcion);
    }

    [Test]
    public void Test_Todo_Cero()
    {
        const string Fecha_Todo_cero ="00/00/0000";
        string  Fecha_Todo_Cero_Por_La_Funcion = DateFormatter.ChangeFormat (Fecha_Todo_cero);
        Assert.AreEqual ("0000-00-00", Fecha_Todo_Cero_Por_La_Funcion);
    }

    [Test]
    public void Test_Formato_Fecha_Al_Revez()
    {
        const string Fecha_Al_Revez ="2023/02/02";
        string  Fecha_Al_Revez_Por_La_Funcion = DateFormatter.ChangeFormat (Fecha_Al_Revez);
        Assert.AreEqual ("2023-02-02", Fecha_Al_Revez_Por_La_Funcion);

    }
    
    
    [Test]
    public void Test_Formato_Incorrecto_sin_signo_de_division_al_revez()
    {
        const string Fecha_Formato_Incorrecto_Al_Revez ="2023*02*02";
        string  Fecha_Foamto_Incorrecto_Al_Revez_Por_La_Funcion = DateFormatter.ChangeFormat (Fecha_Formato_Incorrecto_Al_Revez);
        Assert.AreEqual ("2023-02-02", Fecha_Foamto_Incorrecto_Al_Revez_Por_La_Funcion);
    }
}