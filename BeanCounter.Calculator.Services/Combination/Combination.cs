﻿namespace BeanCounter.Calculator.Services.Combination
{
    using Base.RuntimeChecks;
    using Calculator.Combination;
    using Input;
    using System.Collections.Generic;
    using System.Security.Policy;

    /// <summary>
    /// Implements <see cref="ICombination"/>. Also provides a particular hash code.
    /// </summary>
    public class Combination : ICombination
    {
        private readonly int _hashCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="Combination"/> class.
        /// </summary>
        public Combination(IReadOnlyList<Feature> features)
        {
            ArgumentChecks.AssertNotNull(features, nameof(features));

            this.Features = features;

            this._hashCode = CalculateHashCode(features);
        }

        /// <summary>
        /// Gets the features.
        /// </summary>
        public IReadOnlyList<Feature> Features { get; }

        /// <summary>
        /// See <see cref="object.GetHashCode"/>.
        /// </summary>
        public override int GetHashCode()
        {
            return this._hashCode;
        }

        /// <summary>
        /// Calculates the hash code in such a fashion that the same features in the
        /// same order will result in an equal hash code, no matter the that combination
        /// is represented by the same actual <see cref="Combination"/> instance.
        /// </summary>
        private static int CalculateHashCode(IReadOnlyList<Feature> features)
        {
            unchecked
            {
                var hashCode = features.Count;
                foreach(var feature in features)
                {
                    hashCode = hashCode * 23 + feature.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}
