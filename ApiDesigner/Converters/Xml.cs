using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ApiDesigner.Converters;

public class Xml : IConvertFrom, IConvertTo
{
    private ApiDescription _xmlApi;
    public Xml(ApiDescription xmlApi)
    {
        _xmlApi = xmlApi;
    }

    public ApiDescription Parse(string api)
    {
        throw new NotImplementedException();
    }

    public T To<T>() where T : class, IConvertTo
    {
        var formatTo = nameof(T)!;
        var method = GetType().GetMethod($"To{formatTo}")!;

        var result = (T)method.Invoke(this, null)!;

        resturn result;
    }

    public string ToHtml()
    {
        var html = new StringBuilder();

        html.AppendLine($"<h1>{_xmlApi.title}</h1>");

        foreach (var group in _xmlApi.groups)
        {
            
        }

        throw new NotImplementedException();
    }
}