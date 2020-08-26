namespace QuantumRNG {
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Measurement;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Convert;
    

    operation GenerateRandomBit() : Result {
        using (q = Qubit()){
            H(q); //initally q is put into 0 state this will make simulation run
            return MResetZ(q);
        }
    }

    operation SampleRandomGenInRange(min : Int , max : Int) : Int
    {
        mutable output = 0;
        repeat{
            mutable bits = new Result[0];
            for (idxBit in BitSizeI(min)..BitSizeI(max)){
                set bits += [GenerateRandomBit()];
            }
            set output = ResultArrayAsInt(bits);
        } until (output > min and output <= max);
        return output;    
    }

    @EntryPoint()
    operation SampleRNGCaller() : Int
    {
        let max = 0x10001;
        let min = 5;
        Message($"Sampleing a Random Number generator using Quantum between {min} to {max} : ");
        return SampleRandomGenInRange(min,max);
    }
}