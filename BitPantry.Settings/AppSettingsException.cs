using System;
using System.Collections.Generic;
using System.Text;

namespace BitPantry.Settings
{
    public class AppSettingsException : Exception
    {
        public AppSettingsException(string message, Exception innerException) : base(message, innerException) { }
    }
}
