using System;

namespace Agero.Core.Checker
{
    /// <summary>Helper class that helps assert assumptions in the code</summary>
    public static class Check
    {
        /// <summary>Makes sure argument is not null</summary>
        /// <param name="argument">Argument</param>
        /// <param name="argumentName">Argument name</param>
        /// <exception cref="ArgumentNullException">Thrown if argument is null</exception>
        public static void ArgumentIsNull<TArgument>(TArgument argument, string argumentName)
            where TArgument : class
        {
            if (argument == null)
                throw new ArgumentNullException(argumentName, $"Argument '{argumentName}' cannot be null.");
        }

        /// <summary>Makes sure string argument is not null and not empty</summary>
        /// <param name="argument">String argument</param>
        /// <param name="argumentName">Argument name</param>
        /// <exception cref="ArgumentException">Thrown if string argument is null or empty</exception>
        public static void ArgumentIsNullOrEmpty(string argument, string argumentName)
        {
            if (string.IsNullOrEmpty(argument))
                throw new ArgumentException($"Argument '{argumentName}' cannot be null or empty string.", argumentName);
        }

        /// <summary>Makes sure string argument is not null, not empty or has not only spaces</summary>
        /// <param name="argument">String argument</param>
        /// <param name="argumentName">Argument name</param>
        /// <exception cref="ArgumentException">Thrown if string argument is null, empty or has only spaces</exception>
        public static void ArgumentIsNullOrWhiteSpace(string argument, string argumentName)
        {
            if (string.IsNullOrWhiteSpace(argument))
                throw new ArgumentException($"Argument '{argumentName}' cannot be null or empty string or contain only whitespaces.", argumentName);
        }

        /// <summary>Makes sure argument meets specified condition</summary>
        /// <param name="condition">Argument condition</param>
        /// <param name="description">Condition description</param>
        /// <exception cref="ArgumentException">Thrown if argument does not meet specified condition</exception>
        public static void Argument(bool condition, string description)
        {
            if (!condition)
                throw new ArgumentException($"Argument does not meet the following '{description}' restriction.");
        }

        /// <summary>Makes sure condition is valid</summary>
        /// <param name="condition">Condition</param>
        /// <param name="description">Condition description</param>
        /// <exception cref="InvalidOperationException">Thrown if specified condition is not valid</exception>
        public static void Assert(bool condition, string description)
        {
            if (!condition)
                throw new InvalidOperationException(description);
        }
    }
}