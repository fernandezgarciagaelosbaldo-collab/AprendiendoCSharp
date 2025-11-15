namespace Ejercicio20_MenuPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Alumnos> alumnos = new List<Alumnos>();
            List<Materias> materias = new List<Materias>();
            Console.WriteLine("Holaa bienvenido a la Escuela");
            while (true)
            {
                Console.WriteLine("Que quieres hacer , 1-añadir alumono,2-añadir materia,3-mostrar informacion.4-salir");
                string decicion = Console.ReadLine();
                if (decicion != "4")
                {
                    switch (decicion)
                    {
                        case "1":
                            Console.Write("Como se llama ?");
                            string nombre = Console.ReadLine();
                            Console.Write("Cuantos años tiene ?");
                            int edad = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Cual es su promedio ?");
                            double promedio = Convert.ToDouble(Console.ReadLine());
                            alumnos.Add(new Alumnos(nombre, edad, promedio));
                            break;
                        case "2":
                            Console.Write("Nombre de la Materia :");
                            string materia = Console.ReadLine();
                            Console.Write("Horas por semana de la materia :");
                            int horas = Convert.ToInt32(Console.ReadLine());
                            materias.Add(new Materias(materia, horas));
                            break;
                        case "3":
                            Console.WriteLine("elije un numero 1- Te muestro los estudiantes ,2-te muestro las materias , 3- te muestro amabas");
                            int mostrar=Convert.ToInt32(Console.ReadLine());
                            switch (mostrar)
                            {
                                case 1:
                                    foreach (Alumnos a in alumnos) {
                                        a.mostrar_inf();
                                    }
                                    break;
                                    case 2:
                                    foreach (Materias m in materias)
                                    {
                                        m.mostrar_Inf();
                                    }

                                    break;
                                    case 3:
                                    Console.WriteLine("-----------Alumnos----------");
                                    foreach (Alumnos a in alumnos)
                                    {
                                        a.mostrar_inf();
                                    }
                                    Console.WriteLine("----------Materias-----------");
                                    foreach (Materias m in materias)
                                    {
                                        m.mostrar_Inf();
                                    }

                                    break;
                                    default:
                                    Console.WriteLine("Opcion no valida");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Byeee");
                    break;

                }

            }
            
        }
            
        
    }
}
