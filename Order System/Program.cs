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

Console.WriteLine("Orders System");

OrdersRepository writeOrdersToJson = new OrdersRepository();
var resultwrite = writeOrdersToJson.WriteToJson();

OrdersRepository readOrdersFromJson = new OrdersRepository();
var resultread = readOrdersFromJson.ReadFromJson();

InterfacePrint print = new InterfacePrint();
print.menuOptions();
print.menuControl();

OrdersRepository writeOrdersToJson2 = new OrdersRepository();
var resultwrite2 = writeOrdersToJson.WriteToJson();

string orderdate = Console.ReadLine();








