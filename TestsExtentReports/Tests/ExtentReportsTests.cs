﻿using NUnit.Framework;
using TestsExtentReports.Common;
using Utils.Reports.Extent;

namespace TestsExtentReports.Tests;
//
// Summary:
//      Sample Selenium tests: positive and negative scenarios
// Run:
//      dotnet test .\bin\Debug\net8.0\TestsExtentReports.dll
    internal class ExtentReportsTests : TestBase
    {
        [Test]
        public void WriteToTextAreaTest()
        {
            ExtentReporting.Instance.LogInfo("Starting test - submit form");

            var text = Guid.NewGuid().ToString();
            var expectedMessage = "Received!";

            var message =
                 WebForm?
                 .WriteTextToTextArea(text)
                 .SubmitForm()
                 .GetMessage();

            Assert.That(message, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void WriteToTextAreaNegativeTest()
        {
            ExtentReporting.Instance.LogInfo("Starting negative test - submit form");

            var text = Guid.NewGuid().ToString();
            var expectedMessage = "Received failed!";

            var message =
                 WebForm?
                 .WriteTextToTextArea(text)
                 .SubmitForm()
                 .GetMessage();

            Assert.That(message, Is.EqualTo(expectedMessage));
        }
    }