using Xunit;
using BookDigitalizer.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using OpenCvSharp;

namespace BookDigitalizer.Core.ViewModels.Tests
{
    public class BaseViewModelTests
    {
        [Fact()]
        public void TrueTest()
        {
            Assert.True(true, "This test needs an implementation");
        }
        [Fact()]
        public void OpenCvTest()
        {
            var obj = new Mat();
            Assert.NotNull(obj);
        }
    }
}
