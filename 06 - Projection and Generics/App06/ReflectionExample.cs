

using System.Reflection;

namespace App06
{
    public class ReflectionExample
    {
        private static void ListGenericMethods(Type type)
        {
            // getting the methods (must be public, and have the "instance" characteristic OR static (see binding flags))
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                .Where(m => m.DeclaringType?.Name != "Object");
            Console.WriteLine("\n \n  @@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine($"This methods are type {type.Name}");
            Console.WriteLine("Name     |IsGeneric      |IsGenericDefinition        |ContainsGenParams");
            int colWidth = 12;

            foreach(var method in methods)
            {
                int maxNameLength = Math.Min(method.Name.Length, colWidth);
                Console.Write(method.Name.Substring(0, maxNameLength).PadRight(colWidth));
                Console.Write("|");
                Console.Write(method.IsGenericMethod.ToString().PadRight(colWidth));
                Console.Write("|");
                Console.Write(method.IsGenericMethodDefinition.ToString().PadRight(colWidth));
                Console.Write("|");
                Console.WriteLine(method.ContainsGenericParameters.ToString().PadRight(colWidth));

                if (method.IsGenericMethod)
                {
                    Console.WriteLine("Executing a generic method");
                    var parameters = method.GetGenericArguments();
                    foreach(var p in parameters)
                    {
                        if (p.IsGenericParameter)
                        {
                            Console.WriteLine($"Generic Param: {p.GenericParameterPosition} {p.Name}");
                        }
                    }

                    MethodInfo genericMethod = method.MakeGenericMethod(typeof(Client)); // we need to pass as argument a Client instance
                    object? instance = null;
                    if (!genericMethod.IsStatic)
                    {
                        instance = Activator.CreateInstance(type)!;
                    }

                    // its static, thats why does need to specify the instance class (using first param as null in case that use a static method)
                    // we use a collection because the method may have multiple params
                    genericMethod.Invoke(instance, new[] { new Client("Kone", "Jo") }); 
                }
            }
        }
        private static void ListTypeDetails(List<Type> types)
        {
            Console.WriteLine("Type name".PadRight(20) + "|" + " IsGenericType?".PadRight(20)
                + "|" + "IsGenericDefinition?".PadRight(20) + "|" + "Generic Arguments"
                );

            foreach(Type type in types)
            {
                string output = type.Name.PadRight(20);
                output += type.IsGenericType.ToString().PadRight(20) + "|";
                output += type.IsGenericTypeDefinition.ToString().PadRight(20) + "|";
                output += type.GetGenericArguments().Count();
                //ListGenericMethods(type);
                Console.WriteLine(output);
                ListParameterDetails(type);
            }
        }

        private static void ListParameterDetails(Type type)
        {
            var parameters = type.GetGenericArguments();

            foreach(var p in parameters)
            {
                if (p.IsGenericParameter)
                {
                    DisplayGenericParameter(p);
                }
                else
                {
                    DisplayTypeArgument(p);
                }
            }
        }

        private static void DisplayGenericParameter(Type parameter)
        {
            Console.WriteLine("~~~~~~~GENERIC PARAMETERS~~~~~~");
            var constrains = parameter.GetGenericParameterConstraints();
            Console.WriteLine($"Type parameter position: {parameter.GenericParameterPosition}   \n" +
                $"name:     {parameter.Name}   \n" +
                $"constrains:   {constrains.Length}   \n" +
                $"attributeMask:     {parameter.GenericParameterAttributes}   \n"
                );


            if (constrains.Any())
            {
                Console.WriteLine(" Name       |        Interface?      |    Class?    |    Enum?");
                foreach (var constraint in constrains)
                {
                    Console.WriteLine("  " + constraint.Name.PadRight(16) + "|" +
                        constraint.IsInterface.ToString().PadRight(16) + "|" +
                        constraint.IsClass.ToString().PadRight(16) + "|" +
                        constraint.IsEnum.ToString().PadRight(16)
                        );
                }
            }
            Console.WriteLine("~~~~~~~~~~~~~ \n \n \n");

        }

        private static void DisplayTypeArgument(Type p)
        {
            Console.WriteLine($"Type argument: {p}");
        }

        public static void execute()
        {

            var types = new List<Type>
            {
                //typeof (IProcessor<>),
                //typeof (IProcessor<Client>),
                //typeof (Processor<>),
                //typeof (Processor<Client>),
                //typeof (ClientProcessor)
                typeof (IPipeline<,>) // IPipeline has two arguments
            };

            ListTypeDetails(types);

            Type[] typeArguments = { typeof(Request), typeof(Response) };
            var specificType = typeof (Pipeline<,>).MakeGenericType(typeArguments);

            var createInstance = Activator.CreateInstance(specificType);

            ListTypeDetails(new List<Type> { createInstance!.GetType() });

            // executing the method of the instance
            ((dynamic)createInstance).ExecuteTask(new Request());

            //var openInterface = typeof(IProcessor<>);
            //Console.WriteLine($"The IProcessor<> is generic? {openInterface.IsGenericType}");
            //Console.WriteLine($"The IProcessor<> has generic definition? {openInterface.IsGenericTypeDefinition}");


            //var closeInterface = typeof(IProcessor<Client>);
            //Console.WriteLine($"The IProcessor<Client> is generic? {closeInterface.IsGenericType}");
            //Console.WriteLine($"The IProcessor<Client> has generic definition? {closeInterface.IsGenericTypeDefinition}");

            //var definition = closeInterface.GetGenericTypeDefinition();

            //var result = definition == openInterface;

            //Console.WriteLine($"The result of definition comparative: {result}");
        }
    }
}
