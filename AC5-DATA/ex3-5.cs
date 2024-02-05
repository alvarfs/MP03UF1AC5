// internal class Program
// {
//     struct Empleado
//     {
//         public string nombre;
//         public int edad;
//         public float salario;
//         public Direccion direccion;
//         public struct Direccion
//         {
//             public string calle;
//             public string ciudad;
//             public int codigoPostal;
//         }
//     }
//     private static void Main(string[] args)
//     {
        // 3. Codifica un struct anidado llamado "Empleado" que contenga los siguientes campos:
        //     nombre, edad, salario y un struct interior llamado "Direccion" que contenga los campos:
        //     calle, ciudad y codigo postal.
        
        //     Declara un array de tamaño 3 para almacenar información sobre 3 empleados.
        //     Utilizar un ciclo "foreach" para imprimir la información de cada empleado y su dirección en
        //     pantalla.

    //     Empleado[] empleados = new Empleado[3];

    //     for (int i = 0; i < empleados.Length; i++)
    //     {
    //         System.Console.WriteLine($"- Empleado {i+1} -");
    //         System.Console.Write("Nombre: ");
    //         empleados[i].nombre = Console.ReadLine()!;
    //         System.Console.Write("Edad: ");
    //         empleados[i].edad = Convert.ToInt32(Console.ReadLine());
    //         System.Console.Write("Salario: ");
    //         empleados[i].salario = Convert.ToInt32(Console.ReadLine());
    //         System.Console.Write("Calle: ");
    //         empleados[i].direccion.calle = Console.ReadLine()!;
    //         System.Console.Write("Ciudad: ");
    //         empleados[i].direccion.ciudad = Console.ReadLine()!;
    //         System.Console.Write("Codigo postal: ");
    //         empleados[i].direccion.codigoPostal = Convert.ToInt32(Console.ReadLine());
    //         System.Console.WriteLine();
    //     }

    //     foreach (Empleado empleado in empleados)
    //     {
    //         System.Console.WriteLine($"Nombre: {empleado.nombre}");
    //         System.Console.WriteLine($"Edad: {empleado.edad}");
    //         System.Console.WriteLine($"Salario: {empleado.salario}");
    //         System.Console.WriteLine($"Calle: {empleado.direccion.calle}");
    //         System.Console.WriteLine($"Ciudad: {empleado.direccion.ciudad}");
    //         System.Console.WriteLine($"Codigo postal: {empleado.direccion.codigoPostal}");
    //         System.Console.WriteLine();
    //     }

    //     // 5. Codifica una estructura llamada "Reserva" que contenga los campos: nombre del cliente,
    //     //     apellido y número de teléfono.

    //     //     Codifica un array de booleanos representando los asientos de un teatro. El array de asientos
    //     //     debe tener un tamaño fijo de, por ejemplo, 10 elementos.

    //     //     Declara un array de tamaño 5 para almacenar información sobre 5 reservas. Implementa un
    //     //     menú que permita al usuario realizar las siguientes acciones:

    //     //     Realizar una nueva reserva (indicando el nombre del cliente y los asientos deseados).
    //     //     Mostrar el estado actual de los asientos (indicando si están ocupados o disponibles).
    //     //     Mostrar todas las reservas realizadas.

    //     bool[] teatro = new bool[10];
    //     Reserva[] reservaTeatro = new Reserva[5];
    //     int totalReserva = 0;

    //     int userMenu = 0;

    //     for (int i = 0; i < teatro.Length; i++)
    //     {
    //         teatro[i] = false;
    //     }

    //     do
    //     {
    //         System.Console.WriteLine("1 - Realizar una nueva reserva");
    //         System.Console.WriteLine("2 - Mostrar el estado actual de los asientos");
    //         System.Console.WriteLine("3 - Mostrar todas las reservas realizadas");
    //         System.Console.WriteLine("0 - Salir del menu");
    //         System.Console.Write("Elige opcion: ");
    //         userMenu = Convert.ToInt32(Console.ReadLine());
            
    //         System.Console.WriteLine();

    //         switch (userMenu)
    //         {
    //             case 1:
    //                 System.Console.Write("Nombre: ");
    //                 reservaTeatro[totalReserva].nombre = Console.ReadLine()!;
    //                 System.Console.Write("Apellido: ");
    //                 reservaTeatro[totalReserva].apellido = Console.ReadLine()!;
    //                 System.Console.Write("Telefono: ");
    //                 reservaTeatro[totalReserva].telefono = Convert.ToInt32(Console.ReadLine());

    //                 System.Console.Write("Numero de asiento que desea: ");
    //                 int asientoSelecionado = Convert.ToInt32(Console.ReadLine());

    //                 teatro[asientoSelecionado - 1] = true;
    //                 totalReserva += 1;
    //                 System.Console.WriteLine();
    //                 break;
    //             case 2:
    //                 System.Console.Write("|");
    //                 foreach (bool asiento in teatro)
    //                 {
    //                     if (asiento == false)
    //                     {
    //                         System.Console.Write("Libre");
    //                     }
    //                     else
    //                     {
    //                         System.Console.Write("Ocupado");
    //                     }
    //                     System.Console.Write("|");
    //                 }
    //                 System.Console.WriteLine();
    //                 System.Console.WriteLine();
    //                 break;
    //             case 3:
    //             foreach (Reserva cliente in reservaTeatro)
    //             {
    //                 if (cliente.nombre != null)
    //                 {
    //                     System.Console.WriteLine($"Nombre: {cliente.nombre}");
    //                     System.Console.WriteLine($"Apellido: {cliente.apellido}");
    //                     System.Console.WriteLine($"Telefono: {cliente.telefono}");
    //                     System.Console.WriteLine();
    //                 }
    //             }
    //                 break;
    //             default:
    //                 break;
    //         }
    //     } while(userMenu != 0);

    // }

//     struct Reserva
//     {
//         public string nombre;
//         public string apellido;
//         public int telefono;
//     }
// }