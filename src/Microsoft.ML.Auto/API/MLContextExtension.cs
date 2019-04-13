﻿// Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.ML.Auto
{
    public static class MLContextExtension
    {
        public static AutoMLCatalog Auto(this MLContext mlContext)
        {
            return new AutoMLCatalog(mlContext);
        }
    }
}