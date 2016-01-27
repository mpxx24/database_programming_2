using System;
using System.Threading.Tasks;

namespace DatabaseProgramming2_report2 {

    internal class Program {
        /// <summary>
        ///     The number of users
        /// </summary>
        private const int numberOfUsers = 678;

        /// <summary>
        ///     Mains the specified arguments.
        /// </summary>
        private static void Main() {
            Parallel.For(0, numberOfUsers, i => Helper.UpdateFirstRow(i));
            //Parallel.For(0, numberOfUsers, i => Helper.InsertData(i));
            //Parallel.For(0, numberOfUsers, i => Helper.DeleteData(i));
            //Parallel.For(0, numberOfUsers, i => Helper.SelectData(i));

            Console.ReadLine();
        }
    }

}