using System;
using System.Collections;
using System.Collections.Generic;


namespace spiral.nn.layer
{
    public abstract class Layer
    {
        #region Data Members
        private string title;
        private int id;

        private List<Neuron> neurons;
        #endregion

        #region Properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public List<Neuron> Neurons
        {
            get { return neurons; }
        }

        public int Length
        {
            get { return neurons.Count; }
        }
        #endregion

        #region Static Data Members
        private static List<Layer> allLayers = new List<Layer>();
        #endregion

        #region Static Properties
        public static List<Layer> Layers
        {
            get { return allLayers; }
        }
        #endregion

        public Layer()
        {
            allLayers.Add(this);
        }

        public Layer(string title)
        {
            allLayers.Add(this);
        }

        public bool ConnectTo(Layer target)
        {
            return false;
        }

        public bool DisconnectFrom(Layer target)
        {
            return false;
        }

        public bool IsConnectedWith(Layer target)
        {
            return false;
        }

        public bool PutWeights(float[] weights)
        {
            return false;
        }

        public bool PutInputs(float[] inputs)
        {
            return false;
        }

        public Neuron this[int index]
        {
            get
            {
                if (index > neurons.Count)
                    return null;

                return neurons[index];
            }
        }

    }
}
