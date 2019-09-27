﻿using SimpleNeuralNetworkLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNeuralNetworkConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new MnistDataSource(
                @"E:\data\train-images-idx3-ubyte.gz",
                @"E:\data\train-labels-idx1-ubyte.gz",
                @"E:\data\t10k-images-idx3-ubyte.gz",
                @"E:\data\t10k-labels-idx1-ubyte.gz");

            var numDimensions = 28 * 28;
            var numClasses = 10;

            var config = new ArtificialNeuralNetworkConfig
            {
                InputDimensions = numDimensions,
                NeuronCounts = new int[] { 128, 128, numClasses }
            };

            var ann = new ArtificialNeuralNetwork(config);

            var dataPoint = dataSource.TrainingData.First().AsDouble().Cast<double>().ToArray();
            var result = ann.Classify(dataPoint);
        }
    }
}
