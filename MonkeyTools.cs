﻿using ModelContextProtocol.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyFirstMCP
{
    [McpServerToolType]
    public static class MonkeyTools
    {
        [McpServerTool, Description("Get a list of monkeys.")]
        public static async Task<string> GetMonkeys(MonkeyService monkeyService)
        {
            var monkeys = await monkeyService.GetMonkeys();
            return JsonSerializer.Serialize(monkeys);
        }

        [McpServerTool, Description("Get a monkey by name.")]
        public static async Task<string> GetMonkey(MonkeyService monkeyService, [Description("The name of the monkey to get details for")] string name)
        {
            var monkey = await monkeyService.GetMonkey(name);
            return JsonSerializer.Serialize(monkey);
        }
    }
}
