namespace BeanCounter.Calculator.Test.Combinations
{
    using System;
    using BeanCounter.Calculator.Services.Combinations;

    /// <summary>
    /// Implementation of <see cref="IRandomizer"/> for testing purposes -- is supposed
    /// to deliver "random-like" but stable output.
    /// </summary>
    public class PseudoRandomizer : IRandomizer
    {
        private readonly Random _random;

        /// <summary>
        /// Initializes a new instance of the <see cref="PseudoRandomizer"/> class.
        /// </summary>
        public PseudoRandomizer(int seed)
        {
            this._random = new Random(seed);
        }

        /// <summary>
        /// See <see cref="IRandomizer.GetRandomNumber"/>.
        /// </summary>
        public int GetRandomNumber()
        {
            var pseudoRandomNumber = this._random.Next();

            return pseudoRandomNumber;
        }
    }
}
