internal class Program
{
    struct Employee
    {
        public string name;
        public int age;
        public float salary;
        public string nameEmp;
    }

    struct Producto
    {
        public string nombre;
        public float precio;
        public int cantidad;
        public bool categoria;
    }

    struct Empleado
    {
        public string nombre;
        public int edad;
        public float salario;
        public Direccion direccion;
        public struct Direccion
        {
            public string calle;
            public string ciudad;
            public int codigoPostal;
        }
    }

    struct Reserva
    {
        public string nombre;
        public string apellido;
        public int telefono;
    }

    private static void Main(string[] args)
    {
        // 1. Crear una estruct "Empleado" que contenga los siguientes campos: nombre, edad, salario y
        //     nombreEmpresa.

        //     Crea un array de longitud 5 para guardar registros.

        //     Genera un menú para guardar o mostrar registros (introducirá los 5 y mostrará los 5).

        Employee[] employees = new Employee[5];
        int menuSelection = 0;

        do
        {
            System.Console.WriteLine("1 - GUARDAR REGISTRO");
            System.Console.WriteLine("2 - MOSTRAR REGISTROS");
            System.Console.WriteLine("0 - SALIR DEL PROGRAMA");
            System.Console.Write("Elige una opcion: ");
            menuSelection = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine();

            switch (menuSelection)
            {
                case 0:

                    break;

                case 1:
                    for (int i = 0; i < employees.Length; i++)
                    {
                        System.Console.Write("nombre: ");
                        employees[i].name = Console.ReadLine()!;
                        System.Console.Write("edad: ");
                        employees[i].age = Convert.ToInt32(Console.ReadLine());
                        System.Console.Write("salario: ");
                        employees[i].salary = float.Parse(Console.ReadLine()!);
                        System.Console.Write("nombre empresa: ");
                        employees[i].nameEmp = Console.ReadLine()!;
                    }
                    
                    break;

                case 2:
                    for (int i = 0; i < employees.Length; i++)
                    {
                        Console.WriteLine($"empleado {i+1}");
                        Console.WriteLine($"nombre: {employees[i].name}");
                        Console.WriteLine($"edad: {employees[i].age}");
                        Console.WriteLine($"salario: {employees[i].salary}");
                        Console.WriteLine($"nombre empresa: {employees[i].nameEmp}");
                        System.Console.WriteLine();
                    }

                    break;

                default:
                    System.Console.WriteLine("ESA OPCION NO EXISTE!!");
                    break;
            }

            System.Console.WriteLine();

        } while (menuSelection != 0);
        
        // 2. Codifica una estructura anidada llamada "Producto" que contenga los siguientes campos:
        //     nombre, precio cantidad y categoria (true == alimentación).

        //     Guarda los datos un un array de tamaño [2,5] para almacenar información sobre 5 productos
        //     de cada categoría (deberás comprobar si el array está lleno y avisar al usuario) guarda en el
        //     primer array unidimensional los productos de alimentación y en el segundo, los de otro tipo.

        //     codifica un menu con switch-case para mostrar todos los productos de alimentación o todos
        //     los productos de la categoria general. Además, crearás otras opciones para calcular el
        //     importe total de los productos almacenados y el total de los productos de cada categoría

        Producto[,] productos = new Producto[2,5];
        bool categoriaProducto = true;
        int userOption = 0;

        System.Console.WriteLine("PRODUCTOS:");
        System.Console.WriteLine();

        for (int i = 0; i < 2; i++)
        {
            if (categoriaProducto)
            {
                System.Console.WriteLine("ALIMENTACION:");
            }
            else
            {
                System.Console.WriteLine("GENERAL:");
            }
            System.Console.WriteLine();

            for (int j = 0; j < 5; j++)
            {
                System.Console.WriteLine($"Producto {j+1}:");
                System.Console.Write("nombre: ");
                productos[i,j].nombre = Console.ReadLine()!;
                System.Console.Write("precio: ");
                productos[i,j].precio = float.Parse(Console.ReadLine()!);
                System.Console.Write("cantidad: ");
                productos[i,j].cantidad = Convert.ToInt32(Console.ReadLine());
                productos[i,j].categoria = categoriaProducto;
                System.Console.WriteLine();
            }
            categoriaProducto = false;
        }

        do
        {
            System.Console.WriteLine("1 - Mostrar productos de alimentacion");
            System.Console.WriteLine("2 - Mostrar productos generales");
            System.Console.WriteLine("3 - Importe total de los productos almacenados");
            System.Console.WriteLine("4 - Total de los productos de cada categoría");
            System.Console.WriteLine("0 - Salir del menu");
            Console.Write("Elige opcion: ");
            userOption = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine();

            switch (userOption)
            {
                case 1:
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"Nombre producto: {productos[0,i].nombre}");
                        Console.Write($"Precio: {productos[0,i].precio} ");
                        Console.WriteLine($"Cantidad: {productos[0,i].cantidad}");
                        System.Console.WriteLine();
                    }

                    break;
                
                case 2:
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"Nombre producto: {productos[1,i].nombre}");
                        Console.Write($"Precio: {productos[1,i].precio} ");
                        Console.WriteLine($"Precio: {productos[1,i].cantidad}");
                        System.Console.WriteLine();
                    }

                    break;
                
                case 3:
                    float totalImp = 0;

                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            int cantidadProd = productos[i,j].cantidad;
                            float precioProd = productos[i,j].precio;
                            totalImp += (precioProd * cantidadProd);
                        }
                    }

                    System.Console.WriteLine($"Importe total de todos los productos: {totalImp}");
                    System.Console.WriteLine();

                    break;
                
                case 4:
                    for (int i = 0; i < 2; i++)
                    {
                        int totalCategoria = 0;
                        for (int j = 0; j < 5; j++)
                        {
                            totalCategoria += productos[i,j].cantidad;
                        }

                        if (i==0)
                        {
                            System.Console.WriteLine($"Total categoría Alimentacion: {totalCategoria}");
                        }
                        else
                        {
                            System.Console.WriteLine($"Total categoría General: {totalCategoria}");
                        }

                        System.Console.WriteLine();
                    }

                    break;

                default:
                    System.Console.WriteLine();

                    break;
            }
        } while(userOption != 0);

        // 3. Codifica un struct anidado llamado "Empleado" que contenga los siguientes campos:
        //     nombre, edad, salario y un struct interior llamado "Direccion" que contenga los campos:
        //     calle, ciudad y codigo postal.
        
        //     Declara un array de tamaño 3 para almacenar información sobre 3 empleados.
        //     Utilizar un ciclo "foreach" para imprimir la información de cada empleado y su dirección en
        //     pantalla.

        Empleado[] empleados = new Empleado[3];

        for (int i = 0; i < empleados.Length; i++)
        {
            System.Console.WriteLine($"- Empleado {i+1} -");
            System.Console.Write("Nombre: ");
            empleados[i].nombre = Console.ReadLine()!;
            System.Console.Write("Edad: ");
            empleados[i].edad = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Salario: ");
            empleados[i].salario = float.Parse(Console.ReadLine()!);
            System.Console.Write("Calle: ");
            empleados[i].direccion.calle = Console.ReadLine()!;
            System.Console.Write("Ciudad: ");
            empleados[i].direccion.ciudad = Console.ReadLine()!;
            System.Console.Write("Codigo postal: ");
            empleados[i].direccion.codigoPostal = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine();
        }

        foreach (Empleado empleado in empleados)
        {
            System.Console.WriteLine($"- - - - - - Nombre: {empleado.nombre} - - - - - -");
            System.Console.Write($"| Edad: {empleado.edad} ");
            System.Console.Write($"| Salario: {empleado.salario} ");
            System.Console.Write($"| Calle: {empleado.direccion.calle} ");
            System.Console.Write($"| Ciudad: {empleado.direccion.ciudad} ");
            System.Console.WriteLine($"| Codigo postal: {empleado.direccion.codigoPostal} ");
            System.Console.WriteLine();
        }

        // 4. Declara un array bidimensional de tamaño [2, 5] para almacenar información sobre 5
        //     productos de cada categoría. Avisa al usuario si el array está lleno.
        //     Crea un menú con un bloque switch-case que permita al usuario realizar las siguientes
        //     acciones:

        //     Agregar un producto de alimentación.
        //     Agregar un producto de otra categoría.
        //     Mostrar todos los productos de alimentación.
        //     Mostrar todos los productos de la categoría general.
        //     Calcular el importe total de los productos almacenados.
        //     Calcular el total de los productos de cada categoría.
        //     Salir del programa.

        Producto[,] productos_v2 = new Producto[2,5];
        int indexA = 0;
        int indexG = 0;
        int userSelect = 0;

        do
        {
            System.Console.WriteLine("1 - Agregar un producto de alimentación.");
            System.Console.WriteLine("2 - Agregar un producto de otra categoría.");
            System.Console.WriteLine("3 - Mostrar productos de alimentacion");
            System.Console.WriteLine("4 - Mostrar productos generales");
            System.Console.WriteLine("5 - Importe total de los productos almacenados");
            System.Console.WriteLine("6 - Total de los productos de cada categoría");
            System.Console.WriteLine("0 - Salir del menu");
            Console.Write("Elige opcion: ");
            userSelect = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine();

            switch (userSelect)
            {
                case 1:
                    if (indexA < 5)
                    {
                        System.Console.Write("producto: ");
                        productos_v2[0,indexA].nombre = Console.ReadLine()!;
                        System.Console.Write("precio: ");
                        productos_v2[0,indexA].precio = float.Parse(Console.ReadLine()!);
                        System.Console.Write("cantidad: ");
                        productos_v2[0,indexA].cantidad = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine();

                        indexA += 1;
                    }
                    else
                    {
                        System.Console.WriteLine("No se pueden introducir mas productos de alimentacion!");
                        System.Console.WriteLine();
                    }  
                    break;
                
                case 2:
                    if (indexG < 5)
                    {
                        System.Console.Write("producto: ");
                        productos_v2[1,indexG].nombre = Console.ReadLine()!;
                        System.Console.Write("precio: ");
                        productos_v2[1,indexG].precio = float.Parse(Console.ReadLine()!);
                        System.Console.Write("cantidad: ");
                        productos_v2[1,indexG].cantidad = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine();

                        indexG += 1;
                    }
                    else
                    {
                        System.Console.WriteLine("No se pueden introducir mas productos de alimentacion!");
                        System.Console.WriteLine();
                    }  

                    break;

                case 3:
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"Nombre producto: {productos_v2[0,i].nombre}");
                        Console.Write($"Precio: {productos_v2[0,i].precio} ");
                        Console.WriteLine($"Cantidad: {productos_v2[0,i].cantidad}");
                        System.Console.WriteLine();
                    }

                    break;
                
                case 4:
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"Nombre producto: {productos_v2[1,i].nombre}");
                        Console.Write($"Precio: {productos_v2[1,i].precio} ");
                        Console.WriteLine($"Precio: {productos_v2[1,i].cantidad}");
                        System.Console.WriteLine();
                    }

                    break;
                
                case 5:
                    float totalImp = 0;

                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            int cantidadProd = productos_v2[i,j].cantidad;
                            float precioProd = productos_v2[i,j].precio;
                            totalImp += (precioProd * cantidadProd);
                        }
                    }

                    System.Console.WriteLine($"Importe total de todos los productos: {totalImp}");
                    System.Console.WriteLine();

                    break;
                
                case 6:
                    for (int i = 0; i < 2; i++)
                    {
                        int totalCategoria = 0;
                        for (int j = 0; j < 5; j++)
                        {
                            totalCategoria += productos_v2[i,j].cantidad;
                        }

                        if (i==0)
                        {
                            System.Console.WriteLine($"Total categoría Alimentacion: {totalCategoria}");
                        }
                        else
                        {
                            System.Console.WriteLine($"Total categoría General: {totalCategoria}");
                        }

                        System.Console.WriteLine();
                    }

                    break;

                default:
                    System.Console.WriteLine();

                    break;
            }
        } while(userSelect != 0);

        // 5. Codifica una estructura llamada "Reserva" que contenga los campos: nombre del cliente,
        //     apellido y número de teléfono.

        //     Codifica un array de booleanos representando los asientos de un teatro. El array de asientos
        //     debe tener un tamaño fijo de, por ejemplo, 10 elementos.

        //     Declara un array de tamaño 5 para almacenar información sobre 5 reservas. Implementa un
        //     menú que permita al usuario realizar las siguientes acciones:

        //     Realizar una nueva reserva (indicando el nombre del cliente y los asientos deseados).
        //     Mostrar el estado actual de los asientos (indicando si están ocupados o disponibles).
        //     Mostrar todas las reservas realizadas.

        bool[] teatro = new bool[10];
        Reserva[] reservaTeatro = new Reserva[5];
        int totalReserva = 0;

        int userMenu = 0;

        for (int i = 0; i < teatro.Length; i++)
        {
            teatro[i] = false;
        }

        do
        {
            System.Console.WriteLine("1 - Realizar una nueva reserva");
            System.Console.WriteLine("2 - Mostrar el estado actual de los asientos");
            System.Console.WriteLine("3 - Mostrar todas las reservas realizadas");
            System.Console.WriteLine("0 - Salir del menu");
            System.Console.Write("Elige opcion: ");
            userMenu = Convert.ToInt32(Console.ReadLine());
            
            System.Console.WriteLine();

            switch (userMenu)
            {
                case 1:
                    System.Console.Write("Nombre: ");
                    reservaTeatro[totalReserva].nombre = Console.ReadLine()!;
                    System.Console.Write("Apellido: ");
                    reservaTeatro[totalReserva].apellido = Console.ReadLine()!;
                    System.Console.Write("Telefono: ");
                    reservaTeatro[totalReserva].telefono = Convert.ToInt32(Console.ReadLine());

                    System.Console.Write("Numero de asiento que desea: ");
                    int asientoSelecionado = Convert.ToInt32(Console.ReadLine());

                    teatro[asientoSelecionado - 1] = true;
                    totalReserva += 1;
                    System.Console.WriteLine();
                    break;
                case 2:
                    System.Console.Write("|");
                    foreach (bool asiento in teatro)
                    {
                        if (asiento == false)
                        {
                            System.Console.Write("O");
                        }
                        else
                        {
                            System.Console.Write("X");
                        }
                        System.Console.Write("|");
                    }
                    System.Console.WriteLine();
                    System.Console.WriteLine();
                    break;
                case 3:
                foreach (Reserva cliente in reservaTeatro)
                {
                    if (cliente.nombre != null)
                    {
                        System.Console.WriteLine($"Nombre: {cliente.nombre}");
                        System.Console.WriteLine($"Apellido: {cliente.apellido}");
                        System.Console.WriteLine($"Telefono: {cliente.telefono}");
                        System.Console.WriteLine();
                    }
                }
                    break;
                default:
                    break;
            }
        } while(userMenu != 0);
    }
}