using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        var caso = new CasoList();

        caso.AgregarAlumno(new Alumno (1, "Victoria", 9));
        caso.AgregarAlumno(new Alumno(2, "Juan", 8.5));
        caso.AgregarAlumno(new Alumno(3, "Ana", 7));

        Console.WriteLine("==== Lista de Alumnos ===");
        foreach (var alumno in caso.GetAlumnos())
            Console.WriteLine(alumno.Nombre);

        Alumno? encontrado = caso.BuscarAlumno("Juan");
        Console.WriteLine($"\nBuscando Juan: {encontrado}");

        Alumno? noExiste = caso.BuscarAlumno("Carlos");
        Console.WriteLine($"Buscando Carlos:{(noExiste == null ? "No existe" : noExiste.ToString())}");

        caso.EliminarAlumno(encontrado!);
        Console.WriteLine("\n===Listado después de eliminar a Juan===");
        foreach(var alumno in caso.GetAlumnos())
            Console.WriteLine(alumno.Nombre);

        caso.EliminarPorPosicion(0);
        Console.WriteLine("\n===Listado después de eliminar el primer elemento==");
        foreach (var alumno in caso.GetAlumnos())
            Console.WriteLine(alumno.Nombre);
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var casoDiccionario = new CasoDictionary();
        casoDiccionario.AgregarAlumno(60911, new Alumno(1, "Juan", 10));
        casoDiccionario.AgregarAlumno(60874, new Alumno(2, "Pedro", 6));
        casoDiccionario.AgregarAlumno(60514, new Alumno(3, "Sofia", 9.5));

        Console.WriteLine("===Diccionario de Alumnos===");
        foreach(var item in casoDiccionario.ObtenerDiccionario())
        {
            Console.WriteLine($"Legajo: {item.Key}-{item.Value}");
        }
        Alumno? encontrado = casoDiccionario.BuscarAlumno(60911);
        if (encontrado != null)
            Console.WriteLine($"\nBuscando legajo 60911: {encontrado}");

        Alumno? noExiste = casoDiccionario.BuscarAlumno(57911);
        if (noExiste == null)
            Console.WriteLine("Buscando legajo 57911: No existe");

        casoDiccionario.EliminarAlumno(60874);
        Console.WriteLine("\n===Diccionario tras eliminar legajo 60874===");
        foreach (var item in casoDiccionario.ObtenerDiccionario())
            Console.WriteLine($"Legajo: {item.Key}- {item.Value}");
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        var listaLibros = Libro.CrearLista();
        var casoLinq = new CasoLinq();

        Console.WriteLine("===1.Primer Libro===");
        Libro? primero = casoLinq.GetPrimero();
        if (primero != null)
            Console.WriteLine($"{primero.Id} - {primero.Titulo} . {primero.Precio:c}");


        Console.WriteLine("\n===2.Ultimo Libro===");
        Libro? ultimo = casoLinq.GetUltimo();
        if (ultimo != null)
            Console.WriteLine($"{ultimo.Id} - {ultimo.Titulo} . {ultimo.Precio:c}");

        Console.WriteLine("\n===3.Total precios===");
        Console.WriteLine(casoLinq.GetTotalPrecios());

        Console.WriteLine("\n===4.Promedio de precios===");
        Console.WriteLine(casoLinq.GetPromedioPrecios());

        Console.WriteLine("\n===5.Libros con Id mayor a 15===");
        foreach (var libro in casoLinq.GetListById())
            Console.WriteLine($"{libro.Id}-{libro.Titulo}-{libro.Precio:c}");

        Console.WriteLine("\n===6.Titulos y precios en formato moneda===");
        foreach (var item in casoLinq.GetLibros())
            Console.WriteLine(item);

        Console.WriteLine("\n===7.Mayor Precio===");
        Libro? mayorPrecio = casoLinq.GetMayorPrecio();
        if (mayorPrecio != null)
            Console.WriteLine($"{mayorPrecio.Id}-{mayorPrecio.Titulo}-{mayorPrecio.Precio:c}");

        Console.WriteLine("\n===8.Menor Precio===");
        Libro? menorPrecio = casoLinq.GetMenorPrecio();
        if(menorPrecio != null)
            Console.WriteLine($"{menorPrecio.Id}-{menorPrecio.Titulo}-{menorPrecio.Precio:c}");

        Console.WriteLine("\n===9.Libros sobre el promedio===");
        foreach (var libro in casoLinq.GetMayorPromedio())
            Console.WriteLine($"{libro.Id}-{libro.Titulo}-{libro.Precio:c}");

        Console.WriteLine("\n===10.Libros Ordenados por titulo===");
        foreach (var libro in casoLinq.GetOrdenadosPorTitulo())
            Console.WriteLine($"{libro.Id}-{libro.Titulo}-{libro.Precio:c}");
    }
}
