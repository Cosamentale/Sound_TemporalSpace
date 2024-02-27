extern alias e16;
extern alias e1;
extern alias e2;
extern alias e10;
extern alias e14;

using n5 = e2::VL.Model;
using n3 = global::_TSOSCContainer06022024CELIA_;
using n8 = e2::VL.AppServices.CompilerServices;
using n1 = e2::VL.Core.CompilerServices;
using n2 = e2::VL.Core;
using n7 = global::_TSOSCContainer06022024CELIA_.__auto;
using n10 = e10::_VL_CoreLib_;
using n4 = e1::VL.Core.CompilerServices;
using n6 = global::_TSOSCContainer06022024CELIA_.Main;
using n12 = e16::_VL_Skia_;
using n11 = e14::_VL_IO_OSC_;
using n9 = e1::VL.Core;

[assembly: n1.CompilerVersionAttribute("2023.5.2")]
[assembly: n1.SymbolSourceReferenceAttribute("VL.CoreLib.vl", n2.SymbolSourceKind.Document, false, false)]
[assembly: n1.SymbolSourceReferenceAttribute("VL.IO.OSC.vl", n2.SymbolSourceKind.Document, false, false)]
[assembly: n1.SymbolSourceReferenceAttribute("VL.Skia.vl", n2.SymbolSourceKind.Document, false, false)]
[assembly: n4.AssemblyInitializerAttribute(typeof(n3.RoWK1pOK0gPLwpiC9YkoXcInitializer))]
[assembly: n1.TypeImportAttribute("RoWK1pOK0gPLwpiC9YkoXc", "BpnR2c6W7MGQYBG0HaeBC6", "OSCBridger", "Main", n2.SymbolSmell.Default | n2.SymbolSmell.Hidden, n5.KnownTypeStructure.None, typeof(n6.OSCBridger_BpnR2c6W7MGQYBG0HaeBC6), null, false, true)]
[assembly: n1.ProcessAttribute("OSCBridger", "Main", n2.SymbolSmell.Default, typeof(n6.OSCBridger_BpnR2c6W7MGQYBG0HaeBC6), false, "Create", "Update")]
[assembly: n1.TypeImportAttribute("RoWK1pOK0gPLwpiC9YkoXc", "HAqJBIV7zZxP3TIz3hDCiw", "OSCContainer", "Main", n2.SymbolSmell.Default | n2.SymbolSmell.Hidden, n5.KnownTypeStructure.None, typeof(n6.OSCContainer_HAqJBIV7zZxP3TIz3hDCiw), null, false, true)]
[assembly: n1.ProcessAttribute("OSCContainer", "Main", n2.SymbolSmell.Default, typeof(n6.OSCContainer_HAqJBIV7zZxP3TIz3hDCiw), false, "Create", "Update")]
[assembly: n1.TypeImportAttribute("RoWK1pOK0gPLwpiC9YkoXc", "LiviZnNQlUkPYNSURjpf0v", "MaxMin", "Main", n2.SymbolSmell.Default | n2.SymbolSmell.Hidden, n5.KnownTypeStructure.None, typeof(n6.MaxMin_LiviZnNQlUkPYNSURjpf0v), null, false, true)]
[assembly: n1.ProcessAttribute("MaxMin", "Main", n2.SymbolSmell.Default, typeof(n6.MaxMin_LiviZnNQlUkPYNSURjpf0v), false, "Create", "Update")]
[assembly: n1.TypeImportAttribute("RoWK1pOK0gPLwpiC9YkoXc", "PWFUi8qwqScPkky6ft9xr8", "TSOSCContainer06022024CELIAApplication", "Main", n2.SymbolSmell.Default | n2.SymbolSmell.Hidden, n5.KnownTypeStructure.None, typeof(n7.TSOSCContainer06022024CELIAApplication_PWFUi8qwqScPkky6ft9xr8), null, false, true)]
[assembly: n8.AdaptiveImplementationsAttribute(typeof(n3.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc))]
namespace _TSOSCContainer06022024CELIA_
{
    public sealed class RoWK1pOK0gPLwpiC9YkoXcInitializer : n4.AssemblyInitializer<n3.RoWK1pOK0gPLwpiC9YkoXcInitializer>
    {
        protected override sealed void RegisterServices(n9.IVLFactory factory)
        {
            n10.LMFQrbYrtQvO4pn4vSywS3Initializer.Default.Init(factory);
            n11.Bx9aFHFOZjuOHfIbMh6cIZInitializer.Default.Init(factory);
            n12.M1XXME8bUtmNxzMxVHhNawInitializer.Default.Init(factory);
            if (factory.OnlyStaticServices)
                return;
        }
    }
}