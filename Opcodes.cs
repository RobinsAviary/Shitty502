using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shitty502
{
    internal class Opcodes
    {
        public Dictionary<string, string> opcodes = [];

        public Opcodes()
        {
            opcodes.Add("SetA", "LDA");
            opcodes.Add("SetX", "LDX");
            opcodes.Add("SetY", "LDY");
            opcodes.Add("StoreA", "STA");
            opcodes.Add("StoreX", "STX");
            opcodes.Add("StoreY", "STY");
            opcodes.Add("TransferAX", "TAX");
            opcodes.Add("TransferAY", "TAY");
            opcodes.Add("TransferSX", "TSX");
            opcodes.Add("TransferXA", "TXA");
            opcodes.Add("TransferXS", "TXS");
            opcodes.Add("TransferYA", "TYA");
            opcodes.Add("Dec", "DEC");
            opcodes.Add("Inc", "INC");
            opcodes.Add("IncX", "INX");
            opcodes.Add("IncY", "INY");
            opcodes.Add("DecX", "DEX");
            opcodes.Add("DecY", "DEY");
            opcodes.Add("Add", "ADC");
            opcodes.Add("Sub", "SBC");
            opcodes.Add("And", "AND");
            opcodes.Add("Eor", "EOR");
            opcodes.Add("Or", "ORA");
            opcodes.Add("ShiftLeft", "ASL");
            opcodes.Add("ShiftRight", "LSR");
            opcodes.Add("RotateLeft", "ROL");
            opcodes.Add("RotateRight", "ROR");
            opcodes.Add("ClearCarry", "CLC");
            opcodes.Add("DisableDecimal", "CLD");
            opcodes.Add("EnableInterrupts", "CLI");
            opcodes.Add("ClearOverflow", "CLV");
            opcodes.Add("SetCarry", "SEC");
            opcodes.Add("EnableDecimal", "SED");
            opcodes.Add("DisableInterrupts", "SEI");
            opcodes.Add("CompareA", "CMP");
            opcodes.Add("CompareX", "CPX");
            opcodes.Add("CompareY", "CPY");
            opcodes.Add("BranchNotCarry", "BCC");
            opcodes.Add("BranchCarry", "BCS");
            opcodes.Add("BranchEqual", "BEQ");
            opcodes.Add("BranchNotEqual", "BNE");
            opcodes.Add("BranchPositive", "BPL");
            opcodes.Add("BranchNegative", "BMI");
            opcodes.Add("BranchOverflow", "BVS");
            opcodes.Add("BranchNotOverflow", "BVC");
            opcodes.Add("Jump", "JMP");
            opcodes.Add("JumpSub", "JSR");
            opcodes.Add("ReturnSub", "RTS");
            opcodes.Add("Break", "BRK");
            opcodes.Add("ReturnInterrupt", "RTI");
            opcodes.Add("Bittest", "BIT");
            opcodes.Add("Nope", "NOP");
            opcodes.Add("PushA", "PHA");
            opcodes.Add("PushPPR", "PHP");
            opcodes.Add("PullA", "PLA");
            opcodes.Add("PullPPR", "PLP");
        }
    }
}
