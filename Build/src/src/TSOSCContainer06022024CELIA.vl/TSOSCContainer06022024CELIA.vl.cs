extern alias e1;
extern alias e2;
extern alias e3;
extern alias e10;
extern alias e14;

using n32 = e10::_CoreLibBasics_.Primitive;
using n23 = e2::VL.AppServices;
using n6 = e2::VL.Model;
using n25 = e14::_VL_IO_OSC_.IO.OSC;
using n10 = global::_TSOSCContainer06022024CELIA_;
using n18 = e1::VL.Lib.Animation;
using n34 = e10::_CoreLibBasics_.System.Conversion;
using n11 = e10::_VL_Animation_.Animation.Functions;
using n24 = global::System.Collections.Generic;
using n1 = e2::VL.AppServices.CompilerServices;
using n3 = e2::VL.Core.CompilerServices;
using n17 = e10::_CoreLibBasics_.Animation.IClock;
using n4 = e2::VL.Core;
using n31 = global::_TSOSCContainer06022024CELIA_.__auto;
using n13 = e3::Stride.Core.Mathematics;
using n21 = e1::VL.Core.Utils;
using n8 = e1::VL.Core.CompilerServices;
using n14 = e10::_CoreLibBasics_._3D.Vector3;
using n26 = e10::_CoreLibBasics_.Animation;
using n5 = global::_TSOSCContainer06022024CELIA_.Main;
using n27 = global::System.Runtime.CompilerServices;
using n20 = e1::VL.Lib.Collections;
using n30 = e10::_VL_Collections_.Collections.Sequence;
using n33 = e10::_CoreLibBasics_.Math;
using n16 = e10::_CoreLibBasics_.Math.Ranges.Generic;
using n9 = e10::_CoreLibBasics_.Primitive.String;
using n19 = e10::_VL_Animation_.Animation;
using n29 = e10::_VL_Collections_.Collections.Spread;
using n2 = global::System;
using n22 = e10::_CoreLibBasics_.Control;
using n7 = e1::VL.Core;
using n28 = e10::_CoreLibBasics_.Animation.IFrameClock;
using n15 = e10::_CoreLibBasics_.Math.Generic;
using n12 = e10::_CoreLibBasics_.Primitive.Float32;

