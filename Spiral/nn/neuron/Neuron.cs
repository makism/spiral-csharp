using System;
using System.Collections;
using System.Collections.Generic;


namespace spiral.nn
{
    public class Neuron
    {
        #region Data members
        // A short title for the neuron
        private string title;
        // The id of the neuron.
        private int id;
        // The id of the layer that this neurons belongs to.
        private int layerId;
        
        // The total number of inputs.
        private int numberOfInputs;
        // The total number of synapses that the neuron has.
        private int numberOfSynapses;
        //
        //private int numberOfSynapsesFired;
        //
        private List<synapse.Synapse> synapses;
        
        // The current value of the neuron.
        private float value;
        //private int valueAccessed;
        
        // The input value;
        private float input;
        
        private bool hasActivated;
        private bool autoActivation;
        #endregion

        #region Properties
        public string Title
        {
            get { return title; }
        }

        public int Id
        {
            get { return id; }
        }

        public int LayerId
        {
            get { return layerId; }
        }

        public int NumberOfInputs
        {
            get { return numberOfInputs; }
        }

        public float Value
        {
            get { return value; }
        }

        public float Input
        {
            get { return input; }
        }

        public bool HasActivated
        {
            get { return hasActivated; }
        }

        public bool AutoActivation
        {
            get { return autoActivation; }
            set { autoActivation = value; }
        }
        #endregion


        public Neuron(int Id, int LayerId)
        {
            this.id = Id;
            this.layerId = LayerId;
        }

        public Neuron(int Id, int LayerId, string Title)
        {
            this.id = Id;
            this.layerId = LayerId;
            this.title = Title;
        }

        public synapse.Synapse CreateSynapse(int LayerId, int NeuronId)
        {
            return null;
        }

        public synapse.Synapse CreateSynapse(layer.Layer layer, Neuron neuron)
        {
            return null;
        }

        public void PutInput(float value)
        {
        }

        public void PutWeight(float weight)
        {
        }


    }
}
