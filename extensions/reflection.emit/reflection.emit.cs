/*
APIs removed/broken by this factoring:
    public sealed partial class AppDomain : System.MarshalByRefObject, System.Security.IEvidenceFactory
    {
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access) { throw null; }
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> assemblyAttributes) { throw null; }
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> assemblyAttributes, System.Security.SecurityContextSource securityContextSource) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default.  See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default.  See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Security.Policy.Evidence evidence) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions) { throw null; }
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir) { throw null; }
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, bool isSynchronized, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> assemblyAttributes) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of DefineDynamicAssembly which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkId=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default.  Please see http://go.microsoft.com/fwlink/?LinkId=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions, bool isSynchronized) { throw null; }
//REFEMIT        [System.ObsoleteAttribute("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions, bool isSynchronized, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> assemblyAttributes) { throw null; }
    }
    public partial interface ITypeLibConverter
    {
//REFEMIT        System.Reflection.Emit.AssemblyBuilder ConvertTypeLibToAssembly(object typeLib, string asmFileName, int flags, System.Runtime.InteropServices.ITypeLibImporterNotifySink notifySink, byte[] publicKey, System.Reflection.StrongNameKeyPair keyPair, bool unsafeInterfaces);
//REFEMIT        System.Reflection.Emit.AssemblyBuilder ConvertTypeLibToAssembly(object typeLib, string asmFileName, System.Runtime.InteropServices.TypeLibImporterFlags flags, System.Runtime.InteropServices.ITypeLibImporterNotifySink notifySink, byte[] publicKey, System.Reflection.StrongNameKeyPair keyPair, string asmNamespace, System.Version asmVersion);
    }
    public sealed partial class TypeLibConverter : System.Runtime.InteropServices.ITypeLibConverter
    {
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder ConvertTypeLibToAssembly(object typeLib, string asmFileName, int flags, System.Runtime.InteropServices.ITypeLibImporterNotifySink notifySink, byte[] publicKey, System.Reflection.StrongNameKeyPair keyPair, bool unsafeInterfaces) { throw null; }
//REFEMIT        public System.Reflection.Emit.AssemblyBuilder ConvertTypeLibToAssembly(object typeLib, string asmFileName, System.Runtime.InteropServices.TypeLibImporterFlags flags, System.Runtime.InteropServices.ITypeLibImporterNotifySink notifySink, byte[] publicKey, System.Reflection.StrongNameKeyPair keyPair, string asmNamespace, System.Version asmVersion) { throw null; }
    }
    public partial class Regex : System.Runtime.Serialization.ISerializable
    {
//REFEMIT        public static void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[] regexinfos, System.Reflection.AssemblyName assemblyname) { }
//REFEMIT        public static void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[] regexinfos, System.Reflection.AssemblyName assemblyname, System.Reflection.Emit.CustomAttributeBuilder[] attributes) { }
//REFEMIT        public static void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[] regexinfos, System.Reflection.AssemblyName assemblyname, System.Reflection.Emit.CustomAttributeBuilder[] attributes, string resourceFile) { }
    }
    public abstract partial class LambdaExpression : System.Linq.Expressions.Expression
    {
//REFEMIT        public void CompileToMethod(System.Reflection.Emit.MethodBuilder method) { }
//REFEMIT        public void CompileToMethod(System.Reflection.Emit.MethodBuilder method, System.Runtime.CompilerServices.DebugInfoGenerator debugInfoGenerator) { }
    }
    public partial class XmlSerializer
    {
//REFEMIT        public static System.Reflection.Assembly GenerateSerializer(System.Type[] types, System.Xml.Serialization.XmlMapping[] mappings) { throw null; }
//REFEMIT        public static System.Reflection.Assembly GenerateSerializer(System.Type[] types, System.Xml.Serialization.XmlMapping[] mappings, System.CodeDom.Compiler.CompilerParameters parameters) { throw null; }
    }
    public sealed partial class XslCompiledTransform
    {
//REFEMIT        public static System.CodeDom.Compiler.CompilerErrorCollection CompileToType(System.Xml.XmlReader stylesheet, System.Xml.Xsl.XsltSettings settings, System.Xml.XmlResolver stylesheetResolver, bool debug, System.Reflection.Emit.TypeBuilder typeBuilder, string scriptAssemblyPath) { throw null; }
    }
*/

