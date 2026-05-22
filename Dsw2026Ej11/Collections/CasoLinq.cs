namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;
using System.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{


    private List<Libro> _libros = Libro.CrearLista();

    public Libro? GetPrimero() => _libros.First();
    public Libro? GetUltimo() => _libros.Last();
    public decimal GetTotalPrecios() => _libros.Sum(l => l.Precio);
    public decimal GetPromedioPrecios() =>_libros.Average(l => l.Precio);
    public IEnumerable<Libro> GetListById() => _libros.Where(l => l.Id > 15);
    public IEnumerable<string> GetLibros() => _libros.Select(l => $"{l.Titulo}-{l.Precio:c}");
    public Libro? GetMayorPrecio() => _libros.OrderByDescending(libro => libro.Precio).FirstOrDefault();
    public Libro? GetMenorPrecio() => _libros.OrderBy(libro => libro.Precio).FirstOrDefault();
    public IEnumerable<Libro> GetMayorPromedio() => _libros.Where(l => l.Precio > _libros.Average(x => x.Precio));
    public IEnumerable<Libro> GetOrdenadosPorTitulo() => _libros.OrderByDescending(l => l.Titulo);

}
