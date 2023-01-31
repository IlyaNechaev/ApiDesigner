// See https://aka.ms/new-console-template for more information
using ApiDesigner.Converters;

Console.WriteLine("Hello, World!");


var xml = string.Empty;

ApiDesignConverter
    .Convert()
    .From<Xml>()
    .To<Xml>();