﻿using System;
using Gatekeeper.Localization;

namespace Gatekeeper.Validations
{
    public partial class Contract<T>
    {
        /// <summary>
        /// Requires two Guids are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(Guid val, Guid comparer, string key) =>
            AreEquals(val, comparer, key, GatekeeperErrorMessages.AreEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two Guids are equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreEquals(Guid val, Guid comparer, string key, string message)
        {
            if (val != comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires two Guids are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(Guid val, Guid comparer, string key) =>
            AreNotEquals(val, comparer, key, GatekeeperErrorMessages.AreNotEqualsErrorMessage(val.ToString(), comparer.ToString()));

        /// <summary>
        /// Requires two Guids are not equals
        /// </summary>
        /// <param name="val"></param>
        /// <param name="comparer"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> AreNotEquals(Guid val, Guid comparer, string key, string message)
        {
            if (val == comparer)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a Guid is empty
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsEmpty(Guid val, string key) =>
            IsEmpty(val, key, GatekeeperErrorMessages.IsEmptyErrorMessage(key));

        /// <summary>
        /// Requires a Guid is empty
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsEmpty(Guid val, string key, string message)
        {
            if (val != Guid.Empty)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requires a Guid is not empty
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Contract<T> IsNotEmpty(Guid val, string key) =>
            IsNotEmpty(val, key, GatekeeperErrorMessages.IsNotEmptyErrorMessage(key));

        /// <summary>
        /// Requires a Guid is not empty
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Contract<T> IsNotEmpty(Guid val, string key, string message)
        {
            if (val == Guid.Empty)
                AddNotification(key, message);

            return this;
        }
    }
}
