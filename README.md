# Shitty502
I disliked the shortened opcodes that 6502 assembly typically uses so I made this command-line utility :)

This effectively works as a superset/mod language for 6502 ASM. You can use standard opcodes and the utility will pass over them as normal.

## Usage
```
Shitty502 [filename] [output] [flags...]
```

Output is optional, though it defaults to ``<filename>-out.s``

The flag ``-reverse`` is planned to be supported for reverse decompilation in order to make reading older code easier.

## Opcodes

| Shitty502 Opcode  | 6502 Opcode | Explanation |
| ----------------- | ----------- | ----------- |
| SetA              | LDA         | Set the accumulator. |
| SetX              | LDX         | Set the X index. |
| SetY              | LDY         | Set the Y index. |
| StoreA            | STA         | Store the accumulator in RAM. |
| StoreX            | STX         | Store the X index in memory. |
| StoreY            | STY         | Store the Y index in memory. |
| TransferAX        | TAX         | Copy the accumulator to the X index. |
| TransferAY        | TAY         | Copy the accumulator to the Y index. |
| TransferSX        | TSX         | 
| TransferXA        | TXA         | Copy the X index to the accumulator. |
| TransferXS        | TXS         |
| TransferYA        | TYA         | Copy the Y index to the accumulator. |
| Dec               | DEC         | Decrement a value in memory by one. |
| Inc               | INC         | Increment a value in memory by one. |
| IncX              | INX         | Increment the X index by one. |
| IncY              | INY         | Increment the Y index by one. |
| DecX              | DEX         | Decrement the X index by one. |
| DecY              | DEY         | Decrement the Y index by one. |
| Add               | ADC         | Add value in memory to the accumulator. |
| Sub               | SBC         | Subtract value in memory from the accumulator. |
| And               | AND         |
| Eor               | EOR         |
| Or                | ORA         |
| ShiftLeft         | ASL         | Bitwise. Shift in zeros from the left. |
| ShiftRight        | LSR         | Bitwise. Shift in zeros from the right. |
| RotateLeft         | ROL        | Bitwise. Rotate one bit to the left. |
| RotateRight       | ROR         | Bitwise. Rotate one bit to the right. |
| ClearCarry        | CLC         | Clear the carry flag. |
| DisableDecimal    | CLD         | Disable decimal math. Depending on the system, this may already be unavailable. |
| EnableInterrupts  | CLI         | 
| ClearOverflow     | CLV         | Clear the overflow flag. |
| SetCarry          | SEC         | Activate the carry flag. |
| EnableDecimal     | SED         | Enable decimal math. On by default. Not available on every system. |
| DisableInterrupts | SEI         | 
| CompareA          | CMP         | 
| CompareX          | CPX         | 
| CompareY          | CPY         | 
| BranchNotCarry    | BCC         | 
| BranchCarry       | BCS         | 
| BranchEqual       | BEQ         | 
| BranchNotEqual    | BNE         | 
| BranchPositive    | BPL         | 
| BranchNegative    | BMI         | 
| BranchOverflow    | BVS         | 
| BranchNotOverflow | BVC         | 
| Jump              | JMP         | Jump the program counter to a place in memory. |
| JumpSub           | JSR         | 
| ReturnSub         | RTS         | 
| Break             | BRK         | 
| ReturnInterrupt   | RTI         | 
| Bittest           | BIT         | 
| Nope              | NOP         | 
| PushA             | PHA         | 
| PushPPR          | PHP         | 
| PullA            | PLA         | 
| PullPPR          | PLP         | 
