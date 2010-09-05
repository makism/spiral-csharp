using System;

using spiral;


namespace TestNeuron
{
    class TestNeuron
    {
        public static void Main(String[] args)
        {
            spiral.nn.Neuron n1 = new spiral.nn.Neuron(0, 0);
            spiral.nn.Neuron n2 = new spiral.nn.Neuron(0, 1);

            n1.CreateSynapse(1, 0);
        }
    }
}
