//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 436
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QuantumRNG\",\"Name\":\"GenerateRandomBit\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\Priyanshu Kumar\\\\Documents\\\\QuantumRNG\\\\Program.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Result\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QuantumRNG\",\"Name\":\"GenerateRandomBit\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\Priyanshu Kumar\\\\Documents\\\\QuantumRNG\\\\Program.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QuantumRNG\",\"Name\":\"SampleRandomGenInRange\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\Priyanshu Kumar\\\\Documents\\\\QuantumRNG\\\\Program.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"min\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"max\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":49}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QuantumRNG\",\"Name\":\"SampleRandomGenInRange\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\Priyanshu Kumar\\\\Documents\\\\QuantumRNG\\\\Program.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QuantumRNG\",\"Name\":\"SampleRNGCaller\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Core\",\"Name\":\"EntryPoint\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]}}]},\"Argument\":{\"Item1\":{\"Case\":\"UnitValue\"},\"Item2\":[],\"Item3\":{\"Case\":\"UnitType\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":12},\"Item2\":{\"Line\":1,\"Column\":14}}]}},\"Offset\":{\"Item1\":28,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\Priyanshu Kumar\\\\Documents\\\\QuantumRNG\\\\Program.qs\",\"Position\":{\"Item1\":29,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QuantumRNG\",\"Name\":\"SampleRNGCaller\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\Priyanshu Kumar\\\\Documents\\\\QuantumRNG\\\\Program.qs\",\"Position\":{\"Item1\":29,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
#line hidden
namespace QuantumRNG
{
    [SourceLocation("C:\\Users\\Priyanshu Kumar\\Documents\\QuantumRNG\\Program.qs", OperationFunctor.Body, 9, 16)]
    public partial class GenerateRandomBit : Operation<QVoid, Result>, ICallable
    {
        public GenerateRandomBit(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GenerateRandomBit";
        String ICallable.FullName => "QuantumRNG.GenerateRandomBit";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumMeasurementMResetZ
        {
            get;
            set;
        }

        public override Func<QVoid, Result> Body => (__in__) =>
        {
#line hidden
            {
#line 10 "C:\\Users\\Priyanshu Kumar\\Documents\\QuantumRNG\\Program.qs"
                var q = Allocate.Apply();
#line hidden
                bool __arg1__ = true;
                try
                {
#line 11 "C:\\Users\\Priyanshu Kumar\\Documents\\QuantumRNG\\Program.qs"
                    MicrosoftQuantumIntrinsicH.Apply(q);
#line 12 "C:\\Users\\Priyanshu Kumar\\Documents\\QuantumRNG\\Program.qs"
                    return MicrosoftQuantumMeasurementMResetZ.Apply(q);
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release.Apply(q);
                    }
                }
            }
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumMeasurementMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Measurement.MResetZ));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__)
        {
            return __m__.Run<GenerateRandomBit, QVoid, Result>(QVoid.Instance);
        }
    }

    [SourceLocation("C:\\Users\\Priyanshu Kumar\\Documents\\QuantumRNG\\Program.qs", OperationFunctor.Body, 16, 30)]
    public partial class SampleRandomGenInRange : Operation<(Int64,Int64), Int64>, ICallable
    {
        public SampleRandomGenInRange(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "SampleRandomGenInRange";
        String ICallable.FullName => "QuantumRNG.SampleRandomGenInRange";
        protected ICallable<Int64, Int64> MicrosoftQuantumMathBitSizeI
        {
            get;
            set;
        }

        protected ICallable<QVoid, Result> GenerateRandomBit
        {
            get;
            set;
        }

        protected ICallable<IQArray<Result>, Int64> MicrosoftQuantumConvertResultArrayAsInt
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), Int64> Body => (__in__) =>
        {
            var (min,max) = __in__;
#line 18 "C:\\Users\\Priyanshu Kumar\\Documents\\QuantumRNG\\Program.qs"
            var output = 0L;
#line 19 "C:\\Users\\Priyanshu Kumar\\Documents\\QuantumRNG\\Program.qs"
            while (true)
            {
#line 20 "C:\\Users\\Priyanshu Kumar\\Documents\\QuantumRNG\\Program.qs"
                var bits = QArray<Result>.Create(0L);
#line 21 "C:\\Users\\Priyanshu Kumar\\Documents\\QuantumRNG\\Program.qs"
                foreach (var idxBit in new QRange(MicrosoftQuantumMathBitSizeI.Apply(min), MicrosoftQuantumMathBitSizeI.Apply(max)))
#line hidden
                {
#line 22 "C:\\Users\\Priyanshu Kumar\\Documents\\QuantumRNG\\Program.qs"
                    bits = QArray<Result>.Add(bits, new QArray<Result>(GenerateRandomBit.Apply(QVoid.Instance)));
                }

#line 24 "C:\\Users\\Priyanshu Kumar\\Documents\\QuantumRNG\\Program.qs"
                output = MicrosoftQuantumConvertResultArrayAsInt.Apply(bits?.Copy());
                if (((output > min) && (output <= max)))
                {
                    break;
                }
                else
                {
                }
            }

#line 26 "C:\\Users\\Priyanshu Kumar\\Documents\\QuantumRNG\\Program.qs"
            return output;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumMathBitSizeI = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.BitSizeI));
            this.GenerateRandomBit = this.Factory.Get<ICallable<QVoid, Result>>(typeof(GenerateRandomBit));
            this.MicrosoftQuantumConvertResultArrayAsInt = this.Factory.Get<ICallable<IQArray<Result>, Int64>>(typeof(Microsoft.Quantum.Convert.ResultArrayAsInt));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 min, Int64 max)
        {
            return __m__.Run<SampleRandomGenInRange, (Int64,Int64), Int64>((min, max));
        }
    }

    [SourceLocation("C:\\Users\\Priyanshu Kumar\\Documents\\QuantumRNG\\Program.qs", OperationFunctor.Body, 30, -1)]
    public partial class SampleRNGCaller : Operation<QVoid, Int64>, ICallable
    {
        public SampleRNGCaller(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SampleRNGCaller";
        String ICallable.FullName => "QuantumRNG.SampleRNGCaller";
        public static EntryPointInfo<QVoid, Int64> Info => new EntryPointInfo<QVoid, Int64>(typeof(SampleRNGCaller));
        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), Int64> SampleRandomGenInRange
        {
            get;
            set;
        }

        public override Func<QVoid, Int64> Body => (__in__) =>
        {
#line 32 "C:\\Users\\Priyanshu Kumar\\Documents\\QuantumRNG\\Program.qs"
            var max = 65537L;
#line 33 "C:\\Users\\Priyanshu Kumar\\Documents\\QuantumRNG\\Program.qs"
            var min = 5L;
#line 34 "C:\\Users\\Priyanshu Kumar\\Documents\\QuantumRNG\\Program.qs"
            Message.Apply(String.Format("Sampleing a Random Number generator using Quantum between {0} to {1} : ", min, max));
#line 35 "C:\\Users\\Priyanshu Kumar\\Documents\\QuantumRNG\\Program.qs"
            return SampleRandomGenInRange.Apply((min, max));
        }

        ;
        public override void Init()
        {
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Message));
            this.SampleRandomGenInRange = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(SampleRandomGenInRange));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__)
        {
            return __m__.Run<SampleRNGCaller, QVoid, Int64>(QVoid.Instance);
        }
    }
}