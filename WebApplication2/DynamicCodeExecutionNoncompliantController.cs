﻿using Microsoft.AspNetCore.Mvc;
using System.CodeDom.Compiler;

namespace WebApplicationDotNetCore.Controllers
{
    public class DynamicCodeExecutionNoncompliantController : Controller
    {
        public ActionResult UnsafeCodeExecution(string code)
        {
            var provider = CodeDomProvider.CreateProvider("CSharp");
            var compilerParameters = new CompilerParameters { ReferencedAssemblies = { "System.dll", "System.Runtime.dll" } };
            var compilerResults = provider.CompileAssemblyFromSource(compilerParameters, code);  //NOSONAR does not suppress cs:S5334
            int i; //NOSONAR suppresses correctly csharpsquid:S1481
            object myInstance = compilerResults.CompiledAssembly.CreateInstance("MyClass");
            var result = (string)myInstance.GetType().GetMethod("MyMethod").Invoke(myInstance, new object[0]);
            return Content(result);
        }
    }
}