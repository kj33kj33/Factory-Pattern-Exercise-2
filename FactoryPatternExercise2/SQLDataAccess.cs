﻿using System;
namespace FactoryPatternExercise2
{
	public class SQLDataAccess : IDataAccess
	{
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from a SQL database..");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a SQL database..");
        }
    }
}

