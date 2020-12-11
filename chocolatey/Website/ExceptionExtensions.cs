﻿// Copyright 2017 - 2019 Chocolatey Software
// Copyright 2011 - 2017RealDimensions Software, LLC, the original
// authors/contributors from ChocolateyGallery
// at https://github.com/chocolatey/chocolatey.org,
// and the authors/contributors of NuGetGallery
// at https://github.com/NuGet/NuGetGallery
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;

namespace NuGetGallery
{
    public static class ExceptionExtensions
    {
        public static IEnumerable<Exception> get_inner_exceptions(this Exception ex)
        {
            var exceptions = new List<Exception>();

            var currentException = ex;

            while (currentException.InnerException != null)
            {
                exceptions.Add(currentException);
                currentException = currentException.InnerException;
            }

            exceptions.Add(currentException);

            return exceptions;
        }
    }
}
