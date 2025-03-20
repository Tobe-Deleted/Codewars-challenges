using System.Net.Http.Headers;
using System;
using System.Linq;
using System.Collections.Generic;

public static class TwoKyu
{
    private static string msg = "";
    public static string Interpret(string input)
    {
        string[] inputSorted = input.Split('\n', StringSplitOptions.RemoveEmptyEntries); //splits each line in the input into an array  
        InterpretOrders(inputSorted, new Dictionary<string, int>()); //interprets the orders and saves the result to registers  
        
        return msg;
    }

    public static Dictionary<string, int> InterpretOrders(string[] program, Dictionary<string, int> registers, int start = 0)
    {
        string[][] orders = program.Select(x => x.Split(' ', StringSplitOptions.RemoveEmptyEntries)).ToArray();
        int cmp = 0; // 0 = undefined, 1 = x>y, 2 = x<y, 3 = x==y
        for(int i = start; i < program.Length; i++)
        {
            if(orders[i].Length < 1) 
                continue;
            if(orders[i][0] == ";") 
                continue;
            if(orders[i][0] == "end" || orders[i][0] == "ret") 
                return registers;
            orders[i][1] = orders[i][1].Replace(",", "");
            if(orders[i][0] == "mov")
                registers.TryAdd(orders[i][1], 0);
                
            string key = orders[i][1];

            switch(orders[i][0])
            {
                case "jl":
                    if(cmp == 2)
                    {
                        i = JumpToLabel(orders, orders[i][1] + ":");
                    }
                    break;
                case "jle":
                    if(cmp == 2 || cmp == 3)
                    {
                        i = JumpToLabel(orders, orders[i][1] + ":");
                    }
                    break;
                case "jg":
                    if(cmp == 1)
                    {
                        i = JumpToLabel(orders, orders[i][1] + ":");
                    }
                    break;
                case "jge":
                    if(cmp == 1 || cmp == 3)
                    {
                        i = JumpToLabel(orders, orders[i][1] + ":");
                    }
                    break;
                case "je":
                    if(cmp == 3)
                    {
                        i = JumpToLabel(orders, orders[i][1] + ":");
                    }
                    break;
                case "jne":
                    if(cmp != 3)
                    {
                        i = JumpToLabel(orders, orders[i][1] + ":");
                    }
                    break;
                case "cmp":
                    if(GetValue(orders[i][1], registers) > GetValue(orders[i][2], registers))
                        cmp = 1;
                    else if(GetValue(orders[i][1], registers) < GetValue(orders[i][2], registers))
                        cmp = 2;
                    else
                        cmp = 3;
                    break;
                case "jmp":
                    i = JumpToLabel(orders, orders[i][1] + ":");
                    break;
                case "div":
                    registers[key] /= GetValue(orders[i][2], registers);
                    break;
                case "mul":
                    registers[key] *= GetValue(orders[i][2], registers);
                    break;
                case "sub":
                    registers[key] += -GetValue(orders[i][2], registers);
                    break;
                case "add":
                    registers[key] += GetValue(orders[i][2], registers);
                    break;
                case "ret":
                    if(start > 0) return registers;
                    break;
                case "call":
                    for(int n = 0; n < orders.Length; n++)
                    {
                        if(orders[n][0] == orders[i][1] + ":")
                        {
                            registers = InterpretOrders(program, registers, n+1);
                            break;
                        }
                    }
                    break;
                case "msg":
                    string tempMsg = program[i];
                    
                    if(tempMsg.Contains(";"))
                    {
                        tempMsg = tempMsg.Remove(tempMsg.IndexOf(';'));
                    }

                    string[]splitMsg = tempMsg.Substring(4)
                                              .Trim()  
                                              .Split(",")
                                              .Select(st => st.Trim())
                                              .ToArray();

                    foreach(string s in splitMsg)
                    {
                        if(s.StartsWith('\''))
                            msg += s.Trim('\'');
                        else
                            msg += "" + GetValue(s, registers);
                    }
                    break;
                case "mov":
                    registers[key] = GetValue(orders[i][2], registers);
                    break;
                case "inc":
                    registers[key]++;
                    break;
                case "dec":
                    registers[key]--;
                    break;
                case "jnz":
                    if(registers[key] == 0) break;
                    i += GetValue(orders[i][2], registers) -1;
                    break;
                default:
                    throw new Exception("Unknown command: " + orders[i][0]);
            }
            
                
        }
        return registers;
    }

    private static int GetValue(string input, Dictionary<string, int> result) 
    {
        return result.TryGetValue(input, out int value) ? value : Convert.ToInt32(input);
    }

    private static int JumpToLabel(string[][] orders, string label)
    {
        for(int n = 0; n < orders.Length; n++)
        {
            if(orders[n][0] == label)
            {
                return n;
            }
        }
        throw new Exception("Couldn't find label " + label);
    }
    
}