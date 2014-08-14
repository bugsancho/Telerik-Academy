namespace ComputersSystem
{
    using System;
    using Computers;
    using Manufacturers;

    public class ComputerSystemEntryPoint
    {
        private static void Main()
        {
            var manufacturerName = Console.ReadLine();
            IManufacturerFactory manufacturerFactory = new ManufacturerFactory();
            IManufacturer manufacturer = manufacturerFactory.GetManufacturer(manufacturerName);

            IPersonalComputer pc = manufacturer.CreatePersonalComputer();
            ILaptop laptop = manufacturer.CreateLaptop();
            IServer server = manufacturer.CreateServer();

            while (true)
            {
                var command = Console.ReadLine();
                if (command == null || command.StartsWith("Exit"))
                {
                    break;
                }

                var commandParts = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (commandParts.Length != 2)
                {
                    {
                        throw new ArgumentException("Invalid command!");
                    }
                }

                var commandName = commandParts[0];
                var commandArgument = int.Parse(commandParts[1]);

                if (commandName == "Charge")
                {
                    laptop.Charge(commandArgument);
                }
                else if (commandName == "Process")
                {
                    server.ProccessNumber(commandArgument);
                }
                else if (commandName == "Play")
                {
                    pc.Play(commandArgument);
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }
        }
    }
}