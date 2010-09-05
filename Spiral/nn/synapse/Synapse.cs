using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace spiral.nn.synapse
{
    public class Synapse
    {
        #region Data Members
        private Neuron source;
        private Neuron target;
        private float weight;
        private float value;
        private float input;
        private bool frozen;
        #endregion

        #region Events
        #endregion

        #region Properties
        public Neuron Source
        {
            get { return source; }
        }

        public Neuron Target
        {
            get { return target; }
        }

        public bool Freeze
        {
            get { return frozen; }
            set { frozen = value; }
        }
        #endregion

        public Synapse(Neuron source, Neuron target)
        {
        }

        public void PutInput(float input)
        {
        }

        public void PutWeight(float weight)
        {
        }

        private void CalculateSum()
        {
        }

    }
}
