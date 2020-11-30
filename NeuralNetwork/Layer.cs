﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
   public class Layer
    {
        public List<Neuron> Neurons { get; }
        public int Count => Neurons?.Count ?? 0;

        public Layer (List<Neuron> neurons , NeuronType type =NeuronType.Normal)
        {
            Neurons = neurons;
        }

        public List<double> GetSignals()
        {
            var result = new List<double>();
            foreach (var neuron in Neurons)
            {
                result.Add(neuron.Output);
            }
            return result;
        }
    }
}
