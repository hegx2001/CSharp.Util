namespace MultiLanguage
{
    using System.Runtime.InteropServices;

    [ComImport, CoClass(typeof(CMLangStringClass)), Guid("C04D65CE-B70D-11D0-B188-00AA0038C969")]
    internal interface CMLangString : IMLangString
    {
    }
}