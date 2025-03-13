using System;
using System.Diagnostics.CodeAnalysis;

namespace Module15
{
    /// <summary>
    /// The <c>Example</c> class we use for tutorials.
    /// </summary>
    /// <remarks>
    /// More info about the class goes here.
    /// </remarks>
    /// <include file='docs.xml' path='docs/members[@name="example"]/Example/'/>


    public class Program3<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">An int</param>
        /// <param name="b">An int</param>
        /// <example>
        /// <code>
        /// int c = Example.Add(1,2);
        /// </code>
        /// </example>
        /// <returns>The sum of two integers.</returns>
        public static int Add(int a, int b) { return a + b; }

        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// Gets the value of Val. 
        /// </value>
        /// <remarks> <para> More info goes here.</para> </remarks>
        public static string Val { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// <exception cref="System.DivideByZeroException">Thrown when we attempt to divide by zero.</exception>
        /// <see cref="Example.Divide(int, int)"/> to divide integers
        /// <seealso cref="Example.Divide(int, int)"/>
        public static int Divide (int a, int b) { return a / b; }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="message">The message to print, can be any type.</typeparam>
        /// <returns></returns>
        /// Prints a message <typeparamref name="message"/> to the console.
        public static bool PrintMessage(T message) { return true; }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// 
        /// <term>Add</term>
        /// <description>Addition</description>
        /// </item>
        /// 
        /// <item>
        /// <term>Sub</term>
        /// <description>Subtract</description>
        /// </item>
        /// 
        /// <item>
        /// <term>Multi</term>
        /// <description>Multiply</description>
        /// </item>
        /// 
        /// <item>
        /// <term>Div</term>
        /// <description>Divide</description>
        /// </item>
        /// 
        /// </list>
        /// </summary>
        public class Math { }
    }
}