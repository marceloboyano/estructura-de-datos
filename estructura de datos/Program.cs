
cliente c1 = new cliente("marcelo", 3434343, "asdasdas", "asdasdsa,", true);
Console.WriteLine(c1.mostrarCliente());

public struct cliente
{
  
    public cliente(string nombre, int telefono, string direccion, string email, bool esNuevoCliente)
    {
        this.nombre = nombre;
        this.telefono = telefono;    
        this.direccion = direccion;  
        this.email = email;  
        this.esNuevoCliente = true;  
    }
public string nombre { get; set; }
public int telefono { get; set;}
public string direccion { get; set; }
public string email { get; set; }
public bool esNuevoCliente { get; set; }

    public string mostrarCliente()
    {
        return "nombre: " + nombre + " telefono: " + telefono + " direccion: " + direccion + " email: " + email + " es nuevo cliente: " + esNuevoCliente;
    }



}