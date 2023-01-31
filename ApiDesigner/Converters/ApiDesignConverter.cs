using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDesigner.Converters;

public class ApiDesignConverter
{
    private static Lazy<ApiDesignConverter> _converter;

	public static ApiDesignConverter Convert() => _converter.Value;

    public T From<T>(string rawString) where T : IConvertFrom, new()
    {
        var converter = new T();

        throw new NotImplementedException();
    }
}

public interface IConvertFrom
{
    public T To<T>() where T : class, IConvertTo;

    public ApiDescription Parse(string api);
}

public interface IConvertTo
{

}