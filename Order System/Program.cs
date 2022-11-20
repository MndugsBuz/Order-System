// See https://aka.ms/new-console-template for more information
using Order_System.Entities;
using System.Net.Http.Json;
using System.Numerics;
//using System.Text.Json;
//using System.Text.Json.Serialization;
using System.IO;
using Newtonsoft.Json;
using Order_System.Repositories;
using Order_System;

Console.WriteLine("Order System");

OrdersRepository writeOrderToJson = new OrdersRepository();
var resultwrite = writeOrderToJson.WriteToJson();

OrdersRepository readOrderFromJson = new OrdersRepository();
var resultread = readOrderFromJson.ReadFromJson();

InterfacePrint print = new InterfacePrint();
print.menuOptions();
print.menuControl();