namespace _TSOSCContainer06022024CELIA_.Main
{
    [n1.ElementAttribute(TracingId = 7304U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "BpnR2c6W7MGQYBG0HaeBC6", Name = "OSCBridger")]
    [n2.SerializableAttribute]
    [n3.NameAttribute("OSCBridger")]
    [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
    public sealed class OSCBridger_BpnR2c6W7MGQYBG0HaeBC6 : n4.PatchedObject, n2.IDisposable
    {
        [return: n3.PinAttribute("Output", isState: true)]
        [n8.CreateNewAttribute]
        [n1.ElementAttribute(DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "FwsQgpifi8pQRUTfPzH01c", Name = "Create")]
        [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
        public static n5.OSCBridger_BpnR2c6W7MGQYBG0HaeBC6 Create([n3.PinAttribute("Node Context", visibility: n6.PinVisibility.Hidden)] n7.NodeContext Node_Context)
        {
            var instance = new OSCBridger_BpnR2c6W7MGQYBG0HaeBC6(Node_Context, n4.PatchedObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [return: n3.PinAttribute("Output", isState: true)]
        [n8.CreateDefaultAttribute]
        [n1.ElementAttribute(Name = "CreateDefault")]
        [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
        public static n5.OSCBridger_BpnR2c6W7MGQYBG0HaeBC6 CreateDefault()
        {
            var instance = new OSCBridger_BpnR2c6W7MGQYBG0HaeBC6(n7.NodeContext.Default, n4.PatchedObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        [return: n3.PinAttribute("Output", isState: true)]
        [n1.ElementAttribute(DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "CVLX7CBcW0jMg6snJtOtrj", Name = "Update")]
        [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
        public n5.OSCBridger_BpnR2c6W7MGQYBG0HaeBC6 Update([n3.PinAttribute("ServerInput")] n2.IObservable<n20.Spread<n25.OSCMessage_R>> ServerInput_In, [n3.PinAttribute("ClientInput")] n25.OSCClient_C ClientInput_In, [n3.PinAttribute("BaseAddressName")] string BaseAddressName_In, [n3.PinAttribute("SubSpeed")] float SubSpeed_In, [n1.SerializedDefaultValueAttribute("True", false)][n3.PinAttribute("Enable")] bool Enable_In, [n3.PinAttribute("ServerOutput")] out n2.IObservable<n20.Spread<n25.OSCMessage_R>> ServerOutput_Out, [n3.PinAttribute("ClientOutput")] out n25.OSCClient_C ClientOutput_Out, [n3.PinAttribute("EndSpeed")] out float EndSpeed_Out, [n3.PinAttribute("SpeedAddressOutput")] out string SpeedAddressOutput_Out, [n3.PinAttribute("Sending")] out bool Sending_Out, [n3.PinAttribute("EndX")] out float EndX_Out, [n3.PinAttribute("EndY")] out float EndY_Out, [n3.PinAttribute("EndZ")] out float EndZ_Out)
        {
            var __nodeContext = __GetContext__();
            string __pad_PkI33oXp7QMMNbkR8BibZt_0 = __slot_PkI33oXp7QMMNbkR8BibZt;
            string __pad_TWWFJK9GeTbPNKVVqfBzIl_1 = __slot_TWWFJK9GeTbPNKVVqfBzIl;
            float __pad_DzrXOegsrj6MkTVUzoE0G3_2 = __slot_DzrXOegsrj6MkTVUzoE0G3;
            float __pad_CW0htAIJurvMlc7gA1aePK_3 = __slot_CW0htAIJurvMlc7gA1aePK;
            float __pad_RvlCWZsd6AkPivuVkyhK3c_4 = __slot_RvlCWZsd6AkPivuVkyhK3c;
            string __pad_GMQdVCqn1OgLQA5Mabt7Er_5 = __slot_GMQdVCqn1OgLQA5Mabt7Er;
            string __pad_R3uENvZI8G7OjBP7jTBcEU_6 = __slot_R3uENvZI8G7OjBP7jTBcEU;
            float __pad_NCF28Ot9oauP7b0Vd4AGod_7 = __slot_NCF28Ot9oauP7b0Vd4AGod;
            float __pad_HYl0ajjesh1P6qiXSYhtio_8 = __slot_HYl0ajjesh1P6qiXSYhtio;
            float __pad_FdvylScs71fOgpHduW7Z3E_9 = __slot_FdvylScs71fOgpHduW7Z3E;
            float __pad_MwdklqSOsgjMLGWpNxKnrp_10 = __slot_MwdklqSOsgjMLGWpNxKnrp;
            string __pad_MCZOuVdOOgONG8hRDvBUYY_11 = __slot_MCZOuVdOOgONG8hRDvBUYY;
            float __pad_CDeQnwc9nU2PXRFBkGC0qY_12 = __slot_CDeQnwc9nU2PXRFBkGC0qY;
            string __pad_HbyI5fVKMTfMEc5MEjMUvx_13 = __slot_HbyI5fVKMTfMEc5MEjMUvx;
            float __pad_COgAKg2AVdMMcqVwuDXuJq_14 = __slot_COgAKg2AVdMMcqVwuDXuJq;
            n9._Operations_.OperatorPlus(Input_In: __pad_PkI33oXp7QMMNbkR8BibZt_0, Input_2_In: BaseAddressName_In, Output_Out: out string Output_15);
            n9._Operations_.OperatorPlus(Input_In: Output_15, Input_2_In: __pad_HbyI5fVKMTfMEc5MEjMUvx_13, Output_Out: out string Output_16);
            bool Learn_17 = false;
            var State_Output_22 = this.__p_ViAblvoyIuwMkTCOhVBicU.Update<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Input_In: ServerInput_In, Address_In: Output_16, Learn_In: Learn_17, Output_Out: out float Output_18, Is_Learning_Out: out bool Is_Learning_19, On_Data_Out: out bool On_Data_20, Address_Out: out string Address_21);
            n9._Operations_.OperatorPlus(Input_In: Output_15, Input_2_In: __pad_TWWFJK9GeTbPNKVVqfBzIl_1, Output_Out: out string Output_23);
            bool Learn_24 = false;
            var State_Output_29 = this.__p_IjoH3eNnYkUM6yi1U3Pfx4.Update<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Input_In: ServerInput_In, Address_In: Output_23, Learn_In: Learn_24, Output_Out: out float Output_25, Is_Learning_Out: out bool Is_Learning_26, On_Data_Out: out bool On_Data_27, Address_Out: out string Address_28);
            float Cutoff_for_Derivative_30 = 1F;
            var Output_32 = this.__p_GhYCP5v4Rd1L7zc7SRoxxR.Update<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Goto_Position_In: Output_25, Minimum_Cutoff_Frequency_In: __pad_DzrXOegsrj6MkTVUzoE0G3_2, Beta_In: __pad_CW0htAIJurvMlc7gA1aePK_3, Cutoff_for_Derivative_In: Cutoff_for_Derivative_30, Position_Out: out float Position_31);
            n9._Operations_.OperatorPlus(Input_In: Output_15, Input_2_In: __pad_MCZOuVdOOgONG8hRDvBUYY_11, Output_Out: out string Output_33);
            bool Learn_34 = false;
            var State_Output_39 = this.__p_E9eRumVUxfKN3CaVgFCgt2.Update<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Input_In: ServerInput_In, Address_In: Output_33, Learn_In: Learn_34, Output_Out: out float Output_35, Is_Learning_Out: out bool Is_Learning_36, On_Data_Out: out bool On_Data_37, Address_Out: out string Address_38);
            bool Cyclic_40 = false;
            bool Jump_41 = false;
            bool Force_New_Func_42 = false;
            var Output_48 = this.__p_IYE3UmqiI9VQEdUiDU9CZH.Update(Goto_Position_In: Output_35, Filter_Time_In: __pad_CDeQnwc9nU2PXRFBkGC0qY_12, Cyclic_In: Cyclic_40, Jump_In: Jump_41, Force_New_Func_In: Force_New_Func_42, Position_Out: out float Position_43, Velocity_Out: out float Velocity_44, Acceleration_Out: out float Acceleration_45, Function_Out: out n11.OscillatorFunction_C<float> Function_46, Has_Changed_Out: out bool Has_Changed_47);
            float __pad_AmABh5LLZQKON43FlLesTi_49 = Position_43;
            n12._Operations_.OperatorLess(Input_In: __pad_AmABh5LLZQKON43FlLesTi_49, Input_2_In: __pad_COgAKg2AVdMMcqVwuDXuJq_14, Result_Out: out bool Result_50);
            bool __pad_Bby0JNndIcyNcgvXZEpXpX_51 = Result_50;
            float Cutoff_for_Derivative_52 = 1F;
            var Output_54 = this.__p_TzY088IXP4sPMf7fc0Mqoe.Update<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Goto_Position_In: Output_18, Minimum_Cutoff_Frequency_In: __pad_DzrXOegsrj6MkTVUzoE0G3_2, Beta_In: __pad_CW0htAIJurvMlc7gA1aePK_3, Cutoff_for_Derivative_In: Cutoff_for_Derivative_52, Position_Out: out float Position_53);
            n12._Operations_.OperatorMultiply(Input_In: Position_53, Input_2_In: __pad_RvlCWZsd6AkPivuVkyhK3c_4, Output_Out: out float Output_55);
            n9._Operations_.OperatorPlus(Input_In: Output_15, Input_2_In: __pad_GMQdVCqn1OgLQA5Mabt7Er_5, Output_Out: out string Output_56);
            bool Learn_57 = false;
            var State_Output_62 = this.__p_LAcCpNom4euPk6qyMT2rDl.Update<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Input_In: ServerInput_In, Address_In: Output_56, Learn_In: Learn_57, Output_Out: out float Output_58, Is_Learning_Out: out bool Is_Learning_59, On_Data_Out: out bool On_Data_60, Address_Out: out string Address_61);
            float Cutoff_for_Derivative_63 = 1F;
            var Output_65 = this.__p_D1n6gnv0MfqLaOSWlk193N.Update<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Goto_Position_In: Output_58, Minimum_Cutoff_Frequency_In: __pad_DzrXOegsrj6MkTVUzoE0G3_2, Beta_In: __pad_CW0htAIJurvMlc7gA1aePK_3, Cutoff_for_Derivative_In: Cutoff_for_Derivative_63, Position_Out: out float Position_64);
            n14._Operations_.Vector_Join(X_In: Output_55, Y_In: Position_31, Z_In: Position_64, Output_Out: out n13.Vector3 Output_66);
            var Output_68 = this.__p_UTqhLETXTLULpViiE6Hak2.GetValue(Value_Out: out n13.Vector3 Value_67);
            n15._Operations_.Distance<n13.Vector3, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Input_In: Output_66, Input_2_In: Value_67, Result_Out: out float Result_69);
            n12._Operations_.OperatorMultiply(Input_In: Result_69, Input_2_In: __pad_HYl0ajjesh1P6qiXSYhtio_8, Output_Out: out float Output_70);
            var Output_72 = this.__p_PHkO4IGYfZYP0GfD0x3Bye.GetValue(Value_Out: out float Value_71);
            n12._Operations_.OperatorPlus(Input_In: Output_70, Input_2_In: Value_71, Output_Out: out float Output_73);
            n12._Operations_.OperatorMultiply(Input_In: __pad_FdvylScs71fOgpHduW7Z3E_9, Input_2_In: __pad_HYl0ajjesh1P6qiXSYhtio_8, Output_Out: out float Output_74);
            n12._Operations_.OperatorMinus(Input_In: Output_73, Input_2_In: Output_74, Output_Out: out float Output_75);
            float Minimum_76 = 0F;
            n16._Operations_.Clamp<float, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Input_In: Output_75, Minimum_In: Minimum_76, Maximum_In: __pad_MwdklqSOsgjMLGWpNxKnrp_10, Output_Out: out float Output_77);
            float __auto_78;
            float __auto_79;
            float __auto_80;
            float __auto_81;
            if (__pad_Bby0JNndIcyNcgvXZEpXpX_51)
            {
                float __pad_Hqk8H1Nu05lOEsPFidTp6O_83 = __slot_Hqk8H1Nu05lOEsPFidTp6O;
                float __pad_Ncp0OvGYoBoPFP4ENNOvkZ_84 = __slot_Ncp0OvGYoBoPFP4ENNOvkZ;
                float __pad_DRG7qsrzWJtN0Nfx9uSw2d_85 = __slot_DRG7qsrzWJtN0Nfx9uSw2d;
                float __pad_UK7OdT62lH3ODXoLfxnh3m_86 = __slot_UK7OdT62lH3ODXoLfxnh3m;
                n12._Operations_.OperatorMultiply(Input_In: Output_77, Input_2_In: __pad_Hqk8H1Nu05lOEsPFidTp6O_83, Output_Out: out float Output_87);
                __auto_78 = Output_87;
                n12._Operations_.OperatorMultiply(Input_In: Output_55, Input_2_In: __pad_Ncp0OvGYoBoPFP4ENNOvkZ_84, Output_Out: out float Output_88);
                __auto_79 = Output_88;
                n12._Operations_.OperatorMultiply(Input_In: Position_31, Input_2_In: __pad_DRG7qsrzWJtN0Nfx9uSw2d_85, Output_Out: out float Output_89);
                __auto_80 = Output_89;
                n12._Operations_.OperatorMultiply(Input_In: Position_64, Input_2_In: __pad_UK7OdT62lH3ODXoLfxnh3m_86, Output_Out: out float Output_90);
                __auto_81 = Output_90;
            }
            else
            {
                __auto_78 = Output_77;
                __auto_79 = Output_55;
                __auto_80 = Position_31;
                __auto_81 = Position_64;
            }

            n9._Operations_.OperatorPlus(Input_In: Output_15, Input_2_In: __pad_R3uENvZI8G7OjBP7jTBcEU_6, Output_Out: out string Output_91);
            int Index_92 = n2.Convert.ToInt32(__pad_Bby0JNndIcyNcgvXZEpXpX_51);
            bool Cyclic_93 = false;
            bool Jump_94 = false;
            bool Force_New_Func_95 = false;
            var Output_101 = this.__p_OTlxrUfMvuaMqXouFLOb55.Update(Goto_Position_In: __auto_78, Filter_Time_In: __pad_NCF28Ot9oauP7b0Vd4AGod_7, Cyclic_In: Cyclic_93, Jump_In: Jump_94, Force_New_Func_In: Force_New_Func_95, Position_Out: out float Position_96, Velocity_Out: out float Velocity_97, Acceleration_Out: out float Acceleration_98, Function_Out: out n11.OscillatorFunction_C<float> Function_99, Has_Changed_Out: out bool Has_Changed_100);
            float __auto_102;
            var state_103 = n23.CompilationHelper.Restore<__VWbVqF6ujVQLI5T7jTTdgE>(this.__if_MnhDSYkBRkTNSTdf8lV1Jz, __nodeContext);
            if (__pad_Bby0JNndIcyNcgvXZEpXpX_51)
            {
                if (state_103 == null)
                {
                    state_103 = new __VWbVqF6ujVQLI5T7jTTdgE()
                    {__pin_group_Input_In_UYCWZpUZSJ2N1L3S84ruTe = default(n20.Spread<float>)};
                    n7.NodeContext Node_Context_104 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "NvEsomnHF81Lev4YdN8RbK", 7473U);
                    n18.IClock Clock_105 = n17._Operations_.CreateDefault();
                    var Output_106 = n19.Damper_Qhw7aQNplhrMCum2sxpG8z.Create(Node_Context: Node_Context_104, Clock_In: Clock_105);
                    state_103.__p_NvEsomnHF81Lev4YdN8RbK = Output_106;
                }

                var builder_107 = n21.CollectionBuilders.GetBuilder(state_103.__pin_group_Input_In_UYCWZpUZSJ2N1L3S84ruTe, 2);
                builder_107.Add(Position_96);
                builder_107.Add(SubSpeed_In);
                var __pin_group_Input_In_UYCWZpUZSJ2N1L3S84ruTe_108 = builder_107.Commit();
                n22._Operations_.Switch<float, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Index_In: Index_92, Input_In: __pin_group_Input_In_UYCWZpUZSJ2N1L3S84ruTe_108, Output_Out: out float Output_109);
                float Filter_Time_110 = 1F;
                bool Cyclic_111 = false;
                bool Jump_112 = false;
                bool Force_New_Func_113 = false;
                var Output_119 = state_103.__p_NvEsomnHF81Lev4YdN8RbK.Update(Goto_Position_In: Output_109, Filter_Time_In: Filter_Time_110, Cyclic_In: Cyclic_111, Jump_In: Jump_112, Force_New_Func_In: Force_New_Func_113, Position_Out: out float Position_114, Velocity_Out: out float Velocity_115, Acceleration_Out: out float Acceleration_116, Function_Out: out n11.OscillatorFunction_C<float> Function_117, Has_Changed_Out: out bool Has_Changed_118);
                __auto_102 = Position_114;
                if (this.__GetContext__().IsImmutable)
                    state_103 = !n24.EqualityComparer<n20.Spread<float>>.Default.Equals(__pin_group_Input_In_UYCWZpUZSJ2N1L3S84ruTe_108, state_103.__pin_group_Input_In_UYCWZpUZSJ2N1L3S84ruTe) || !n24.EqualityComparer<n19.Damper_Qhw7aQNplhrMCum2sxpG8z>.Default.Equals(Output_119, state_103.__p_NvEsomnHF81Lev4YdN8RbK) ? new __VWbVqF6ujVQLI5T7jTTdgE(state_103)
                    {__pin_group_Input_In_UYCWZpUZSJ2N1L3S84ruTe = __pin_group_Input_In_UYCWZpUZSJ2N1L3S84ruTe_108, __p_NvEsomnHF81Lev4YdN8RbK = Output_119} : state_103;
                else
                {
                    state_103.__pin_group_Input_In_UYCWZpUZSJ2N1L3S84ruTe = __pin_group_Input_In_UYCWZpUZSJ2N1L3S84ruTe_108;
                    state_103.__p_NvEsomnHF81Lev4YdN8RbK = Output_119;
                }
            }
            else
            {
                __auto_102 = Position_96;
            }

            bool __pad_FrmBtLs68pYOzv1XADLCoO_120 = Enable_In;
            bool Bundled_Per_Frame_121 = true;
            var Output_122 = ClientInput_In.SendMessage<float, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Address_In: Output_91, Arguments_In: __auto_102, Bundled_Per_Frame_In: Bundled_Per_Frame_121, Apply_In: __pad_FrmBtLs68pYOzv1XADLCoO_120);
            bool Cyclic_123 = false;
            bool Jump_124 = false;
            bool Force_New_Func_125 = false;
            var Output_131 = this.__p_FlDAk4R5oJrLcJNMxSid7R.Update(Goto_Position_In: __auto_79, Filter_Time_In: __pad_NCF28Ot9oauP7b0Vd4AGod_7, Cyclic_In: Cyclic_123, Jump_In: Jump_124, Force_New_Func_In: Force_New_Func_125, Position_Out: out float Position_126, Velocity_Out: out float Velocity_127, Acceleration_Out: out float Acceleration_128, Function_Out: out n11.OscillatorFunction_C<float> Function_129, Has_Changed_Out: out bool Has_Changed_130);
            bool __pad_F8PuLLEofvDNLcUhgQwgBg_132 = Enable_In;
            bool Bundled_Per_Frame_133 = true;
            var Output_134 = Output_122.SendMessage<float, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Address_In: Output_16, Arguments_In: Position_126, Bundled_Per_Frame_In: Bundled_Per_Frame_133, Apply_In: __pad_F8PuLLEofvDNLcUhgQwgBg_132);
            bool Cyclic_135 = false;
            bool Jump_136 = false;
            bool Force_New_Func_137 = false;
            var Output_143 = this.__p_PeURRzywtrxONaoiFR3RYv.Update(Goto_Position_In: __auto_80, Filter_Time_In: __pad_NCF28Ot9oauP7b0Vd4AGod_7, Cyclic_In: Cyclic_135, Jump_In: Jump_136, Force_New_Func_In: Force_New_Func_137, Position_Out: out float Position_138, Velocity_Out: out float Velocity_139, Acceleration_Out: out float Acceleration_140, Function_Out: out n11.OscillatorFunction_C<float> Function_141, Has_Changed_Out: out bool Has_Changed_142);
            bool __pad_BoMJQ8m9VnILHXmM9Vff0b_144 = Enable_In;
            bool Bundled_Per_Frame_145 = true;
            var Output_146 = Output_134.SendMessage<float, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Address_In: Output_23, Arguments_In: Position_138, Bundled_Per_Frame_In: Bundled_Per_Frame_145, Apply_In: __pad_BoMJQ8m9VnILHXmM9Vff0b_144);
            bool Cyclic_147 = false;
            bool Jump_148 = false;
            bool Force_New_Func_149 = false;
            var Output_155 = this.__p_SeXFHDq458eNAC1rRzld6k.Update(Goto_Position_In: __auto_81, Filter_Time_In: __pad_NCF28Ot9oauP7b0Vd4AGod_7, Cyclic_In: Cyclic_147, Jump_In: Jump_148, Force_New_Func_In: Force_New_Func_149, Position_Out: out float Position_150, Velocity_Out: out float Velocity_151, Acceleration_Out: out float Acceleration_152, Function_Out: out n11.OscillatorFunction_C<float> Function_153, Has_Changed_Out: out bool Has_Changed_154);
            bool __pad_PtOWDPWZzMaNVgJzcNVH4t_156 = Enable_In;
            bool Bundled_Per_Frame_157 = true;
            var Output_158 = Output_146.SendMessage<float, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Address_In: Output_56, Arguments_In: Position_150, Bundled_Per_Frame_In: Bundled_Per_Frame_157, Apply_In: __pad_PtOWDPWZzMaNVgJzcNVH4t_156);
            float Input_2_159 = 0F;
            n12._Operations_.OperatorGreater(Input_In: __auto_102, Input_2_In: Input_2_159, Result_Out: out bool Result_160);
            bool SetValue_161 = true;
            n22.FrameDelay_VYPkCl1PIexL9IROxeL6ju<n13.Vector3> Output_162 = Output_68;
            if (SetValue_161)
            {
                Output_162 = Output_68.SetValue(Value_In: Output_66);
            }

            bool SetValue_163 = true;
            n22.FrameDelay_VYPkCl1PIexL9IROxeL6ju<float> Output_164 = Output_72;
            if (SetValue_163)
            {
                Output_164 = Output_72.SetValue(Value_In: Output_77);
            }

            float __pad_SNs3pVLHmplN4G3yFB1J56_165 = Output_77;
            ServerOutput_Out = ServerInput_In;
            ClientOutput_Out = Output_158;
            EndSpeed_Out = __auto_102;
            SpeedAddressOutput_Out = Output_91;
            Sending_Out = Result_160;
            EndX_Out = Position_126;
            EndY_Out = Position_138;
            EndZ_Out = Position_150;
            n5.OSCBridger_BpnR2c6W7MGQYBG0HaeBC6 that_166 = this;
            if (this.__GetContext__().IsImmutable)
                that_166 = !n24.EqualityComparer<n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>>.Default.Equals(State_Output_22, this.__p_ViAblvoyIuwMkTCOhVBicU) || !n24.EqualityComparer<n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>>.Default.Equals(State_Output_29, this.__p_IjoH3eNnYkUM6yi1U3Pfx4) || !n24.EqualityComparer<n26.OneEuroFilter_FvW0xl6URWWMjdPsygqbs7<float>>.Default.Equals(Output_32, this.__p_GhYCP5v4Rd1L7zc7SRoxxR) || !n24.EqualityComparer<n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>>.Default.Equals(State_Output_39, this.__p_E9eRumVUxfKN3CaVgFCgt2) || !n24.EqualityComparer<n19.Damper_Qhw7aQNplhrMCum2sxpG8z>.Default.Equals(Output_48, this.__p_IYE3UmqiI9VQEdUiDU9CZH) || Position_43 != this.__slot_AmABh5LLZQKON43FlLesTi || Result_50 != this.__slot_Bby0JNndIcyNcgvXZEpXpX || !n24.EqualityComparer<n26.OneEuroFilter_FvW0xl6URWWMjdPsygqbs7<float>>.Default.Equals(Output_54, this.__p_TzY088IXP4sPMf7fc0Mqoe) || !n24.EqualityComparer<n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>>.Default.Equals(State_Output_62, this.__p_LAcCpNom4euPk6qyMT2rDl) || !n24.EqualityComparer<n26.OneEuroFilter_FvW0xl6URWWMjdPsygqbs7<float>>.Default.Equals(Output_65, this.__p_D1n6gnv0MfqLaOSWlk193N) || !n24.EqualityComparer<n22.FrameDelay_VYPkCl1PIexL9IROxeL6ju<n13.Vector3>>.Default.Equals(Output_162, this.__p_UTqhLETXTLULpViiE6Hak2) || !n24.EqualityComparer<n22.FrameDelay_VYPkCl1PIexL9IROxeL6ju<float>>.Default.Equals(Output_164, this.__p_PHkO4IGYfZYP0GfD0x3Bye) || !n24.EqualityComparer<n19.Damper_Qhw7aQNplhrMCum2sxpG8z>.Default.Equals(Output_101, this.__p_OTlxrUfMvuaMqXouFLOb55) || !n24.EqualityComparer<n2.Object>.Default.Equals(state_103, this.__if_MnhDSYkBRkTNSTdf8lV1Jz) || Enable_In != this.__slot_FrmBtLs68pYOzv1XADLCoO || !n24.EqualityComparer<n19.Damper_Qhw7aQNplhrMCum2sxpG8z>.Default.Equals(Output_131, this.__p_FlDAk4R5oJrLcJNMxSid7R) || Enable_In != this.__slot_F8PuLLEofvDNLcUhgQwgBg || !n24.EqualityComparer<n19.Damper_Qhw7aQNplhrMCum2sxpG8z>.Default.Equals(Output_143, this.__p_PeURRzywtrxONaoiFR3RYv) || Enable_In != this.__slot_BoMJQ8m9VnILHXmM9Vff0b || !n24.EqualityComparer<n19.Damper_Qhw7aQNplhrMCum2sxpG8z>.Default.Equals(Output_155, this.__p_SeXFHDq458eNAC1rRzld6k) || Enable_In != this.__slot_PtOWDPWZzMaNVgJzcNVH4t || Output_77 != this.__slot_SNs3pVLHmplN4G3yFB1J56 ? new n5.OSCBridger_BpnR2c6W7MGQYBG0HaeBC6(this)
                {__p_ViAblvoyIuwMkTCOhVBicU = State_Output_22, __p_IjoH3eNnYkUM6yi1U3Pfx4 = State_Output_29, __p_GhYCP5v4Rd1L7zc7SRoxxR = Output_32, __p_E9eRumVUxfKN3CaVgFCgt2 = State_Output_39, __p_IYE3UmqiI9VQEdUiDU9CZH = Output_48, __slot_AmABh5LLZQKON43FlLesTi = Position_43, __slot_Bby0JNndIcyNcgvXZEpXpX = Result_50, __p_TzY088IXP4sPMf7fc0Mqoe = Output_54, __p_LAcCpNom4euPk6qyMT2rDl = State_Output_62, __p_D1n6gnv0MfqLaOSWlk193N = Output_65, __p_UTqhLETXTLULpViiE6Hak2 = Output_162, __p_PHkO4IGYfZYP0GfD0x3Bye = Output_164, __p_OTlxrUfMvuaMqXouFLOb55 = Output_101, __if_MnhDSYkBRkTNSTdf8lV1Jz = state_103, __slot_FrmBtLs68pYOzv1XADLCoO = Enable_In, __p_FlDAk4R5oJrLcJNMxSid7R = Output_131, __slot_F8PuLLEofvDNLcUhgQwgBg = Enable_In, __p_PeURRzywtrxONaoiFR3RYv = Output_143, __slot_BoMJQ8m9VnILHXmM9Vff0b = Enable_In, __p_SeXFHDq458eNAC1rRzld6k = Output_155, __slot_PtOWDPWZzMaNVgJzcNVH4t = Enable_In, __slot_SNs3pVLHmplN4G3yFB1J56 = Output_77} : that_166;
            else
            {
                this.__p_ViAblvoyIuwMkTCOhVBicU = State_Output_22;
                this.__p_IjoH3eNnYkUM6yi1U3Pfx4 = State_Output_29;
                this.__p_GhYCP5v4Rd1L7zc7SRoxxR = Output_32;
                this.__p_E9eRumVUxfKN3CaVgFCgt2 = State_Output_39;
                this.__p_IYE3UmqiI9VQEdUiDU9CZH = Output_48;
                this.__slot_AmABh5LLZQKON43FlLesTi = Position_43;
                this.__slot_Bby0JNndIcyNcgvXZEpXpX = Result_50;
                this.__p_TzY088IXP4sPMf7fc0Mqoe = Output_54;
                this.__p_LAcCpNom4euPk6qyMT2rDl = State_Output_62;
                this.__p_D1n6gnv0MfqLaOSWlk193N = Output_65;
                this.__p_UTqhLETXTLULpViiE6Hak2 = Output_162;
                this.__p_PHkO4IGYfZYP0GfD0x3Bye = Output_164;
                this.__p_OTlxrUfMvuaMqXouFLOb55 = Output_101;
                this.__if_MnhDSYkBRkTNSTdf8lV1Jz = state_103;
                this.__slot_FrmBtLs68pYOzv1XADLCoO = Enable_In;
                this.__p_FlDAk4R5oJrLcJNMxSid7R = Output_131;
                this.__slot_F8PuLLEofvDNLcUhgQwgBg = Enable_In;
                this.__p_PeURRzywtrxONaoiFR3RYv = Output_143;
                this.__slot_BoMJQ8m9VnILHXmM9Vff0b = Enable_In;
                this.__p_SeXFHDq458eNAC1rRzld6k = Output_155;
                this.__slot_PtOWDPWZzMaNVgJzcNVH4t = Enable_In;
                this.__slot_SNs3pVLHmplN4G3yFB1J56 = Output_77;
            }

            return that_166;
        }

        [return: n3.PinAttribute("Output", isState: true)]
        [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
        public n5.OSCBridger_BpnR2c6W7MGQYBG0HaeBC6 __Create__([n3.PinAttribute("Node Context", visibility: n6.PinVisibility.Hidden)] n7.NodeContext Node_Context)
        {
            n27.RuntimeHelpers.EnsureSufficientExecutionStack();
            var __nodeContext = Node_Context;
            n7.NodeContext Node_Context_0 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "ViAblvoyIuwMkTCOhVBicU", 7307U);
            var Output_1 = n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>.Create<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Node_Context: Node_Context_0);
            n7.NodeContext Node_Context_2 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "IjoH3eNnYkUM6yi1U3Pfx4", 7314U);
            var Output_3 = n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>.Create<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Node_Context: Node_Context_2);
            n7.NodeContext Node_Context_4 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "E9eRumVUxfKN3CaVgFCgt2", 7321U);
            var Output_5 = n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>.Create<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Node_Context: Node_Context_4);
            n7.NodeContext Node_Context_6 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "UTqhLETXTLULpViiE6Hak2", 7402U);
            n13.Vector3 Initial_Value_7 = n14._Operations_.CreateDefault();
            var Output_8 = n22.FrameDelay_VYPkCl1PIexL9IROxeL6ju<n13.Vector3>.Create(Node_Context: Node_Context_6, Initial_Value_In: Initial_Value_7);
            n7.NodeContext Node_Context_9 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "TzY088IXP4sPMf7fc0Mqoe", 7446U);
            n18.IFrameClock Clock_10 = n28._Operations_.CreateDefault();
            var Output_11 = n26.OneEuroFilter_FvW0xl6URWWMjdPsygqbs7<float>.Create<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Node_Context: Node_Context_9, Clock_In: Clock_10);
            n7.NodeContext Node_Context_12 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "GhYCP5v4Rd1L7zc7SRoxxR", 7454U);
            n18.IFrameClock Clock_13 = n28._Operations_.CreateDefault();
            var Output_14 = n26.OneEuroFilter_FvW0xl6URWWMjdPsygqbs7<float>.Create<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Node_Context: Node_Context_12, Clock_In: Clock_13);
            n7.NodeContext Node_Context_15 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "IYE3UmqiI9VQEdUiDU9CZH", 7489U);
            n18.IClock Clock_16 = n17._Operations_.CreateDefault();
            var Output_17 = n19.Damper_Qhw7aQNplhrMCum2sxpG8z.Create(Node_Context: Node_Context_15, Clock_In: Clock_16);
            n7.NodeContext Node_Context_18 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "PHkO4IGYfZYP0GfD0x3Bye", 7520U);
            float Initial_Value_19 = 0F;
            var Output_20 = n22.FrameDelay_VYPkCl1PIexL9IROxeL6ju<float>.Create(Node_Context: Node_Context_18, Initial_Value_In: Initial_Value_19);
            n7.NodeContext Node_Context_21 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "OTlxrUfMvuaMqXouFLOb55", 7524U);
            n18.IClock Clock_22 = n17._Operations_.CreateDefault();
            var Output_23 = n19.Damper_Qhw7aQNplhrMCum2sxpG8z.Create(Node_Context: Node_Context_21, Clock_In: Clock_22);
            n7.NodeContext Node_Context_24 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "FlDAk4R5oJrLcJNMxSid7R", 7534U);
            n18.IClock Clock_25 = n17._Operations_.CreateDefault();
            var Output_26 = n19.Damper_Qhw7aQNplhrMCum2sxpG8z.Create(Node_Context: Node_Context_24, Clock_In: Clock_25);
            n7.NodeContext Node_Context_27 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "PeURRzywtrxONaoiFR3RYv", 7543U);
            n18.IClock Clock_28 = n17._Operations_.CreateDefault();
            var Output_29 = n19.Damper_Qhw7aQNplhrMCum2sxpG8z.Create(Node_Context: Node_Context_27, Clock_In: Clock_28);
            n7.NodeContext Node_Context_30 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "LAcCpNom4euPk6qyMT2rDl", 7564U);
            var Output_31 = n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>.Create<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Node_Context: Node_Context_30);
            n7.NodeContext Node_Context_32 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "D1n6gnv0MfqLaOSWlk193N", 7576U);
            n18.IFrameClock Clock_33 = n28._Operations_.CreateDefault();
            var Output_34 = n26.OneEuroFilter_FvW0xl6URWWMjdPsygqbs7<float>.Create<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Node_Context: Node_Context_32, Clock_In: Clock_33);
            n7.NodeContext Node_Context_35 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "SeXFHDq458eNAC1rRzld6k", 7582U);
            n18.IClock Clock_36 = n17._Operations_.CreateDefault();
            var Output_37 = n19.Damper_Qhw7aQNplhrMCum2sxpG8z.Create(Node_Context: Node_Context_35, Clock_In: Clock_36);
            n5.OSCBridger_BpnR2c6W7MGQYBG0HaeBC6 that_38 = this;
            this.__slot_AmABh5LLZQKON43FlLesTi = 0F;
            this.__slot_FrmBtLs68pYOzv1XADLCoO = false;
            this.__slot_F8PuLLEofvDNLcUhgQwgBg = false;
            this.__slot_BoMJQ8m9VnILHXmM9Vff0b = false;
            this.__slot_Bby0JNndIcyNcgvXZEpXpX = false;
            this.__slot_SNs3pVLHmplN4G3yFB1J56 = 0F;
            this.__slot_PtOWDPWZzMaNVgJzcNVH4t = false;
            this.__p_ViAblvoyIuwMkTCOhVBicU = Output_1;
            this.__p_IjoH3eNnYkUM6yi1U3Pfx4 = Output_3;
            this.__p_E9eRumVUxfKN3CaVgFCgt2 = Output_5;
            this.__p_UTqhLETXTLULpViiE6Hak2 = Output_8;
            this.__p_TzY088IXP4sPMf7fc0Mqoe = Output_11;
            this.__p_GhYCP5v4Rd1L7zc7SRoxxR = Output_14;
            this.__p_IYE3UmqiI9VQEdUiDU9CZH = Output_17;
            this.__p_PHkO4IGYfZYP0GfD0x3Bye = Output_20;
            this.__p_OTlxrUfMvuaMqXouFLOb55 = Output_23;
            this.__p_FlDAk4R5oJrLcJNMxSid7R = Output_26;
            this.__p_PeURRzywtrxONaoiFR3RYv = Output_29;
            this.__p_LAcCpNom4euPk6qyMT2rDl = Output_31;
            this.__p_D1n6gnv0MfqLaOSWlk193N = Output_34;
            this.__p_SeXFHDq458eNAC1rRzld6k = Output_37;
            return that_38;
        }

        [return: n3.PinAttribute("Output", isState: true)]
        [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
        public n5.OSCBridger_BpnR2c6W7MGQYBG0HaeBC6 __CreateDefault__()
        {
            var __nodeContext = n7.NodeContext.Default;
            n5.OSCBridger_BpnR2c6W7MGQYBG0HaeBC6 that_0 = this;
            this.__slot_AmABh5LLZQKON43FlLesTi = 0F;
            this.__slot_FrmBtLs68pYOzv1XADLCoO = false;
            this.__slot_F8PuLLEofvDNLcUhgQwgBg = false;
            this.__slot_BoMJQ8m9VnILHXmM9Vff0b = false;
            this.__slot_Bby0JNndIcyNcgvXZEpXpX = false;
            this.__slot_SNs3pVLHmplN4G3yFB1J56 = 0F;
            this.__slot_PtOWDPWZzMaNVgJzcNVH4t = false;
            this.__p_ViAblvoyIuwMkTCOhVBicU = n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>.CreateDefault();
            this.__p_IjoH3eNnYkUM6yi1U3Pfx4 = n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>.CreateDefault();
            this.__p_GhYCP5v4Rd1L7zc7SRoxxR = n26.OneEuroFilter_FvW0xl6URWWMjdPsygqbs7<float>.CreateDefault<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>();
            this.__p_E9eRumVUxfKN3CaVgFCgt2 = n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>.CreateDefault();
            this.__p_IYE3UmqiI9VQEdUiDU9CZH = n19.Damper_Qhw7aQNplhrMCum2sxpG8z.CreateDefault();
            this.__p_TzY088IXP4sPMf7fc0Mqoe = n26.OneEuroFilter_FvW0xl6URWWMjdPsygqbs7<float>.CreateDefault<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>();
            this.__p_LAcCpNom4euPk6qyMT2rDl = n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>.CreateDefault();
            this.__p_D1n6gnv0MfqLaOSWlk193N = n26.OneEuroFilter_FvW0xl6URWWMjdPsygqbs7<float>.CreateDefault<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>();
            this.__p_UTqhLETXTLULpViiE6Hak2 = n22.FrameDelay_VYPkCl1PIexL9IROxeL6ju<n13.Vector3>.CreateDefault();
            this.__p_PHkO4IGYfZYP0GfD0x3Bye = n22.FrameDelay_VYPkCl1PIexL9IROxeL6ju<float>.CreateDefault();
            this.__p_OTlxrUfMvuaMqXouFLOb55 = n19.Damper_Qhw7aQNplhrMCum2sxpG8z.CreateDefault();
            this.__p_FlDAk4R5oJrLcJNMxSid7R = n19.Damper_Qhw7aQNplhrMCum2sxpG8z.CreateDefault();
            this.__p_PeURRzywtrxONaoiFR3RYv = n19.Damper_Qhw7aQNplhrMCum2sxpG8z.CreateDefault();
            this.__p_SeXFHDq458eNAC1rRzld6k = n19.Damper_Qhw7aQNplhrMCum2sxpG8z.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            var __nodeContext = __GetContext__();
            try
            {
                return;
            }
            finally
            {
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_SeXFHDq458eNAC1rRzld6k);
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_D1n6gnv0MfqLaOSWlk193N);
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_LAcCpNom4euPk6qyMT2rDl);
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_PeURRzywtrxONaoiFR3RYv);
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_FlDAk4R5oJrLcJNMxSid7R);
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_OTlxrUfMvuaMqXouFLOb55);
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_PHkO4IGYfZYP0GfD0x3Bye);
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_IYE3UmqiI9VQEdUiDU9CZH);
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_GhYCP5v4Rd1L7zc7SRoxxR);
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_TzY088IXP4sPMf7fc0Mqoe);
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_UTqhLETXTLULpViiE6Hak2);
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_E9eRumVUxfKN3CaVgFCgt2);
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_IjoH3eNnYkUM6yi1U3Pfx4);
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_ViAblvoyIuwMkTCOhVBicU);
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__if_MnhDSYkBRkTNSTdf8lV1Jz);
            }
        }

        [n1.ElementAttribute(TracingId = 7337U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "AmABh5LLZQKON43FlLesTi", Name = "__slot_AmABh5LLZQKON43FlLesTi")]
        public float __slot_AmABh5LLZQKON43FlLesTi;
        [n1.ElementAttribute(TracingId = 7375U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "COgAKg2AVdMMcqVwuDXuJq", Name = "__slot_COgAKg2AVdMMcqVwuDXuJq")]
        public static float __slot_COgAKg2AVdMMcqVwuDXuJq = 0.3F;
        [n1.ElementAttribute(TracingId = 7383U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "FrmBtLs68pYOzv1XADLCoO", Name = "__slot_FrmBtLs68pYOzv1XADLCoO")]
        public bool __slot_FrmBtLs68pYOzv1XADLCoO;
        [n1.ElementAttribute(TracingId = 7389U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "HbyI5fVKMTfMEc5MEjMUvx", Name = "__slot_HbyI5fVKMTfMEc5MEjMUvx")]
        public static string __slot_HbyI5fVKMTfMEc5MEjMUvx = "X";
        [n1.ElementAttribute(TracingId = 7394U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "TWWFJK9GeTbPNKVVqfBzIl", Name = "__slot_TWWFJK9GeTbPNKVVqfBzIl")]
        public static string __slot_TWWFJK9GeTbPNKVVqfBzIl = "Y";
        [n1.ElementAttribute(TracingId = 7399U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "MCZOuVdOOgONG8hRDvBUYY", Name = "__slot_MCZOuVdOOgONG8hRDvBUYY")]
        public static string __slot_MCZOuVdOOgONG8hRDvBUYY = "S";
        [n1.ElementAttribute(TracingId = 7409U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "R3uENvZI8G7OjBP7jTBcEU", Name = "__slot_R3uENvZI8G7OjBP7jTBcEU")]
        public static string __slot_R3uENvZI8G7OjBP7jTBcEU = "Speed";
        [n1.ElementAttribute(TracingId = 7413U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "DIm0u9KEVCfPGDAf6cW8l4", Name = "__slot_DIm0u9KEVCfPGDAf6cW8l4")]
        public static string __slot_DIm0u9KEVCfPGDAf6cW8l4 = "//Receiver chain\r\nInput from OSCServer and stringing with XYZ";
        [n1.ElementAttribute(TracingId = 7414U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "GBsrl3i4GxXLNEopRSUzCg", Name = "__slot_GBsrl3i4GxXLNEopRSUzCg")]
        public static string __slot_GBsrl3i4GxXLNEopRSUzCg = "//X values are multiplied by camera aspect ratio";
        [n1.ElementAttribute(TracingId = 7415U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "SqOaKBhDH49L9llMsQSrEW", Name = "__slot_SqOaKBhDH49L9llMsQSrEW")]
        public static string __slot_SqOaKBhDH49L9llMsQSrEW = "//s is a body-recognition score";
        [n1.ElementAttribute(TracingId = 7423U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "QeLnpy3fs4POj3kNtWRsXB", Name = "__slot_QeLnpy3fs4POj3kNtWRsXB")]
        public static string __slot_QeLnpy3fs4POj3kNtWRsXB = "//push Speed to OSCClient";
        [n1.ElementAttribute(TracingId = 7431U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "F8PuLLEofvDNLcUhgQwgBg", Name = "__slot_F8PuLLEofvDNLcUhgQwgBg")]
        public bool __slot_F8PuLLEofvDNLcUhgQwgBg;
        [n1.ElementAttribute(TracingId = 7432U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "IRS1c93bu6KMYRDHm5buO9", Name = "__slot_IRS1c93bu6KMYRDHm5buO9")]
        public static string __slot_IRS1c93bu6KMYRDHm5buO9 = "//push X to OSCClient";
        [n1.ElementAttribute(TracingId = 7433U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "N5JOQZodYrKQVbQ6Xtlw6q", Name = "__slot_N5JOQZodYrKQVbQ6Xtlw6q")]
        public static string __slot_N5JOQZodYrKQVbQ6Xtlw6q = "//framedelay to calc speed";
        [n1.ElementAttribute(TracingId = 7441U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "BoMJQ8m9VnILHXmM9Vff0b", Name = "__slot_BoMJQ8m9VnILHXmM9Vff0b")]
        public bool __slot_BoMJQ8m9VnILHXmM9Vff0b;
        [n1.ElementAttribute(TracingId = 7442U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "SZZi0vtoiMjLO0Sy5ZxXrU", Name = "__slot_SZZi0vtoiMjLO0Sy5ZxXrU")]
        public static string __slot_SZZi0vtoiMjLO0Sy5ZxXrU = "//push Y to OSCClient";
        [n1.ElementAttribute(TracingId = 7443U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "NxvD1FSXBTnQR6B8w75Clb", Name = "__slot_NxvD1FSXBTnQR6B8w75Clb")]
        public static string __slot_NxvD1FSXBTnQR6B8w75Clb = "//IF sets value to 0 if body-recognition is off";
        [n1.ElementAttribute(TracingId = 7452U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "DzrXOegsrj6MkTVUzoE0G3", Name = "__slot_DzrXOegsrj6MkTVUzoE0G3")]
        public static float __slot_DzrXOegsrj6MkTVUzoE0G3 = 1.18F;
        [n1.ElementAttribute(TracingId = 7453U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "CW0htAIJurvMlc7gA1aePK", Name = "__slot_CW0htAIJurvMlc7gA1aePK")]
        public static float __slot_CW0htAIJurvMlc7gA1aePK = 1.2F;
        [n1.ElementAttribute(TracingId = 7460U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "Nf6DuJgm3oQQEmKrkAO9bc", Name = "__slot_Nf6DuJgm3oQQEmKrkAO9bc")]
        public static string __slot_Nf6DuJgm3oQQEmKrkAO9bc = "//antijitter";
        [n1.ElementAttribute(TracingId = 7465U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "Bby0JNndIcyNcgvXZEpXpX", Name = "__slot_Bby0JNndIcyNcgvXZEpXpX")]
        public bool __slot_Bby0JNndIcyNcgvXZEpXpX;
        [n1.ElementAttribute(TracingId = 7498U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "CDeQnwc9nU2PXRFBkGC0qY", Name = "__slot_CDeQnwc9nU2PXRFBkGC0qY")]
        public static float __slot_CDeQnwc9nU2PXRFBkGC0qY = 0.5F;
        [n1.ElementAttribute(TracingId = 7503U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "RvlCWZsd6AkPivuVkyhK3c", Name = "__slot_RvlCWZsd6AkPivuVkyhK3c")]
        public static float __slot_RvlCWZsd6AkPivuVkyhK3c = 1.777F;
        [n1.ElementAttribute(TracingId = 7504U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "JFvtmWwEKUsNynnZuxh1yj", Name = "__slot_JFvtmWwEKUsNynnZuxh1yj")]
        public static string __slot_JFvtmWwEKUsNynnZuxh1yj = "//x-width by Aspect Ratio";
        [n1.ElementAttribute(TracingId = 7513U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "FdvylScs71fOgpHduW7Z3E", Name = "__slot_FdvylScs71fOgpHduW7Z3E")]
        public static float __slot_FdvylScs71fOgpHduW7Z3E = 0.13F;
        [n1.ElementAttribute(TracingId = 7519U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "MwdklqSOsgjMLGWpNxKnrp", Name = "__slot_MwdklqSOsgjMLGWpNxKnrp")]
        public static float __slot_MwdklqSOsgjMLGWpNxKnrp = 1F;
        [n1.ElementAttribute(TracingId = 7523U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "SNs3pVLHmplN4G3yFB1J56", Name = "__slot_SNs3pVLHmplN4G3yFB1J56")]
        public float __slot_SNs3pVLHmplN4G3yFB1J56;
        [n1.ElementAttribute(TracingId = 7533U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "NCF28Ot9oauP7b0Vd4AGod", Name = "__slot_NCF28Ot9oauP7b0Vd4AGod")]
        public static float __slot_NCF28Ot9oauP7b0Vd4AGod = 0.5F;
        [n1.ElementAttribute(TracingId = 7556U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "HYl0ajjesh1P6qiXSYhtio", Name = "__slot_HYl0ajjesh1P6qiXSYhtio")]
        public static float __slot_HYl0ajjesh1P6qiXSYhtio = 10F;
        [n1.ElementAttribute(TracingId = 7562U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "F9Ollu6k9oqPC59VUYHI7C", Name = "__slot_F9Ollu6k9oqPC59VUYHI7C")]
        public static string __slot_F9Ollu6k9oqPC59VUYHI7C = "//increase speed scale";
        [n1.ElementAttribute(TracingId = 7563U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "EeCeZplb1LvLB3Gf9v2R5X", Name = "__slot_EeCeZplb1LvLB3Gf9v2R5X")]
        public static string __slot_EeCeZplb1LvLB3Gf9v2R5X = "// tt2+=tt-y";
        [n1.ElementAttribute(TracingId = 7575U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "GMQdVCqn1OgLQA5Mabt7Er", Name = "__slot_GMQdVCqn1OgLQA5Mabt7Er")]
        public static string __slot_GMQdVCqn1OgLQA5Mabt7Er = "Z";
        [n1.ElementAttribute(TracingId = 7598U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "PtOWDPWZzMaNVgJzcNVH4t", Name = "__slot_PtOWDPWZzMaNVgJzcNVH4t")]
        public bool __slot_PtOWDPWZzMaNVgJzcNVH4t;
        [n1.ElementAttribute(TracingId = 7599U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "OHg2NsyyC1cO668net7kvu", Name = "__slot_OHg2NsyyC1cO668net7kvu")]
        public static string __slot_OHg2NsyyC1cO668net7kvu = "//push Z to OSCClient";
        [n1.ElementAttribute(TracingId = 7605U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "PkI33oXp7QMMNbkR8BibZt", Name = "__slot_PkI33oXp7QMMNbkR8BibZt")]
        public static string __slot_PkI33oXp7QMMNbkR8BibZt = "/P1";
        [n1.ElementAttribute(TracingId = 7307U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "ViAblvoyIuwMkTCOhVBicU", Name = "OSCReceiver", IsManaged = true, IsAutoGenerated = true)]
        public n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float> __p_ViAblvoyIuwMkTCOhVBicU;
        [n1.ElementAttribute(TracingId = 7314U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "IjoH3eNnYkUM6yi1U3Pfx4", Name = "OSCReceiver", IsManaged = true, IsAutoGenerated = true)]
        public n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float> __p_IjoH3eNnYkUM6yi1U3Pfx4;
        [n1.ElementAttribute(TracingId = 7454U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "GhYCP5v4Rd1L7zc7SRoxxR", Name = "OneEuroFilter", IsManaged = true, IsAutoGenerated = true)]
        public n26.OneEuroFilter_FvW0xl6URWWMjdPsygqbs7<float> __p_GhYCP5v4Rd1L7zc7SRoxxR;
        [n1.ElementAttribute(TracingId = 7321U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "E9eRumVUxfKN3CaVgFCgt2", Name = "OSCReceiver", IsManaged = true, IsAutoGenerated = true)]
        public n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float> __p_E9eRumVUxfKN3CaVgFCgt2;
        [n1.ElementAttribute(TracingId = 7489U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "IYE3UmqiI9VQEdUiDU9CZH", Name = "Damper", IsManaged = true, IsAutoGenerated = true)]
        public n19.Damper_Qhw7aQNplhrMCum2sxpG8z __p_IYE3UmqiI9VQEdUiDU9CZH;
        [n1.ElementAttribute(TracingId = 7446U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "TzY088IXP4sPMf7fc0Mqoe", Name = "OneEuroFilter", IsManaged = true, IsAutoGenerated = true)]
        public n26.OneEuroFilter_FvW0xl6URWWMjdPsygqbs7<float> __p_TzY088IXP4sPMf7fc0Mqoe;
        [n1.ElementAttribute(TracingId = 7564U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "LAcCpNom4euPk6qyMT2rDl", Name = "OSCReceiver", IsManaged = true, IsAutoGenerated = true)]
        public n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float> __p_LAcCpNom4euPk6qyMT2rDl;
        [n1.ElementAttribute(TracingId = 7576U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "D1n6gnv0MfqLaOSWlk193N", Name = "OneEuroFilter", IsManaged = true, IsAutoGenerated = true)]
        public n26.OneEuroFilter_FvW0xl6URWWMjdPsygqbs7<float> __p_D1n6gnv0MfqLaOSWlk193N;
        [n1.ElementAttribute(TracingId = 7402U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "UTqhLETXTLULpViiE6Hak2", Name = "FrameDelay", IsManaged = true, IsAutoGenerated = true)]
        public n22.FrameDelay_VYPkCl1PIexL9IROxeL6ju<n13.Vector3> __p_UTqhLETXTLULpViiE6Hak2;
        [n1.ElementAttribute(TracingId = 7520U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "PHkO4IGYfZYP0GfD0x3Bye", Name = "FrameDelay", IsManaged = true, IsAutoGenerated = true)]
        public n22.FrameDelay_VYPkCl1PIexL9IROxeL6ju<float> __p_PHkO4IGYfZYP0GfD0x3Bye;
        [n1.ElementAttribute(TracingId = 7347U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "Hqk8H1Nu05lOEsPFidTp6O", Name = "__slot_Hqk8H1Nu05lOEsPFidTp6O")]
        public static float __slot_Hqk8H1Nu05lOEsPFidTp6O = 0F;
        [n1.ElementAttribute(TracingId = 7352U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "Ncp0OvGYoBoPFP4ENNOvkZ", Name = "__slot_Ncp0OvGYoBoPFP4ENNOvkZ")]
        public static float __slot_Ncp0OvGYoBoPFP4ENNOvkZ = 0F;
        [n1.ElementAttribute(TracingId = 7357U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "DRG7qsrzWJtN0Nfx9uSw2d", Name = "__slot_DRG7qsrzWJtN0Nfx9uSw2d")]
        public static float __slot_DRG7qsrzWJtN0Nfx9uSw2d = 0F;
        [n1.ElementAttribute(TracingId = 7362U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "UK7OdT62lH3ODXoLfxnh3m", Name = "__slot_UK7OdT62lH3ODXoLfxnh3m")]
        public static float __slot_UK7OdT62lH3ODXoLfxnh3m = 0F;
        [n1.ElementAttribute(TracingId = 7524U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "OTlxrUfMvuaMqXouFLOb55", Name = "Damper", IsManaged = true, IsAutoGenerated = true)]
        public n19.Damper_Qhw7aQNplhrMCum2sxpG8z __p_OTlxrUfMvuaMqXouFLOb55;
        [n1.ElementAttribute(IsManaged = true, IsAutoGenerated = true)]
        public n2.Object __if_MnhDSYkBRkTNSTdf8lV1Jz;
        [n1.ElementAttribute(TracingId = 7534U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "FlDAk4R5oJrLcJNMxSid7R", Name = "Damper", IsManaged = true, IsAutoGenerated = true)]
        public n19.Damper_Qhw7aQNplhrMCum2sxpG8z __p_FlDAk4R5oJrLcJNMxSid7R;
        [n1.ElementAttribute(TracingId = 7543U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "PeURRzywtrxONaoiFR3RYv", Name = "Damper", IsManaged = true, IsAutoGenerated = true)]
        public n19.Damper_Qhw7aQNplhrMCum2sxpG8z __p_PeURRzywtrxONaoiFR3RYv;
        [n1.ElementAttribute(TracingId = 7582U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "SeXFHDq458eNAC1rRzld6k", Name = "Damper", IsManaged = true, IsAutoGenerated = true)]
        public n19.Damper_Qhw7aQNplhrMCum2sxpG8z __p_SeXFHDq458eNAC1rRzld6k;
        [n2.SerializableAttribute]
        sealed class __VWbVqF6ujVQLI5T7jTTdgE : n2.IDisposable
        {
            [n1.ElementAttribute(TracingId = 7473U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "NvEsomnHF81Lev4YdN8RbK", Name = "Damper", IsManaged = true, IsAutoGenerated = true)]
            public n19.Damper_Qhw7aQNplhrMCum2sxpG8z __p_NvEsomnHF81Lev4YdN8RbK;
            [n1.ElementAttribute(IsAutoGenerated = true)]
            public n20.Spread<float> __pin_group_Input_In_UYCWZpUZSJ2N1L3S84ruTe;
            public __VWbVqF6ujVQLI5T7jTTdgE()
            {
            }

            public __VWbVqF6ujVQLI5T7jTTdgE(__VWbVqF6ujVQLI5T7jTTdgE other)
            {
                this.__p_NvEsomnHF81Lev4YdN8RbK = other.__p_NvEsomnHF81Lev4YdN8RbK;
                this.__pin_group_Input_In_UYCWZpUZSJ2N1L3S84ruTe = other.__pin_group_Input_In_UYCWZpUZSJ2N1L3S84ruTe;
            }

            void n2.IDisposable.Dispose()
            {
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_NvEsomnHF81Lev4YdN8RbK);
            }
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        public OSCBridger_BpnR2c6W7MGQYBG0HaeBC6() : base()
        {
        }

        public OSCBridger_BpnR2c6W7MGQYBG0HaeBC6(n7.NodeContext context, uint identity) : base(context, identity)
        {
        }

        public OSCBridger_BpnR2c6W7MGQYBG0HaeBC6(OSCBridger_BpnR2c6W7MGQYBG0HaeBC6 other) : base(other)
        {
            this.__slot_AmABh5LLZQKON43FlLesTi = other.__slot_AmABh5LLZQKON43FlLesTi;
            this.__slot_FrmBtLs68pYOzv1XADLCoO = other.__slot_FrmBtLs68pYOzv1XADLCoO;
            this.__slot_F8PuLLEofvDNLcUhgQwgBg = other.__slot_F8PuLLEofvDNLcUhgQwgBg;
            this.__slot_BoMJQ8m9VnILHXmM9Vff0b = other.__slot_BoMJQ8m9VnILHXmM9Vff0b;
            this.__slot_Bby0JNndIcyNcgvXZEpXpX = other.__slot_Bby0JNndIcyNcgvXZEpXpX;
            this.__slot_SNs3pVLHmplN4G3yFB1J56 = other.__slot_SNs3pVLHmplN4G3yFB1J56;
            this.__slot_PtOWDPWZzMaNVgJzcNVH4t = other.__slot_PtOWDPWZzMaNVgJzcNVH4t;
            this.__p_ViAblvoyIuwMkTCOhVBicU = other.__p_ViAblvoyIuwMkTCOhVBicU;
            this.__p_IjoH3eNnYkUM6yi1U3Pfx4 = other.__p_IjoH3eNnYkUM6yi1U3Pfx4;
            this.__p_GhYCP5v4Rd1L7zc7SRoxxR = other.__p_GhYCP5v4Rd1L7zc7SRoxxR;
            this.__p_E9eRumVUxfKN3CaVgFCgt2 = other.__p_E9eRumVUxfKN3CaVgFCgt2;
            this.__p_IYE3UmqiI9VQEdUiDU9CZH = other.__p_IYE3UmqiI9VQEdUiDU9CZH;
            this.__p_TzY088IXP4sPMf7fc0Mqoe = other.__p_TzY088IXP4sPMf7fc0Mqoe;
            this.__p_LAcCpNom4euPk6qyMT2rDl = other.__p_LAcCpNom4euPk6qyMT2rDl;
            this.__p_D1n6gnv0MfqLaOSWlk193N = other.__p_D1n6gnv0MfqLaOSWlk193N;
            this.__p_UTqhLETXTLULpViiE6Hak2 = other.__p_UTqhLETXTLULpViiE6Hak2;
            this.__p_PHkO4IGYfZYP0GfD0x3Bye = other.__p_PHkO4IGYfZYP0GfD0x3Bye;
            this.__p_OTlxrUfMvuaMqXouFLOb55 = other.__p_OTlxrUfMvuaMqXouFLOb55;
            this.__if_MnhDSYkBRkTNSTdf8lV1Jz = other.__if_MnhDSYkBRkTNSTdf8lV1Jz;
            this.__p_FlDAk4R5oJrLcJNMxSid7R = other.__p_FlDAk4R5oJrLcJNMxSid7R;
            this.__p_PeURRzywtrxONaoiFR3RYv = other.__p_PeURRzywtrxONaoiFR3RYv;
            this.__p_SeXFHDq458eNAC1rRzld6k = other.__p_SeXFHDq458eNAC1rRzld6k;
        }

        protected override n7.IVLObject __With__(n24.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n23.CompilationHelper.GetValueOrExisting(values, "__slot_AmABh5LLZQKON43FlLesTi", in __slot_AmABh5LLZQKON43FlLesTi), n23.CompilationHelper.GetValueOrExisting(values, "__slot_FrmBtLs68pYOzv1XADLCoO", in __slot_FrmBtLs68pYOzv1XADLCoO), n23.CompilationHelper.GetValueOrExisting(values, "__slot_F8PuLLEofvDNLcUhgQwgBg", in __slot_F8PuLLEofvDNLcUhgQwgBg), n23.CompilationHelper.GetValueOrExisting(values, "__slot_BoMJQ8m9VnILHXmM9Vff0b", in __slot_BoMJQ8m9VnILHXmM9Vff0b), n23.CompilationHelper.GetValueOrExisting(values, "__slot_Bby0JNndIcyNcgvXZEpXpX", in __slot_Bby0JNndIcyNcgvXZEpXpX), n23.CompilationHelper.GetValueOrExisting(values, "__slot_SNs3pVLHmplN4G3yFB1J56", in __slot_SNs3pVLHmplN4G3yFB1J56), n23.CompilationHelper.GetValueOrExisting(values, "__slot_PtOWDPWZzMaNVgJzcNVH4t", in __slot_PtOWDPWZzMaNVgJzcNVH4t), n23.CompilationHelper.GetValueOrExisting(values, "__p_ViAblvoyIuwMkTCOhVBicU", in __p_ViAblvoyIuwMkTCOhVBicU), n23.CompilationHelper.GetValueOrExisting(values, "__p_IjoH3eNnYkUM6yi1U3Pfx4", in __p_IjoH3eNnYkUM6yi1U3Pfx4), n23.CompilationHelper.GetValueOrExisting(values, "__p_GhYCP5v4Rd1L7zc7SRoxxR", in __p_GhYCP5v4Rd1L7zc7SRoxxR), n23.CompilationHelper.GetValueOrExisting(values, "__p_E9eRumVUxfKN3CaVgFCgt2", in __p_E9eRumVUxfKN3CaVgFCgt2), n23.CompilationHelper.GetValueOrExisting(values, "__p_IYE3UmqiI9VQEdUiDU9CZH", in __p_IYE3UmqiI9VQEdUiDU9CZH), n23.CompilationHelper.GetValueOrExisting(values, "__p_TzY088IXP4sPMf7fc0Mqoe", in __p_TzY088IXP4sPMf7fc0Mqoe), n23.CompilationHelper.GetValueOrExisting(values, "__p_LAcCpNom4euPk6qyMT2rDl", in __p_LAcCpNom4euPk6qyMT2rDl), n23.CompilationHelper.GetValueOrExisting(values, "__p_D1n6gnv0MfqLaOSWlk193N", in __p_D1n6gnv0MfqLaOSWlk193N), n23.CompilationHelper.GetValueOrExisting(values, "__p_UTqhLETXTLULpViiE6Hak2", in __p_UTqhLETXTLULpViiE6Hak2), n23.CompilationHelper.GetValueOrExisting(values, "__p_PHkO4IGYfZYP0GfD0x3Bye", in __p_PHkO4IGYfZYP0GfD0x3Bye), n23.CompilationHelper.GetValueOrExisting(values, "__p_OTlxrUfMvuaMqXouFLOb55", in __p_OTlxrUfMvuaMqXouFLOb55), n23.CompilationHelper.GetValueOrExisting(values, "__if_MnhDSYkBRkTNSTdf8lV1Jz", in __if_MnhDSYkBRkTNSTdf8lV1Jz), n23.CompilationHelper.GetValueOrExisting(values, "__p_FlDAk4R5oJrLcJNMxSid7R", in __p_FlDAk4R5oJrLcJNMxSid7R), n23.CompilationHelper.GetValueOrExisting(values, "__p_PeURRzywtrxONaoiFR3RYv", in __p_PeURRzywtrxONaoiFR3RYv), n23.CompilationHelper.GetValueOrExisting(values, "__p_SeXFHDq458eNAC1rRzld6k", in __p_SeXFHDq458eNAC1rRzld6k));
        }

        internal OSCBridger_BpnR2c6W7MGQYBG0HaeBC6 __WITH__(float __slot_AmABh5LLZQKON43FlLesTi, bool __slot_FrmBtLs68pYOzv1XADLCoO, bool __slot_F8PuLLEofvDNLcUhgQwgBg, bool __slot_BoMJQ8m9VnILHXmM9Vff0b, bool __slot_Bby0JNndIcyNcgvXZEpXpX, float __slot_SNs3pVLHmplN4G3yFB1J56, bool __slot_PtOWDPWZzMaNVgJzcNVH4t, n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float> __p_ViAblvoyIuwMkTCOhVBicU, n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float> __p_IjoH3eNnYkUM6yi1U3Pfx4, n26.OneEuroFilter_FvW0xl6URWWMjdPsygqbs7<float> __p_GhYCP5v4Rd1L7zc7SRoxxR, n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float> __p_E9eRumVUxfKN3CaVgFCgt2, n19.Damper_Qhw7aQNplhrMCum2sxpG8z __p_IYE3UmqiI9VQEdUiDU9CZH, n26.OneEuroFilter_FvW0xl6URWWMjdPsygqbs7<float> __p_TzY088IXP4sPMf7fc0Mqoe, n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float> __p_LAcCpNom4euPk6qyMT2rDl, n26.OneEuroFilter_FvW0xl6URWWMjdPsygqbs7<float> __p_D1n6gnv0MfqLaOSWlk193N, n22.FrameDelay_VYPkCl1PIexL9IROxeL6ju<n13.Vector3> __p_UTqhLETXTLULpViiE6Hak2, n22.FrameDelay_VYPkCl1PIexL9IROxeL6ju<float> __p_PHkO4IGYfZYP0GfD0x3Bye, n19.Damper_Qhw7aQNplhrMCum2sxpG8z __p_OTlxrUfMvuaMqXouFLOb55, n2.Object __if_MnhDSYkBRkTNSTdf8lV1Jz, n19.Damper_Qhw7aQNplhrMCum2sxpG8z __p_FlDAk4R5oJrLcJNMxSid7R, n19.Damper_Qhw7aQNplhrMCum2sxpG8z __p_PeURRzywtrxONaoiFR3RYv, n19.Damper_Qhw7aQNplhrMCum2sxpG8z __p_SeXFHDq458eNAC1rRzld6k)
        {
            n5.OSCBridger_BpnR2c6W7MGQYBG0HaeBC6 that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_AmABh5LLZQKON43FlLesTi != this.__slot_AmABh5LLZQKON43FlLesTi || __slot_FrmBtLs68pYOzv1XADLCoO != this.__slot_FrmBtLs68pYOzv1XADLCoO || __slot_F8PuLLEofvDNLcUhgQwgBg != this.__slot_F8PuLLEofvDNLcUhgQwgBg || __slot_BoMJQ8m9VnILHXmM9Vff0b != this.__slot_BoMJQ8m9VnILHXmM9Vff0b || __slot_Bby0JNndIcyNcgvXZEpXpX != this.__slot_Bby0JNndIcyNcgvXZEpXpX || __slot_SNs3pVLHmplN4G3yFB1J56 != this.__slot_SNs3pVLHmplN4G3yFB1J56 || __slot_PtOWDPWZzMaNVgJzcNVH4t != this.__slot_PtOWDPWZzMaNVgJzcNVH4t || !n24.EqualityComparer<n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>>.Default.Equals(__p_ViAblvoyIuwMkTCOhVBicU, this.__p_ViAblvoyIuwMkTCOhVBicU) || !n24.EqualityComparer<n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>>.Default.Equals(__p_IjoH3eNnYkUM6yi1U3Pfx4, this.__p_IjoH3eNnYkUM6yi1U3Pfx4) || !n24.EqualityComparer<n26.OneEuroFilter_FvW0xl6URWWMjdPsygqbs7<float>>.Default.Equals(__p_GhYCP5v4Rd1L7zc7SRoxxR, this.__p_GhYCP5v4Rd1L7zc7SRoxxR) || !n24.EqualityComparer<n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>>.Default.Equals(__p_E9eRumVUxfKN3CaVgFCgt2, this.__p_E9eRumVUxfKN3CaVgFCgt2) || !n24.EqualityComparer<n19.Damper_Qhw7aQNplhrMCum2sxpG8z>.Default.Equals(__p_IYE3UmqiI9VQEdUiDU9CZH, this.__p_IYE3UmqiI9VQEdUiDU9CZH) || !n24.EqualityComparer<n26.OneEuroFilter_FvW0xl6URWWMjdPsygqbs7<float>>.Default.Equals(__p_TzY088IXP4sPMf7fc0Mqoe, this.__p_TzY088IXP4sPMf7fc0Mqoe) || !n24.EqualityComparer<n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>>.Default.Equals(__p_LAcCpNom4euPk6qyMT2rDl, this.__p_LAcCpNom4euPk6qyMT2rDl) || !n24.EqualityComparer<n26.OneEuroFilter_FvW0xl6URWWMjdPsygqbs7<float>>.Default.Equals(__p_D1n6gnv0MfqLaOSWlk193N, this.__p_D1n6gnv0MfqLaOSWlk193N) || !n24.EqualityComparer<n22.FrameDelay_VYPkCl1PIexL9IROxeL6ju<n13.Vector3>>.Default.Equals(__p_UTqhLETXTLULpViiE6Hak2, this.__p_UTqhLETXTLULpViiE6Hak2) || !n24.EqualityComparer<n22.FrameDelay_VYPkCl1PIexL9IROxeL6ju<float>>.Default.Equals(__p_PHkO4IGYfZYP0GfD0x3Bye, this.__p_PHkO4IGYfZYP0GfD0x3Bye) || !n24.EqualityComparer<n19.Damper_Qhw7aQNplhrMCum2sxpG8z>.Default.Equals(__p_OTlxrUfMvuaMqXouFLOb55, this.__p_OTlxrUfMvuaMqXouFLOb55) || !n24.EqualityComparer<n2.Object>.Default.Equals(__if_MnhDSYkBRkTNSTdf8lV1Jz, this.__if_MnhDSYkBRkTNSTdf8lV1Jz) || !n24.EqualityComparer<n19.Damper_Qhw7aQNplhrMCum2sxpG8z>.Default.Equals(__p_FlDAk4R5oJrLcJNMxSid7R, this.__p_FlDAk4R5oJrLcJNMxSid7R) || !n24.EqualityComparer<n19.Damper_Qhw7aQNplhrMCum2sxpG8z>.Default.Equals(__p_PeURRzywtrxONaoiFR3RYv, this.__p_PeURRzywtrxONaoiFR3RYv) || !n24.EqualityComparer<n19.Damper_Qhw7aQNplhrMCum2sxpG8z>.Default.Equals(__p_SeXFHDq458eNAC1rRzld6k, this.__p_SeXFHDq458eNAC1rRzld6k) ? new n5.OSCBridger_BpnR2c6W7MGQYBG0HaeBC6(this)
                {__slot_AmABh5LLZQKON43FlLesTi = __slot_AmABh5LLZQKON43FlLesTi, __slot_FrmBtLs68pYOzv1XADLCoO = __slot_FrmBtLs68pYOzv1XADLCoO, __slot_F8PuLLEofvDNLcUhgQwgBg = __slot_F8PuLLEofvDNLcUhgQwgBg, __slot_BoMJQ8m9VnILHXmM9Vff0b = __slot_BoMJQ8m9VnILHXmM9Vff0b, __slot_Bby0JNndIcyNcgvXZEpXpX = __slot_Bby0JNndIcyNcgvXZEpXpX, __slot_SNs3pVLHmplN4G3yFB1J56 = __slot_SNs3pVLHmplN4G3yFB1J56, __slot_PtOWDPWZzMaNVgJzcNVH4t = __slot_PtOWDPWZzMaNVgJzcNVH4t, __p_ViAblvoyIuwMkTCOhVBicU = __p_ViAblvoyIuwMkTCOhVBicU, __p_IjoH3eNnYkUM6yi1U3Pfx4 = __p_IjoH3eNnYkUM6yi1U3Pfx4, __p_GhYCP5v4Rd1L7zc7SRoxxR = __p_GhYCP5v4Rd1L7zc7SRoxxR, __p_E9eRumVUxfKN3CaVgFCgt2 = __p_E9eRumVUxfKN3CaVgFCgt2, __p_IYE3UmqiI9VQEdUiDU9CZH = __p_IYE3UmqiI9VQEdUiDU9CZH, __p_TzY088IXP4sPMf7fc0Mqoe = __p_TzY088IXP4sPMf7fc0Mqoe, __p_LAcCpNom4euPk6qyMT2rDl = __p_LAcCpNom4euPk6qyMT2rDl, __p_D1n6gnv0MfqLaOSWlk193N = __p_D1n6gnv0MfqLaOSWlk193N, __p_UTqhLETXTLULpViiE6Hak2 = __p_UTqhLETXTLULpViiE6Hak2, __p_PHkO4IGYfZYP0GfD0x3Bye = __p_PHkO4IGYfZYP0GfD0x3Bye, __p_OTlxrUfMvuaMqXouFLOb55 = __p_OTlxrUfMvuaMqXouFLOb55, __if_MnhDSYkBRkTNSTdf8lV1Jz = __if_MnhDSYkBRkTNSTdf8lV1Jz, __p_FlDAk4R5oJrLcJNMxSid7R = __p_FlDAk4R5oJrLcJNMxSid7R, __p_PeURRzywtrxONaoiFR3RYv = __p_PeURRzywtrxONaoiFR3RYv, __p_SeXFHDq458eNAC1rRzld6k = __p_SeXFHDq458eNAC1rRzld6k} : that_0;
            else
            {
                this.__slot_AmABh5LLZQKON43FlLesTi = __slot_AmABh5LLZQKON43FlLesTi;
                this.__slot_FrmBtLs68pYOzv1XADLCoO = __slot_FrmBtLs68pYOzv1XADLCoO;
                this.__slot_F8PuLLEofvDNLcUhgQwgBg = __slot_F8PuLLEofvDNLcUhgQwgBg;
                this.__slot_BoMJQ8m9VnILHXmM9Vff0b = __slot_BoMJQ8m9VnILHXmM9Vff0b;
                this.__slot_Bby0JNndIcyNcgvXZEpXpX = __slot_Bby0JNndIcyNcgvXZEpXpX;
                this.__slot_SNs3pVLHmplN4G3yFB1J56 = __slot_SNs3pVLHmplN4G3yFB1J56;
                this.__slot_PtOWDPWZzMaNVgJzcNVH4t = __slot_PtOWDPWZzMaNVgJzcNVH4t;
                this.__p_ViAblvoyIuwMkTCOhVBicU = __p_ViAblvoyIuwMkTCOhVBicU;
                this.__p_IjoH3eNnYkUM6yi1U3Pfx4 = __p_IjoH3eNnYkUM6yi1U3Pfx4;
                this.__p_GhYCP5v4Rd1L7zc7SRoxxR = __p_GhYCP5v4Rd1L7zc7SRoxxR;
                this.__p_E9eRumVUxfKN3CaVgFCgt2 = __p_E9eRumVUxfKN3CaVgFCgt2;
                this.__p_IYE3UmqiI9VQEdUiDU9CZH = __p_IYE3UmqiI9VQEdUiDU9CZH;
                this.__p_TzY088IXP4sPMf7fc0Mqoe = __p_TzY088IXP4sPMf7fc0Mqoe;
                this.__p_LAcCpNom4euPk6qyMT2rDl = __p_LAcCpNom4euPk6qyMT2rDl;
                this.__p_D1n6gnv0MfqLaOSWlk193N = __p_D1n6gnv0MfqLaOSWlk193N;
                this.__p_UTqhLETXTLULpViiE6Hak2 = __p_UTqhLETXTLULpViiE6Hak2;
                this.__p_PHkO4IGYfZYP0GfD0x3Bye = __p_PHkO4IGYfZYP0GfD0x3Bye;
                this.__p_OTlxrUfMvuaMqXouFLOb55 = __p_OTlxrUfMvuaMqXouFLOb55;
                this.__if_MnhDSYkBRkTNSTdf8lV1Jz = __if_MnhDSYkBRkTNSTdf8lV1Jz;
                this.__p_FlDAk4R5oJrLcJNMxSid7R = __p_FlDAk4R5oJrLcJNMxSid7R;
                this.__p_PeURRzywtrxONaoiFR3RYv = __p_PeURRzywtrxONaoiFR3RYv;
                this.__p_SeXFHDq458eNAC1rRzld6k = __p_SeXFHDq458eNAC1rRzld6k;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 7758U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "HAqJBIV7zZxP3TIz3hDCiw", Name = "OSCContainer")]
    [n2.SerializableAttribute]
    [n3.NameAttribute("OSCContainer")]
    [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
    public sealed class OSCContainer_HAqJBIV7zZxP3TIz3hDCiw : n4.PatchedObject, n2.IDisposable
    {
        [return: n3.PinAttribute("Output", isState: true)]
        [n8.CreateNewAttribute]
        [n1.ElementAttribute(DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "CLodlwE5Q9NP5VPCNI7g1E", Name = "Create")]
        [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
        public static n5.OSCContainer_HAqJBIV7zZxP3TIz3hDCiw Create([n3.PinAttribute("Node Context", visibility: n6.PinVisibility.Hidden)] n7.NodeContext Node_Context)
        {
            var instance = new OSCContainer_HAqJBIV7zZxP3TIz3hDCiw(Node_Context, n4.PatchedObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [return: n3.PinAttribute("Output", isState: true)]
        [n8.CreateDefaultAttribute]
        [n1.ElementAttribute(Name = "CreateDefault")]
        [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
        public static n5.OSCContainer_HAqJBIV7zZxP3TIz3hDCiw CreateDefault()
        {
            var instance = new OSCContainer_HAqJBIV7zZxP3TIz3hDCiw(n7.NodeContext.Default, n4.PatchedObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        [return: n3.PinAttribute("Output", isState: true)]
        [n1.ElementAttribute(DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "F6Wz2kjlELBOiwachbwmji", Name = "Update")]
        [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
        public n5.OSCContainer_HAqJBIV7zZxP3TIz3hDCiw Update([n1.SerializedDefaultValueAttribute("False", false)][n3.PinAttribute("ResetDataPreview")] bool ResetDataPreview_In, [n1.SerializedDefaultValueAttribute("False", false)][n3.PinAttribute("ReceiverEnabled")] bool ReceiverEnabled_In, [n1.SerializedDefaultValueAttribute("False", false)][n3.PinAttribute("SendingEnabled")] bool SendingEnabled_In, [n3.PinAttribute("stopRArgument")] float stopRArgument_In, [n1.SerializedDefaultValueAttribute("0", false)][n3.PinAttribute("MuteArgument")] float MuteArgument_In, [n1.SerializedDefaultValueAttribute("0", false)][n3.PinAttribute("IndexSound")] int IndexSound_In, [n1.SerializedDefaultValueAttribute("True", false)][n3.PinAttribute("GateSound")] bool GateSound_In, [n1.SerializedDefaultValueAttribute("0", false)][n3.PinAttribute("NbrRArgument")] float NbrRArgument_In, [n3.PinAttribute("DataFromMax")] out n2.IObservable<n20.Spread<n25.OSCMessage_R>> DataFromMax_Out, [n3.PinAttribute("DataPreviewMax")] out n20.Spread<n20.Spread<string>> DataPreviewMax_Out, [n3.PinAttribute("DataFromLouis")] out n2.IObservable<n20.Spread<n25.OSCMessage_R>> DataFromLouis_Out, [n3.PinAttribute("DataPreviewLouis")] out n20.Spread<n20.Spread<string>> DataPreviewLouis_Out, [n3.PinAttribute("OSCNbrGhost")] out int OSCNbrGhost_Out, [n3.PinAttribute("OSC_ResultMatch")] out float OSC_ResultMatch_Out, [n3.PinAttribute("SpeedValue")] out float SpeedValue_Out)
        {
            var __nodeContext = __GetContext__();
            string __pad_DR5A3ir8Z8KNRpla03TwLf_0 = __slot_DR5A3ir8Z8KNRpla03TwLf;
            string __pad_Ov3C2uOTyrHPxMkWBGnQiB_1 = __slot_Ov3C2uOTyrHPxMkWBGnQiB;
            int __pad_McLsyGTbY09Ppqttltl8pB_2 = __slot_McLsyGTbY09Ppqttltl8pB;
            string __pad_OEcRrtG7gfaO1xIiYbBU3o_3 = __slot_OEcRrtG7gfaO1xIiYbBU3o;
            int __pad_Vt3XASX0cb8MK21TFUnldG_4 = __slot_Vt3XASX0cb8MK21TFUnldG;
            string __pad_RGpOkBjDw4FPOARLMDCCdV_5 = __slot_RGpOkBjDw4FPOARLMDCCdV;
            string __pad_Cnk7uYTlTpGN221ytHc4aO_6 = __slot_Cnk7uYTlTpGN221ytHc4aO;
            string __pad_SaGJOtAmMUTMUNShKIeYPq_7 = __slot_SaGJOtAmMUTMUNShKIeYPq;
            string __pad_VEbuZ2uodLDLErFjUYLLgW_8 = __slot_VEbuZ2uodLDLErFjUYLLgW;
            int __pad_PvkKZZwQv9hQblJZqRgSOW_9 = __slot_PvkKZZwQv9hQblJZqRgSOW;
            int __pad_U7Wkc1vg9QiNq6DwU1bBhm_10 = __slot_U7Wkc1vg9QiNq6DwU1bBhm;
            int __pad_J2xMfdUldv1P50blnuzKVw_11 = __slot_J2xMfdUldv1P50blnuzKVw;
            string __pad_UF3c6TP0GPbNuhZRl9PIFk_12 = __slot_UF3c6TP0GPbNuhZRl9PIFk;
            string __pad_MUDapa2P3CJOk1torKiakp_13 = __slot_MUDapa2P3CJOk1torKiakp;
            string __pad_TV9wN7s8mQMOsLhLs9iGHT_14 = __slot_TV9wN7s8mQMOsLhLs9iGHT;
            bool __pad_MMp4qlEje41LbOr3rMasGz_15 = ResetDataPreview_In;
            bool __pad_NnFARYr2ZTGO5cNK0OZjwq_16 = ResetDataPreview_In;
            bool __pad_VoFJU65zzZuLlBwvUQBzXi_17 = ReceiverEnabled_In;
            bool __pad_AeHvatbwHnxMMUOkLSNOKi_18 = ReceiverEnabled_In;
            bool __pad_AScWUoP5hbKPoLCEAqM8tO_19 = SendingEnabled_In;
            var builder_20 = n21.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ, 3);
            builder_20.Add(__pad_Cnk7uYTlTpGN221ytHc4aO_6);
            builder_20.Add(__pad_SaGJOtAmMUTMUNShKIeYPq_7);
            builder_20.Add(__pad_VEbuZ2uodLDLErFjUYLLgW_8);
            var __pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ_21 = builder_20.Commit();
            n29._Operations_.Cons<string>(Input_In: __pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ_21, Result_Out: out n20.Spread<string> Result_22);
            n20.Spread<string> __pad_AfIhCtPJX1MPhmG7xjdlLD_23 = Result_22;
            var builder_24 = n21.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK, 3);
            builder_24.Add(__pad_PvkKZZwQv9hQblJZqRgSOW_9);
            builder_24.Add(__pad_U7Wkc1vg9QiNq6DwU1bBhm_10);
            builder_24.Add(__pad_J2xMfdUldv1P50blnuzKVw_11);
            var __pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK_25 = builder_24.Commit();
            n29._Operations_.Cons<int>(Input_In: __pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK_25, Result_Out: out n20.Spread<int> Result_26);
            n20.Spread<int> __pad_DUtIXItAzMJO5z9C3TriG8_27 = Result_26;
            string Server_28 = "127.0.0.1";
            int Port_29 = 4444;
            int Maximum_Bundle_Size_30 = 1024;
            var Output_34 = this.__p_Okczex40HF7K9wxXVw6urE.Update(Server_In: Server_28, Port_In: Port_29, Servers_In: __pad_AfIhCtPJX1MPhmG7xjdlLD_23, Ports_In: __pad_DUtIXItAzMJO5z9C3TriG8_27, Maximum_Bundle_Size_In: Maximum_Bundle_Size_30, Enabled_In: __pad_AScWUoP5hbKPoLCEAqM8tO_19, Data_Out: out n2.IObservable<n20.Spread<n25.OSCMessage_R>> Data_31, Is_Open_Out: out bool Is_Open_32, Bundle_Size_Exceeded_Out: out bool Bundle_Size_Exceeded_33);
            string Address_35 = "/record";
            bool Bundled_Per_Frame_36 = true;
            bool Apply_37 = true;
            var Output_38 = Output_34.SendMessage<float, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Address_In: Address_35, Arguments_In: stopRArgument_In, Bundled_Per_Frame_In: Bundled_Per_Frame_36, Apply_In: Apply_37);
            string Address_39 = "/Mute";
            bool Bundled_Per_Frame_40 = true;
            bool Apply_41 = true;
            var Output_42 = Output_38.SendMessage<float, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Address_In: Address_39, Arguments_In: MuteArgument_In, Bundled_Per_Frame_In: Bundled_Per_Frame_40, Apply_In: Apply_41);
            float __pad_SItRjklTI4cP8l7eFHQsJN_43 = MuteArgument_In;
            bool Bundled_Per_Frame_44 = true;
            bool Apply_45 = true;
            var Output_46 = Output_34.SendMessage<float, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Address_In: __pad_DR5A3ir8Z8KNRpla03TwLf_0, Arguments_In: MuteArgument_In, Bundled_Per_Frame_In: Bundled_Per_Frame_44, Apply_In: Apply_45);
            int __pad_Rc7GEvnIUG7L67J86Sel8b_47 = IndexSound_In;
            bool Bundled_Per_Frame_48 = true;
            var Output_49 = Output_34.SendMessage<int, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Address_In: __pad_Ov3C2uOTyrHPxMkWBGnQiB_1, Arguments_In: __pad_Rc7GEvnIUG7L67J86Sel8b_47, Bundled_Per_Frame_In: Bundled_Per_Frame_48, Apply_In: GateSound_In);
            float __pad_MEFZpTXw22JQBUPk0MAaWB_50 = NbrRArgument_In;
            bool Enable_Data_Preview_51 = true;
            bool Sort_Data_Preview_52 = true;
            var Output_56 = this.__p_EqEeqn1IqpHPIa2b9ZbKwg.Update(Listening_IP_In: __pad_OEcRrtG7gfaO1xIiYbBU3o_3, Port_In: __pad_McLsyGTbY09Ppqttltl8pB_2, Enable_Data_Preview_In: Enable_Data_Preview_51, Sort_Data_Preview_In: Sort_Data_Preview_52, Reset_Data_Preview_In: __pad_MMp4qlEje41LbOr3rMasGz_15, Enabled_In: __pad_VoFJU65zzZuLlBwvUQBzXi_17, Data_Out: out n2.IObservable<n20.Spread<n25.OSCMessage_R>> Data_53, Data_Preview_Out: out n20.Spread<n20.Spread<string>> Data_Preview_54, Is_Open_Out: out bool Is_Open_55);
            n20.Spread<n20.Spread<string>> __pad_EjhCrOfnIvKLdI1IWsX4cD_57 = Data_Preview_54;
            string Address_58 = "/MaxSpeed";
            bool Learn_59 = false;
            var State_Output_64 = this.__p_ABIXTWWN7xBLHfo1zIdnmN.Update<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Input_In: Data_53, Address_In: Address_58, Learn_In: Learn_59, Output_Out: out float Output_60, Is_Learning_Out: out bool Is_Learning_61, On_Data_Out: out bool On_Data_62, Address_Out: out string Address_63);
            bool Enable_Data_Preview_65 = true;
            bool Sort_Data_Preview_66 = true;
            var Output_70 = this.__p_VhCv0bEfJsZPCMp4HQJTPb.Update(Listening_IP_In: __pad_RGpOkBjDw4FPOARLMDCCdV_5, Port_In: __pad_Vt3XASX0cb8MK21TFUnldG_4, Enable_Data_Preview_In: Enable_Data_Preview_65, Sort_Data_Preview_In: Sort_Data_Preview_66, Reset_Data_Preview_In: __pad_NnFARYr2ZTGO5cNK0OZjwq_16, Enabled_In: __pad_AeHvatbwHnxMMUOkLSNOKi_18, Data_Out: out n2.IObservable<n20.Spread<n25.OSCMessage_R>> Data_67, Data_Preview_Out: out n20.Spread<n20.Spread<string>> Data_Preview_68, Is_Open_Out: out bool Is_Open_69);
            string Address_71 = "/ScoreGhost";
            bool Learn_72 = false;
            var State_Output_77 = this.__p_Uuah89pZ0gWM8eaoTTMDF1.Update<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Input_In: Data_67, Address_In: Address_71, Learn_In: Learn_72, Output_Out: out float Output_73, Is_Learning_Out: out bool Is_Learning_74, On_Data_Out: out bool On_Data_75, Address_Out: out string Address_76);
            float __pad_JGoDAuDsD0ON9saqDahNjd_78 = Output_73;
            string Address_79 = "/NbrGhost";
            bool Learn_80 = false;
            var State_Output_85 = this.__p_EgbYeCfEmTHPRuIyoWaUAN.Update<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Input_In: Data_67, Address_In: Address_79, Learn_In: Learn_80, Output_Out: out float Output_81, Is_Learning_Out: out bool Is_Learning_82, On_Data_Out: out bool On_Data_83, Address_Out: out string Address_84);
            float __pad_OXPsYpTTTKTPqwR1MybGIu_86 = Output_81;
            bool __pad_CoHpyznE2zqQAk4TAiZp93_87 = On_Data_83;
            n12._Operations_.Floor(Input_In: __pad_OXPsYpTTTKTPqwR1MybGIu_86, Result_Out: out int Result_88);
            float Period_89 = 1F;
            bool Pause_90 = false;
            bool Update_91 = true;
            n26.LFO_F48sA9CC7kzM1Y1LIpWRrD Output_92 = this.__p_PICkNvHQBIILgiUEhwg7ow;
            if (Update_91)
            {
                Output_92 = this.__p_PICkNvHQBIILgiUEhwg7ow.Update(Period_In: Period_89, Pause_In: Pause_90);
            }

            var Output_96 = Output_92.GetValues(Phase_Out: out float Phase_93, On_New_Cycle_Out: out bool On_New_Cycle_94, Cycles_Out: out int Cycles_95);
            n25.OSCClient_C Input_97 = n25.OSCClient_C.CreateDefault();
            bool Bundled_Per_Frame_98 = true;
            bool Apply_99 = true;
            var Output_100 = Input_97.SendMessage<float, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Address_In: __pad_UF3c6TP0GPbNuhZRl9PIFk_12, Arguments_In: Phase_93, Bundled_Per_Frame_In: Bundled_Per_Frame_98, Apply_In: Apply_99);
            bool Bundled_Per_Frame_101 = true;
            bool Apply_102 = true;
            var Output_103 = Output_34.SendMessage<float, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Address_In: __pad_MUDapa2P3CJOk1torKiakp_13, Arguments_In: __pad_SItRjklTI4cP8l7eFHQsJN_43, Bundled_Per_Frame_In: Bundled_Per_Frame_101, Apply_In: Apply_102);
            bool Bundled_Per_Frame_104 = true;
            bool Apply_105 = true;
            var Output_106 = Output_34.SendMessage<float, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Address_In: __pad_TV9wN7s8mQMOsLhLs9iGHT_14, Arguments_In: __pad_MEFZpTXw22JQBUPk0MAaWB_50, Bundled_Per_Frame_In: Bundled_Per_Frame_104, Apply_In: Apply_105);
            DataFromMax_Out = Data_53;
            DataPreviewMax_Out = __pad_EjhCrOfnIvKLdI1IWsX4cD_57;
            DataFromLouis_Out = Data_67;
            DataPreviewLouis_Out = Data_Preview_68;
            OSCNbrGhost_Out = Result_88;
            OSC_ResultMatch_Out = __pad_JGoDAuDsD0ON9saqDahNjd_78;
            SpeedValue_Out = Output_60;
            n5.OSCContainer_HAqJBIV7zZxP3TIz3hDCiw that_107 = this;
            if (this.__GetContext__().IsImmutable)
                that_107 = ResetDataPreview_In != this.__slot_MMp4qlEje41LbOr3rMasGz || ResetDataPreview_In != this.__slot_NnFARYr2ZTGO5cNK0OZjwq || ReceiverEnabled_In != this.__slot_VoFJU65zzZuLlBwvUQBzXi || ReceiverEnabled_In != this.__slot_AeHvatbwHnxMMUOkLSNOKi || SendingEnabled_In != this.__slot_AScWUoP5hbKPoLCEAqM8tO || !n24.EqualityComparer<n20.Spread<string>>.Default.Equals(__pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ_21, this.__pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ) || !n24.EqualityComparer<n20.Spread<string>>.Default.Equals(Result_22, this.__slot_AfIhCtPJX1MPhmG7xjdlLD) || !n24.EqualityComparer<n20.Spread<int>>.Default.Equals(__pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK_25, this.__pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK) || !n24.EqualityComparer<n20.Spread<int>>.Default.Equals(Result_26, this.__slot_DUtIXItAzMJO5z9C3TriG8) || !n24.EqualityComparer<n25.OSCClient_C>.Default.Equals(Output_34, this.__p_Okczex40HF7K9wxXVw6urE) || MuteArgument_In != this.__slot_SItRjklTI4cP8l7eFHQsJN || IndexSound_In != this.__slot_Rc7GEvnIUG7L67J86Sel8b || NbrRArgument_In != this.__slot_MEFZpTXw22JQBUPk0MAaWB || !n24.EqualityComparer<n25.OSCServer_IKIo4Vfhm7kNF6zaGENX9O>.Default.Equals(Output_56, this.__p_EqEeqn1IqpHPIa2b9ZbKwg) || !n24.EqualityComparer<n20.Spread<n20.Spread<string>>>.Default.Equals(Data_Preview_54, this.__slot_EjhCrOfnIvKLdI1IWsX4cD) || !n24.EqualityComparer<n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>>.Default.Equals(State_Output_64, this.__p_ABIXTWWN7xBLHfo1zIdnmN) || !n24.EqualityComparer<n25.OSCServer_IKIo4Vfhm7kNF6zaGENX9O>.Default.Equals(Output_70, this.__p_VhCv0bEfJsZPCMp4HQJTPb) || !n24.EqualityComparer<n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>>.Default.Equals(State_Output_77, this.__p_Uuah89pZ0gWM8eaoTTMDF1) || Output_73 != this.__slot_JGoDAuDsD0ON9saqDahNjd || !n24.EqualityComparer<n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>>.Default.Equals(State_Output_85, this.__p_EgbYeCfEmTHPRuIyoWaUAN) || Output_81 != this.__slot_OXPsYpTTTKTPqwR1MybGIu || On_Data_83 != this.__slot_CoHpyznE2zqQAk4TAiZp93 || !n24.EqualityComparer<n26.LFO_F48sA9CC7kzM1Y1LIpWRrD>.Default.Equals(Output_96, this.__p_PICkNvHQBIILgiUEhwg7ow) ? new n5.OSCContainer_HAqJBIV7zZxP3TIz3hDCiw(this)
                {__slot_MMp4qlEje41LbOr3rMasGz = ResetDataPreview_In, __slot_NnFARYr2ZTGO5cNK0OZjwq = ResetDataPreview_In, __slot_VoFJU65zzZuLlBwvUQBzXi = ReceiverEnabled_In, __slot_AeHvatbwHnxMMUOkLSNOKi = ReceiverEnabled_In, __slot_AScWUoP5hbKPoLCEAqM8tO = SendingEnabled_In, __pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ = __pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ_21, __slot_AfIhCtPJX1MPhmG7xjdlLD = Result_22, __pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK = __pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK_25, __slot_DUtIXItAzMJO5z9C3TriG8 = Result_26, __p_Okczex40HF7K9wxXVw6urE = Output_34, __slot_SItRjklTI4cP8l7eFHQsJN = MuteArgument_In, __slot_Rc7GEvnIUG7L67J86Sel8b = IndexSound_In, __slot_MEFZpTXw22JQBUPk0MAaWB = NbrRArgument_In, __p_EqEeqn1IqpHPIa2b9ZbKwg = Output_56, __slot_EjhCrOfnIvKLdI1IWsX4cD = Data_Preview_54, __p_ABIXTWWN7xBLHfo1zIdnmN = State_Output_64, __p_VhCv0bEfJsZPCMp4HQJTPb = Output_70, __p_Uuah89pZ0gWM8eaoTTMDF1 = State_Output_77, __slot_JGoDAuDsD0ON9saqDahNjd = Output_73, __p_EgbYeCfEmTHPRuIyoWaUAN = State_Output_85, __slot_OXPsYpTTTKTPqwR1MybGIu = Output_81, __slot_CoHpyznE2zqQAk4TAiZp93 = On_Data_83, __p_PICkNvHQBIILgiUEhwg7ow = Output_96} : that_107;
            else
            {
                this.__slot_MMp4qlEje41LbOr3rMasGz = ResetDataPreview_In;
                this.__slot_NnFARYr2ZTGO5cNK0OZjwq = ResetDataPreview_In;
                this.__slot_VoFJU65zzZuLlBwvUQBzXi = ReceiverEnabled_In;
                this.__slot_AeHvatbwHnxMMUOkLSNOKi = ReceiverEnabled_In;
                this.__slot_AScWUoP5hbKPoLCEAqM8tO = SendingEnabled_In;
                this.__pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ = __pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ_21;
                this.__slot_AfIhCtPJX1MPhmG7xjdlLD = Result_22;
                this.__pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK = __pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK_25;
                this.__slot_DUtIXItAzMJO5z9C3TriG8 = Result_26;
                this.__p_Okczex40HF7K9wxXVw6urE = Output_34;
                this.__slot_SItRjklTI4cP8l7eFHQsJN = MuteArgument_In;
                this.__slot_Rc7GEvnIUG7L67J86Sel8b = IndexSound_In;
                this.__slot_MEFZpTXw22JQBUPk0MAaWB = NbrRArgument_In;
                this.__p_EqEeqn1IqpHPIa2b9ZbKwg = Output_56;
                this.__slot_EjhCrOfnIvKLdI1IWsX4cD = Data_Preview_54;
                this.__p_ABIXTWWN7xBLHfo1zIdnmN = State_Output_64;
                this.__p_VhCv0bEfJsZPCMp4HQJTPb = Output_70;
                this.__p_Uuah89pZ0gWM8eaoTTMDF1 = State_Output_77;
                this.__slot_JGoDAuDsD0ON9saqDahNjd = Output_73;
                this.__p_EgbYeCfEmTHPRuIyoWaUAN = State_Output_85;
                this.__slot_OXPsYpTTTKTPqwR1MybGIu = Output_81;
                this.__slot_CoHpyznE2zqQAk4TAiZp93 = On_Data_83;
                this.__p_PICkNvHQBIILgiUEhwg7ow = Output_96;
            }

            return that_107;
        }

        [return: n3.PinAttribute("Output", isState: true)]
        [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
        public n5.OSCContainer_HAqJBIV7zZxP3TIz3hDCiw __Create__([n3.PinAttribute("Node Context", visibility: n6.PinVisibility.Hidden)] n7.NodeContext Node_Context)
        {
            n27.RuntimeHelpers.EnsureSufficientExecutionStack();
            var __nodeContext = Node_Context;
            n7.NodeContext Node_Context_0 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "EqEeqn1IqpHPIa2b9ZbKwg", 7761U);
            var Output_1 = n25.OSCServer_IKIo4Vfhm7kNF6zaGENX9O.Create(Node_Context: Node_Context_0);
            n7.NodeContext Node_Context_2 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "Okczex40HF7K9wxXVw6urE", 7774U);
            var Output_3 = n25.OSCClient_C.Create(Node_Context: Node_Context_2);
            n7.NodeContext Node_Context_4 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "PICkNvHQBIILgiUEhwg7ow", 7814U);
            n18.IFrameClock Clock_5 = n28._Operations_.CreateDefault();
            var Output_6 = n26.LFO_F48sA9CC7kzM1Y1LIpWRrD.Create(Node_Context: Node_Context_4, Clock_In: Clock_5);
            n7.NodeContext Node_Context_7 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "VhCv0bEfJsZPCMp4HQJTPb", 7890U);
            var Output_8 = n25.OSCServer_IKIo4Vfhm7kNF6zaGENX9O.Create(Node_Context: Node_Context_7);
            n7.NodeContext Node_Context_9 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "Uuah89pZ0gWM8eaoTTMDF1", 7928U);
            var Output_10 = n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>.Create<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Node_Context: Node_Context_9);
            n7.NodeContext Node_Context_11 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "EgbYeCfEmTHPRuIyoWaUAN", 7935U);
            var Output_12 = n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>.Create<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Node_Context: Node_Context_11);
            n7.NodeContext Node_Context_13 = __nodeContext.CreateSubContext("RoWK1pOK0gPLwpiC9YkoXc", "ABIXTWWN7xBLHfo1zIdnmN", 7950U);
            var Output_14 = n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>.Create<n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Node_Context: Node_Context_13);
            n5.OSCContainer_HAqJBIV7zZxP3TIz3hDCiw that_15 = this;
            this.__slot_VoFJU65zzZuLlBwvUQBzXi = false;
            this.__slot_EjhCrOfnIvKLdI1IWsX4cD = n29._Operations_.CreateDefault<n20.Spread<string>>();
            this.__slot_AScWUoP5hbKPoLCEAqM8tO = false;
            this.__slot_MMp4qlEje41LbOr3rMasGz = false;
            this.__slot_AfIhCtPJX1MPhmG7xjdlLD = n29._Operations_.CreateDefault<string>();
            this.__slot_DUtIXItAzMJO5z9C3TriG8 = n29._Operations_.CreateDefault<int>();
            this.__slot_Rc7GEvnIUG7L67J86Sel8b = 0;
            this.__slot_SItRjklTI4cP8l7eFHQsJN = 0F;
            this.__slot_AeHvatbwHnxMMUOkLSNOKi = false;
            this.__slot_NnFARYr2ZTGO5cNK0OZjwq = false;
            this.__slot_MEFZpTXw22JQBUPk0MAaWB = 0F;
            this.__slot_OXPsYpTTTKTPqwR1MybGIu = 0F;
            this.__slot_CoHpyznE2zqQAk4TAiZp93 = false;
            this.__slot_JGoDAuDsD0ON9saqDahNjd = 0F;
            this.__pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ = default(n20.Spread<string>);
            this.__pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK = default(n20.Spread<int>);
            this.__p_EqEeqn1IqpHPIa2b9ZbKwg = Output_1;
            this.__p_Okczex40HF7K9wxXVw6urE = Output_3;
            this.__p_PICkNvHQBIILgiUEhwg7ow = Output_6;
            this.__p_VhCv0bEfJsZPCMp4HQJTPb = Output_8;
            this.__p_Uuah89pZ0gWM8eaoTTMDF1 = Output_10;
            this.__p_EgbYeCfEmTHPRuIyoWaUAN = Output_12;
            this.__p_ABIXTWWN7xBLHfo1zIdnmN = Output_14;
            return that_15;
        }

        [return: n3.PinAttribute("Output", isState: true)]
        [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
        public n5.OSCContainer_HAqJBIV7zZxP3TIz3hDCiw __CreateDefault__()
        {
            var __nodeContext = n7.NodeContext.Default;
            n5.OSCContainer_HAqJBIV7zZxP3TIz3hDCiw that_0 = this;
            this.__slot_VoFJU65zzZuLlBwvUQBzXi = false;
            this.__slot_EjhCrOfnIvKLdI1IWsX4cD = n29._Operations_.CreateDefault<n20.Spread<string>>();
            this.__slot_AScWUoP5hbKPoLCEAqM8tO = false;
            this.__slot_MMp4qlEje41LbOr3rMasGz = false;
            this.__slot_AfIhCtPJX1MPhmG7xjdlLD = n29._Operations_.CreateDefault<string>();
            this.__slot_DUtIXItAzMJO5z9C3TriG8 = n29._Operations_.CreateDefault<int>();
            this.__slot_Rc7GEvnIUG7L67J86Sel8b = 0;
            this.__slot_SItRjklTI4cP8l7eFHQsJN = 0F;
            this.__slot_AeHvatbwHnxMMUOkLSNOKi = false;
            this.__slot_NnFARYr2ZTGO5cNK0OZjwq = false;
            this.__slot_MEFZpTXw22JQBUPk0MAaWB = 0F;
            this.__slot_OXPsYpTTTKTPqwR1MybGIu = 0F;
            this.__slot_CoHpyznE2zqQAk4TAiZp93 = false;
            this.__slot_JGoDAuDsD0ON9saqDahNjd = 0F;
            this.__pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ = default(n20.Spread<string>);
            this.__pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK = default(n20.Spread<int>);
            this.__p_Okczex40HF7K9wxXVw6urE = n25.OSCClient_C.CreateDefault();
            this.__p_EqEeqn1IqpHPIa2b9ZbKwg = n25.OSCServer_IKIo4Vfhm7kNF6zaGENX9O.CreateDefault();
            this.__p_ABIXTWWN7xBLHfo1zIdnmN = n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>.CreateDefault();
            this.__p_VhCv0bEfJsZPCMp4HQJTPb = n25.OSCServer_IKIo4Vfhm7kNF6zaGENX9O.CreateDefault();
            this.__p_Uuah89pZ0gWM8eaoTTMDF1 = n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>.CreateDefault();
            this.__p_EgbYeCfEmTHPRuIyoWaUAN = n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>.CreateDefault();
            this.__p_PICkNvHQBIILgiUEhwg7ow = n26.LFO_F48sA9CC7kzM1Y1LIpWRrD.CreateDefault();
            return that_0;
        }

        public void Dispose()
        {
            var __nodeContext = __GetContext__();
            try
            {
                return;
            }
            finally
            {
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_ABIXTWWN7xBLHfo1zIdnmN);
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_EgbYeCfEmTHPRuIyoWaUAN);
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_Uuah89pZ0gWM8eaoTTMDF1);
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_VhCv0bEfJsZPCMp4HQJTPb);
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_PICkNvHQBIILgiUEhwg7ow);
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_Okczex40HF7K9wxXVw6urE);
                n23.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_EqEeqn1IqpHPIa2b9ZbKwg);
            }
        }

        [n1.ElementAttribute(TracingId = 7771U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "McLsyGTbY09Ppqttltl8pB", Name = "__slot_McLsyGTbY09Ppqttltl8pB")]
        public static int __slot_McLsyGTbY09Ppqttltl8pB = 2222;
        [n1.ElementAttribute(TracingId = 7772U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "OEcRrtG7gfaO1xIiYbBU3o", Name = "__slot_OEcRrtG7gfaO1xIiYbBU3o")]
        public static string __slot_OEcRrtG7gfaO1xIiYbBU3o = "";
        [n1.ElementAttribute(TracingId = 7773U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "VoFJU65zzZuLlBwvUQBzXi", Name = "__slot_VoFJU65zzZuLlBwvUQBzXi")]
        public bool __slot_VoFJU65zzZuLlBwvUQBzXi;
        [n1.ElementAttribute(TracingId = 7785U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "JkAaL3UzwxhQFb16my1OIT", Name = "__slot_JkAaL3UzwxhQFb16my1OIT")]
        public static string __slot_JkAaL3UzwxhQFb16my1OIT = "127.0.0.1";
        [n1.ElementAttribute(TracingId = 7786U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "EjhCrOfnIvKLdI1IWsX4cD", Name = "__slot_EjhCrOfnIvKLdI1IWsX4cD")]
        public n20.Spread<n20.Spread<string>> __slot_EjhCrOfnIvKLdI1IWsX4cD;
        [n1.ElementAttribute(TracingId = 7787U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "AScWUoP5hbKPoLCEAqM8tO", Name = "__slot_AScWUoP5hbKPoLCEAqM8tO")]
        public bool __slot_AScWUoP5hbKPoLCEAqM8tO;
        [n1.ElementAttribute(TracingId = 7788U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "EKzAqc8ybCoOCxJvqco9yw", Name = "__slot_EKzAqc8ybCoOCxJvqco9yw")]
        public static string __slot_EKzAqc8ybCoOCxJvqco9yw = "FROM MAX";
        [n1.ElementAttribute(TracingId = 7789U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "VFX4XrzVjgVPXwvR5Xopd1", Name = "__slot_VFX4XrzVjgVPXwvR5Xopd1")]
        public static string __slot_VFX4XrzVjgVPXwvR5Xopd1 = "//OSCClient sending to VCV";
        [n1.ElementAttribute(TracingId = 7790U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "MMp4qlEje41LbOr3rMasGz", Name = "__slot_MMp4qlEje41LbOr3rMasGz")]
        public bool __slot_MMp4qlEje41LbOr3rMasGz;
        [n1.ElementAttribute(TracingId = 7792U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "Ag0kn4cjDYBL1b410ifHpG", Name = "__slot_Ag0kn4cjDYBL1b410ifHpG")]
        public static string __slot_Ag0kn4cjDYBL1b410ifHpG = "//check Z value 10 or 1 or .1";
        [n1.ElementAttribute(TracingId = 7793U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "ECqITyu1pYaPSajuqEo38O", Name = "__slot_ECqITyu1pYaPSajuqEo38O")]
        public static string __slot_ECqITyu1pYaPSajuqEo38O = "//check pow/log factor";
        [n1.ElementAttribute(TracingId = 7799U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "Cnk7uYTlTpGN221ytHc4aO", Name = "__slot_Cnk7uYTlTpGN221ytHc4aO")]
        public static string __slot_Cnk7uYTlTpGN221ytHc4aO = "169.254.92.193";
        [n1.ElementAttribute(TracingId = 7800U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "AfIhCtPJX1MPhmG7xjdlLD", Name = "__slot_AfIhCtPJX1MPhmG7xjdlLD")]
        public n20.Spread<string> __slot_AfIhCtPJX1MPhmG7xjdlLD;
        [n1.ElementAttribute(TracingId = 7801U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "C4sLhYt4vb3OOtxeB7pKuT", Name = "__slot_C4sLhYt4vb3OOtxeB7pKuT")]
        public static string __slot_C4sLhYt4vb3OOtxeB7pKuT = "169.254.88.20";
        [n1.ElementAttribute(TracingId = 7802U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "SaGJOtAmMUTMUNShKIeYPq", Name = "__slot_SaGJOtAmMUTMUNShKIeYPq")]
        public static string __slot_SaGJOtAmMUTMUNShKIeYPq = "169.254.158.243";
        [n1.ElementAttribute(TracingId = 7803U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "VMoNmz77UWwOtB7yGKCqSn", Name = "__slot_VMoNmz77UWwOtB7yGKCqSn")]
        public static string __slot_VMoNmz77UWwOtB7yGKCqSn = "//localhost";
        [n1.ElementAttribute(TracingId = 7804U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "GusHxbPa7DlPp9PRKeYZfi", Name = "__slot_GusHxbPa7DlPp9PRKeYZfi")]
        public static string __slot_GusHxbPa7DlPp9PRKeYZfi = "//HP ANE";
        [n1.ElementAttribute(TracingId = 7805U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "ULKlwgyScsiPb4ZdqqDucI", Name = "__slot_ULKlwgyScsiPb4ZdqqDucI")]
        public static string __slot_ULKlwgyScsiPb4ZdqqDucI = "//GB NOEL";
        [n1.ElementAttribute(TracingId = 7806U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "SZvdXlRUbTzM2E9SgYVQ9e", Name = "__slot_SZvdXlRUbTzM2E9SgYVQ9e")]
        public static string __slot_SZvdXlRUbTzM2E9SgYVQ9e = "//LOUIS";
        [n1.ElementAttribute(TracingId = 7821U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "UF3c6TP0GPbNuhZRl9PIFk", Name = "__slot_UF3c6TP0GPbNuhZRl9PIFk")]
        public static string __slot_UF3c6TP0GPbNuhZRl9PIFk = "/lfo";
        [n1.ElementAttribute(TracingId = 7822U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "VW4epA5Y4WCPfNM5z2qHgC", Name = "__slot_VW4epA5Y4WCPfNM5z2qHgC")]
        public static string __slot_VW4epA5Y4WCPfNM5z2qHgC = "//check ip port IN";
        [n1.ElementAttribute(TracingId = 7823U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "KDdx9ZPrf8HPl3vFu6PDld", Name = "__slot_KDdx9ZPrf8HPl3vFu6PDld")]
        public static string __slot_KDdx9ZPrf8HPl3vFu6PDld = "//check ip port OUT";
        [n1.ElementAttribute(TracingId = 7824U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "TlXWzyO2ntaNZbJIFSLyxV", Name = "__slot_TlXWzyO2ntaNZbJIFSLyxV")]
        public static string __slot_TlXWzyO2ntaNZbJIFSLyxV = "//check LFO send message";
        [n1.ElementAttribute(TracingId = 7827U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "JgkogWqOwAUPbIhZ5WpVUp", Name = "__slot_JgkogWqOwAUPbIhZ5WpVUp")]
        public static string __slot_JgkogWqOwAUPbIhZ5WpVUp = "//testsignal";
        [n1.ElementAttribute(TracingId = 7828U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "V7VbMk9hCrJMZGsktzHvLt", Name = "__slot_V7VbMk9hCrJMZGsktzHvLt")]
        public static string __slot_V7VbMk9hCrJMZGsktzHvLt = "169.254.138.242";
        [n1.ElementAttribute(TracingId = 7829U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "J5MVfFbhXPDP1C0dGbTXIi", Name = "__slot_J5MVfFbhXPDP1C0dGbTXIi")]
        public static string __slot_J5MVfFbhXPDP1C0dGbTXIi = "//CELIA";
        [n1.ElementAttribute(TracingId = 7843U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "U4Pv3bg7ln7Pb6VLPAw6dY", Name = "__slot_U4Pv3bg7ln7Pb6VLPAw6dY")]
        public static string __slot_U4Pv3bg7ln7Pb6VLPAw6dY = "//stopR";
        [n1.ElementAttribute(TracingId = 7844U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "UEA6HxSqvhfO5L0n5hp0cK", Name = "__slot_UEA6HxSqvhfO5L0n5hp0cK")]
        public static string __slot_UEA6HxSqvhfO5L0n5hp0cK = "//in OSCBridger";
        [n1.ElementAttribute(TracingId = 7845U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "V8n1UpdzPSQOre87aq9Ymq", Name = "__slot_V8n1UpdzPSQOre87aq9Ymq")]
        public static string __slot_V8n1UpdzPSQOre87aq9Ymq = "//check SpeedCalculation Map for InputMax";
        [n1.ElementAttribute(TracingId = 7852U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "DUtIXItAzMJO5z9C3TriG8", Name = "__slot_DUtIXItAzMJO5z9C3TriG8")]
        public n20.Spread<int> __slot_DUtIXItAzMJO5z9C3TriG8;
        [n1.ElementAttribute(TracingId = 7853U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "PvkKZZwQv9hQblJZqRgSOW", Name = "__slot_PvkKZZwQv9hQblJZqRgSOW")]
        public static int __slot_PvkKZZwQv9hQblJZqRgSOW = 3333;
        [n1.ElementAttribute(TracingId = 7854U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "U7Wkc1vg9QiNq6DwU1bBhm", Name = "__slot_U7Wkc1vg9QiNq6DwU1bBhm")]
        public static int __slot_U7Wkc1vg9QiNq6DwU1bBhm = 4444;
        [n1.ElementAttribute(TracingId = 7863U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "DJdJpfUL6GiMlZueFprvgw", Name = "__slot_DJdJpfUL6GiMlZueFprvgw")]
        public static string __slot_DJdJpfUL6GiMlZueFprvgw = "//Mute";
        [n1.ElementAttribute(TracingId = 7864U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "VEbuZ2uodLDLErFjUYLLgW", Name = "__slot_VEbuZ2uodLDLErFjUYLLgW")]
        public static string __slot_VEbuZ2uodLDLErFjUYLLgW = "169.254.231.76";
        [n1.ElementAttribute(TracingId = 7865U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "G585zpgwkplMPRYGxtgYeE", Name = "__slot_G585zpgwkplMPRYGxtgYeE")]
        public static string __slot_G585zpgwkplMPRYGxtgYeE = "//Mac";
        [n1.ElementAttribute(TracingId = 7866U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "J2xMfdUldv1P50blnuzKVw", Name = "__slot_J2xMfdUldv1P50blnuzKVw")]
        public static int __slot_J2xMfdUldv1P50blnuzKVw = 8888;
        [n1.ElementAttribute(TracingId = 7867U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "Ov3C2uOTyrHPxMkWBGnQiB", Name = "__slot_Ov3C2uOTyrHPxMkWBGnQiB")]
        public static string __slot_Ov3C2uOTyrHPxMkWBGnQiB = "/plays1";
        [n1.ElementAttribute(TracingId = 7878U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "Rc7GEvnIUG7L67J86Sel8b", Name = "__slot_Rc7GEvnIUG7L67J86Sel8b")]
        public int __slot_Rc7GEvnIUG7L67J86Sel8b;
        [n1.ElementAttribute(TracingId = 7886U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "PKg5BGtE1PdMqMj2Mfq4wT", Name = "__slot_PKg5BGtE1PdMqMj2Mfq4wT")]
        public static string __slot_PKg5BGtE1PdMqMj2Mfq4wT = "//Phase2Start";
        [n1.ElementAttribute(TracingId = 7887U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "MUDapa2P3CJOk1torKiakp", Name = "__slot_MUDapa2P3CJOk1torKiakp")]
        public static string __slot_MUDapa2P3CJOk1torKiakp = "/Phase2";
        [n1.ElementAttribute(TracingId = 7889U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "SItRjklTI4cP8l7eFHQsJN", Name = "__slot_SItRjklTI4cP8l7eFHQsJN")]
        public float __slot_SItRjklTI4cP8l7eFHQsJN;
        [n1.ElementAttribute(TracingId = 7900U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "Vt3XASX0cb8MK21TFUnldG", Name = "__slot_Vt3XASX0cb8MK21TFUnldG")]
        public static int __slot_Vt3XASX0cb8MK21TFUnldG = 1111;
        [n1.ElementAttribute(TracingId = 7901U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "RGpOkBjDw4FPOARLMDCCdV", Name = "__slot_RGpOkBjDw4FPOARLMDCCdV")]
        public static string __slot_RGpOkBjDw4FPOARLMDCCdV = "";
        [n1.ElementAttribute(TracingId = 7902U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "AeHvatbwHnxMMUOkLSNOKi", Name = "__slot_AeHvatbwHnxMMUOkLSNOKi")]
        public bool __slot_AeHvatbwHnxMMUOkLSNOKi;
        [n1.ElementAttribute(TracingId = 7903U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "NnFARYr2ZTGO5cNK0OZjwq", Name = "__slot_NnFARYr2ZTGO5cNK0OZjwq")]
        public bool __slot_NnFARYr2ZTGO5cNK0OZjwq;
        [n1.ElementAttribute(TracingId = 7905U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "AJAHWrRIh7NPWdO6I8IFlO", Name = "__slot_AJAHWrRIh7NPWdO6I8IFlO")]
        public static string __slot_AJAHWrRIh7NPWdO6I8IFlO = "FROM LOUIS";
        [n1.ElementAttribute(TracingId = 7908U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "D7CTZV0LxSdNV6hgk27MgN", Name = "__slot_D7CTZV0LxSdNV6hgk27MgN")]
        public static string __slot_D7CTZV0LxSdNV6hgk27MgN = "169.254.254.162";
        [n1.ElementAttribute(TracingId = 7916U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "TV9wN7s8mQMOsLhLs9iGHT", Name = "__slot_TV9wN7s8mQMOsLhLs9iGHT")]
        public static string __slot_TV9wN7s8mQMOsLhLs9iGHT = "/NbrR";
        [n1.ElementAttribute(TracingId = 7917U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "MEFZpTXw22JQBUPk0MAaWB", Name = "__slot_MEFZpTXw22JQBUPk0MAaWB")]
        public float __slot_MEFZpTXw22JQBUPk0MAaWB;
        [n1.ElementAttribute(TracingId = 7919U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "TvuOpqi67ESN2sWqXybahc", Name = "__slot_TvuOpqi67ESN2sWqXybahc")]
        public static string __slot_TvuOpqi67ESN2sWqXybahc = "169.254.245.27";
        [n1.ElementAttribute(TracingId = 7920U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "DR5A3ir8Z8KNRpla03TwLf", Name = "__slot_DR5A3ir8Z8KNRpla03TwLf")]
        public static string __slot_DR5A3ir8Z8KNRpla03TwLf = "/Mute";
        [n1.ElementAttribute(TracingId = 7942U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "OXPsYpTTTKTPqwR1MybGIu", Name = "__slot_OXPsYpTTTKTPqwR1MybGIu")]
        public float __slot_OXPsYpTTTKTPqwR1MybGIu;
        [n1.ElementAttribute(TracingId = 7943U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "CoHpyznE2zqQAk4TAiZp93", Name = "__slot_CoHpyznE2zqQAk4TAiZp93")]
        public bool __slot_CoHpyznE2zqQAk4TAiZp93;
        [n1.ElementAttribute(TracingId = 7949U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "JGoDAuDsD0ON9saqDahNjd", Name = "__slot_JGoDAuDsD0ON9saqDahNjd")]
        public float __slot_JGoDAuDsD0ON9saqDahNjd;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n20.Spread<string> __pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ;
        [n1.ElementAttribute(IsAutoGenerated = true)]
        public n20.Spread<int> __pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK;
        [n1.ElementAttribute(TracingId = 7774U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "Okczex40HF7K9wxXVw6urE", Name = "OSCClient", IsManaged = true, IsAutoGenerated = true)]
        public n25.OSCClient_C __p_Okczex40HF7K9wxXVw6urE;
        [n1.ElementAttribute(TracingId = 7761U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "EqEeqn1IqpHPIa2b9ZbKwg", Name = "OSCServer", IsManaged = true, IsAutoGenerated = true)]
        public n25.OSCServer_IKIo4Vfhm7kNF6zaGENX9O __p_EqEeqn1IqpHPIa2b9ZbKwg;
        [n1.ElementAttribute(TracingId = 7950U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "ABIXTWWN7xBLHfo1zIdnmN", Name = "OSCReceiver", IsManaged = true, IsAutoGenerated = true)]
        public n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float> __p_ABIXTWWN7xBLHfo1zIdnmN;
        [n1.ElementAttribute(TracingId = 7890U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "VhCv0bEfJsZPCMp4HQJTPb", Name = "OSCServer", IsManaged = true, IsAutoGenerated = true)]
        public n25.OSCServer_IKIo4Vfhm7kNF6zaGENX9O __p_VhCv0bEfJsZPCMp4HQJTPb;
        [n1.ElementAttribute(TracingId = 7928U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "Uuah89pZ0gWM8eaoTTMDF1", Name = "OSCReceiver", IsManaged = true, IsAutoGenerated = true)]
        public n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float> __p_Uuah89pZ0gWM8eaoTTMDF1;
        [n1.ElementAttribute(TracingId = 7935U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "EgbYeCfEmTHPRuIyoWaUAN", Name = "OSCReceiver", IsManaged = true, IsAutoGenerated = true)]
        public n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float> __p_EgbYeCfEmTHPRuIyoWaUAN;
        [n1.ElementAttribute(TracingId = 7814U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "PICkNvHQBIILgiUEhwg7ow", Name = "LFO", IsManaged = true, IsAutoGenerated = true)]
        public n26.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_PICkNvHQBIILgiUEhwg7ow;
        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        public OSCContainer_HAqJBIV7zZxP3TIz3hDCiw() : base()
        {
        }

        public OSCContainer_HAqJBIV7zZxP3TIz3hDCiw(n7.NodeContext context, uint identity) : base(context, identity)
        {
        }

        public OSCContainer_HAqJBIV7zZxP3TIz3hDCiw(OSCContainer_HAqJBIV7zZxP3TIz3hDCiw other) : base(other)
        {
            this.__slot_VoFJU65zzZuLlBwvUQBzXi = other.__slot_VoFJU65zzZuLlBwvUQBzXi;
            this.__slot_EjhCrOfnIvKLdI1IWsX4cD = other.__slot_EjhCrOfnIvKLdI1IWsX4cD;
            this.__slot_AScWUoP5hbKPoLCEAqM8tO = other.__slot_AScWUoP5hbKPoLCEAqM8tO;
            this.__slot_MMp4qlEje41LbOr3rMasGz = other.__slot_MMp4qlEje41LbOr3rMasGz;
            this.__slot_AfIhCtPJX1MPhmG7xjdlLD = other.__slot_AfIhCtPJX1MPhmG7xjdlLD;
            this.__slot_DUtIXItAzMJO5z9C3TriG8 = other.__slot_DUtIXItAzMJO5z9C3TriG8;
            this.__slot_Rc7GEvnIUG7L67J86Sel8b = other.__slot_Rc7GEvnIUG7L67J86Sel8b;
            this.__slot_SItRjklTI4cP8l7eFHQsJN = other.__slot_SItRjklTI4cP8l7eFHQsJN;
            this.__slot_AeHvatbwHnxMMUOkLSNOKi = other.__slot_AeHvatbwHnxMMUOkLSNOKi;
            this.__slot_NnFARYr2ZTGO5cNK0OZjwq = other.__slot_NnFARYr2ZTGO5cNK0OZjwq;
            this.__slot_MEFZpTXw22JQBUPk0MAaWB = other.__slot_MEFZpTXw22JQBUPk0MAaWB;
            this.__slot_OXPsYpTTTKTPqwR1MybGIu = other.__slot_OXPsYpTTTKTPqwR1MybGIu;
            this.__slot_CoHpyznE2zqQAk4TAiZp93 = other.__slot_CoHpyznE2zqQAk4TAiZp93;
            this.__slot_JGoDAuDsD0ON9saqDahNjd = other.__slot_JGoDAuDsD0ON9saqDahNjd;
            this.__pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ = other.__pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ;
            this.__pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK = other.__pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK;
            this.__p_Okczex40HF7K9wxXVw6urE = other.__p_Okczex40HF7K9wxXVw6urE;
            this.__p_EqEeqn1IqpHPIa2b9ZbKwg = other.__p_EqEeqn1IqpHPIa2b9ZbKwg;
            this.__p_ABIXTWWN7xBLHfo1zIdnmN = other.__p_ABIXTWWN7xBLHfo1zIdnmN;
            this.__p_VhCv0bEfJsZPCMp4HQJTPb = other.__p_VhCv0bEfJsZPCMp4HQJTPb;
            this.__p_Uuah89pZ0gWM8eaoTTMDF1 = other.__p_Uuah89pZ0gWM8eaoTTMDF1;
            this.__p_EgbYeCfEmTHPRuIyoWaUAN = other.__p_EgbYeCfEmTHPRuIyoWaUAN;
            this.__p_PICkNvHQBIILgiUEhwg7ow = other.__p_PICkNvHQBIILgiUEhwg7ow;
        }

        protected override n7.IVLObject __With__(n24.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__(n23.CompilationHelper.GetValueOrExisting(values, "__slot_VoFJU65zzZuLlBwvUQBzXi", in __slot_VoFJU65zzZuLlBwvUQBzXi), n23.CompilationHelper.GetValueOrExisting(values, "__slot_EjhCrOfnIvKLdI1IWsX4cD", in __slot_EjhCrOfnIvKLdI1IWsX4cD), n23.CompilationHelper.GetValueOrExisting(values, "__slot_AScWUoP5hbKPoLCEAqM8tO", in __slot_AScWUoP5hbKPoLCEAqM8tO), n23.CompilationHelper.GetValueOrExisting(values, "__slot_MMp4qlEje41LbOr3rMasGz", in __slot_MMp4qlEje41LbOr3rMasGz), n23.CompilationHelper.GetValueOrExisting(values, "__slot_AfIhCtPJX1MPhmG7xjdlLD", in __slot_AfIhCtPJX1MPhmG7xjdlLD), n23.CompilationHelper.GetValueOrExisting(values, "__slot_DUtIXItAzMJO5z9C3TriG8", in __slot_DUtIXItAzMJO5z9C3TriG8), n23.CompilationHelper.GetValueOrExisting(values, "__slot_Rc7GEvnIUG7L67J86Sel8b", in __slot_Rc7GEvnIUG7L67J86Sel8b), n23.CompilationHelper.GetValueOrExisting(values, "__slot_SItRjklTI4cP8l7eFHQsJN", in __slot_SItRjklTI4cP8l7eFHQsJN), n23.CompilationHelper.GetValueOrExisting(values, "__slot_AeHvatbwHnxMMUOkLSNOKi", in __slot_AeHvatbwHnxMMUOkLSNOKi), n23.CompilationHelper.GetValueOrExisting(values, "__slot_NnFARYr2ZTGO5cNK0OZjwq", in __slot_NnFARYr2ZTGO5cNK0OZjwq), n23.CompilationHelper.GetValueOrExisting(values, "__slot_MEFZpTXw22JQBUPk0MAaWB", in __slot_MEFZpTXw22JQBUPk0MAaWB), n23.CompilationHelper.GetValueOrExisting(values, "__slot_OXPsYpTTTKTPqwR1MybGIu", in __slot_OXPsYpTTTKTPqwR1MybGIu), n23.CompilationHelper.GetValueOrExisting(values, "__slot_CoHpyznE2zqQAk4TAiZp93", in __slot_CoHpyznE2zqQAk4TAiZp93), n23.CompilationHelper.GetValueOrExisting(values, "__slot_JGoDAuDsD0ON9saqDahNjd", in __slot_JGoDAuDsD0ON9saqDahNjd), n23.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ", in __pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ), n23.CompilationHelper.GetValueOrExisting(values, "__pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK", in __pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK), n23.CompilationHelper.GetValueOrExisting(values, "__p_Okczex40HF7K9wxXVw6urE", in __p_Okczex40HF7K9wxXVw6urE), n23.CompilationHelper.GetValueOrExisting(values, "__p_EqEeqn1IqpHPIa2b9ZbKwg", in __p_EqEeqn1IqpHPIa2b9ZbKwg), n23.CompilationHelper.GetValueOrExisting(values, "__p_ABIXTWWN7xBLHfo1zIdnmN", in __p_ABIXTWWN7xBLHfo1zIdnmN), n23.CompilationHelper.GetValueOrExisting(values, "__p_VhCv0bEfJsZPCMp4HQJTPb", in __p_VhCv0bEfJsZPCMp4HQJTPb), n23.CompilationHelper.GetValueOrExisting(values, "__p_Uuah89pZ0gWM8eaoTTMDF1", in __p_Uuah89pZ0gWM8eaoTTMDF1), n23.CompilationHelper.GetValueOrExisting(values, "__p_EgbYeCfEmTHPRuIyoWaUAN", in __p_EgbYeCfEmTHPRuIyoWaUAN), n23.CompilationHelper.GetValueOrExisting(values, "__p_PICkNvHQBIILgiUEhwg7ow", in __p_PICkNvHQBIILgiUEhwg7ow));
        }

        internal OSCContainer_HAqJBIV7zZxP3TIz3hDCiw __WITH__(bool __slot_VoFJU65zzZuLlBwvUQBzXi, n20.Spread<n20.Spread<string>> __slot_EjhCrOfnIvKLdI1IWsX4cD, bool __slot_AScWUoP5hbKPoLCEAqM8tO, bool __slot_MMp4qlEje41LbOr3rMasGz, n20.Spread<string> __slot_AfIhCtPJX1MPhmG7xjdlLD, n20.Spread<int> __slot_DUtIXItAzMJO5z9C3TriG8, int __slot_Rc7GEvnIUG7L67J86Sel8b, float __slot_SItRjklTI4cP8l7eFHQsJN, bool __slot_AeHvatbwHnxMMUOkLSNOKi, bool __slot_NnFARYr2ZTGO5cNK0OZjwq, float __slot_MEFZpTXw22JQBUPk0MAaWB, float __slot_OXPsYpTTTKTPqwR1MybGIu, bool __slot_CoHpyznE2zqQAk4TAiZp93, float __slot_JGoDAuDsD0ON9saqDahNjd, n20.Spread<string> __pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ, n20.Spread<int> __pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK, n25.OSCClient_C __p_Okczex40HF7K9wxXVw6urE, n25.OSCServer_IKIo4Vfhm7kNF6zaGENX9O __p_EqEeqn1IqpHPIa2b9ZbKwg, n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float> __p_ABIXTWWN7xBLHfo1zIdnmN, n25.OSCServer_IKIo4Vfhm7kNF6zaGENX9O __p_VhCv0bEfJsZPCMp4HQJTPb, n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float> __p_Uuah89pZ0gWM8eaoTTMDF1, n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float> __p_EgbYeCfEmTHPRuIyoWaUAN, n26.LFO_F48sA9CC7kzM1Y1LIpWRrD __p_PICkNvHQBIILgiUEhwg7ow)
        {
            n5.OSCContainer_HAqJBIV7zZxP3TIz3hDCiw that_0 = this;
            if (this.__GetContext__().IsImmutable)
                that_0 = __slot_VoFJU65zzZuLlBwvUQBzXi != this.__slot_VoFJU65zzZuLlBwvUQBzXi || !n24.EqualityComparer<n20.Spread<n20.Spread<string>>>.Default.Equals(__slot_EjhCrOfnIvKLdI1IWsX4cD, this.__slot_EjhCrOfnIvKLdI1IWsX4cD) || __slot_AScWUoP5hbKPoLCEAqM8tO != this.__slot_AScWUoP5hbKPoLCEAqM8tO || __slot_MMp4qlEje41LbOr3rMasGz != this.__slot_MMp4qlEje41LbOr3rMasGz || !n24.EqualityComparer<n20.Spread<string>>.Default.Equals(__slot_AfIhCtPJX1MPhmG7xjdlLD, this.__slot_AfIhCtPJX1MPhmG7xjdlLD) || !n24.EqualityComparer<n20.Spread<int>>.Default.Equals(__slot_DUtIXItAzMJO5z9C3TriG8, this.__slot_DUtIXItAzMJO5z9C3TriG8) || __slot_Rc7GEvnIUG7L67J86Sel8b != this.__slot_Rc7GEvnIUG7L67J86Sel8b || __slot_SItRjklTI4cP8l7eFHQsJN != this.__slot_SItRjklTI4cP8l7eFHQsJN || __slot_AeHvatbwHnxMMUOkLSNOKi != this.__slot_AeHvatbwHnxMMUOkLSNOKi || __slot_NnFARYr2ZTGO5cNK0OZjwq != this.__slot_NnFARYr2ZTGO5cNK0OZjwq || __slot_MEFZpTXw22JQBUPk0MAaWB != this.__slot_MEFZpTXw22JQBUPk0MAaWB || __slot_OXPsYpTTTKTPqwR1MybGIu != this.__slot_OXPsYpTTTKTPqwR1MybGIu || __slot_CoHpyznE2zqQAk4TAiZp93 != this.__slot_CoHpyznE2zqQAk4TAiZp93 || __slot_JGoDAuDsD0ON9saqDahNjd != this.__slot_JGoDAuDsD0ON9saqDahNjd || !n24.EqualityComparer<n20.Spread<string>>.Default.Equals(__pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ, this.__pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ) || !n24.EqualityComparer<n20.Spread<int>>.Default.Equals(__pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK, this.__pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK) || !n24.EqualityComparer<n25.OSCClient_C>.Default.Equals(__p_Okczex40HF7K9wxXVw6urE, this.__p_Okczex40HF7K9wxXVw6urE) || !n24.EqualityComparer<n25.OSCServer_IKIo4Vfhm7kNF6zaGENX9O>.Default.Equals(__p_EqEeqn1IqpHPIa2b9ZbKwg, this.__p_EqEeqn1IqpHPIa2b9ZbKwg) || !n24.EqualityComparer<n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>>.Default.Equals(__p_ABIXTWWN7xBLHfo1zIdnmN, this.__p_ABIXTWWN7xBLHfo1zIdnmN) || !n24.EqualityComparer<n25.OSCServer_IKIo4Vfhm7kNF6zaGENX9O>.Default.Equals(__p_VhCv0bEfJsZPCMp4HQJTPb, this.__p_VhCv0bEfJsZPCMp4HQJTPb) || !n24.EqualityComparer<n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>>.Default.Equals(__p_Uuah89pZ0gWM8eaoTTMDF1, this.__p_Uuah89pZ0gWM8eaoTTMDF1) || !n24.EqualityComparer<n25.OSCReceiver_SfJDk17Od8wMmTO3AiRe99<float>>.Default.Equals(__p_EgbYeCfEmTHPRuIyoWaUAN, this.__p_EgbYeCfEmTHPRuIyoWaUAN) || !n24.EqualityComparer<n26.LFO_F48sA9CC7kzM1Y1LIpWRrD>.Default.Equals(__p_PICkNvHQBIILgiUEhwg7ow, this.__p_PICkNvHQBIILgiUEhwg7ow) ? new n5.OSCContainer_HAqJBIV7zZxP3TIz3hDCiw(this)
                {__slot_VoFJU65zzZuLlBwvUQBzXi = __slot_VoFJU65zzZuLlBwvUQBzXi, __slot_EjhCrOfnIvKLdI1IWsX4cD = __slot_EjhCrOfnIvKLdI1IWsX4cD, __slot_AScWUoP5hbKPoLCEAqM8tO = __slot_AScWUoP5hbKPoLCEAqM8tO, __slot_MMp4qlEje41LbOr3rMasGz = __slot_MMp4qlEje41LbOr3rMasGz, __slot_AfIhCtPJX1MPhmG7xjdlLD = __slot_AfIhCtPJX1MPhmG7xjdlLD, __slot_DUtIXItAzMJO5z9C3TriG8 = __slot_DUtIXItAzMJO5z9C3TriG8, __slot_Rc7GEvnIUG7L67J86Sel8b = __slot_Rc7GEvnIUG7L67J86Sel8b, __slot_SItRjklTI4cP8l7eFHQsJN = __slot_SItRjklTI4cP8l7eFHQsJN, __slot_AeHvatbwHnxMMUOkLSNOKi = __slot_AeHvatbwHnxMMUOkLSNOKi, __slot_NnFARYr2ZTGO5cNK0OZjwq = __slot_NnFARYr2ZTGO5cNK0OZjwq, __slot_MEFZpTXw22JQBUPk0MAaWB = __slot_MEFZpTXw22JQBUPk0MAaWB, __slot_OXPsYpTTTKTPqwR1MybGIu = __slot_OXPsYpTTTKTPqwR1MybGIu, __slot_CoHpyznE2zqQAk4TAiZp93 = __slot_CoHpyznE2zqQAk4TAiZp93, __slot_JGoDAuDsD0ON9saqDahNjd = __slot_JGoDAuDsD0ON9saqDahNjd, __pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ = __pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ, __pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK = __pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK, __p_Okczex40HF7K9wxXVw6urE = __p_Okczex40HF7K9wxXVw6urE, __p_EqEeqn1IqpHPIa2b9ZbKwg = __p_EqEeqn1IqpHPIa2b9ZbKwg, __p_ABIXTWWN7xBLHfo1zIdnmN = __p_ABIXTWWN7xBLHfo1zIdnmN, __p_VhCv0bEfJsZPCMp4HQJTPb = __p_VhCv0bEfJsZPCMp4HQJTPb, __p_Uuah89pZ0gWM8eaoTTMDF1 = __p_Uuah89pZ0gWM8eaoTTMDF1, __p_EgbYeCfEmTHPRuIyoWaUAN = __p_EgbYeCfEmTHPRuIyoWaUAN, __p_PICkNvHQBIILgiUEhwg7ow = __p_PICkNvHQBIILgiUEhwg7ow} : that_0;
            else
            {
                this.__slot_VoFJU65zzZuLlBwvUQBzXi = __slot_VoFJU65zzZuLlBwvUQBzXi;
                this.__slot_EjhCrOfnIvKLdI1IWsX4cD = __slot_EjhCrOfnIvKLdI1IWsX4cD;
                this.__slot_AScWUoP5hbKPoLCEAqM8tO = __slot_AScWUoP5hbKPoLCEAqM8tO;
                this.__slot_MMp4qlEje41LbOr3rMasGz = __slot_MMp4qlEje41LbOr3rMasGz;
                this.__slot_AfIhCtPJX1MPhmG7xjdlLD = __slot_AfIhCtPJX1MPhmG7xjdlLD;
                this.__slot_DUtIXItAzMJO5z9C3TriG8 = __slot_DUtIXItAzMJO5z9C3TriG8;
                this.__slot_Rc7GEvnIUG7L67J86Sel8b = __slot_Rc7GEvnIUG7L67J86Sel8b;
                this.__slot_SItRjklTI4cP8l7eFHQsJN = __slot_SItRjklTI4cP8l7eFHQsJN;
                this.__slot_AeHvatbwHnxMMUOkLSNOKi = __slot_AeHvatbwHnxMMUOkLSNOKi;
                this.__slot_NnFARYr2ZTGO5cNK0OZjwq = __slot_NnFARYr2ZTGO5cNK0OZjwq;
                this.__slot_MEFZpTXw22JQBUPk0MAaWB = __slot_MEFZpTXw22JQBUPk0MAaWB;
                this.__slot_OXPsYpTTTKTPqwR1MybGIu = __slot_OXPsYpTTTKTPqwR1MybGIu;
                this.__slot_CoHpyznE2zqQAk4TAiZp93 = __slot_CoHpyznE2zqQAk4TAiZp93;
                this.__slot_JGoDAuDsD0ON9saqDahNjd = __slot_JGoDAuDsD0ON9saqDahNjd;
                this.__pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ = __pin_group_Input_In_PM6x6ZFno4eLRnAT4W4ZyZ;
                this.__pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK = __pin_group_Input_In_IGMACj1SGV6LosYN8tXQnK;
                this.__p_Okczex40HF7K9wxXVw6urE = __p_Okczex40HF7K9wxXVw6urE;
                this.__p_EqEeqn1IqpHPIa2b9ZbKwg = __p_EqEeqn1IqpHPIa2b9ZbKwg;
                this.__p_ABIXTWWN7xBLHfo1zIdnmN = __p_ABIXTWWN7xBLHfo1zIdnmN;
                this.__p_VhCv0bEfJsZPCMp4HQJTPb = __p_VhCv0bEfJsZPCMp4HQJTPb;
                this.__p_Uuah89pZ0gWM8eaoTTMDF1 = __p_Uuah89pZ0gWM8eaoTTMDF1;
                this.__p_EgbYeCfEmTHPRuIyoWaUAN = __p_EgbYeCfEmTHPRuIyoWaUAN;
                this.__p_PICkNvHQBIILgiUEhwg7ow = __p_PICkNvHQBIILgiUEhwg7ow;
            }

            return that_0;
        }
    }

    [n1.ElementAttribute(TracingId = 8054U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "LiviZnNQlUkPYNSURjpf0v", Name = "MaxMin")]
    [n2.SerializableAttribute]
    [n3.NameAttribute("MaxMin")]
    [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
    public sealed class MaxMin_LiviZnNQlUkPYNSURjpf0v : n4.PatchedObject, n2.IDisposable
    {
        [return: n3.PinAttribute("Output", isState: true)]
        [n8.CreateNewAttribute]
        [n1.ElementAttribute(DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "TiVFBdu7boKL03dHRvXgnx", Name = "Create")]
        [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
        public static n5.MaxMin_LiviZnNQlUkPYNSURjpf0v Create([n3.PinAttribute("Node Context", visibility: n6.PinVisibility.Hidden)] n7.NodeContext Node_Context)
        {
            var instance = new MaxMin_LiviZnNQlUkPYNSURjpf0v(Node_Context, n4.PatchedObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [return: n3.PinAttribute("Output", isState: true)]
        [n8.CreateDefaultAttribute]
        [n1.ElementAttribute(Name = "CreateDefault")]
        [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
        public static n5.MaxMin_LiviZnNQlUkPYNSURjpf0v CreateDefault()
        {
            var instance = new MaxMin_LiviZnNQlUkPYNSURjpf0v(n7.NodeContext.Default, n4.PatchedObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        [return: n3.PinAttribute("Output", isState: true)]
        [n1.ElementAttribute(DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "MfLso8bUFnuN68Wq7TKmbv", Name = "Update")]
        [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
        public n5.MaxMin_LiviZnNQlUkPYNSURjpf0v Update([n3.PinAttribute("ClientInput")] n25.OSCClient_C ClientInput_In, [n3.PinAttribute("SpreadInput")] n20.Spread<float> SpreadInput_In, [n3.PinAttribute("AddressSuffix")] string AddressSuffix_In, [n1.SerializedDefaultValueAttribute("True", false)][n3.PinAttribute("Enable")] bool Enable_In, [n3.PinAttribute("ClientOutput")] out n25.OSCClient_C ClientOutput_Out, [n3.PinAttribute("Result")] out float Result_Out)
        {
            var __nodeContext = __GetContext__();
            string __pad_KUDoBscO3FfQHs7h8g91Ba_0 = __slot_KUDoBscO3FfQHs7h8g91Ba;
            n9._Operations_.OperatorPlus(Input_In: __pad_KUDoBscO3FfQHs7h8g91Ba_0, Input_2_In: AddressSuffix_In, Output_Out: out string Output_1);
            n30._Operations_.Min<n20.Spread<float>, float, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Input_In: SpreadInput_In, Result_Out: out float Result_2);
            n30._Operations_.Max<n20.Spread<float>, float, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Input_In: SpreadInput_In, Result_Out: out float Result_3);
            n15._Operations_.Distance<float, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Input_In: Result_2, Input_2_In: Result_3, Result_Out: out float Result_4);
            bool Bundled_Per_Frame_5 = true;
            var Output_6 = ClientInput_In.SendMessage<float, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Address_In: Output_1, Arguments_In: Result_4, Bundled_Per_Frame_In: Bundled_Per_Frame_5, Apply_In: Enable_In);
            ClientOutput_Out = Output_6;
            Result_Out = Result_4;
            return this;
        }

        [return: n3.PinAttribute("Output", isState: true)]
        [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
        public n5.MaxMin_LiviZnNQlUkPYNSURjpf0v __Create__([n3.PinAttribute("Node Context", visibility: n6.PinVisibility.Hidden)] n7.NodeContext Node_Context)
        {
            n27.RuntimeHelpers.EnsureSufficientExecutionStack();
            var __nodeContext = Node_Context;
            return this;
        }

        [return: n3.PinAttribute("Output", isState: true)]
        [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
        public n5.MaxMin_LiviZnNQlUkPYNSURjpf0v __CreateDefault__()
        {
            var __nodeContext = n7.NodeContext.Default;
            return this;
        }

        public void Dispose()
        {
            var __nodeContext = __GetContext__();
            return;
        }

        [n1.ElementAttribute(TracingId = 8078U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "KUDoBscO3FfQHs7h8g91Ba", Name = "__slot_KUDoBscO3FfQHs7h8g91Ba")]
        public static string __slot_KUDoBscO3FfQHs7h8g91Ba = "/MaxDist";
        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        public MaxMin_LiviZnNQlUkPYNSURjpf0v() : base()
        {
        }

        public MaxMin_LiviZnNQlUkPYNSURjpf0v(n7.NodeContext context, uint identity) : base(context, identity)
        {
        }

        public MaxMin_LiviZnNQlUkPYNSURjpf0v(MaxMin_LiviZnNQlUkPYNSURjpf0v other) : base(other)
        {
        }

        protected override n7.IVLObject __With__(n24.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal MaxMin_LiviZnNQlUkPYNSURjpf0v __WITH__()
        {
            return this;
        }
    }
}

namespace _TSOSCContainer06022024CELIA_.__auto
{
    [n1.ElementAttribute(TracingId = 8114U, DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "PWFUi8qwqScPkky6ft9xr8", Name = "TSOSCContainer06022024CELIAApplication")]
    [n2.SerializableAttribute]
    [n3.NameAttribute("TSOSCContainer06022024CELIAApplication")]
    [n3.CategoryAttribute("Main")]
    [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
    public sealed class TSOSCContainer06022024CELIAApplication_PWFUi8qwqScPkky6ft9xr8 : n4.PatchedObject, n2.IDisposable
    {
        [return: n3.PinAttribute("Output", isState: true)]
        [n8.CreateNewAttribute]
        [n1.ElementAttribute(DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "Bg3MROwz3KQMW7aVFwWGd1", Name = "Create")]
        [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
        public static n31.TSOSCContainer06022024CELIAApplication_PWFUi8qwqScPkky6ft9xr8 Create([n3.PinAttribute("Node Context", visibility: n6.PinVisibility.Hidden)] n7.NodeContext Node_Context)
        {
            var instance = new TSOSCContainer06022024CELIAApplication_PWFUi8qwqScPkky6ft9xr8(Node_Context, n4.PatchedObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }

        [return: n3.PinAttribute("Output", isState: true)]
        [n8.CreateDefaultAttribute]
        [n1.ElementAttribute(Name = "CreateDefault")]
        [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
        public static n31.TSOSCContainer06022024CELIAApplication_PWFUi8qwqScPkky6ft9xr8 CreateDefault()
        {
            var instance = new TSOSCContainer06022024CELIAApplication_PWFUi8qwqScPkky6ft9xr8(n7.NodeContext.Default, n4.PatchedObject.NewIdentity());
            return instance.__CreateDefault__();
        }

        [return: n3.PinAttribute("Output", isState: true)]
        [n1.ElementAttribute(DocumentId = "RoWK1pOK0gPLwpiC9YkoXc", PersistentId = "SHay7uKzUtCMud4i5uTEHm", Name = "Update")]
        [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
        public n31.TSOSCContainer06022024CELIAApplication_PWFUi8qwqScPkky6ft9xr8 Update()
        {
            var __nodeContext = __GetContext__();
            return this;
        }

        [return: n3.PinAttribute("Output", isState: true)]
        [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
        public n31.TSOSCContainer06022024CELIAApplication_PWFUi8qwqScPkky6ft9xr8 __Create__([n3.PinAttribute("Node Context", visibility: n6.PinVisibility.Hidden)] n7.NodeContext Node_Context)
        {
            n27.RuntimeHelpers.EnsureSufficientExecutionStack();
            var __nodeContext = Node_Context;
            return this;
        }

        [return: n3.PinAttribute("Output", isState: true)]
        [n3.SmellAttribute(n4.SymbolSmell.Default | n4.SymbolSmell.Hidden)]
        public n31.TSOSCContainer06022024CELIAApplication_PWFUi8qwqScPkky6ft9xr8 __CreateDefault__()
        {
            var __nodeContext = n7.NodeContext.Default;
            return this;
        }

        public void Dispose()
        {
            var __nodeContext = __GetContext__();
            return;
        }

        void n2.IDisposable.Dispose()
        {
            using var __current_services = __GetServiceRegistry__().MakeCurrentIfNone();
            Dispose();
        }

        public TSOSCContainer06022024CELIAApplication_PWFUi8qwqScPkky6ft9xr8() : base()
        {
        }

        public TSOSCContainer06022024CELIAApplication_PWFUi8qwqScPkky6ft9xr8(n7.NodeContext context, uint identity) : base(context, identity)
        {
        }

        public TSOSCContainer06022024CELIAApplication_PWFUi8qwqScPkky6ft9xr8(TSOSCContainer06022024CELIAApplication_PWFUi8qwqScPkky6ft9xr8 other) : base(other)
        {
        }

        protected override n7.IVLObject __With__(n24.IReadOnlyDictionary<string, n2.Object> values)
        {
            return __WITH__();
        }

        internal TSOSCContainer06022024CELIAApplication_PWFUi8qwqScPkky6ft9xr8 __WITH__()
        {
            return this;
        }
    }
}

namespace _TSOSCContainer06022024CELIA_
{
    public struct __AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc : n32.IAdaptiveCreateDefault<float>, n25.IAdaptiveDataToArgs<float>, n33.IAdaptiveOperatorMinus<n13.Vector3>, n33.IAdaptiveLength<n13.Vector3>, n25.IAdaptiveArgsToData<float>, n33.IAdaptiveOperatorMinus<float>, n33.IAdaptiveLength<float>, n33.IAdaptiveOperatorMultiply_Scale<float>, n33.IAdaptiveAvoidNaN<float>, n33.IAdaptiveIsNaN<float>, n33.IAdaptiveNE<float>, n33.IAdaptiveOperatorPlus<float>, n33.IAdaptiveSin<float>, n33.IAdaptiveCos<float>, n33.IAdaptiveOperatorDivide_Scale<float>, n34.IAdaptiveToFloat32<float>, n34.IAdaptiveToFloat64<float>, n33.IAdaptiveOperatorMinus_Negate<float>, n33.IAdaptiveMax<float>, n33.IAdaptiveOperatorGreater<float>, n33.IAdaptiveMin<float>, n33.IAdaptiveOperatorLess<float>, n25.IAdaptiveArgsToData<int>
    {
        public void CreateDefault(out float Output_Out)
        {
            n32._Operations_.CreateDefault_Generic<float>(Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void DataToArgs(string TypeTags_In, n20.Spread<byte> Data_In, int TypeTag_Index_In, int Byte_Index_In, out float Args_Out, out int Next_TypeTag_Index_Out, out int Next_Byte_Index_Out)
        {
            n25._Operations_.DataToArgs(Data_In: Data_In, Byte_Index_In: Byte_Index_In, TypeTags_In: TypeTags_In, TypeTag_Index_In: TypeTag_Index_In, Args_Out: out float Args_0, Next_Byte_Index_Out: out int Next_Byte_Index_1, Next_TypeTag_Index_Out: out int Next_TypeTag_Index_2);
            Args_Out = Args_0;
            Next_TypeTag_Index_Out = Next_TypeTag_Index_2;
            Next_Byte_Index_Out = Next_Byte_Index_1;
            return;
        }

        public void OperatorMinus(n13.Vector3 Input_In, n13.Vector3 Input_2_In, out n13.Vector3 Output_Out)
        {
            n14._Operations_.OperatorMinus(Input_In: Input_In, Input_2_In: Input_2_In, Output_Out: out n13.Vector3 Output_0);
            Output_Out = Output_0;
            return;
        }

        public void Length(n13.Vector3 Input_In, out float Result_Out)
        {
            n14._Operations_.Length(Input_In: Input_In, Result_Out: out float Result_0);
            Result_Out = Result_0;
            return;
        }

        public void ArgsToData(n25.SerializationContext_C Context_In, float Args_In, out n25.SerializationContext_C Context_Out)
        {
            n25._Operations_.ArgsToData(Context_In: Context_In, Args_In: Args_In, Context_Out: out n25.SerializationContext_C Context_0);
            Context_Out = Context_0;
            return;
        }

        public void OperatorMinus(float Input_In, float Input_2_In, out float Output_Out)
        {
            n12._Operations_.OperatorMinus(Input_In: Input_In, Input_2_In: Input_2_In, Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void Length(float Input_In, out float Result_Out)
        {
            n12._Operations_.Length(Input_In: Input_In, Result_Out: out float Result_0);
            Result_Out = Result_0;
            return;
        }

        public void OperatorMultiply_Scale(float Input_In, float Scalar_In, out float Output_Out)
        {
            n12._Operations_.OperatorMultiply_Scale(Input_In: Input_In, Scalar_In: Scalar_In, Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void AvoidNaN(float Input_In, float Default_In, out float Output_Out)
        {
            n15._Operations_.AvoidNaN<float, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Input_In: Input_In, Default_In: Default_In, Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void IsNaN(float Input_In, out bool Result_Out)
        {
            n15._Operations_.IsNaN<float, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Input_In: Input_In, Result_Out: out bool Result_0);
            Result_Out = Result_0;
            return;
        }

        public void NE(float Input_In, float Input_2_In, out bool Result_Out)
        {
            n12._Operations_.NE(Input_In: Input_In, Input_2_In: Input_2_In, Result_Out: out bool Result_0);
            Result_Out = Result_0;
            return;
        }

        public void OperatorPlus(float Input_In, float Input_2_In, out float Output_Out)
        {
            n12._Operations_.OperatorPlus(Input_In: Input_In, Input_2_In: Input_2_In, Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void Sin(float Input_In, out float Output_Out)
        {
            n12._Operations_.Sin(Input_In: Input_In, Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void Cos(float Input_In, out float Output_Out)
        {
            n12._Operations_.Cos(Input_In: Input_In, Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorDivide_Scale(float Input_In, float Scalar_In, out float Output_Out)
        {
            n12._Operations_.OperatorDivide_Scale(Input_In: Input_In, Scalar_In: Scalar_In, Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void ToFloat32(float Input_In, out float Result_Out)
        {
            n12._Operations_.ToFloat32(Input_In: Input_In, Result_Out: out float Result_0);
            Result_Out = Result_0;
            return;
        }

        public void ToFloat64(float Input_In, out double Result_Out)
        {
            n12._Operations_.ToFloat64(Input_In: Input_In, Result_Out: out double Result_0);
            Result_Out = Result_0;
            return;
        }

        public void OperatorMinus_Negate(float Input_In, out float Output_Out)
        {
            n12._Operations_.OperatorMinus_Negate(Input_In: Input_In, Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void Max(float Input_In, float Input_2_In, out float Output_Out)
        {
            n16._Operations_.Max<float, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Input_In: Input_In, Input_2_In: Input_2_In, Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorGreater(float Input_In, float Input_2_In, out bool Result_Out)
        {
            n12._Operations_.OperatorGreater(Input_In: Input_In, Input_2_In: Input_2_In, Result_Out: out bool Result_0);
            Result_Out = Result_0;
            return;
        }

        public void Min(float Input_In, float Input_2_In, out float Output_Out)
        {
            n16._Operations_.Min<float, n10.__AdaptiveImplementations__RoWK1pOK0gPLwpiC9YkoXc>(Input_In: Input_In, Input_2_In: Input_2_In, Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }

        public void OperatorLess(float Input_In, float Input_2_In, out bool Result_Out)
        {
            n12._Operations_.OperatorLess(Input_In: Input_In, Input_2_In: Input_2_In, Result_Out: out bool Result_0);
            Result_Out = Result_0;
            return;
        }

        public void ArgsToData(n25.SerializationContext_C Context_In, int Args_In, out n25.SerializationContext_C Context_Out)
        {
            n25._Operations_.ArgsToData(Context_In: Context_In, Args_In: Args_In, Context_Out: out n25.SerializationContext_C Context_0);
            Context_Out = Context_0;
            return;
        }
    }
}