namespace System.Reflection.Emit
{
    public sealed partial class AssemblyBuilder : System.Reflection.Assembly
    {
        internal AssemblyBuilder() { }
        public override string CodeBase { get { throw null; } }
        public override System.Reflection.MethodInfo EntryPoint { get { throw null; } }
//CAS        public override System.Security.Policy.Evidence Evidence { get { throw null; } }
        public override string FullName { get { throw null; } }
        public override bool GlobalAssemblyCache { get { throw null; } }
        public override long HostContext { get { throw null; } }
        public override string ImageRuntimeVersion { get { throw null; } }
        public override bool IsDynamic { get { throw null; } }
        public override string Location { get { throw null; } }
        public override System.Reflection.Module ManifestModule { get { throw null; } }
//CAS        public override System.Security.PermissionSet PermissionSet { get { throw null; } }
        public override bool ReflectionOnly { get { throw null; } }
        public override System.Security.SecurityRuleSet SecurityRuleSet { get { throw null; } }
        public void AddResourceFile(string name, string fileName) { }
        public void AddResourceFile(string name, string fileName, System.Reflection.ResourceAttributes attribute) { }
        public static System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access) { throw null; }
        public static System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> assemblyAttributes) { throw null; }
        public System.Reflection.Emit.ModuleBuilder DefineDynamicModule(string name) { throw null; }
        public System.Reflection.Emit.ModuleBuilder DefineDynamicModule(string name, bool emitSymbolInfo) { throw null; }
        public System.Reflection.Emit.ModuleBuilder DefineDynamicModule(string name, string fileName) { throw null; }
        public System.Reflection.Emit.ModuleBuilder DefineDynamicModule(string name, string fileName, bool emitSymbolInfo) { throw null; }
        public System.Resources.IResourceWriter DefineResource(string name, string description, string fileName) { throw null; }
        public System.Resources.IResourceWriter DefineResource(string name, string description, string fileName, System.Reflection.ResourceAttributes attribute) { throw null; }
        public void DefineUnmanagedResource(byte[] resource) { }
        public void DefineUnmanagedResource(string resourceFileName) { }
        public void DefineVersionInfoResource() { }
        public void DefineVersionInfoResource(string product, string productVersion, string company, string copyright, string trademark) { }
        public override bool Equals(object obj) { throw null; }
        public override object[] GetCustomAttributes(bool inherit) { throw null; }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public override System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData() { throw null; }
        public System.Reflection.Emit.ModuleBuilder GetDynamicModule(string name) { throw null; }
        public override System.Type[] GetExportedTypes() { throw null; }
        public override System.IO.FileStream GetFile(string name) { throw null; }
        public override System.IO.FileStream[] GetFiles(bool getResourceModules) { throw null; }
        public override int GetHashCode() { throw null; }
        public override System.Reflection.Module[] GetLoadedModules(bool getResourceModules) { throw null; }
        public override System.Reflection.ManifestResourceInfo GetManifestResourceInfo(string resourceName) { throw null; }
        public override string[] GetManifestResourceNames() { throw null; }
        public override System.IO.Stream GetManifestResourceStream(string name) { throw null; }
        public override System.IO.Stream GetManifestResourceStream(System.Type type, string name) { throw null; }
        public override System.Reflection.Module GetModule(string name) { throw null; }
        public override System.Reflection.Module[] GetModules(bool getResourceModules) { throw null; }
        public override System.Reflection.AssemblyName GetName(bool copiedName) { throw null; }
        public override System.Reflection.AssemblyName[] GetReferencedAssemblies() { throw null; }
        public override System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo culture) { throw null; }
        public override System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo culture, System.Version version) { throw null; }
        public override System.Type GetType(string name, bool throwOnError, bool ignoreCase) { throw null; }
        public override bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
        public void Save(string assemblyFileName) { }
        public void Save(string assemblyFileName, System.Reflection.PortableExecutableKinds portableExecutableKind, System.Reflection.ImageFileMachine imageFileMachine) { }
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
        public void SetEntryPoint(System.Reflection.MethodInfo entryMethod) { }
        public void SetEntryPoint(System.Reflection.MethodInfo entryMethod, System.Reflection.Emit.PEFileKinds fileKind) { }
    }
    [System.FlagsAttribute]
    public enum AssemblyBuilderAccess
    {
        ReflectionOnly = 6,
        Run = 1,
        RunAndCollect = 9,
        RunAndSave = 3,
        Save = 2,
    }
    public sealed partial class ConstructorBuilder : System.Reflection.ConstructorInfo
    {
        internal ConstructorBuilder() { }
        public override System.Reflection.MethodAttributes Attributes { get { throw null; } }
        public override System.Reflection.CallingConventions CallingConvention { get { throw null; } }
        public override System.Type DeclaringType { get { throw null; } }
        public bool InitLocals { get { throw null; } set { } }
        public override System.RuntimeMethodHandle MethodHandle { get { throw null; } }
        public override System.Reflection.Module Module { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Type ReflectedType { get { throw null; } }
        [System.ObsoleteAttribute("This property has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
        public System.Type ReturnType { get { throw null; } }
        public string Signature { get { throw null; } }
//CAS        public void AddDeclarativeSecurity(System.Security.Permissions.SecurityAction action, System.Security.PermissionSet pset) { }
        public System.Reflection.Emit.ParameterBuilder DefineParameter(int iSequence, System.Reflection.ParameterAttributes attributes, string strParamName) { throw null; }
        public override object[] GetCustomAttributes(bool inherit) { throw null; }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public System.Reflection.Emit.ILGenerator GetILGenerator() { throw null; }
        public System.Reflection.Emit.ILGenerator GetILGenerator(int streamSize) { throw null; }
        public override System.Reflection.MethodImplAttributes GetMethodImplementationFlags() { throw null; }
        public System.Reflection.Module GetModule() { throw null; }
        public override System.Reflection.ParameterInfo[] GetParameters() { throw null; }
        public System.Reflection.Emit.MethodToken GetToken() { throw null; }
        public override object Invoke(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture) { throw null; }
        public override object Invoke(System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture) { throw null; }
        public override bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
        public void SetImplementationFlags(System.Reflection.MethodImplAttributes attributes) { }
        public void SetMethodBody(byte[] il, int maxStack, byte[] localSignature, System.Collections.Generic.IEnumerable<System.Reflection.Emit.ExceptionHandler> exceptionHandlers, System.Collections.Generic.IEnumerable<int> tokenFixups) { }
        public void SetSymCustomAttribute(string name, byte[] data) { }
        public override string ToString() { throw null; }
    }
    public partial class CustomAttributeBuilder
    {
        public CustomAttributeBuilder(System.Reflection.ConstructorInfo con, object[] constructorArgs) { }
        public CustomAttributeBuilder(System.Reflection.ConstructorInfo con, object[] constructorArgs, System.Reflection.FieldInfo[] namedFields, object[] fieldValues) { }
        public CustomAttributeBuilder(System.Reflection.ConstructorInfo con, object[] constructorArgs, System.Reflection.PropertyInfo[] namedProperties, object[] propertyValues) { }
        public CustomAttributeBuilder(System.Reflection.ConstructorInfo con, object[] constructorArgs, System.Reflection.PropertyInfo[] namedProperties, object[] propertyValues, System.Reflection.FieldInfo[] namedFields, object[] fieldValues) { }
    }
    public partial class DynamicILInfo
    {
        internal DynamicILInfo() { }
        public System.Reflection.Emit.DynamicMethod DynamicMethod { get { throw null; } }
        public int GetTokenFor(byte[] signature) { throw null; }
        public int GetTokenFor(System.Reflection.Emit.DynamicMethod method) { throw null; }
        public int GetTokenFor(System.RuntimeFieldHandle field) { throw null; }
        public int GetTokenFor(System.RuntimeFieldHandle field, System.RuntimeTypeHandle contextType) { throw null; }
        public int GetTokenFor(System.RuntimeMethodHandle method) { throw null; }
        public int GetTokenFor(System.RuntimeMethodHandle method, System.RuntimeTypeHandle contextType) { throw null; }
        public int GetTokenFor(System.RuntimeTypeHandle type) { throw null; }
        public int GetTokenFor(string literal) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public unsafe void SetCode(byte* code, int codeSize, int maxStackSize) { }
        public void SetCode(byte[] code, int maxStackSize) { }
        [System.CLSCompliantAttribute(false)]
        public unsafe void SetExceptions(byte* exceptions, int exceptionsSize) { }
        public void SetExceptions(byte[] exceptions) { }
        [System.CLSCompliantAttribute(false)]
        public unsafe void SetLocalSignature(byte* localSignature, int signatureSize) { }
        public void SetLocalSignature(byte[] localSignature) { }
    }
    public sealed partial class DynamicMethod : System.Reflection.MethodInfo
    {
        public DynamicMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes, System.Reflection.Module m, bool skipVisibility) { }
        public DynamicMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes, System.Type owner, bool skipVisibility) { }
        public DynamicMethod(string name, System.Type returnType, System.Type[] parameterTypes) { }
        public DynamicMethod(string name, System.Type returnType, System.Type[] parameterTypes, bool restrictedSkipVisibility) { }
        public DynamicMethod(string name, System.Type returnType, System.Type[] parameterTypes, System.Reflection.Module m) { }
        public DynamicMethod(string name, System.Type returnType, System.Type[] parameterTypes, System.Reflection.Module m, bool skipVisibility) { }
        public DynamicMethod(string name, System.Type returnType, System.Type[] parameterTypes, System.Type owner) { }
        public DynamicMethod(string name, System.Type returnType, System.Type[] parameterTypes, System.Type owner, bool skipVisibility) { }
        public override System.Reflection.MethodAttributes Attributes { get { throw null; } }
        public override System.Reflection.CallingConventions CallingConvention { get { throw null; } }
        public override System.Type DeclaringType { get { throw null; } }
        public bool InitLocals { get { throw null; } set { } }
        public override bool IsSecurityCritical { get { throw null; } }
        public override bool IsSecuritySafeCritical { get { throw null; } }
        public override bool IsSecurityTransparent { get { throw null; } }
        public override System.RuntimeMethodHandle MethodHandle { get { throw null; } }
        public override System.Reflection.Module Module { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Type ReflectedType { get { throw null; } }
        public override System.Reflection.ParameterInfo ReturnParameter { get { throw null; } }
        public override System.Type ReturnType { get { throw null; } }
        public override System.Reflection.ICustomAttributeProvider ReturnTypeCustomAttributes { get { throw null; } }
        public sealed override System.Delegate CreateDelegate(System.Type delegateType) { throw null; }
        public sealed override System.Delegate CreateDelegate(System.Type delegateType, object target) { throw null; }
        public System.Reflection.Emit.ParameterBuilder DefineParameter(int position, System.Reflection.ParameterAttributes attributes, string parameterName) { throw null; }
        public override System.Reflection.MethodInfo GetBaseDefinition() { throw null; }
        public override object[] GetCustomAttributes(bool inherit) { throw null; }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public System.Reflection.Emit.DynamicILInfo GetDynamicILInfo() { throw null; }
        public System.Reflection.Emit.ILGenerator GetILGenerator() { throw null; }
        public System.Reflection.Emit.ILGenerator GetILGenerator(int streamSize) { throw null; }
        public override System.Reflection.MethodImplAttributes GetMethodImplementationFlags() { throw null; }
        public override System.Reflection.ParameterInfo[] GetParameters() { throw null; }
        public override object Invoke(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture) { throw null; }
        public override bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class EnumBuilder : System.Type //TYPEINFO: System.Reflection.TypeInfo doesn't have a public ctor
    {
        internal EnumBuilder() { }
        public override System.Reflection.Assembly Assembly { get { throw null; } }
        public override string AssemblyQualifiedName { get { throw null; } }
        public override System.Type BaseType { get { throw null; } }
        public override System.Type DeclaringType { get { throw null; } }
        public override string FullName { get { throw null; } }
        public override System.Guid GUID { get { throw null; } }
        public override bool IsConstructedGenericType { get { throw null; } }
        public override System.Reflection.Module Module { get { throw null; } }
        public override string Name { get { throw null; } }
        public override string Namespace { get { throw null; } }
        public override System.Type ReflectedType { get { throw null; } }
        public override System.RuntimeTypeHandle TypeHandle { get { throw null; } }
        public System.Reflection.Emit.TypeToken TypeToken { get { throw null; } }
        public System.Reflection.Emit.FieldBuilder UnderlyingField { get { throw null; } }
        public override System.Type UnderlyingSystemType { get { throw null; } }
        public System.Type CreateType() { throw null; }
        public System.Reflection.TypeInfo CreateTypeInfo() { throw null; }
        public System.Reflection.Emit.FieldBuilder DefineLiteral(string literalName, object literalValue) { throw null; }
        protected override System.Reflection.TypeAttributes GetAttributeFlagsImpl() { throw null; }
        protected override System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        public override System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override object[] GetCustomAttributes(bool inherit) { throw null; }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public override System.Type GetElementType() { throw null; }
        public override System.Type GetEnumUnderlyingType() { throw null; }
        public override System.Reflection.EventInfo GetEvent(string name, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Reflection.EventInfo[] GetEvents() { throw null; }
        public override System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Type GetInterface(string name, bool ignoreCase) { throw null; }
        public override System.Reflection.InterfaceMapping GetInterfaceMap(System.Type interfaceType) { throw null; }
        public override System.Type[] GetInterfaces() { throw null; }
        public override System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.MemberTypes type, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr) { throw null; }
        protected override System.Reflection.MethodInfo GetMethodImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        public override System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Type GetNestedType(string name, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Type[] GetNestedTypes(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr) { throw null; }
        protected override System.Reflection.PropertyInfo GetPropertyImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        protected override bool HasElementTypeImpl() { throw null; }
        public override object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namedParameters) { throw null; }
        protected override bool IsArrayImpl() { throw null; }
//TYPEINFO        public override bool IsAssignableFrom(System.Reflection.TypeInfo typeInfo) { throw null; }
        protected override bool IsByRefImpl() { throw null; }
        protected override bool IsCOMObjectImpl() { throw null; }
        public override bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
        protected override bool IsPointerImpl() { throw null; }
        protected override bool IsPrimitiveImpl() { throw null; }
        protected override bool IsValueTypeImpl() { throw null; }
        public override System.Type MakeArrayType() { throw null; }
        public override System.Type MakeArrayType(int rank) { throw null; }
        public override System.Type MakeByRefType() { throw null; }
        public override System.Type MakePointerType() { throw null; }
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
    }
    public sealed partial class EventBuilder
    {
        internal EventBuilder() { }
        public void AddOtherMethod(System.Reflection.Emit.MethodBuilder mdBuilder) { }
        public System.Reflection.Emit.EventToken GetEventToken() { throw null; }
        public void SetAddOnMethod(System.Reflection.Emit.MethodBuilder mdBuilder) { }
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
        public void SetRaiseMethod(System.Reflection.Emit.MethodBuilder mdBuilder) { }
        public void SetRemoveOnMethod(System.Reflection.Emit.MethodBuilder mdBuilder) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct EventToken
    {
        public static readonly System.Reflection.Emit.EventToken Empty;
        public int Token { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Reflection.Emit.EventToken obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Reflection.Emit.EventToken a, System.Reflection.Emit.EventToken b) { throw null; }
        public static bool operator !=(System.Reflection.Emit.EventToken a, System.Reflection.Emit.EventToken b) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ExceptionHandler : System.IEquatable<System.Reflection.Emit.ExceptionHandler>
    {
        public ExceptionHandler(int tryOffset, int tryLength, int filterOffset, int handlerOffset, int handlerLength, System.Reflection.ExceptionHandlingClauseOptions kind, int exceptionTypeToken) { throw null;}
        public int ExceptionTypeToken { get { throw null; } }
        public int FilterOffset { get { throw null; } }
        public int HandlerLength { get { throw null; } }
        public int HandlerOffset { get { throw null; } }
        public System.Reflection.ExceptionHandlingClauseOptions Kind { get { throw null; } }
        public int TryLength { get { throw null; } }
        public int TryOffset { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Reflection.Emit.ExceptionHandler other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Reflection.Emit.ExceptionHandler left, System.Reflection.Emit.ExceptionHandler right) { throw null; }
        public static bool operator !=(System.Reflection.Emit.ExceptionHandler left, System.Reflection.Emit.ExceptionHandler right) { throw null; }
    }
    public sealed partial class FieldBuilder : System.Reflection.FieldInfo
    {
        internal FieldBuilder() { }
        public override System.Reflection.FieldAttributes Attributes { get { throw null; } }
        public override System.Type DeclaringType { get { throw null; } }
        public override System.RuntimeFieldHandle FieldHandle { get { throw null; } }
        public override System.Type FieldType { get { throw null; } }
        public override System.Reflection.Module Module { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Type ReflectedType { get { throw null; } }
        public override object[] GetCustomAttributes(bool inherit) { throw null; }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public System.Reflection.Emit.FieldToken GetToken() { throw null; }
        public override object GetValue(object obj) { throw null; }
        public override bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
        public void SetConstant(object defaultValue) { }
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
        [System.ObsoleteAttribute("An alternate API is available: Emit the MarshalAs custom attribute instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public void SetMarshal(System.Reflection.Emit.UnmanagedMarshal unmanagedMarshal) { }
        public void SetOffset(int iOffset) { }
        public override void SetValue(object obj, object val, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Globalization.CultureInfo culture) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct FieldToken
    {
        public static readonly System.Reflection.Emit.FieldToken Empty;
        public int Token { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Reflection.Emit.FieldToken obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Reflection.Emit.FieldToken a, System.Reflection.Emit.FieldToken b) { throw null; }
        public static bool operator !=(System.Reflection.Emit.FieldToken a, System.Reflection.Emit.FieldToken b) { throw null; }
    }
    public sealed partial class GenericTypeParameterBuilder : System.Type //TYPEINFO: System.Reflection.TypeInfo
    {
        internal GenericTypeParameterBuilder() { }
        public override System.Reflection.Assembly Assembly { get { throw null; } }
        public override string AssemblyQualifiedName { get { throw null; } }
        public override System.Type BaseType { get { throw null; } }
        public override bool ContainsGenericParameters { get { throw null; } }
        public override System.Reflection.MethodBase DeclaringMethod { get { throw null; } }
        public override System.Type DeclaringType { get { throw null; } }
        public override string FullName { get { throw null; } }
        public override System.Reflection.GenericParameterAttributes GenericParameterAttributes { get { throw null; } }
        public override int GenericParameterPosition { get { throw null; } }
        public override System.Guid GUID { get { throw null; } }
        public override bool IsConstructedGenericType { get { throw null; } }
        public override bool IsGenericParameter { get { throw null; } }
        public override bool IsGenericType { get { throw null; } }
        public override bool IsGenericTypeDefinition { get { throw null; } }
        public override System.Reflection.Module Module { get { throw null; } }
        public override string Name { get { throw null; } }
        public override string Namespace { get { throw null; } }
        public override System.Type ReflectedType { get { throw null; } }
        public override System.RuntimeTypeHandle TypeHandle { get { throw null; } }
        public override System.Type UnderlyingSystemType { get { throw null; } }
        public override bool Equals(object o) { throw null; }
        protected override System.Reflection.TypeAttributes GetAttributeFlagsImpl() { throw null; }
        protected override System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        public override System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override object[] GetCustomAttributes(bool inherit) { throw null; }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public override System.Type GetElementType() { throw null; }
        public override System.Reflection.EventInfo GetEvent(string name, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Reflection.EventInfo[] GetEvents() { throw null; }
        public override System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Type[] GetGenericArguments() { throw null; }
        public override System.Type GetGenericTypeDefinition() { throw null; }
        public override int GetHashCode() { throw null; }
        public override System.Type GetInterface(string name, bool ignoreCase) { throw null; }
        public override System.Reflection.InterfaceMapping GetInterfaceMap(System.Type interfaceType) { throw null; }
        public override System.Type[] GetInterfaces() { throw null; }
        public override System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.MemberTypes type, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr) { throw null; }
        protected override System.Reflection.MethodInfo GetMethodImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        public override System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Type GetNestedType(string name, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Type[] GetNestedTypes(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr) { throw null; }
        protected override System.Reflection.PropertyInfo GetPropertyImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        protected override bool HasElementTypeImpl() { throw null; }
        public override object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namedParameters) { throw null; }
        protected override bool IsArrayImpl() { throw null; }
//TYPEINFO:        public override bool IsAssignableFrom(System.Reflection.TypeInfo typeInfo) { throw null; }
        public override bool IsAssignableFrom(System.Type c) { throw null; }
        protected override bool IsByRefImpl() { throw null; }
        protected override bool IsCOMObjectImpl() { throw null; }
        public override bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
        protected override bool IsPointerImpl() { throw null; }
        protected override bool IsPrimitiveImpl() { throw null; }
        public override bool IsSubclassOf(System.Type c) { throw null; }
        protected override bool IsValueTypeImpl() { throw null; }
        public override System.Type MakeArrayType() { throw null; }
        public override System.Type MakeArrayType(int rank) { throw null; }
        public override System.Type MakeByRefType() { throw null; }
        public override System.Type MakeGenericType(params System.Type[] typeArguments) { throw null; }
        public override System.Type MakePointerType() { throw null; }
        public void SetBaseTypeConstraint(System.Type baseTypeConstraint) { }
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
        public void SetGenericParameterAttributes(System.Reflection.GenericParameterAttributes genericParameterAttributes) { }
        public void SetInterfaceConstraints(params System.Type[] interfaceConstraints) { }
        public override string ToString() { throw null; }
    }
    public partial class ILGenerator
    {
        internal ILGenerator() { }
        public virtual int ILOffset { get { throw null; } }
        public virtual void BeginCatchBlock(System.Type exceptionType) { }
        public virtual void BeginExceptFilterBlock() { }
        public virtual System.Reflection.Emit.Label BeginExceptionBlock() { throw null; }
        public virtual void BeginFaultBlock() { }
        public virtual void BeginFinallyBlock() { }
        public virtual void BeginScope() { }
        public virtual System.Reflection.Emit.LocalBuilder DeclareLocal(System.Type localType) { throw null; }
        public virtual System.Reflection.Emit.LocalBuilder DeclareLocal(System.Type localType, bool pinned) { throw null; }
        public virtual System.Reflection.Emit.Label DefineLabel() { throw null; }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, byte arg) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, double arg) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, short arg) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, int arg) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, long arg) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.ConstructorInfo con) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.Emit.Label label) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.Emit.Label[] labels) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.Emit.LocalBuilder local) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.Emit.SignatureHelper signature) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.FieldInfo field) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.MethodInfo meth) { }
        [System.CLSCompliantAttribute(false)]
        public void Emit(System.Reflection.Emit.OpCode opcode, sbyte arg) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, float arg) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, string str) { }
        public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Type cls) { }
        public virtual void EmitCall(System.Reflection.Emit.OpCode opcode, System.Reflection.MethodInfo methodInfo, System.Type[] optionalParameterTypes) { }
        public virtual void EmitCalli(System.Reflection.Emit.OpCode opcode, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes, System.Type[] optionalParameterTypes) { }
        public virtual void EmitCalli(System.Reflection.Emit.OpCode opcode, System.Runtime.InteropServices.CallingConvention unmanagedCallConv, System.Type returnType, System.Type[] parameterTypes) { }
        public virtual void EmitWriteLine(System.Reflection.Emit.LocalBuilder localBuilder) { }
        public virtual void EmitWriteLine(System.Reflection.FieldInfo fld) { }
        public virtual void EmitWriteLine(string value) { }
        public virtual void EndExceptionBlock() { }
        public virtual void EndScope() { }
        public virtual void MarkLabel(System.Reflection.Emit.Label loc) { }
        public virtual void MarkSequencePoint(System.Diagnostics.SymbolStore.ISymbolDocumentWriter document, int startLine, int startColumn, int endLine, int endColumn) { }
        public virtual void ThrowException(System.Type excType) { }
        public virtual void UsingNamespace(string usingNamespace) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Label
    {
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Reflection.Emit.Label obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Reflection.Emit.Label a, System.Reflection.Emit.Label b) { throw null; }
        public static bool operator !=(System.Reflection.Emit.Label a, System.Reflection.Emit.Label b) { throw null; }
    }
    public sealed partial class LocalBuilder : System.Reflection.LocalVariableInfo
    {
        internal LocalBuilder() { }
        public override bool IsPinned { get { throw null; } }
        public override int LocalIndex { get { throw null; } }
        public override System.Type LocalType { get { throw null; } }
        public void SetLocalSymInfo(string name) { }
        public void SetLocalSymInfo(string name, int startOffset, int endOffset) { }
    }
    public sealed partial class MethodBuilder : System.Reflection.MethodInfo
    {
        internal MethodBuilder() { }
        public override System.Reflection.MethodAttributes Attributes { get { throw null; } }
        public override System.Reflection.CallingConventions CallingConvention { get { throw null; } }
        public override bool ContainsGenericParameters { get { throw null; } }
        public override System.Type DeclaringType { get { throw null; } }
        public bool InitLocals { get { throw null; } set { } }
        public override bool IsGenericMethod { get { throw null; } }
        public override bool IsGenericMethodDefinition { get { throw null; } }
        public override bool IsSecurityCritical { get { throw null; } }
        public override bool IsSecuritySafeCritical { get { throw null; } }
        public override bool IsSecurityTransparent { get { throw null; } }
        public override System.RuntimeMethodHandle MethodHandle { get { throw null; } }
        public override System.Reflection.Module Module { get { throw null; } }
        public override string Name { get { throw null; } }
        public override System.Type ReflectedType { get { throw null; } }
        public override System.Reflection.ParameterInfo ReturnParameter { get { throw null; } }
        public override System.Type ReturnType { get { throw null; } }
        public override System.Reflection.ICustomAttributeProvider ReturnTypeCustomAttributes { get { throw null; } }
        public string Signature { get { throw null; } }
//CAS        public void AddDeclarativeSecurity(System.Security.Permissions.SecurityAction action, System.Security.PermissionSet pset) { }
        public void CreateMethodBody(byte[] il, int count) { }
        public System.Reflection.Emit.GenericTypeParameterBuilder[] DefineGenericParameters(params string[] names) { throw null; }
        public System.Reflection.Emit.ParameterBuilder DefineParameter(int position, System.Reflection.ParameterAttributes attributes, string strParamName) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override System.Reflection.MethodInfo GetBaseDefinition() { throw null; }
        public override object[] GetCustomAttributes(bool inherit) { throw null; }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public override System.Type[] GetGenericArguments() { throw null; }
        public override System.Reflection.MethodInfo GetGenericMethodDefinition() { throw null; }
        public override int GetHashCode() { throw null; }
        public System.Reflection.Emit.ILGenerator GetILGenerator() { throw null; }
        public System.Reflection.Emit.ILGenerator GetILGenerator(int size) { throw null; }
        public override System.Reflection.MethodImplAttributes GetMethodImplementationFlags() { throw null; }
        public System.Reflection.Module GetModule() { throw null; }
        public override System.Reflection.ParameterInfo[] GetParameters() { throw null; }
        public System.Reflection.Emit.MethodToken GetToken() { throw null; }
        public override object Invoke(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture) { throw null; }
        public override bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
        public override System.Reflection.MethodInfo MakeGenericMethod(params System.Type[] typeArguments) { throw null; }
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
        public void SetImplementationFlags(System.Reflection.MethodImplAttributes attributes) { }
        [System.ObsoleteAttribute("An alternate API is available: Emit the MarshalAs custom attribute instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public void SetMarshal(System.Reflection.Emit.UnmanagedMarshal unmanagedMarshal) { }
        public void SetMethodBody(byte[] il, int maxStack, byte[] localSignature, System.Collections.Generic.IEnumerable<System.Reflection.Emit.ExceptionHandler> exceptionHandlers, System.Collections.Generic.IEnumerable<int> tokenFixups) { }
        public void SetParameters(params System.Type[] parameterTypes) { }
        public void SetReturnType(System.Type returnType) { }
        public void SetSignature(System.Type returnType, System.Type[] returnTypeRequiredCustomModifiers, System.Type[] returnTypeOptionalCustomModifiers, System.Type[] parameterTypes, System.Type[][] parameterTypeRequiredCustomModifiers, System.Type[][] parameterTypeOptionalCustomModifiers) { }
        public void SetSymCustomAttribute(string name, byte[] data) { }
        public override string ToString() { throw null; }
    }
    public sealed partial class MethodRental
    {
        internal MethodRental() { }
        public const int JitImmediate = 1;
        public const int JitOnDemand = 0;
        public static void SwapMethodBody(System.Type cls, int methodtoken, System.IntPtr rgIL, int methodSize, int flags) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct MethodToken
    {
        public static readonly System.Reflection.Emit.MethodToken Empty;
        public int Token { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Reflection.Emit.MethodToken obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Reflection.Emit.MethodToken a, System.Reflection.Emit.MethodToken b) { throw null; }
        public static bool operator !=(System.Reflection.Emit.MethodToken a, System.Reflection.Emit.MethodToken b) { throw null; }
    }
    public partial class ModuleBuilder : System.Reflection.Module
    {
        internal ModuleBuilder() { }
        public override System.Reflection.Assembly Assembly { get { throw null; } }
        public override string FullyQualifiedName { get { throw null; } }
        public override int MDStreamVersion { get { throw null; } }
        public override int MetadataToken { get { throw null; } }
        public override System.Guid ModuleVersionId { get { throw null; } }
        public override string Name { get { throw null; } }
        public override string ScopeName { get { throw null; } }
        public void CreateGlobalFunctions() { }
        public System.Diagnostics.SymbolStore.ISymbolDocumentWriter DefineDocument(string url, System.Guid language, System.Guid languageVendor, System.Guid documentType) { throw null; }
        public System.Reflection.Emit.EnumBuilder DefineEnum(string name, System.Reflection.TypeAttributes visibility, System.Type underlyingType) { throw null; }
        public System.Reflection.Emit.MethodBuilder DefineGlobalMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes) { throw null; }
        public System.Reflection.Emit.MethodBuilder DefineGlobalMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] requiredReturnTypeCustomModifiers, System.Type[] optionalReturnTypeCustomModifiers, System.Type[] parameterTypes, System.Type[][] requiredParameterTypeCustomModifiers, System.Type[][] optionalParameterTypeCustomModifiers) { throw null; }
        public System.Reflection.Emit.MethodBuilder DefineGlobalMethod(string name, System.Reflection.MethodAttributes attributes, System.Type returnType, System.Type[] parameterTypes) { throw null; }
        public System.Reflection.Emit.FieldBuilder DefineInitializedData(string name, byte[] data, System.Reflection.FieldAttributes attributes) { throw null; }
        public void DefineManifestResource(string name, System.IO.Stream stream, System.Reflection.ResourceAttributes attribute) { }
        public System.Reflection.Emit.MethodBuilder DefinePInvokeMethod(string name, string dllName, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes, System.Runtime.InteropServices.CallingConvention nativeCallConv, System.Runtime.InteropServices.CharSet nativeCharSet) { throw null; }
        public System.Reflection.Emit.MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes, System.Runtime.InteropServices.CallingConvention nativeCallConv, System.Runtime.InteropServices.CharSet nativeCharSet) { throw null; }
        public System.Resources.IResourceWriter DefineResource(string name, string description) { throw null; }
        public System.Resources.IResourceWriter DefineResource(string name, string description, System.Reflection.ResourceAttributes attribute) { throw null; }
        public System.Reflection.Emit.TypeBuilder DefineType(string name) { throw null; }
        public System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr) { throw null; }
        public System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, System.Type parent) { throw null; }
        public System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, System.Type parent, int typesize) { throw null; }
        public System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Reflection.Emit.PackingSize packsize) { throw null; }
        public System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Reflection.Emit.PackingSize packingSize, int typesize) { throw null; }
        public System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Type[] interfaces) { throw null; }
        public System.Reflection.Emit.FieldBuilder DefineUninitializedData(string name, int size, System.Reflection.FieldAttributes attributes) { throw null; }
        public void DefineUnmanagedResource(byte[] resource) { }
        public void DefineUnmanagedResource(string resourceFileName) { }
        public override bool Equals(object obj) { throw null; }
        public System.Reflection.MethodInfo GetArrayMethod(System.Type arrayClass, string methodName, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes) { throw null; }
        public System.Reflection.Emit.MethodToken GetArrayMethodToken(System.Type arrayClass, string methodName, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes) { throw null; }
        public System.Reflection.Emit.MethodToken GetConstructorToken(System.Reflection.ConstructorInfo con) { throw null; }
        public System.Reflection.Emit.MethodToken GetConstructorToken(System.Reflection.ConstructorInfo constructor, System.Collections.Generic.IEnumerable<System.Type> optionalParameterTypes) { throw null; }
        public override object[] GetCustomAttributes(bool inherit) { throw null; }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public override System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData() { throw null; }
        public override System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingFlags) { throw null; }
        public System.Reflection.Emit.FieldToken GetFieldToken(System.Reflection.FieldInfo field) { throw null; }
        public override int GetHashCode() { throw null; }
        protected override System.Reflection.MethodInfo GetMethodImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        public override System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingFlags) { throw null; }
        public System.Reflection.Emit.MethodToken GetMethodToken(System.Reflection.MethodInfo method) { throw null; }
        public System.Reflection.Emit.MethodToken GetMethodToken(System.Reflection.MethodInfo method, System.Collections.Generic.IEnumerable<System.Type> optionalParameterTypes) { throw null; }
        public override void GetPEKind(out System.Reflection.PortableExecutableKinds peKind, out System.Reflection.ImageFileMachine machine) { peKind = default(System.Reflection.PortableExecutableKinds); machine = default(System.Reflection.ImageFileMachine); }
        public System.Reflection.Emit.SignatureToken GetSignatureToken(byte[] sigBytes, int sigLength) { throw null; }
        public System.Reflection.Emit.SignatureToken GetSignatureToken(System.Reflection.Emit.SignatureHelper sigHelper) { throw null; }
        public override System.Security.Cryptography.X509Certificates.X509Certificate GetSignerCertificate() { throw null; }
        public System.Reflection.Emit.StringToken GetStringConstant(string str) { throw null; }
        public System.Diagnostics.SymbolStore.ISymbolWriter GetSymWriter() { throw null; }
        public override System.Type GetType(string className) { throw null; }
        public override System.Type GetType(string className, bool ignoreCase) { throw null; }
        public override System.Type GetType(string className, bool throwOnError, bool ignoreCase) { throw null; }
        public override System.Type[] GetTypes() { throw null; }
        public System.Reflection.Emit.TypeToken GetTypeToken(string name) { throw null; }
        public System.Reflection.Emit.TypeToken GetTypeToken(System.Type type) { throw null; }
        public override bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
        public override bool IsResource() { throw null; }
        public bool IsTransient() { throw null; }
        public override System.Reflection.FieldInfo ResolveField(int metadataToken, System.Type[] genericTypeArguments, System.Type[] genericMethodArguments) { throw null; }
        public override System.Reflection.MemberInfo ResolveMember(int metadataToken, System.Type[] genericTypeArguments, System.Type[] genericMethodArguments) { throw null; }
        public override System.Reflection.MethodBase ResolveMethod(int metadataToken, System.Type[] genericTypeArguments, System.Type[] genericMethodArguments) { throw null; }
        public override byte[] ResolveSignature(int metadataToken) { throw null; }
        public override string ResolveString(int metadataToken) { throw null; }
        public override System.Type ResolveType(int metadataToken, System.Type[] genericTypeArguments, System.Type[] genericMethodArguments) { throw null; }
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
        public void SetSymCustomAttribute(string name, byte[] data) { }
        public void SetUserEntryPoint(System.Reflection.MethodInfo entryPoint) { }
    }
    public partial class ParameterBuilder
    {
        internal ParameterBuilder() { }
        public virtual int Attributes { get { throw null; } }
        public bool IsIn { get { throw null; } }
        public bool IsOptional { get { throw null; } }
        public bool IsOut { get { throw null; } }
        public virtual string Name { get { throw null; } }
        public virtual int Position { get { throw null; } }
        public virtual System.Reflection.Emit.ParameterToken GetToken() { throw null; }
        public virtual void SetConstant(object defaultValue) { }
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
        [System.ObsoleteAttribute("An alternate API is available: Emit the MarshalAs custom attribute instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public virtual void SetMarshal(System.Reflection.Emit.UnmanagedMarshal unmanagedMarshal) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ParameterToken
    {
        public static readonly System.Reflection.Emit.ParameterToken Empty;
        public int Token { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Reflection.Emit.ParameterToken obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Reflection.Emit.ParameterToken a, System.Reflection.Emit.ParameterToken b) { throw null; }
        public static bool operator !=(System.Reflection.Emit.ParameterToken a, System.Reflection.Emit.ParameterToken b) { throw null; }
    }
    public enum PEFileKinds
    {
        ConsoleApplication = 2,
        Dll = 1,
        WindowApplication = 3,
    }
    public sealed partial class PropertyBuilder : System.Reflection.PropertyInfo
    {
        internal PropertyBuilder() { }
        public override System.Reflection.PropertyAttributes Attributes { get { throw null; } }
        public override bool CanRead { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override System.Type DeclaringType { get { throw null; } }
        public override System.Reflection.Module Module { get { throw null; } }
        public override string Name { get { throw null; } }
        public System.Reflection.Emit.PropertyToken PropertyToken { get { throw null; } }
        public override System.Type PropertyType { get { throw null; } }
        public override System.Type ReflectedType { get { throw null; } }
        public void AddOtherMethod(System.Reflection.Emit.MethodBuilder mdBuilder) { }
        public override System.Reflection.MethodInfo[] GetAccessors(bool nonPublic) { throw null; }
        public override object[] GetCustomAttributes(bool inherit) { throw null; }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public override System.Reflection.MethodInfo GetGetMethod(bool nonPublic) { throw null; }
        public override System.Reflection.ParameterInfo[] GetIndexParameters() { throw null; }
        public override System.Reflection.MethodInfo GetSetMethod(bool nonPublic) { throw null; }
        public override object GetValue(object obj, object[] index) { throw null; }
        public override object GetValue(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture) { throw null; }
        public override bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
        public void SetConstant(object defaultValue) { }
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
        public void SetGetMethod(System.Reflection.Emit.MethodBuilder mdBuilder) { }
        public void SetSetMethod(System.Reflection.Emit.MethodBuilder mdBuilder) { }
        public override void SetValue(object obj, object value, object[] index) { }
        public override void SetValue(object obj, object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct PropertyToken
    {
        public static readonly System.Reflection.Emit.PropertyToken Empty;
        public int Token { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Reflection.Emit.PropertyToken obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Reflection.Emit.PropertyToken a, System.Reflection.Emit.PropertyToken b) { throw null; }
        public static bool operator !=(System.Reflection.Emit.PropertyToken a, System.Reflection.Emit.PropertyToken b) { throw null; }
    }
    public sealed partial class SignatureHelper
    {
        internal SignatureHelper() { }
        public void AddArgument(System.Type clsArgument) { }
        public void AddArgument(System.Type argument, bool pinned) { }
        public void AddArgument(System.Type argument, System.Type[] requiredCustomModifiers, System.Type[] optionalCustomModifiers) { }
        public void AddArguments(System.Type[] arguments, System.Type[][] requiredCustomModifiers, System.Type[][] optionalCustomModifiers) { }
        public void AddSentinel() { }
        public override bool Equals(object obj) { throw null; }
        public static System.Reflection.Emit.SignatureHelper GetFieldSigHelper(System.Reflection.Module mod) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Reflection.Emit.SignatureHelper GetLocalVarSigHelper() { throw null; }
        public static System.Reflection.Emit.SignatureHelper GetLocalVarSigHelper(System.Reflection.Module mod) { throw null; }
        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.CallingConventions callingConvention, System.Type returnType) { throw null; }
        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module mod, System.Reflection.CallingConventions callingConvention, System.Type returnType) { throw null; }
        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module mod, System.Runtime.InteropServices.CallingConvention unmanagedCallConv, System.Type returnType) { throw null; }
        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module mod, System.Type returnType, System.Type[] parameterTypes) { throw null; }
        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Runtime.InteropServices.CallingConvention unmanagedCallingConvention, System.Type returnType) { throw null; }
        public static System.Reflection.Emit.SignatureHelper GetPropertySigHelper(System.Reflection.Module mod, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] requiredReturnTypeCustomModifiers, System.Type[] optionalReturnTypeCustomModifiers, System.Type[] parameterTypes, System.Type[][] requiredParameterTypeCustomModifiers, System.Type[][] optionalParameterTypeCustomModifiers) { throw null; }
        public static System.Reflection.Emit.SignatureHelper GetPropertySigHelper(System.Reflection.Module mod, System.Type returnType, System.Type[] parameterTypes) { throw null; }
        public static System.Reflection.Emit.SignatureHelper GetPropertySigHelper(System.Reflection.Module mod, System.Type returnType, System.Type[] requiredReturnTypeCustomModifiers, System.Type[] optionalReturnTypeCustomModifiers, System.Type[] parameterTypes, System.Type[][] requiredParameterTypeCustomModifiers, System.Type[][] optionalParameterTypeCustomModifiers) { throw null; }
        public byte[] GetSignature() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SignatureToken
    {
        public static readonly System.Reflection.Emit.SignatureToken Empty;
        public int Token { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Reflection.Emit.SignatureToken obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Reflection.Emit.SignatureToken a, System.Reflection.Emit.SignatureToken b) { throw null; }
        public static bool operator !=(System.Reflection.Emit.SignatureToken a, System.Reflection.Emit.SignatureToken b) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct StringToken
    {
        public int Token { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Reflection.Emit.StringToken obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Reflection.Emit.StringToken a, System.Reflection.Emit.StringToken b) { throw null; }
        public static bool operator !=(System.Reflection.Emit.StringToken a, System.Reflection.Emit.StringToken b) { throw null; }
    }
    public sealed partial class TypeBuilder : System.Type //TYPEINFO: System.Reflection.TypeInfo
    {
        internal TypeBuilder() { }
        public const int UnspecifiedTypeSize = 0;
        public override System.Reflection.Assembly Assembly { get { throw null; } }
        public override string AssemblyQualifiedName { get { throw null; } }
        public override System.Type BaseType { get { throw null; } }
        public override System.Reflection.MethodBase DeclaringMethod { get { throw null; } }
        public override System.Type DeclaringType { get { throw null; } }
        public override string FullName { get { throw null; } }
        public override System.Reflection.GenericParameterAttributes GenericParameterAttributes { get { throw null; } }
        public override int GenericParameterPosition { get { throw null; } }
        public override System.Guid GUID { get { throw null; } }
        public override bool IsConstructedGenericType { get { throw null; } }
        public override bool IsGenericParameter { get { throw null; } }
        public override bool IsGenericType { get { throw null; } }
        public override bool IsGenericTypeDefinition { get { throw null; } }
        public override bool IsSecurityCritical { get { throw null; } }
        public override bool IsSecuritySafeCritical { get { throw null; } }
        public override bool IsSecurityTransparent { get { throw null; } }
        public override System.Reflection.Module Module { get { throw null; } }
        public override string Name { get { throw null; } }
        public override string Namespace { get { throw null; } }
        public System.Reflection.Emit.PackingSize PackingSize { get { throw null; } }
        public override System.Type ReflectedType { get { throw null; } }
        public int Size { get { throw null; } }
        public override System.RuntimeTypeHandle TypeHandle { get { throw null; } }
        public System.Reflection.Emit.TypeToken TypeToken { get { throw null; } }
        public override System.Type UnderlyingSystemType { get { throw null; } }
//CAS        public void AddDeclarativeSecurity(System.Security.Permissions.SecurityAction action, System.Security.PermissionSet pset) { }
        public void AddInterfaceImplementation(System.Type interfaceType) { }
        public System.Type CreateType() { throw null; }
        public System.Reflection.TypeInfo CreateTypeInfo() { throw null; }
        public System.Reflection.Emit.ConstructorBuilder DefineConstructor(System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type[] parameterTypes) { throw null; }
        public System.Reflection.Emit.ConstructorBuilder DefineConstructor(System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type[] parameterTypes, System.Type[][] requiredCustomModifiers, System.Type[][] optionalCustomModifiers) { throw null; }
        public System.Reflection.Emit.ConstructorBuilder DefineDefaultConstructor(System.Reflection.MethodAttributes attributes) { throw null; }
        public System.Reflection.Emit.EventBuilder DefineEvent(string name, System.Reflection.EventAttributes attributes, System.Type eventtype) { throw null; }
        public System.Reflection.Emit.FieldBuilder DefineField(string fieldName, System.Type type, System.Reflection.FieldAttributes attributes) { throw null; }
        public System.Reflection.Emit.FieldBuilder DefineField(string fieldName, System.Type type, System.Type[] requiredCustomModifiers, System.Type[] optionalCustomModifiers, System.Reflection.FieldAttributes attributes) { throw null; }
        public System.Reflection.Emit.GenericTypeParameterBuilder[] DefineGenericParameters(params string[] names) { throw null; }
        public System.Reflection.Emit.FieldBuilder DefineInitializedData(string name, byte[] data, System.Reflection.FieldAttributes attributes) { throw null; }
        public System.Reflection.Emit.MethodBuilder DefineMethod(string name, System.Reflection.MethodAttributes attributes) { throw null; }
        public System.Reflection.Emit.MethodBuilder DefineMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention) { throw null; }
        public System.Reflection.Emit.MethodBuilder DefineMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes) { throw null; }
        public System.Reflection.Emit.MethodBuilder DefineMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] returnTypeRequiredCustomModifiers, System.Type[] returnTypeOptionalCustomModifiers, System.Type[] parameterTypes, System.Type[][] parameterTypeRequiredCustomModifiers, System.Type[][] parameterTypeOptionalCustomModifiers) { throw null; }
        public System.Reflection.Emit.MethodBuilder DefineMethod(string name, System.Reflection.MethodAttributes attributes, System.Type returnType, System.Type[] parameterTypes) { throw null; }
        public void DefineMethodOverride(System.Reflection.MethodInfo methodInfoBody, System.Reflection.MethodInfo methodInfoDeclaration) { }
        public System.Reflection.Emit.TypeBuilder DefineNestedType(string name) { throw null; }
        public System.Reflection.Emit.TypeBuilder DefineNestedType(string name, System.Reflection.TypeAttributes attr) { throw null; }
        public System.Reflection.Emit.TypeBuilder DefineNestedType(string name, System.Reflection.TypeAttributes attr, System.Type parent) { throw null; }
        public System.Reflection.Emit.TypeBuilder DefineNestedType(string name, System.Reflection.TypeAttributes attr, System.Type parent, int typeSize) { throw null; }
        public System.Reflection.Emit.TypeBuilder DefineNestedType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Reflection.Emit.PackingSize packSize) { throw null; }
        public System.Reflection.Emit.TypeBuilder DefineNestedType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Reflection.Emit.PackingSize packSize, int typeSize) { throw null; }
        public System.Reflection.Emit.TypeBuilder DefineNestedType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Type[] interfaces) { throw null; }
        public System.Reflection.Emit.MethodBuilder DefinePInvokeMethod(string name, string dllName, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes, System.Runtime.InteropServices.CallingConvention nativeCallConv, System.Runtime.InteropServices.CharSet nativeCharSet) { throw null; }
        public System.Reflection.Emit.MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes, System.Runtime.InteropServices.CallingConvention nativeCallConv, System.Runtime.InteropServices.CharSet nativeCharSet) { throw null; }
        public System.Reflection.Emit.MethodBuilder DefinePInvokeMethod(string name, string dllName, string entryName, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] returnTypeRequiredCustomModifiers, System.Type[] returnTypeOptionalCustomModifiers, System.Type[] parameterTypes, System.Type[][] parameterTypeRequiredCustomModifiers, System.Type[][] parameterTypeOptionalCustomModifiers, System.Runtime.InteropServices.CallingConvention nativeCallConv, System.Runtime.InteropServices.CharSet nativeCharSet) { throw null; }
        public System.Reflection.Emit.PropertyBuilder DefineProperty(string name, System.Reflection.PropertyAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes) { throw null; }
        public System.Reflection.Emit.PropertyBuilder DefineProperty(string name, System.Reflection.PropertyAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] returnTypeRequiredCustomModifiers, System.Type[] returnTypeOptionalCustomModifiers, System.Type[] parameterTypes, System.Type[][] parameterTypeRequiredCustomModifiers, System.Type[][] parameterTypeOptionalCustomModifiers) { throw null; }
        public System.Reflection.Emit.PropertyBuilder DefineProperty(string name, System.Reflection.PropertyAttributes attributes, System.Type returnType, System.Type[] parameterTypes) { throw null; }
        public System.Reflection.Emit.PropertyBuilder DefineProperty(string name, System.Reflection.PropertyAttributes attributes, System.Type returnType, System.Type[] returnTypeRequiredCustomModifiers, System.Type[] returnTypeOptionalCustomModifiers, System.Type[] parameterTypes, System.Type[][] parameterTypeRequiredCustomModifiers, System.Type[][] parameterTypeOptionalCustomModifiers) { throw null; }
        public System.Reflection.Emit.ConstructorBuilder DefineTypeInitializer() { throw null; }
        public System.Reflection.Emit.FieldBuilder DefineUninitializedData(string name, int size, System.Reflection.FieldAttributes attributes) { throw null; }
        protected override System.Reflection.TypeAttributes GetAttributeFlagsImpl() { throw null; }
        public static System.Reflection.ConstructorInfo GetConstructor(System.Type type, System.Reflection.ConstructorInfo constructor) { throw null; }
        protected override System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        public override System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override object[] GetCustomAttributes(bool inherit) { throw null; }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public override System.Type GetElementType() { throw null; }
        public override System.Reflection.EventInfo GetEvent(string name, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Reflection.EventInfo[] GetEvents() { throw null; }
        public override System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public static System.Reflection.FieldInfo GetField(System.Type type, System.Reflection.FieldInfo field) { throw null; }
        public override System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Type[] GetGenericArguments() { throw null; }
        public override System.Type GetGenericTypeDefinition() { throw null; }
        public override System.Type GetInterface(string name, bool ignoreCase) { throw null; }
        public override System.Reflection.InterfaceMapping GetInterfaceMap(System.Type interfaceType) { throw null; }
        public override System.Type[] GetInterfaces() { throw null; }
        public override System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.MemberTypes type, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public static System.Reflection.MethodInfo GetMethod(System.Type type, System.Reflection.MethodInfo method) { throw null; }
        protected override System.Reflection.MethodInfo GetMethodImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        public override System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Type GetNestedType(string name, System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Type[] GetNestedTypes(System.Reflection.BindingFlags bindingAttr) { throw null; }
        public override System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr) { throw null; }
        protected override System.Reflection.PropertyInfo GetPropertyImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers) { throw null; }
        protected override bool HasElementTypeImpl() { throw null; }
        public override object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namedParameters) { throw null; }
        protected override bool IsArrayImpl() { throw null; }
