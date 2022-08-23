using Newtonsoft.Json.Serialization;
using NJsonSchema;
using NJsonSchema.CodeGeneration.TypeScript;
using NJsonSchema.Generation;
using System.Runtime.Serialization;

Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
var entitiesAssembly = typeof(WebApi.Entities.DataServiceFactory).Assembly;
var types = entitiesAssembly.ExportedTypes;
var selectedTypes = types.Where(x => x.IsEnum || x.CustomAttributes.Any(ad => ad.AttributeType == typeof(DataContractAttribute)));

var generationSettings = new TypeScriptGeneratorSettings
{
    TypeStyle = TypeScriptTypeStyle.Interface,
    TypeScriptVersion = 2.7m,
};

var modelsFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "..", "angular", "src", "app", "models");

var schemaGenerationSettings = new JsonSchemaGeneratorSettings
{
    SerializerSettings = new Newtonsoft.Json.JsonSerializerSettings
    {
        ContractResolver = new CamelCasePropertyNamesContractResolver()
    }
};
foreach (var type in selectedTypes)
{
    var entities = "Entities.";
    var schema = JsonSchema.FromType(type, schemaGenerationSettings);
    var generator = new TypeScriptGenerator(schema, generationSettings);
    var fileContent = generator.GenerateFile();
    var typeFullName = ((Type)type).FullName;
    var pos = typeFullName.IndexOf(entities);
    if (pos < 0)
    {
        pos = "ContactManager.".Length;
    }
    else
    {
        pos += entities.Length;
    }
    var fileName = ((Type)type).FullName.Substring(pos) + ".ts";
    var filePath = Path.Combine(modelsFolderPath, fileName);
    File.WriteAllText(filePath, fileContent);
    Console.Out.WriteLine(fileName);
}
