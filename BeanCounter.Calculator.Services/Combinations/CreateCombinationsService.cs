namespace BeanCounter.Calculator.Services.Combinations
{
    using System;
    using System.Collections.Generic;
    using BeanCounter.Calculator.Combinations;
    using Input;
    using Base.RuntimeChecks;
    using Input.Constraints;
    using Constraints;
    using System.Linq;

    /// <summary>
    /// See <see cref="ICreateCombinationsService"/>.
    /// </summary>
    public class CreateCombinationsService : ICreateCombinationsService
    {
        private readonly IConstraintValidatorFactory _constraintValidatorFactory;
        private readonly IRandomCombinationGenerator _randomCombinationGenerator;

        /// <summary>
        /// Initializes a new instance of the <see cref="RandomCombinationGenerator"/> class.
        /// </summary>
        public CreateCombinationsService(
            IConstraintValidatorFactory constraintValidatorFactory,
            IRandomCombinationGenerator randomCombinationGenerator)
        {
            ArgumentChecks.AssertNotNull(constraintValidatorFactory, nameof(constraintValidatorFactory));
            ArgumentChecks.AssertNotNull(randomCombinationGenerator, nameof(randomCombinationGenerator));

            this._constraintValidatorFactory = constraintValidatorFactory;
            this._randomCombinationGenerator = randomCombinationGenerator;
        }

        /// <summary>
        ///  See <see cref="ICreateCombinationsService.CreateCombinations(IEnumerable{Feature}, IEnumerable{IConstraint}, Action{ICombination}, Func{bool})"/>.
        /// </summary>
        public void CreateCombinations(
            IEnumerable<Feature> features,
            IEnumerable<IConstraint> contraints,
            Action<ICombination> addCombinationAction,
            Func<bool> shouldKeepCreating,
            int maxNumberOfCombinations)
        {
            ArgumentChecks.AssertNotNull(features, nameof(features));
            ArgumentChecks.AssertNotNull(contraints, nameof(contraints));
            ArgumentChecks.AssertNotNull(addCombinationAction, nameof(addCombinationAction));
            ArgumentChecks.AssertNotNull(shouldKeepCreating, nameof(shouldKeepCreating));
            ArgumentChecks.AssertNotNegative(maxNumberOfCombinations, nameof(maxNumberOfCombinations));

            var alreadyCreatedCombinations = new HashSet<Combination>();
            var constraintValidators = contraints
                .Select(this._constraintValidatorFactory.CreateValidator)
                .ToList();

            while (alreadyCreatedCombinations.Count <= maxNumberOfCombinations &&
                   shouldKeepCreating())
            {
                var combination = this._randomCombinationGenerator.GenerateCombination(features);

                if (alreadyCreatedCombinations.Contains(combination))
                {
                    continue;
                }

                if (constraintValidators.Any(v => !v.IsValid(combination)))
                {
                    continue;
                }

                addCombinationAction(combination);
                alreadyCreatedCombinations.Add(combination);
            }
        }
    }
}
