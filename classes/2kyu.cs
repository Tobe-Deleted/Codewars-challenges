using System.Net.Http.Headers;
using System;
using System.Linq;
using System.Collections.Generic;

public static class TwoKyu
{
    private static string msg = "";
    public static string Interpret(string input)
    {
        string[] inputSorted = input.Split('\n'); //splits each line in the input into an array  
        Dictionary<string, int> registers = InterpretOrders(inputSorted, new Dictionary<string, int>()); //interprets the orders and saves the result to registers  
        
        return msg;
    }

    public static Dictionary<string, int> InterpretOrders(string[] program, Dictionary<string, int> registers, int start = 0)
    {
        string[][] orders = program.Select(x => x.Split(' ', StringSplitOptions.RemoveEmptyEntries)).ToArray();
        int cmp = 0; // 0 = undefined, 1 = x>y, 2 = x<y, 3 = x==y
        for(int i = start; i < program.Length; i++)
        {
            Console.WriteLine(i);
            if(orders[i].Length < 1) 
                continue;
            if(orders[i][0] == ";") 
                continue;
            if(orders[i][0] == "end") 
                return registers;
            orders[i][1] = orders[i][1].Replace(",", ""); // removes comma from register name
            if(orders[i][0] == "mov")
                registers.TryAdd(orders[i][1], 0);
                
            string key = orders[i][1];
            int value = registers.TryGetValue(key, out int v) ? v : Convert.ToInt32(key);

            switch(orders[i][0])
            {
                case "jl":
                    if(cmp == 2)
                    {
                        i = GetValue(orders[i][1], registers) -1;
                    }
                    break;
                case "jle":
                    if(cmp == 2 || cmp == 3)
                    {
                        i = GetValue(orders[i][1], registers) -1;
                    }
                    break;
                case "jg":
                    if(cmp == 1)
                    {
                        i = GetValue(orders[i][1], registers) -1;
                    }
                    break;
                case "jge":
                    if(cmp == 1 || cmp == 3)
                    {
                        i = GetValue(orders[i][1], registers) -1;
                    }
                    break;
                case "je":
                    if(cmp == 3)
                    {
                        i = GetValue(orders[i][1], registers) -1;
                    }
                    break;
                case "jne":
                    if(cmp != 3)
                    {
                        i = GetValue(orders[i][1], registers) -1;
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
                    i = GetValue(orders[i][1], registers) -1;
                    break;
                case "div":
                    value /= GetValue(orders[i][2], registers);
                    break;
                case "mul":
                    value *= GetValue(orders[i][2], registers);
                    break;
                case "sub":
                    value += -GetValue(orders[i][2], registers);
                    break;
                case "add":
                    value += GetValue(orders[i][2], registers);
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
                    msg = program[i].Substring(program[i].IndexOf("\'")+1);
                    msg = msg.Remove(msg.IndexOf("\'"));
                    string msgRegister = program[i].Substring(program[i].IndexOf("\',")+2, 2).Trim();
                    msg += GetValue(msgRegister, registers);
                    break;
                case "mov":
                    value = GetValue(orders[i][2], registers);
                    break;
                case "inc":
                    value++;
                    break;
                case "dec":
                    value--;
                    break;
                case "jnz":
                    if(value == 0) break;
                    i += GetValue(orders[i][2], registers) -1;
                    break;
                default:
                    throw new Exception("Unknown command: " + orders[i][0]);
            }
            if(registers.ContainsKey(key))
            {
                registers[key] = value;
            }
                
        }
        return registers;
    }

    private static int GetValue(string input, Dictionary<string, int> result) 
    {
        return result.TryGetValue(input, out int value) ? value : Convert.ToInt32(input);
    }
    
}