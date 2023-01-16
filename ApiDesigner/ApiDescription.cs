using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ApiDesigner;

/// <summary>
/// Описание API
/// </summary>
public struct ApiDescription
{
    public string title { get; set; }
    public ApiMethodsGroup[] groups { get; set; }
}

/// <summary>
/// Группа API-методов
/// </summary>
public struct ApiMethodsGroup
{
    public string? description { get; set; }
    public ApiMethod[] methods { get; set; }

    #region ATTRIBUTES

    [XmlAttribute("name")]
    public string groupName { get; set; }

    #endregion
}

/// <summary>
/// API-метод
/// </summary>
public struct ApiMethod
{
    /// <summary>
    /// URI метода
    /// </summary>
    public string uri { get; set; }

    /// <summary>
    /// Описание метода
    /// </summary>
    public string? description { get; set; }

    /// <summary>
    /// Тип метода
    /// </summary>
    public ApiMethodType type { get; set; }

    /// <summary>
    /// Ответ
    /// </summary>
    public string? response { get; set; }
}

public enum ApiMethodType
{
    GET = 1,
    POST = 2, 
    PUT = 3,
    DELETE = 4
}