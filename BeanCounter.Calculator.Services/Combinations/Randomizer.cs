namespace BeanCounter.Calculator.Services.Combinations
{
    using System;

    /// <summary>
    /// See <see cref="IRandomizer"/>
    /// </summary>
    public class Randomizer : IRandomizer
    {
        private readonly Random _random = new Random();

        /// <summary>
        /// See <see cref="IRandomizer.GetRandomNumber"/>.
        /// </summary>
        public int GetRandomNumber()
        {
            return this._random.Next();
        }
    }
}
