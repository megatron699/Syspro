using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;


namespace LowFunction
{
    public class XOR
    {
        public static void XORCalc()
        {
            AppDomain asmDomain = Thread.GetDomain();
            AssemblyBuilder asmBuilder = asmDomain.DefineDynamicAssembly(new AssemblyName("XOR"), AssemblyBuilderAccess.RunAndSave);
            ModuleBuilder xorModule = asmBuilder.DefineDynamicModule("xor.dll", true);
            TypeBuilder typeBuilder = xorModule.DefineType("XOR", TypeAttributes.Public);
            MethodBuilder methodBuilder = typeBuilder.DefineMethod("XOR", MethodAttributes.Public, typeof(int), new Type[] { typeof(int), typeof(int) });
            ILGenerator iLGenerator = methodBuilder.GetILGenerator();
            iLGenerator.Emit(OpCodes.Ldarg_1);
            iLGenerator.Emit(OpCodes.Ldarg_2);
            iLGenerator.Emit(OpCodes.Xor);
            iLGenerator.Emit(OpCodes.Ret);
            typeBuilder.CreateType();
            asmBuilder.Save("XOR.dll");
        }
    }
                
}
