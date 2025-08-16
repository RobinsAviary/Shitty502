using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shitty502
{
    internal static class Opcodes
    {
        public static KeyValuePair<string,string>[] opcodes = {
            new("SetA", "LDA"),
            new("SetX", "LDX"),
            new("SetY", "LDY"),
            new("StoreA", "STA"),
            new("StoreX", "STX"),
            new("StoreY", "STY"),
            new("TransferAX", "TAX"),
            new("TransferAY", "TAY"),
            new("TransferSX", "TSX"),
            new("TransferXA", "TXA"),
            new("TransferXS", "TXS"),
            new("TransferYA", "TYA"),
            new("Dec", "DEC"),
            new("Inc", "INC"),
            new("IncX", "INX"),
            new("IncY", "INY"),
            new("DecX", "DEX"),
            new("DecY", "DEY"),
            new("Add", "ADC"),
            new("Sub", "SBC"),
            new("And", "AND"),
            new("Eor", "EOR"),
            new("Or", "ORA"),
            new("ShiftLeft", "ASL"),
            new("ShiftRight", "LSR"),
            new("RotateLeft", "ROL"),
            new("RotateRight", "ROR"),
            new("ClearCarry", "CLC"),
            new("DisableDecimal", "CLD"),
            new("EnableInterrupts", "CLI"),
            new("ClearOverflow", "CLV"),
            new("SetCarry", "SEC"),
            new("EnableDecimal", "SED"),
            new("DisableInterrupts", "SEI"),
            new("CompareA", "CMP"),
            new("CompareX", "CPX"),
            new("CompareY", "CPY"),
            new("BranchNotCarry", "BCC"),
            new("BranchCarry", "BCS"),
            new("BranchEqual", "BEQ"),
            new("BranchNotEqual", "BNE"),
            new("BranchPositive", "BPL"),
            new("BranchNegative", "BMI"),
            new("BranchOverflow", "BVS"),
            new("BranchNotOverflow", "BVC"),
            new("Jump", "JMP"),
            new("JumpSub", "JSR"),
            new("ReturnSub", "RTS"),
            new("Break", "BRK"),
            new("ReturnInterrupt", "RTI"),
            new("Bittest", "BIT"),
            new("Nope", "NOP"),
            new("PushA", "PHA"),
            new("PushPPR", "PHP"),
            new("PullA", "PLA"),
            new("PullPPR", "PLP"),
        };
    }
    
}
