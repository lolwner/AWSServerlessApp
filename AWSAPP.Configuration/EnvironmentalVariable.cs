using System;

namespace AWSAPP.Configuration
{
    public static class EnvironmentalVariable
    {
        public static readonly string LambdaVariable = Environment.GetEnvironmentVariable("LambdaTest");
    }
}
