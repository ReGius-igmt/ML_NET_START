﻿
// This file was auto-generated by ML.NET Model Builder. 

using System;

namespace MLModel1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
            {
                Message = @"Go until jurong point, crazy.. Available only in bugis n great world la e buffet... Cine there got amore wat...",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = MLModel1.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Spam with predicted Spam from sample data...\n\n");


            Console.WriteLine($"Spam: {0F}");
            Console.WriteLine($"Message: {@"Go until jurong point, crazy.. Available only in bugis n great world la e buffet... Cine there got amore wat..."}");


            Console.WriteLine($"\n\nPredicted Spam: {predictionResult.Prediction}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}