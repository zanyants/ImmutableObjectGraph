using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmutableObjectGraph.CodeGeneration.Tests.TestSources
{
    interface IPropertyTypeTest
    {
        IReadOnlyDictionary<string, string> KeyedData { get; }
    }

    [GenerateImmutable(GenerateBuilder = true, DefineWithMethodsPerProperty = true)]
    partial class PropertyType : IPropertyTypeTest
    {
        [PropertyType(typeof(IReadOnlyDictionary<string,string>))]
        readonly ImmutableDictionary<string, string> keyedData;

        readonly string name;
    }
}
