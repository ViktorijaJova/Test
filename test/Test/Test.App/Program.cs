using System;
using Test.Services.Services;

namespace Test.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var userService = new StudentService();

            userService.Register();
            Console.ReadLine();

        }
    }
}
