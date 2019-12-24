using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Pay.Here.RNPayHere
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNPayHereModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNPayHereModule"/>.
        /// </summary>
        internal RNPayHereModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNPayHere";
            }
        }
    }
}
