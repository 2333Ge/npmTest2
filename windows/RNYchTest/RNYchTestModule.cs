using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Ych.Test.RNYchTest
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNYchTestModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNYchTestModule"/>.
        /// </summary>
        internal RNYchTestModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNYchTest";
            }
        }
    }
}
