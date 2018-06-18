using UnityEngine;
using System.Diagnostics;

public static class DebugUtility
{
    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void Assert(bool condition)
    {
        Debug.Assert(condition);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void Assert(bool condition, Object context)
    {
        Debug.Assert(condition, context);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void Assert(bool condition, object message)
    {
        Debug.Assert(condition, message);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void Assert(bool condition, object message, Object context)
    {
        Debug.Assert(condition, message, context);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void AssertFormat(bool condition, string format, params object[] args)
    {
        Debug.AssertFormat(condition, format, args);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void AssertFormat(bool condition, Object context, string format, params object[] args)
    {
        Debug.AssertFormat(condition, context, format, args);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void Break()
    {
        Debug.Break();
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void ClearDeveloperConsole()
    {
        Debug.ClearDeveloperConsole();
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void DrawLine(Vector3 start, Vector3 end, Color color = default(Color), float duration = 0.0f, bool depthTest = true)
    {
        Debug.DrawLine(start, end, color, duration, depthTest);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void DrawRay(Vector3 start, Vector3 dir, Color color = default(Color), float duration = 0.0f, bool depthTest = true)
    {
        Debug.DrawRay(start, dir, color, duration, depthTest);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void Log(object message)
    {
        Debug.Log(message);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void Log(object message, Object context)
    {
        Debug.Log(message, context);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void LogAssertion(object message)
    {
        Debug.LogAssertion(message);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void LogAssertion(object message, Object context)
    {
        Debug.LogAssertion(message, context);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void LogAssertionFormat(string format, params object[] args)
    {
        Debug.LogAssertionFormat(format, args);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void LogAssertionFormat(Object context, string format, params object[] args)
    {
        Debug.LogAssertionFormat(context, format, args);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void LogError(object message)
    {
        Debug.LogError(message);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void LogError(object message, Object context)
    {
        Debug.LogError(message, context);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void LogErrorFormat(string format, params object[] args)
    {
        Debug.LogErrorFormat(format, args);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void LogErrorFormat(Object context, string format, params object[] args)
    {
        Debug.LogErrorFormat(context, format, args);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void LogException(System.Exception exception)
    {
        Debug.LogException(exception);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void LogException(System.Exception exception, Object context)
    {
        Debug.LogException(exception, context);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void LogFormat(string format, params object[] args)
    {
        Debug.LogFormat(format, args);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void LogFormat(Object context, string format, params object[] args)
    {
        Debug.LogFormat(context, format, args);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void LogWarning(object message)
    {
        Debug.LogWarning(message);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void LogWarning(object message, Object context)
    {
        Debug.LogWarning(message, context);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void LogWarningFormat(string format, params object[] args)
    {
        Debug.LogWarningFormat(format, args);
    }

    [Conditional("DEVELOPMENT_BUILD"),  Conditional("UNITY_EDITOR")]
    public static void LogWarningFormat(Object context, string format, params object[] args)
    {
        Debug.LogWarningFormat(context, format, args);
    }
}