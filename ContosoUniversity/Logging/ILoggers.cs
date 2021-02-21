using System;



//creating a logging interface
//this is the EF Interception feature used for logging and for simulating transient errors
//use to test connection resiliency feature (way to intercept queries that EF sends to SQL Server
//and replace SQL Server response with an exception type that is typically transient
namespace ContosoUniversity.Logging
{
    public interface ILogger
    {
        void Information(string message);
        void Information(string fmt, params object[] vars);
        void Information(Exception exception, string fmt, params object[] vars);

        void Warning(string message);
        void Warning(string fmt, params object[] vars);
        void Warning(Exception exception, string fmt, params object[] vars);

        void Error(string message);
        void Error(string fmt, params object[] vars);
        void Error(Exception exception, string fmt, params object[] vars);


        //The TraceApi methods enable you to track the latency of each call to an external service such as SQL Database
        void TraceApi(string componentName, string method, TimeSpan timespan);
        void TraceApi(string componentName, string method, TimeSpan timespan, string properties);
        void TraceApi(string componentName, string method, TimeSpan timespan, string fmt, params object[] vars);
    }
}