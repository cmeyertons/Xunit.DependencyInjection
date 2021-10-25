﻿using System.Reflection;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Xunit.DependencyInjection
{
    public sealed class DependencyInjectionTestFramework : XunitTestFramework
    {
        public DependencyInjectionTestFramework(IMessageSink messageSink) : base(messageSink) { }

        protected override ITestFrameworkExecutor CreateExecutor(AssemblyName assemblyName) =>
            new DependencyInjectionTestFrameworkExecutor(assemblyName, SourceInformationProvider, DiagnosticMessageSink);
    }
}
