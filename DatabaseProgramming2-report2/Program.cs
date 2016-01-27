using System;
using System.Threading.Tasks;

namespace DatabaseProgramming2_report2 {

    internal class Program {
        /// <summary>
        ///     The number of users
        /// </summary>
        private const int numberOfUsers = 678;

        /// <summary>
        ///     The number of admins
        /// </summary>
        private static readonly int numberOfAdmins = 4;

        /// <summary>
        ///     Mains the specified arguments.
        /// </summary>
        private static void Main() {
            Parallel.For(0, numberOfUsers, i => Helper.UpdateFirstRow(i));

            Console.ReadLine();
        }
    }

}