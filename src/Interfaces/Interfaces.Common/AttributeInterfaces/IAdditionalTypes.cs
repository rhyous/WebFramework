﻿using System;

namespace Rhyous.WebFramework.Interfaces
{
    /// <summary>
    /// The interface is used to enforce that AdditionalWebServiceTypesAttribute and AdditionalServiceTypesAttribute have a common interface.
    /// </summary>
    public interface IAdditionalTypes
    {
        /// <summary>
        /// The additional generic types.
        /// </summary>
        Type[] Types { get; set; }
    }
}