/*
EJERCICIO 1 - CLASES Y OBJETOS
 1) El supermercado “Eureka” posee un problema al vender productos que no se descuenta del stock
existente.
Se requiere realizar el modelado de las clases del stock de un supermercado, donde se detalle la
clase Producto con sus dos clases hijas: Bebida y Alimento, que posean un método que haga
referencia a la venta de un producto y descuente la cantidad vendida del stock existente.
 */
using System;

namespace Sample
{
    class Test
    {
        public static void Main(string[] args)
        {
            //EJERCICIO 1
            //mostrarDatosDeProducto();
            //EJERCICIO 2
            //mostrarDatosDeTriangulo();
            //mostrarDatosDeCirculo();
            //EJERCICIO 3
            //probarCuentaMayor();
            //probarCuentaMenor();
            //probarCuentaEstudiante();
            //EJERCICIO 4
        }
        public static void probarCuentaMayor()
        {
            CuentaMayor cuentaMayor = new CuentaMayor(123456, "Jhuly Lopez", 22, 1000);
            cuentaMayor.mostrarInfo();
            cuentaMayor.ingresarMonto(2000);
            cuentaMayor.esMayor();
            cuentaMayor.mostrarInfo();
            cuentaMayor.retirarMonto(3000);
            cuentaMayor.mostrarInfo();
        }
        public static void probarCuentaEstudiante()
        {
            CuentaEstudiante cuentaEstudiante = new CuentaEstudiante(123456, "Mateo Olivera", 12, 1000);
            cuentaEstudiante.mostrarInfo();
            cuentaEstudiante.ingresarMonto(4000);
            cuentaEstudiante.mostrarInfo();
            cuentaEstudiante.retirarMonto(3000);
            cuentaEstudiante.mostrarInfo();
        }
        public static void probarCuentaMenor()
        {
            CuentaMenor cuentaMenor = new CuentaMenor(123456, "Marcelo Olivera", 17, 1000);
            cuentaMenor.mostrarInfo();
            cuentaMenor.ingresarMonto(500);
            cuentaMenor.mostrarInfo();
            cuentaMenor.retirarMonto(200);
            cuentaMenor.mostrarInfo();
        }
        public static void mostrarDatosDeProducto()
        {
            Bebida bebida1 = new Bebida(1, "Pepsi", 10, 1.20, "Refresco", "PepsiCo");
            Bebida bebida2 = new Bebida(2, "Coca-Cola", 5, 1.50, "Refresco", "Coca-Cola Company");
            bebida1.mostrarDatos();
            bebida2.mostrarDatos();
            bebida1.ventaDeProducto(5);
            bebida1.mostrarDatosdeBebida();
        }
        public static void mostrarDatosDeTriangulo()
        {
            Triangulo triangulo = new Triangulo();
            Console.WriteLine("Ingrese la base del triangulo: ");
            double baseTriangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo: ");
            double alturaTriangulo = double.Parse(Console.ReadLine());
            triangulo.calcularArea(baseTriangulo, alturaTriangulo);
            triangulo.mostrarArea();
        }
        public static void mostrarDatosDeCirculo()
        {
            Circulo circulo = new Circulo();
            Console.WriteLine("Ingresar el diametro del circulo: ");
            double diametro = double.Parse(Console.ReadLine());
            circulo.calcularArea(diametro);
            circulo.mostrarArea();
        }
    }
    public class Producto
    {
        public int id;
        public string nombre;
        public int stock;
        public double precio;

        public Producto(int id, string nombre, int stock, double precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }
        public void ventaDeProducto(int cantidad)
        {
            this.stock = stock - cantidad;
        }
        public void mostrarDatos()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Stock: " + this.stock);
            Console.WriteLine("Precio: " + this.precio);
        }
    }
    public class Bebida : Producto
    {
        public string tipoBebida;
        public string marca;
        public Bebida(int id, string nombre, int stock, double precio, string tipoBebida, string marca) : base(id, nombre, stock, precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.stock = stock;
            this.precio = precio;
            this.tipoBebida = tipoBebida;
            this.marca = marca;
        }

        public void mostrarDatosdeBebida()
        {
            base.mostrarDatos();
            Console.WriteLine("Tipo de bebida: " + this.tipoBebida);
            Console.WriteLine("Marca: " + this.marca);
        }
    }
    /* 
    2) Se requiere un programa que nos ayude a calcular el área de un Triangulo, de un Cuadrado y de
    un Circulo y que éstas clases dependan de la clase Figura, la cual debe tener un método que sea
    mostrarArea, donde debe consulte el valor de la variable area y si no es nulo, mostrar por consola
    el valor.
    */
    public class Figura
    {
        public double? area;
        /* public Figura(double area)
        {
            this.area = area;
        } */
        public void mostrarArea()
        {
            if (area != null)
            {
                Console.WriteLine("El area es: " + this.area);
            }
            else
            {
                Console.WriteLine("El area es nulo, pruebe de nuevo cargando area");
            }

        }
    }
    public class Circulo : Figura
    {
        public double diametro;
        public double radio;
        public void calcularArea(double diametro)
        {
            double pi = Math.PI;
            this.diametro = diametro;
            this.radio = this.diametro / 2;
            this.area = pi * Math.Pow(this.radio, 2);
        }

    }
    public class Triangulo : Figura
    {
        public double baseDeTriangulo;
        public double altura;
        public void calcularArea(double baseDeTriangulo, double altura)
        {
            this.baseDeTriangulo = baseDeTriangulo;
            this.altura = altura;
            this.area = this.baseDeTriangulo * this.altura / 2;
        }
    }
}
/* 
3) Se requiere que se defina la clase Cuenta con métodos que permitan ingresarMonto(int
montoASumar), retirarMonto(int montoARestar) mostrar información de la cuenta
(nro_cuenta, nombre, saldo, estado_cuenta) de la cuenta y definir las clases CuentaMayor,
CuentaMenor y CuentaEstudiante que puedan ejecutar estos métodos.
En el caso de CuentaMayor, crear un método que consulte si la persona es mayor de 18 años.
*/
public class Cuenta
{
    public int nro_cuenta;
    public string nombre = "";
    public int edad;
    public double saldo;
    public string estado_cuenta = "Activo";
    public Cuenta(int nro_cuenta, string nombre, int edad, double saldo)
    {
        this.nro_cuenta = nro_cuenta;
        this.nombre = nombre;
        this.edad = edad;
        this.saldo = saldo;
    }
    public void ingresarMonto(int montoAsumar)
    {
        this.saldo = this.saldo + montoAsumar;
    }
    public void retirarMonto(int montoARestar)
    {
        this.saldo = this.saldo - montoARestar;
    }

