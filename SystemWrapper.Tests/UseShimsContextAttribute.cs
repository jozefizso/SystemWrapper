using System;

using Microsoft.QualityTools.Testing.Fakes;

using NUnit.Framework;

namespace SystemWrapper.Tests
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class UseShimsContextAttribute : Attribute, ITestAction
    {
        private IDisposable _context;

        public ActionTargets Targets
        {
            get
            {
                return ActionTargets.Test;
            }
        }

        public void BeforeTest(TestDetails testDetails)
        {
            this._context = ShimsContext.Create();
        }

        public void AfterTest(TestDetails testDetails)
        {
            if (this._context != null)
            {
                this._context.Dispose();
            }
        }
    }
}
