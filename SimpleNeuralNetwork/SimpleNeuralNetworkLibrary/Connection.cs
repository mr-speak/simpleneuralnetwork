﻿using System;

namespace SimpleNeuralNetworkLibrary
{
    public class Connection
    {
        private bool _isBias;
        private double _activation;

        public bool IsBias
        {
            get { return _isBias; }

            set
            {
                _isBias = value;

                if (_isBias)
                {
                    _activation = 1.0;
                }
            }
        }

        public double Activation
        {
            get
            {
                return _activation;
            }

            set
            {
                if (!_isBias)
                {
                    _activation = value;
                }
            }
        }

        public double Weight { get; set; }

        /// <summary>
        /// Last calculated error signal
        /// </summary>
        public double ErrorSignal { get; set; }
        
        public Neuron Sender { get; set; }

        public Neuron Receiver { get; set; }
    }
}