    public void mostrarInfo()
    {
        Console.WriteLine("Numero de cuenta: " + this.nro_cuenta);
        Console.WriteLine("Nombre: " + this.nombre);
        Console.WriteLine("Edad: " + this.edad);
        Console.WriteLine("Saldo: " + this.saldo);
        Console.WriteLine("Estado de cuenta: " + this.estado_cuenta);
    }
}
public class CuentaMayor : Cuenta
{
    public CuentaMayor(int nro_cuenta, string nombre, int edad, double saldo) : base(nro_cuenta, nombre, edad, saldo)
    {
        this.nro_cuenta = nro_cuenta;
        this.nombre = nombre;
        this.edad = edad;
        this.saldo = saldo;
    }
    public void esMayor()
    {
        if (this.edad >= 18)
        {
            Console.WriteLine("Es mayor de edad");
        }
        else
        {
            Console.WriteLine("Es menor de edad");
        }
    }
}
public class CuentaMenor : Cuenta
{
    public CuentaMenor(int nro_cuenta, string nombre, int edad, double saldo) : base(nro_cuenta, nombre, edad, saldo)
    {
        this.nro_cuenta = nro_cuenta;
        this.nombre = nombre;
        this.edad = edad;
        this.saldo = saldo;
    }
}
public class CuentaEstudiante : Cuenta
{
    public CuentaEstudiante(int nro_cuenta, string nombre, int edad, double saldo) : base(nro_cuenta, nombre, edad, saldo)
    {
        this.nro_cuenta = nro_cuenta;
        this.nombre = nombre;
        this.edad = edad;
        this.saldo = saldo;
    }
}
/* 
4) Definir la clase Empleado, con nombre, apellido, telefono, email, dni y sueldo.
Definir la clase DptoSistemas (para el Departamento de Sistemas) que posea el área en la
que trabaja de Sistemas, si posee titulo relacionado a su trabajo, si posee una computadora laboral a
su cargo y cantidad de gente a cargo.
Definir la clase Programador donde se almacene en que lenguaje de programación trabaja, si
es senior, semisenior o junior y la cantidad de veces que tumbó producción.
Crear un método mostrar información del empleado en la clase Programador donde muestre
toda la información requerida.
 */
public class Empleado
{
    public string nombre = "";
    public string apellido = "";

    public string telefono = "";
    public string email = "";

    public int dni;
    public double sueldo;
    public Empleado(string nombre, string apellido, string telefono, string email, int dni, double sueldo)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.telefono = telefono;
        this.email = email;
        this.dni = dni;
        this.sueldo = sueldo;
    }

}

