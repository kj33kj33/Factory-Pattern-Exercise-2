using System;
namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess
	{
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from a List database..");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a List database..");
        }
    }
}