//TYPEINFO:        public override bool IsAssignableFrom(System.Reflection.TypeInfo typeInfo) { throw null; }
        public override bool IsAssignableFrom(System.Type c) { throw null; }
        protected override bool IsByRefImpl() { throw null; }
        protected override bool IsCOMObjectImpl() { throw null; }
        public bool IsCreated() { throw null; }
        public override bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
        protected override bool IsPointerImpl() { throw null; }
        protected override bool IsPrimitiveImpl() { throw null; }
        public override bool IsSubclassOf(System.Type c) { throw null; }
        public override System.Type MakeArrayType() { throw null; }
        public override System.Type MakeArrayType(int rank) { throw null; }
        public override System.Type MakeByRefType() { throw null; }
        public override System.Type MakeGenericType(params System.Type[] typeArguments) { throw null; }
        public override System.Type MakePointerType() { throw null; }
        public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
        public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
        public void SetParent(System.Type parent) { }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TypeToken
    {
        public static readonly System.Reflection.Emit.TypeToken Empty;
        public int Token { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Reflection.Emit.TypeToken obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Reflection.Emit.TypeToken a, System.Reflection.Emit.TypeToken b) { throw null; }
        public static bool operator !=(System.Reflection.Emit.TypeToken a, System.Reflection.Emit.TypeToken b) { throw null; }
    }
    [System.ObsoleteAttribute("An alternate API is available: Emit the MarshalAs custom attribute instead. http://go.microsoft.com/fwlink/?linkid=14202")]
    public sealed partial class UnmanagedMarshal
    {
        internal UnmanagedMarshal() { }
        public System.Runtime.InteropServices.UnmanagedType BaseType { get { throw null; } }
        public int ElementCount { get { throw null; } }
        public System.Runtime.InteropServices.UnmanagedType GetUnmanagedType { get { throw null; } }
        public System.Guid IIDGuid { get { throw null; } }
        public static System.Reflection.Emit.UnmanagedMarshal DefineByValArray(int elemCount) { throw null; }
        public static System.Reflection.Emit.UnmanagedMarshal DefineByValTStr(int elemCount) { throw null; }
        public static System.Reflection.Emit.UnmanagedMarshal DefineLPArray(System.Runtime.InteropServices.UnmanagedType elemType) { throw null; }
        public static System.Reflection.Emit.UnmanagedMarshal DefineSafeArray(System.Runtime.InteropServices.UnmanagedType elemType) { throw null; }
        public static System.Reflection.Emit.UnmanagedMarshal DefineUnmanagedMarshal(System.Runtime.InteropServices.UnmanagedType unmanagedType) { throw null; }
    }
}
namespace System.Text.RegularExpressions
{
    public partial class RegexCompilationInfo
    {
        public RegexCompilationInfo(string pattern, System.Text.RegularExpressions.RegexOptions options, string name, string fullnamespace, bool ispublic) { }
        public RegexCompilationInfo(string pattern, System.Text.RegularExpressions.RegexOptions options, string name, string fullnamespace, bool ispublic, System.TimeSpan matchTimeout) { }
        public bool IsPublic { get { throw null; } set { } }
        public System.TimeSpan MatchTimeout { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public System.Text.RegularExpressions.RegexOptions Options { get { throw null; } set { } }
        public string Pattern { get { throw null; } set { } }
    }
}