public class Programador : Empleado
{
    public string lenguaje;
    public string seniority;
    public int vecesEnProduccion;
    public DptoSistemas dptoSistemas;
    public Programador(string nombre, string apellido, string telefono, string email, int dni, double sueldo, string lenguaje, string seniority, int vecesEnProduccion, int cantidadDeGenteACargo, bool tieneTitulo, bool poseeCompu, string areaDeTrabajo) : base(nombre, apellido, telefono, email, dni, sueldo)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.telefono = telefono;
        this.email = email;
        this.dni = dni;
        this.sueldo = sueldo;
        this.lenguaje = lenguaje;
        this.seniority = seniority;
        this.vecesEnProduccion = vecesEnProduccion;
        this.dptoSistemas = new DptoSistemas(
            tieneTitulo: tieneTitulo,
            poseeCompu: poseeCompu,
            cantidadDeGenteACargo: cantidadDeGenteACargo,
            areaDeTrabajo: areaDeTrabajo
        );
    }
    public void mostrarInfo()
    {
        Console.WriteLine("Nombre: " + this.nombre);
        Console.WriteLine("Apellido: " + this.apellido);
        Console.WriteLine("Telefono: " + this.telefono);
        Console.WriteLine("Email: " + this.email);
        Console.WriteLine("DNI: " + this.dni);
        Console.WriteLine("Sueldo: " + this.sueldo);
        Console.WriteLine("Lenguaje: " + this.lenguaje);
        Console.WriteLine("Seniority: " + this.seniority);
        Console.WriteLine("Veces en produccion: " + this.vecesEnProduccion);
        Console.WriteLine("Cantidad de gente a cargo: " + this.dptoSistemas.cantidadDeGenteACargo);
        Console.WriteLine("Tiene titulo: " + this.dptoSistemas.tieneTitulo);
        Console.WriteLine("Posee computadora: " + this.dptoSistemas.poseeCompu);
        Console.WriteLine("Area de trabajo: " + this.dptoSistemas.areaDeTrabajo);
    }
}
public class DptoSistemas
{
    public bool tieneTitulo;
    public string areaDeTrabajo = "Sin Area";

    public bool poseeCompu;

    public int cantidadDeGenteACargo;
    public DptoSistemas(bool tieneTitulo, bool poseeCompu, int cantidadDeGenteACargo, string areaDeTrabajo)
    {
        this.tieneTitulo = tieneTitulo;
        this.poseeCompu = poseeCompu;
        this.cantidadDeGenteACargo = cantidadDeGenteACargo;
        this.areaDeTrabajo = areaDeTrabajo;
    }

}
/* 5) Definir la clase Ambiente y generar los objetos: “Desarrollo”, “Testing”, “Preproduccion” y
“Produccion” que posea un método que sea verificarDespliegue y comprobar que la información
del Ambiente sea igual a: “sistema_operativo: linux, ram:4, base_datos: postgresql, app: openjdk”,
si es correcto mostrar por pantalla que el despliegue se puede realizar, de lo contrario, mostrar que
no será posible realizar el despliegue.
 */
public class Ambiente
{
    public string nombre = "Sin nombre";
    public string sistema_operativo = "linux";
    public int ram = 4;
    public string base_datos = "postgresql";
    public string app = "Sin app";

    public Ambiente(string nombre, string sistema_operativo, int ram, string base_datos, string app)
    {
        this.nombre = nombre;
        this.sistema_operativo = sistema_operativo;
        this.ram = ram;
        this.base_datos = base_datos;
        this.app = app;
    }
    public void verificarDespliege()
    {
        if (this.sistema_operativo == "linux" && this.ram >= 4 && this.base_datos == "postgresql" && this.app == "appjdk")
        {
            Console.WriteLine("El ambiente es apto para el despliegue de la app: " + this.app);
        }
        else
        {
            Console.WriteLine("El ambiente no es apto para el despliegue de la app: " + this.app);
        }
    }
}
/* 
6) Crear la clase Persona, con un método que compare la edad de una persona con otra.
(Se deben crear dos objetos de la clase persona, y ejecutar el método compararEdad en persona2,
pasando como parámetro la edad de persona1).
 */
public class Persona
{
    public string nombre = "Sin nombre";
    public int edad = 0;
    public Persona(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }
    public void mostrarDatos()
    {
        Console.WriteLine("Nombre: " + this.nombre);
        Console.WriteLine("EDAD: " + this.edad);
    }
    public void compararEdad(int edad)
    {
        if (this.edad == edad)
        {
            Console.WriteLine($"La edad de {this.nombre} es igual a: " + this.edad);
        }
        else if (this.edad > edad)
        {
            Console.WriteLine($"La edad de {this.nombre} es mayor a: " + this.edad);
        }
        else
        {
            Console.WriteLine($"La edad de {this.nombre} es menor a: " + this.edad);
        }
    }
}
/* 
7) Definir la clase Tren y su hija, Vagón. Se deben crear los métodos vagonLleno, ascelerar(int
velocidad) y frenar.
 */
public class Tren{
    public double velocidad = 0;
    public Tren(int velocidad){
        this.velocidad = velocidad;
    }
    public void acelerar(int velocidad){
        this.velocidad = velocidad;
    }
    public void frenar(){
        this.velocidad = 0;
    }
    public void mostrarVelocidad(){
        Console.WriteLine("La velocidad del tren es: " + this.velocidad);
    }
}
public class Vagon : Tren{
    public int capacidad = 250;
    public Vagon(int velocidad, int capacidad) : base(velocidad){
        this.capacidad = capacidad;
    }
    public void vagonLleno(){
        if (this.capacidad == 0){
            Console.WriteLine("El vagon esta lleno");
        }else{
            Console.WriteLine("El vagon no esta lleno");
        }
    }
    public void agregarCapacidad(int capacidad){
        this.capacidad = this.capacidad + capacidad;
    }
    public void quitarCapacidad(int capacidad){
        this.capacidad = this.capacidad - capacidad;
    }
}