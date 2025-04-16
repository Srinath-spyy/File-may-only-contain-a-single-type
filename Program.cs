using System;

namespace TaskSchedulerApp
{
    /// <summary>
    /// The main program entry point.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method to demonstrate task scheduling.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        public static void Main(string[] args)
        {
            var scheduler = new TaskScheduler();

            // Adding tasks
            scheduler.AddTask("Compile");
            scheduler.AddTask("Test");
            scheduler.AddTask("Deploy");

            // Adding dependencies
            scheduler.AddDependency("Test", "Compile");
            scheduler.AddDependency("Deploy", "Test");

            // Executing tasks
            try
            {
                scheduler.ExecuteTasks();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}