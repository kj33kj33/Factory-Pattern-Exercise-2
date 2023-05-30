namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogging.Greeting();

            var databaseType = Console.ReadLine();

            ConsoleLogging.DatabaseAccessText();

            IDataAccess database = DataAccessFactory.GetDataAccessType(databaseType);

            database.LoadData();
            database.SaveData();
        }
    }
}
