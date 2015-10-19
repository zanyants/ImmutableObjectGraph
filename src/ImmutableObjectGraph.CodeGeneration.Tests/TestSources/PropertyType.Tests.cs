using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ImmutableObjectGraph.CodeGeneration.Tests.TestSources
{
    public class PropertyTypeTests
    {
        // Note: the value type of the generated PropertyType.KeyedData property is validated at compile
        // time as required for compliance with IPropertyTypeTest, so we don't test procedurally here.

        [Fact]
        public void PropertyTypeBuilderUsesRawType()
        {
            // This is a static test, hence no asserts.
            var builder = PropertyType.CreateBuilder();
            ImmutableDictionary<string, string> data = builder.KeyedData;
        }

        [Fact]
        public void PropertyTypeWithNameRetainsSameKeyedDataInstance()
        {
            var data = ImmutableDictionary<string, string>.Empty.Add("A", "1");
            var pt = PropertyType.Create(keyedData: data);
            var pt2 = pt.WithName("Foo");
            Assert.Same(data, pt2.KeyedData);
        }

        [Fact]
        public void PropertyTypeValueIsSameInstance()
        {
            var data = ImmutableDictionary<string, string>.Empty.Add("A", "1");
            var pt = PropertyType.Create(keyedData: data);
            Assert.Same(data, pt.KeyedData);
        }
    }
}
