// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Eson">
//   copyright Eson org
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace HelloGithub
{
    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The test.
        /// </summary>
        public const string Test = "HAHA";

        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Github !!!");

            Console.WriteLine(Test);

            Console.Read();
        }
    }
}
