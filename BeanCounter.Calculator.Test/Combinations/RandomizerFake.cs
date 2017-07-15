namespace BeanCounter.Calculator.Test.Combinations
{
    using System.Linq;
    using BeanCounter.Calculator.Services.Combinations;

    /// <summary>
    /// Fake implementation of <see cref="IRandomizer"/>.
    /// </summary>
    public class RandomizerFake : IRandomizer
    {
        private readonly int[] _numbers;
        private int _currentIndex;

        /// <summary>
        /// Initializes a new instance of the <see cref="RandomizerFake"/> class.
        /// </summary>
        public RandomizerFake(params int[] numbers)
        {
            if (numbers.Any())
            {
                this._numbers = numbers;
            }
            else
            {
                this._numbers = new[] { 0 };
            }

            this._currentIndex = 0;
        }

        public int GetRandomNumber()
        {
            var number = this._numbers[this._currentIndex];
            this._currentIndex = (this._currentIndex + 1) % this._numbers.Count();

            return number;
        }
    }
}
